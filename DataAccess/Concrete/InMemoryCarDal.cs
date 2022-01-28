using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        { 
               _car =new List<Car>
        { 
            new Car{BrandId=1,ColorId=1,DailyPrice=35000,Description="Mercedes",CarId=1,ModdelYear=2022},
            new Car{BrandId=2,ColorId=2,DailyPrice=25000,Description="Volvo",CarId=1,ModdelYear=2019}
        };

        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);

            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int carId)
        {
           return  _car.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModdelYear = car.ModdelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
    }
    }
}
