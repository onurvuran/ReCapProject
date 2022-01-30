using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach(var car in carManager.GetAll())
            {

                Console.WriteLine(car.Description + " " +car.ModelYear);
            }

           
                Car car1 = new Car
                {
                    CarId = 11,
                    BrandId = 10,
                    ColorId = 10,
                    ModelYear = 1995,
                    DailyPrice = 345,
                    Description = "T"
                };
            
   

            carManager.Add(car1);

          

            
        }
    }
}
