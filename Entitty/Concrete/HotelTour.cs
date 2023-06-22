using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HotelTour:IEntity
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Citydistrict { get; set; }
        public string HotelName { get; set; }
        public string Explanation { get; set; }
        public string Explanation2 { get; set; }
        public string Offer1 { get; set; }
        public string Offer2{ get; set; }
        public string Offer3 { get; set; }
        public string HotelFeatures1 { get; set; }
        public string HotelFeatures2 { get; set; }
        public string HotelFeatures3 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public Double Price { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
    }
}
