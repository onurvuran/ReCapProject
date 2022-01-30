using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;   

        }

        public void Add(Car car)
        {
            if (car.Description.Length >2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Eklenmiştir");

            }
            else
            {
                Console.WriteLine("Araç Eklenemdi!! Lütfen Açıklamyı daha uzun tutun ve Gün fiyatı olarak sıfırdan yüksek rakam girilmelidir.");

            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();    
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p=> p.BrandId == brandId);

        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p=>p.ColorId==colorId);
        }
    }
}
