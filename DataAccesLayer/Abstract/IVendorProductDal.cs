using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IVendorProductDal :IGenericdal<VendorProduct>
    {
        List<VendorProduct> GetlistProduct();
        List<VendorProduct> GetProductWithAll(Expression<Func<VendorProduct, bool>> filter);
    }
}
