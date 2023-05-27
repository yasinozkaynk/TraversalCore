using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }
        public IResult Add(Destination destination)
        {
            _destinationDal.Add(destination);
            return new SuccessResult();
        }

        public IResult Delete(Destination destination)
        {
            _destinationDal.Delete(destination);
            return new SuccessResult();
        }

        public IDataResult<List<Destination>> GetAll()
        {
            return new SuccessDataResult<List<Destination>>(_destinationDal.GetAll());
        }

        public List<Destination> GetAllById(int id)
        {
            return _destinationDal.GetAll(x=>x.CategoryId==id);
        }

        public Destination GetById(int id)
        {
            return _destinationDal.Get(x=>x.DestinationID==id);

        }

        public List<Destination> GetList()
        {
            return _destinationDal.GetAll();
        }

        public IResult Update(Destination destination)
        {
            _destinationDal.Update(destination);
            return new SuccessResult();
        }
    }
}
