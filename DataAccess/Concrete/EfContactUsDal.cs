using Core.DataAccess.EntityFremawork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremawork.Context;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfContactUsDal:EfEntityRepositoryBase<ContactUs,Context>,IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using (var context = new Context())
            {
                var values = context.ContactUs.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                var values = context.ContactUs.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }
    }
}
