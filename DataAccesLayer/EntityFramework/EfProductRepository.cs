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
    public class EfProductRepository : GenericRepository<Product>, IProductdal
    {
        public List<Product> GetAllIncludeAll()
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.imageS).Include(x => x.Category).Include(x => x.Brands).ToList();
            }
        }
    }
}
