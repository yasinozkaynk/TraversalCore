using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Destination : IEntity
    {
        public int DestinationID { get; set; }
        public int CategoryId { get; set; }
        public int Capacity { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string CoverImage { get; set; }
        public string FirstImage { get; set; }
        public string FirstDetails { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public List<Comment> Comments { get; set; }
    }



}
