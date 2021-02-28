using Castle.DynamicProxy;
using Core.CrossCuttingConcers.Validation;
using Core.Utilities.Intercepors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{

    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)//Bana validatorType ver attirubutelşere tipleri böle atıuyoruz typela 
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))//Gönderilen validatorType IValidator değilse kız demek.O zaman benim validatorum doğruysa benim  _validatorType =validatorType yani gönderilen ProductValidatorType
            {//Attiributelerde böle kısıtlama var
                throw new System.Exception("Bu bir doğrualama sınıfı değil.");
            }

            _validatorType = validatorType;
        }

        protected override void OnBefore(IInvocation invocation)// içerisindeki OnBefore metodunu override ettik
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);//Reflection reflection = çalışma anında bir şeyleri çalıştırabilmemizi sağlıyor örn. newleme işlemini çalışma anında yapmak istiyoruz.
            //CreateInstance = ProductValidatorun instancesini oluştur. 
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//sonra product validatorun çalışma tipini bul diyo.Yani ProductValidatorun base tipini bul Business içerisindeki AbstractValidatoru ve onun çalıştığı generics çalıştığı veri tipini bul.Generics argumanlarından ilghini bul.

            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//Onun parametrelerini bul bu sefer.Parametrelerini bul demek ilgili metodun parametreleri.invocation metod demek.Metodun parametrelerine bak entityType denk gelen (yani entityType çalışılan generics veri tipi (Product)) parametreleri git bul diyor ve herbirini tek tek gez validation toolu kullanarak validate et. birden fazla parametrede olabilir. .
            foreach (var entity in entities)
            {
                ValidationTools.Validate(validator, entity);
            }
        }
    }
}
