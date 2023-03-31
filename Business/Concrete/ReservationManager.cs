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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation reservation)
        {
            _reservationDal.Add(reservation);
        }

        public void Delete(Reservation reservation)
        {
            _reservationDal.Delete(reservation);
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.Get(x=>x.ReservationID==id);
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitAprroval(id);
        }

        public void Update(Reservation reservation)
        {
            _reservationDal.Update(reservation);
        }
    }
}
