using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
   public interface IGenericServices<T>
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TDelete(T t);
        List<T> TGetAll();

        List<T> TGetAll(int id);

        List<T> TGetAll(Expression<Func<T, bool>> filter);
        T TGetById(int id);
    }
}
