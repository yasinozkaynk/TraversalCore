using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        public List<CategoryDto> GetAllCategory(Expression<Func<CategoryDto, bool>> filter = null);

    }
}
