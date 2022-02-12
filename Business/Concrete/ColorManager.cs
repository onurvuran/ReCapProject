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
    public class ColorManager : IColorService
    {

        IColorDal _icolorDal;

        public ColorManager(IColorDal icolorDal)
        {
            _icolorDal = icolorDal;
        }

        public IResult Add(Color color)
        {
            _icolorDal.Add(color);
            return new SuccessResult(Message.Create);
        }

        public IResult Delete(Color color)
        {
            _icolorDal.Delete(color);
            return new SuccessResult(Message.Delete);
        }

        public IDataResult<List<Color>> GetAll()
        {
          
            return new SuccessDataResult<List<Color>>(_icolorDal.GetAll(), Message.Listed);
        }

        public IDataResult<Color> ColorGetById(int colorId)
        {
            return new SuccessDataResult<Color>(_icolorDal.Get(p => p.ColorId == colorId));
        }

        public IResult Update(Color color)
        {
            _icolorDal.Update(color);
            return new SuccessResult(Message.Update);
        }

       
         

       
        

        
       
    }
}
