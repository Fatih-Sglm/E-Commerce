using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IGenericdal<T> where  T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll();

        T GetWihtExpression(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression <Func<T,bool >> filter);
        T GetById(int id);

    }
}
