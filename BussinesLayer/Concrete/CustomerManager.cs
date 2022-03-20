using BussinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class CustomerManager : ICustomerServices
    {
        ICustomerdal _cd;

        public CustomerManager(ICustomerdal cd)
        {
            _cd = cd;
        }

        public List<Customer> GetCustomerById(int id)
        {
            return _cd.GetById(x => x.Id == id);
        }

        public void TDelete(Customer t)
        {
            throw new NotImplementedException();
        }

        public List<Customer> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Customer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Customer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Customer t)
        {
            throw new NotImplementedException();
        }
    }
}
