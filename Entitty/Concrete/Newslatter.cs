using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Newslatter : IEntity
    {
        [Key]
        public int NewslaterID { get; set; }
        public string Mail { get; set; }
    }
}
