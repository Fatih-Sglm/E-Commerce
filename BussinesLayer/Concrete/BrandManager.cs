using BussinesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class BrandManager : IBrandServices
    {
        public void TDelete(Brand t)
        {
            throw new NotImplementedException();
        }

        public List<Brand> TGetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> TGetAll(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> TGetAll(int id)
        {
            throw new NotImplementedException();
        }

        public Brand TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Brand t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Brand t)
        {
            throw new NotImplementedException();
        }
    }
}
