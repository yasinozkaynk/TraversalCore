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
    public class HoildayTourManager : IHoildayTourService
    {
        IHoildayTourDal _hoildayTourDal;
public HoildayTourManager(IHoildayTourDal hoildayTourDal)
        {
            _hoildayTourDal = hoildayTourDal;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(HoildayTour hoildayTour)
        {
            throw new NotImplementedException();
        }

        public List<HoildayTour> GetAll()
        {
            return _hoildayTourDal.GetAll();
        }

        public List<HoildayTour> GetAllById(int id)
        {
            return _hoildayTourDal.GetAll(x=>x.CategoryId==id);
        }

        public HoildayTour GetById(int id)
        {
           return _hoildayTourDal.Get(x=>x.Id==id);
        }

        public void Update(HoildayTour hoildayTour)
        {
            throw new NotImplementedException();
        }
    }
}
