using Business.Concrete;
using Business.Constants;
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
            //NewUser();
           //NewCustomer();

            //CarManager carManager = CArmanagerTest();
            //CarAddTest(carManager);
            //CarDelete();
            //CarUpdate();
            CaraddT();
            //CarGetById();
            //CarGetAll();

            //ColortTestGetAll();
            //ColorGetById();
            //ColorDelete();
            //ColorUpdate();
            //ColorAdd();

            //BrandDelete();
            //BrandUpdate();
            //BrandAdd();
            //BrandGetById();
            //BrandGetAll();



        }

        private static void NewCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer { CostumerId = 101, CompanyName = "opıyh" });
            Console.WriteLine("Yeni Müşteri Eklenmiştir.");
        }

        private static void NewUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "Onur", LastName = "Vuran", UserId = 1, Email = "onurvuran0@gmail.com", Paswword = "12345" });
            Console.WriteLine("User Eklendi.");
        }

        //private static void CarGetAll()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}

        //private static void CarGetById()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    Console.WriteLine(carManager.GetCarsId(5).Description);
        //}

       private static void CaraddT()
        {
           CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId = 19, BrandId = 19, ColorId = 2, DailyPrice = 1345600, ModelYear = 2022, Description = "Toyota" });
        }

        //private static void CarUpdate()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Update(new Car { CarId = 3, BrandId = 1, ColorId = 2, DailyPrice = 256000, ModelYear = 2022, Description = "merso" });
        //}

        //private static void CarDelete()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Delete(new Car { CarId = 2 });
        //}

        //private static void BrandGetAll()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}

        //private static void BrandGetById()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    Console.WriteLine(brandManager.BrandGetById(2).BrandName);
        //}

        //private static void BrandAdd()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    brandManager.Add(new Brand { BrandName = "Opel", BrandId = 1 });
        //}

        //private static void BrandUpdate()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    brandManager.Update(new Brand { BrandId = 2, BrandName = "MercedesUpdate" });
        //}

        //private static void BrandDelete()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    brandManager.Delete(new Brand { BrandId = 1 });
        //}

        //private static void ColorAdd()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Add(new Color { ColorName = "Green", ColorId = 1 });
        //}

        //private static void ColorUpdate()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Update(new Color { ColorId = 2, ColorName = "Pink" });
        //}

        //private static void ColorDelete()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Delete(new Color { ColorId = 1 });
        //}

        //private static void ColorGetById()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    Console.WriteLine(colorManager.GetGetById(2).ColorName + " ID 2 olan getirildi.");
        //}

        //private static void ColortTestGetAll()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);

        //    }
        //}

        //private static void CarAddTest(CarManager carManager)
        //{
        //    Car car1 = new Car
        //    {
        //        CarId = 11,
        //        BrandId = 10,
        //        ColorId = 10,
        //        ModelYear = 1995,
        //        DailyPrice = 345,
        //        Description = "T"
        //    };



        //    carManager.Add(car1);
        //}

        //private static CarManager CArmanagerTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());




        //    foreach (var car in carManager.GetAll())
        //    {

        //        Console.WriteLine(car.Description + " " + car.ModelYear);
        //    }

        //    return carManager;
        //}


    }
}
