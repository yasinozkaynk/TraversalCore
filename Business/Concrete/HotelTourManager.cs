using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs.HotelDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HotelTourManager : IHotelTourService
    {
        IHotelTourDal _hotelTourDal;
        IHotelTourDetailDal _hotelTourDetailDal;

        public HotelTourManager(IHotelTourDal hotelTourDal, IHotelTourDetailDal hotelTourDetailDal = null)
        {
            _hotelTourDal = hotelTourDal;
            _hotelTourDetailDal = hotelTourDetailDal;
        }

        public void Add(HotelTour hotelTour)
        {
            _hotelTourDal.Add(hotelTour);
        }

        public void Delete(HotelTour hotelTour)
        {
            throw new NotImplementedException();
        }

        public List<HotelTour> GetAll()
        {
            return _hotelTourDal.GetAll();
        }

        public List<HotelTour> GetAllById(int id)
        {

            return _hotelTourDal.GetAll(x => x.CategoryId == id);
        }

        public HotelTour GetById(int id)
        {
            return _hotelTourDal.Get(x => x.Id == id);

        }

        public HotelDetailDTOs GetHotelDetail(int id)
        {
            return _hotelTourDetailDal.GetHotelDetail(x=>x.HotelId==id);
        }

        public List<HotelTour> GetHotelNameFilter( string hotelName)
        {
            if (hotelName !=null)
            {
                return _hotelTourDal.GetAll(x =>x.HotelName==hotelName);
            }
            throw new NotImplementedException();
        }

        public List<HotelTour> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(HotelTour hotelTour)
        {
            throw new NotImplementedException();
        }
    }
}
