using Core.DataAccess.EntityFremawork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremawork.Context;
using Entity.Concrete;
using Entity.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFCategoryDal : EfEntityRepositoryBase<Category, Context>, ICategoryDal
    {
        public List<CategoryDto> GetAllCategory(Expression<Func<CategoryDto, bool>> filter = null)
        {
            using (Context context =new Context())
            {
                var result = from categories in context.Categories
                             join subheadings in context.Subheadings
                             on categories.Id equals subheadings.CategoryId
                             into aaa from a in aaa.DefaultIfEmpty()
                             //join subcategory in context.SubCategories
                             //on subheadings.Id equals subcategory.SubheadingId
                             select new CategoryDto
                             {
                                 Id = categories.Id,
                                 //CategoryId = subcategory.Id,
                                 CategoryName = categories.CategoryName,
                                 //SubcategoryName = subcategory.CategoryName,
                                 SubheadingId = a.Id,
                                 SubheadingName = a.SubheadingName,
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
