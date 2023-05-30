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
    public class OferManager : IOferService
    {
        IOferDal _oferDal;

        public OferManager(IOferDal oferDal)
        {
            _oferDal = oferDal;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(Ofer ofer)
        {
            throw new NotImplementedException();
        }

        public List<Ofer> GetAll()
        {
            return _oferDal.GetAll();
        }

        public void Update(Ofer ofer)
        {
            throw new NotImplementedException();
        }
    }
}
