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
    public class HotelTourDetailManager : IHotelTourDetailService
    {
        IHotelTourDetailDal _hotelTourDetailDal;

        public HotelTourDetailManager(IHotelTourDetailDal hotelTourDetailDal)
        {
            _hotelTourDetailDal = hotelTourDetailDal;
        }

        public HotelTourDetail GetHotelDetail(int id)
        {
            return _hotelTourDetailDal.Get(x => x.HotelId == id);
        }
    }
}
