using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CartLine
    {
        public HolidayTourCardDTOs holidayTourCardDTOs { get; set; }
        public decimal Quantity { get; set; }
    }
}
