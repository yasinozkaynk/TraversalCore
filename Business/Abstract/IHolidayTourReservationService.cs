using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHolidayTourReservationService
    {
        void Add(HolidayTourReservation reservation);
        void Update(HolidayTourReservation reservation);
        void Delete(HolidayTourReservation reservation);
        List<HolidayTourReservation> GetAll();
        HolidayTourReservation GetById(int id);

    }
}
