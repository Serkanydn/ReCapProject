using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ICarService carService = new CarManager(new InMemoryCarDal());
            Console.WriteLine("First List");
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.CarId+" "+car.Description);
            }
            


            Console.WriteLine("                                              ");
            Console.WriteLine("After Add");
            carService.Add(new Car{ CarId = 5, BrandId = 1, ColorId = 1, DailyPrice = 150000, Description = "Kia", ModelYear = "2012" });
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }
           


            Console.WriteLine("                                              ");
            Console.WriteLine("After Update");
            carService.Update(new Car{ CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 150000, Description = "Honda", ModelYear = "2012" });
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }


            Console.WriteLine("                                              ");
            Console.WriteLine("After Delete");
            carService.Delete(new Car { CarId = 1, BrandId = 2, ColorId = 1, DailyPrice = 135000, Description = "Skoda", ModelYear = "2019" });
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }

            Console.WriteLine("                                              ");
            Console.WriteLine("After Get By Id");
            foreach (var car in carService.GetById(2))
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }
          




        }
    }
}
