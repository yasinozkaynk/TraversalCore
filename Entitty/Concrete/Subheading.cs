using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Subheading:IEntity
    {
        public int Id { get; set; }
        public string SubheadingName { get; set; }
        public int CategoryId { get; set; }

    }
}
