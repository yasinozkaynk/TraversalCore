using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HolidayTourDetail:IEntity
    {
        public int Id { get; set; }
        public string PaketName  { get; set; }
        public int TourCapacity { get; set; }
        public bool MorningMeal { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }
        public decimal TourPrice { get; set; }
        public int RemainingCapacity { get; set; }
        public int HolidayTourId { get; set; }

    }
}
