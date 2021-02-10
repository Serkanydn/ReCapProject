using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EFCarDal());

            Console.WriteLine("------GÜNLÜK ARAÇ KİRA FİYATLARI------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Marka Id     Renk Id     Model Yılı          Açıklama              Günlük ücret");
            Console.WriteLine("--------     -------     ----------          --------              ------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId + "           -   " + car.ColorId + "       -   " + car.ModelYear + "      -   " + car.Description + "         ---> " + car.DailyPrice + " TL");
            }
            Console.WriteLine("                                               ");
            Console.WriteLine("------Markaya Göre------");
            Console.WriteLine("Marka Id     Renk Id     Model Yılı          Açıklama              Günlük ücret");
            Console.WriteLine("---------------------------------------------");
            
            foreach (var car in carManager.GetByBrandId(1))
            {
                Console.WriteLine(car.BrandId + "           -   " + car.ColorId + "       -   " + car.ModelYear + "      -   " + car.Description + "         ---> " + car.DailyPrice + " TL");
            }
            Console.WriteLine("                                               ");
            Console.WriteLine("------Renge Göre------");
            Console.WriteLine("Marka Id     Renk Id     Model Yılı          Açıklama              Günlük ücret");
            Console.WriteLine("---------------------------------------------");
           
            foreach (var car in carManager.GetByColorId(2))
            {
                Console.WriteLine(car.BrandId + "           -   " + car.ColorId + "       -   " + car.ModelYear + "      -   " + car.Description + "         ---> " + car.DailyPrice + " TL");
            }
            Console.WriteLine("                                               ");
            Console.WriteLine("------Add İşlemi Sonrası------");
            Console.WriteLine("Marka Id     Renk Id     Model Yılı          Açıklama              Günlük ücret");
            Console.WriteLine("---------------------------------------------");
            Car car1 = new Car
            {
                CarId = 9,
                BrandId = 2,
                ColorId = 5,
                DailyPrice = 250,
                Description = "Subaru",
                ModelYear = "2018",
            };
            carManager.Add(car1) ;
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
           

            BrandManager brandManager = new BrandManager(new EFBrandDal());
            Console.WriteLine("                                               ");
            Console.WriteLine("------ARAÇ MARKA ID VE MARKA ADI BİLGİSİ------");
            Console.WriteLine("                                               ");
            Console.WriteLine("Marka Id     Marka Adı");
            Console.WriteLine("--------     ---------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + "       --->  " + brand.BrandName);
            }

            ColorManager colorManager = new ColorManager(new EFColorDal());
            Console.WriteLine("                                               ");
            Console.WriteLine("------ARAÇ RENK ID VE MARKA ADI BİLGİSİ------");
            Console.WriteLine("                                               ");
            Console.WriteLine("Renk Id     Renk Adı");
            Console.WriteLine("-------     --------");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + "       --->  " + color.ColorName);
            }





        }
    }
}
