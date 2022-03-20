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
    public class CategoryManager : ICategoryServices
    {
        ICategorydal _cd;
public CategoryManager(ICategorydal cd)
        {
            _cd = cd;
        }

        public void TInsert(Category c)
        {
            _cd.Insert(c);
        }

        public void TDelete(Category p)
        {
            _cd.Delete(p);
        }

        public void TUpdate(Category c)
        {
            _cd.Update(c);
        }

        public List<Category> TGetAll()
        {
            return _cd.GetAll();
        }

        public List<Category> TGetAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category TGetById(int id)
        {
            return _cd.GetById(id);
        }
    }
}
