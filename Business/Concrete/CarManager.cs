using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;   

        }

        public IResult Add(Car car)
        {
            if (car.Description.Length >2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Message.Create);

            }
            return new ErrorResult(Message.NameInvalid);
        }

        public IResult Delete(Car car)
        {
           _carDal.Delete(car);
           return new SuccessResult(Message.Delete);  
        }

        public IDataResult<List<Car>> GetAll()
        {

            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Message.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Message.Listed);    
        }


        public IDataResult<Car> GetCarsId(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == carId));
        }

        public IResult Update(Car car)
        {
           _carDal.Update(car);
            return new SuccessResult(Message.Update);
        }
    }
}
