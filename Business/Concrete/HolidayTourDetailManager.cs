using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HolidayTourDetailManager : IHolidayTourDetailService
    {
        IHolidayTourDetailDal _holidayTourDetailDal;

        public HolidayTourDetailManager(IHolidayTourDetailDal holidayTourDetailDal)
        {
            _holidayTourDetailDal = holidayTourDetailDal;
        }

        public HolidayTourCardDTOs GetAlById(int id)
        {
            return _holidayTourDetailDal.HolidayTourCard(x => x.HolidayTourId == id);
        }

        public List<HolidayTourCardDTOs> GetAllByCardId(int id)
        {
            return _holidayTourDetailDal.HolidayTourGetAllCard(x=>x.HolidayTourId==id);
        }

        public HolidayTourDetail GetById(int id)
        {
            return _holidayTourDetailDal.Get(x => x.HolidayTourId == id);
        }
    }
}
