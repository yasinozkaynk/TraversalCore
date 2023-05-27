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
    public class SubheadingManager : ISubhadingService
    {
        ISubheadingDal _subheadingDal;

        public SubheadingManager(ISubheadingDal subheadingDal)
        {
            _subheadingDal = subheadingDal;
        }

        public List<Subheading> GetAll()
        {
           return _subheadingDal.GetAll();
        }
    }
}
