using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class About: IEntity
    {
        public int AboutID { get; set; }
        public string FirstTitle { get; set; }
        public string FirstDescription { get; set; }
        public string FirtsImage { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
