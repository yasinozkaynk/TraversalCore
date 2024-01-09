using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HolidayTourReservation : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int PersonCount { get; set; }
        public int HolidayTourId { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool Status { get; set; }
    }
}
