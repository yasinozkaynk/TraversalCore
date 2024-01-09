using Entity.Concrete;
using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHolidayTourDetailService
    {
        HolidayTourDetail GetById(int id);
        HolidayTourCardDTOs GetAlById(int id);
        List<HolidayTourCardDTOs> GetAllByCardId(int id);
    }
}
