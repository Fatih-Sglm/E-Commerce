using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
namespace DataAccesLayer.Abstract
{
    public interface ICustomerdal : IGenericdal<Customer>
    {
        List<Customer> GetById(Expression<Func<Customer, bool>> filter);
    }
}
