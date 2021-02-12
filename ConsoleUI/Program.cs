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
            CarManagerGetCarDetailDtosTest(carManager);

            //CarManagerGetAllTest(carManager);
            //CarManagerGetBrandIdTest(carManager);
            //CarManagerGetByIdTest(carManager);

            //CarManagerAddUpdateDeleteTest(carManager);


            //BrandManagerTest();

            //ColorManagetTest();

        }

        private static void CarManagerGetCarDetailDtosTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.BrandName + car.ColorName + car.DailyPrice);
            }
        }

        private static void CarManagerGetAllTest(CarManager carManager)
        {
            Console.WriteLine("------GÜNLÜK ARAÇ KİRA FİYATLARI------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Marka Id     Renk Id     Model Yılı          Açıklama              Günlük ücret");
            Console.WriteLine("--------     -------     ----------          --------              ------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId + "           -   " + car.ColorId + "       -   " + car.ModelYear + "      -   " + car.Description + "         ---> " + car.DailyPrice + " TL");
            }
        }

        private static void CarManagerGetBrandIdTest(CarManager carManager)
        {
           
            Console.WriteLine("                                               ");
            Console.WriteLine("------Markaya Göre------");
            Console.WriteLine("Marka Id     Renk Id     Model Yılı          Açıklama              Günlük ücret");
            Console.WriteLine("---------------------------------------------");

            foreach (var car in carManager.GetByBrandId(1))
            {
                Console.WriteLine(car.BrandId + "           -   " + car.ColorId + "       -   " + car.ModelYear + "      -   " + car.Description + "         ---> " + car.DailyPrice + " TL");
            }
        }

        private static void CarManagerGetByIdTest(CarManager carManager)
        {
            
            Console.WriteLine("                                               ");
            Console.WriteLine("------Renge Göre------");
            Console.WriteLine("Marka Id     Renk Id     Model Yılı          Açıklama              Günlük ücret");
            Console.WriteLine("---------------------------------------------");

            foreach (var car in carManager.GetByColorId(2))
            {
                Console.WriteLine(car.BrandId + "           -   " + car.ColorId + "       -   " + car.ModelYear + "      -   " + car.Description + "         ---> " + car.DailyPrice + " TL");
            }
        }

        private static void CarManagerAddUpdateDeleteTest(CarManager carManager)
        {
            
            Car car1 = new Car
            {
                CarId = 13,
                BrandId = 2,
                ColorId = 5,
                DailyPrice = 250,
                Description = "Ferrari",
                ModelYear = "2018",
            };
            Car car2 = new Car
            {
                CarId = 13,
                BrandId = 2,
                ColorId = 5,
                DailyPrice = 250,
                Description = "Ferrari",
                ModelYear = "2018",
            };
            Car car3 = new Car
            {
                CarId = 13,
                BrandId = 2,
                ColorId = 5,
                DailyPrice = 250,
                Description = "Ferrari",
                ModelYear = "2018",
            };
            carManager.Add(car3);
            carManager.Delete(car1);
            carManager.Update(car2);
        }

        private static void BrandManagerTest()
        {
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
        }

        private static void ColorManagetTest()
        {
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
