using Core.DataAccess;
using Core.DataAccess.EntityFremawork;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHolidayTourReservationDal:IEntityRepository<HolidayTourReservation>
    {
    }
}
