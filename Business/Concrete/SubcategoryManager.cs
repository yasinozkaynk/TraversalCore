using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubcategoryManager : ISubcategoryService
    {
        ISubcategoryDal _subcategoryDal;

        public SubcategoryManager(ISubcategoryDal subcategoryDal)
        {
            _subcategoryDal = subcategoryDal;
        }

        public List<Subcategory> GetAll()
        {
            return _subcategoryDal.GetAll();
        }
    }
}
