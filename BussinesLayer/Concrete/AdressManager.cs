using BussinesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Abstract;
using System.Linq.Expressions;

namespace BussinesLayer.Concrete
{
    public class AdressManager : IAdressServices
    {
        IAdressdal _ad;

        public AdressManager(IAdressdal ad)
        {
            _ad = ad;
        }

        public List<Adress> ListAdress(int id)
        {
            return _ad.GetAll(x => x.CustomerId == id);
        }

        public void TDelete(Adress t)
        {
            _ad.Delete(t);
        }

        public List<Adress> TGetAll()
        {
            throw new NotImplementedException();
        }

        public List<Adress> TGetAll(Expression<Func<Adress, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Adress> TGetAll(int id)
        {
            throw new NotImplementedException();
        }

        public Adress TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Adress t)
        {
            _ad.Insert(t);
        }

        public void TUpdate(Adress t)
        {
            _ad.Update(t);
        }
    }
}
