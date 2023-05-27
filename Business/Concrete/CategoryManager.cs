using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> CategoriList()
        {
            return _categoryDal.GetAll();
        }

        public List<CategoryDto> CategoryDtos()
        {
           return  _categoryDal.GetAllCategory();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
