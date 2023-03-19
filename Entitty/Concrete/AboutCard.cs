using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AboutCard: IEntity
    {
        public int AboutCardID { get; set; }
        public string Title { get; set; }
        public string FirstTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        
        
    }
}
