using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs.CategoryDTOs;
using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHolidayTourDetailDal : IEntityRepository<HolidayTourDetail> 
    {
        public HolidayTourCardDTOs HolidayTourCard(Expression<Func<HolidayTourCardDTOs, bool>> filter);
        public List<HolidayTourCardDTOs> HolidayTourGetAllCard(Expression<Func<HolidayTourCardDTOs, bool>> filter=null);

    }
}
