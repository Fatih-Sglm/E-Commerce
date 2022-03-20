using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace DataAccesLayer.EntityFramework
{
    public class EfCustomerRepository : GenericRepository<Customer>, ICustomerdal
    {
        public List<Customer> GetById(Expression<Func<Customer, bool>> filter)
        {
            using (var c = new Context())
            {
                return c.Customers.Where(filter).ToList();
            }
        }
    }
}
