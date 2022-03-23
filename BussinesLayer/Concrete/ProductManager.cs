using BussinesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.EntityFramework;
using DataAccesLayer.Abstract;
using System.Linq.Expressions;

namespace BussinesLayer.Concrete
{
    public class ProductManager : IProductServices
    {
        IProductdal _ct;
        public ProductManager(IProductdal ct)
        {
            _ct = ct;
        }

        public void TInsert(Product p)
        {
            _ct.Insert(p);
        }

        public void TDelete(Product p)
        {
            _ct.Delete(p);
        }
        public List<Product> TGetAll()
        {
            return _ct.GetAll();
        }

        public void TUpdate(Product p)
        {
            _ct.Update(p);
        }

        public List<Product> TGetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            return _ct.GetById(id);
        }

        public List<Product> TGetAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllIncludeAll()
        {
            return _ct.GetAllIncludeAll();
        }
    }
}
