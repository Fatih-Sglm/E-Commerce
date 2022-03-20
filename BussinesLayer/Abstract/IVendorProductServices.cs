using EntityLayer.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
     public interface IVendorProductServices : IGenericServices<VendorProduct>
    {
        List<VendorProduct> GetProductById(int id);

        VendorProduct GetProductAll(int id);
    }
}
