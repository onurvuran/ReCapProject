using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            //if (brand.BrandName.Length < 2)
            //{
            //    return new ErrorResult(Message.NameInvalid);

            //}
            _brandDal.Add(brand);
            return new SuccessResult(Message.Create);

        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccessResult(Message.Delete);

        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Brand>>(Message.MaintenanceTime);
            }


            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Message.Listed);
        }

        public IDataResult<Brand> BrandGetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == brandId));
        }

        public IResult Update(Brand brand)
        {


            _brandDal.Update(brand);
            return new SuccessResult(Message.Update);
        }
    }
}
