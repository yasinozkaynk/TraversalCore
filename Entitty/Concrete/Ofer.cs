using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Ofer:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirsExplanation { get; set; }
        public string Explanation { get; set; }
        public string FirstImage { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

    }
}
