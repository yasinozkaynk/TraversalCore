using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HotelTourDetail:IEntity
    {
        public int Id { get; set; }
        public string HotelFeatures1 { get; set; }
        public string HotelFeatures2 { get; set; }
        public string HotelFeatures3 { get; set; }
        public string HotelFeatures4 { get; set; }
        public string HotelFeatures5 { get; set; }
        public string HotelFeatures6 { get; set; }
        public string HotelInformation { get; set; }
        public string HotelRom1 { get; set; }
        public string HotelRom2 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public int HotelId { get; set; }
    }
}
