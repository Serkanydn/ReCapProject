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
            ColorManager colorManager = new ColorManager(new EFColorDal());
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            var resultCar = carManager.GetAll();
            foreach (var car in resultCar.Data)
            {
                Console.WriteLine( car.CarId+"   "+car.BrandId+"   "+car.ColorId+"   "+car.DailyPrice+"   "+car.Description+"   "+car.ModelYear );
            }

            var resultColor = colorManager.GetAll();
            foreach (var color in resultColor.Data)
            {
                Console.WriteLine(color.ColorName + color.ColorId);
            }

            var resultBrand = brandManager.GetAll();
            foreach (var brand in resultBrand.Data)
            {
                Console.WriteLine(brand.BrandName+brand.BrandId);
            }


            //Console.WriteLine(result);
            //CarManagerGetCarDetailDtosTest(carManager);

            //CarManagerGetAllTest(carManager);
            //CarManagerGetBrandIdTest(carManager);
            //CarManagerGetByIdTest(carManager);

            CarManagerAddUpdateDeleteTest(carManager);


            //BrandManagerTest();

            //ColorManagetTest();

        }

        private static void CarManagerGetCarDetailDtosTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetailDtos().Data)
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
            foreach (var car in carManager.GetAll().Data)
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

            foreach (var car in carManager.GetByBrandId(1).Data)
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

            foreach (var car in carManager.GetByColorId(2).Data)
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
            //carManager.Add(car3);
            // carManager.Delete(car1);
            var result = carManager.Update(new Car
            {
                CarId = 9,
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 250,
                Description = "Golf",
                ModelYear = "2018",
            });
            Console.WriteLine(result.Message);
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            Console.WriteLine("                                               ");
            Console.WriteLine("------ARAÇ MARKA ID VE MARKA ADI BİLGİSİ------");
            Console.WriteLine("                                               ");
            Console.WriteLine("Marka Id     Marka Adı");
            Console.WriteLine("--------     ---------");
            foreach (var brand in brandManager.GetAll().Data)
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
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "       --->  " + color.ColorName);
            }
        }
    }
}
