using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Utilities.Intercepors
{

    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            //classın attirubutelerini oku
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            //ilgili metodun attirubutelerini oku log, cash hepsi olabilir.Git bak bunları bul diyo
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);//Ve bulduklarını listeye koy diyo
            //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));Otomatik olarak sistemdeki bütün metodları loga dahil et.  

            //Yalnız onların çalışma sıralarınıda priorityye(öncelik değerine) göre sırala diyor
            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
