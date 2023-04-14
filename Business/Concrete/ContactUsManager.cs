using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void Add(ContactUs t)
        {
            _contactUsDal.Add(t);
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public ContactUs GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetList()
        {
            return _contactUsDal.GetAll();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public void Update(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
