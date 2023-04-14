using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactUsService
    {
        void Add(ContactUs contactUs);
        void Delete(ContactUs contactUs);
        void Update(ContactUs contactUs);
        List<ContactUs> GetList();
        ContactUs GetByID(int id);
        List<ContactUs> GetListContactUsByTrue();
        List<ContactUs> GetListContactUsByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
