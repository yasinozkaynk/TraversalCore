using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class CategoryViewModel
    {
        public List<Subcategory> Subcategory { get; set; }
        public List<Subheading> Subheading { get; set; }
        public List<Category> Category  { get; set; }
    }
}
