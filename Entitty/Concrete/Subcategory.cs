using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Subcategory:IEntity
    {
        public int Id { get; set; }
        public int SubheadingId { get; set; }
        public string CategoryName { get; set; }
    }
}
