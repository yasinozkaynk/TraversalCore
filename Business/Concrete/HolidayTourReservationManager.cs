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
    public class HolidayTourReservationManager : IHolidayTourReservationService
    {
        IHolidayTourReservationDal _reservationDal;

        public HolidayTourReservationManager(IHolidayTourReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(HolidayTourReservation reservation)
        {
            reservation.ReservationDate = DateTime.Now;
            _reservationDal.Add(reservation);
        }

        public void Delete(HolidayTourReservation reservation)
        {
            _reservationDal.Delete(reservation);
        }

        public List<HolidayTourReservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public HolidayTourReservation GetById(int id)
        {
            return _reservationDal.Get(x=>x.Id==id);
        }

        public void Update(HolidayTourReservation reservation)
        {
            _reservationDal.Update(reservation);
        }
    }
}
