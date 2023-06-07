using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SubAbout : IEntity
    {
        public int SubAboutID { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        
    }
}
