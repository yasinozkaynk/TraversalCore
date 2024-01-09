using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class UserCrediCart:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CartNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CVV { get; set; }
        public int AvailableBalance { get; set; }
        public int UserId { get; set; }
    }
}
