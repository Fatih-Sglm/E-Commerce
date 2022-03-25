using BussinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class ImagesManager : IImagesServices
    {
        IImagesDal _img;

        public ImagesManager(IImagesDal img)
        {
            _img = img;
        }

        public void TDelete(Images t)
        {
            _img.Delete(t);
        }

        public List<Images> TGetAll(int id)
        {
            return _img.GetAll(x => x.ProductId == id);
        }

        public List<Images> TGetAll(Expression<Func<Images, bool>> filter)
        {
            return _img.GetAll(filter);
        }

        public List<Images> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Images TGetById(int id)
        {
            return _img.GetById(id);
        }

        public void TInsert(Images t)
        {
            _img.Insert(t);
        }

        public void TUpdate(Images t)
        {
            throw new NotImplementedException();
        }
    }
}
