using BussinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class VendorProductManager : IVendorProductServices
    {

        IVendorProductDal _vd;
    public VendorProductManager(IVendorProductDal vd)
        {
            _vd = vd;
        }
        public void TInsert(VendorProduct p)
        {
            _vd.Insert(p);
        }

        public void TDelete(VendorProduct p)
        {
            _vd.Delete(p);
        }

        public VendorProduct TGetByID(int id)
        {
            return _vd.GetById(id);
        }
        public List<VendorProduct> TGetAll()
        {
            return _vd.GetlistProduct();
        }


        public void TUpdate(VendorProduct p)
        {
            _vd.Update(p);
        }


        public VendorProduct TGetById(int id)
        {
            return _vd.GetById(id);
        }

        public VendorProduct GetProductAll(int id)
        {
            return _vd.GetProductWithAll(x => x.Id == id);
        }

        public List<VendorProduct> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<VendorProduct> TGetAll(Expression<Func<VendorProduct, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<VendorProduct> TGetAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}
