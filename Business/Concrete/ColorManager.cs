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
    public class ColorManager : IColorService
    {

        IColorDal _icolorDal;

        public ColorManager(IColorDal icolorDal)
        {
            _icolorDal = icolorDal;
        }

        public void Add(Color color)
        {
            _icolorDal.Add(color);
            Console.WriteLine("Color added!");
        }

        public void Delete(Color color)
        {
            _icolorDal.Delete(color);
            Console.WriteLine("Color deleted!");
        }

        public List<Color> GetAll()
        {
           return _icolorDal.GetAll();  
        }

        public Color GetGetById(int colorId)
        {
            return _icolorDal.Get(p => p.ColorId == colorId);
        }

        public void Update(Color color)
        {
            _icolorDal.Update(color);
            Console.WriteLine("Color updated!");
        }

       
         

       
        

        
       
    }
}
