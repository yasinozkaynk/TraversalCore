using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Contact : IEntity
    {
        public int ContactID { get; set; }
        public string MapLocation { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
