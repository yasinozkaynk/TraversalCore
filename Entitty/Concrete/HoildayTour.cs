using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HoildayTour:IEntity
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Comment { get; set; }
        public string SubComment { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Ofer { get; set; }
        public string TourCompany { get; set; }
        public int CategoryId { get; set; }
        public bool Delete { get; set; }
        public bool PopularStatus { get; set; }


    }
}
