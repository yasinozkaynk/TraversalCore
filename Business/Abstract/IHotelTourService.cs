using Entity.Concrete;
using Entity.DTOs.HotelDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHotelTourService
    {
        List<HotelTour> GetAll();
        void Add(HotelTour hotelTour );
        List<HotelTour> GetList();
        void Update(HotelTour hotelTour );
        void Delete(HotelTour hotelTour );
        List<HotelTour> GetHotelNameFilter(string hotelName);
        HotelTour GetById(int id);
        List<HotelTour> GetAllById(int id);
        HotelDetailDTOs GetHotelDetail(int id);

    }
}
