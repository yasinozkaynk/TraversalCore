using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.CategoryDTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string SubheadingName { get; set; }
        public int SubheadingId { get; set; }
        public string SubcategoryName { get; set; }
    }
}
