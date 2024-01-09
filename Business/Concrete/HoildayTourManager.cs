using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HolidayTourManager : IHolidayTourService
    {
        IHoildayTourDal _hoildayTourDal;
        IHolidayTourDetailDal _holidayTourDetailDal;

        public HolidayTourManager(IHoildayTourDal hoildayTourDal, IHolidayTourDetailDal holidayTourDetailDal)
        {
            _hoildayTourDal = hoildayTourDal;
            _holidayTourDetailDal = holidayTourDetailDal;

        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(HolidayTour hoildayTour)
        {
            throw new NotImplementedException();
        }

        public List<HolidayTour> GetAll()
        {
            return _hoildayTourDal.GetAll();
        }

        public List<HolidayTour> GetAllById(int id)
        {
            return _hoildayTourDal.GetAll(x => x.CategoryId == id);
        }

        public List<HolidayTourCardDTOs> GetByAllCard(int id)
        {
            return _holidayTourDetailDal.HolidayTourGetAllCard();
        }

        public HolidayTourCardDTOs GetByCardId(int id)
        {
            return _holidayTourDetailDal.HolidayTourCard(x=>x.HolidayTourId==id);
            
        }

        public HolidayTour GetById(int id)
        {
            return _hoildayTourDal.Get(x => x.Id == id);
        }

        public HolidayTour GetOnlyHolidayTour(int id, bool trackChanges)
        {
            return _hoildayTourDal.Get(x => x.Id == id);
        }

        public void Update(HolidayTour hoildayTour)
        {
            throw new NotImplementedException();
        }
    }
}
