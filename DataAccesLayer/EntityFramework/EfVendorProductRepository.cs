using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfVendorProductRepository : GenericRepository<VendorProduct>, IVendorProductDal
    {
        public List<VendorProduct> GetById(Expression<Func<VendorProduct, bool>> filter)
        {
            using (var c = new Context())
            {
                return c.VendorProducts.Where(filter).Include(x => x.Product).ToList();
            }
        }

        public List<VendorProduct> GetlistProduct()
        {
            using(var c = new Context())
            {
                return c.VendorProducts.Include(x => x.Product).ToList();
            }
        }

        public List<VendorProduct> GetProductWithAll(Expression<Func<VendorProduct, bool>> filter)
        {
            using (var c = new Context())
            {
                return c.VendorProducts.Where(filter).Include(x => x.Product).Include(y => y.Product.Category).Include(x=> x.Product.Brands).ToList();
            }
        }
    }
}
