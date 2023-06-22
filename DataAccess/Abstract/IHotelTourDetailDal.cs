using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs.HotelDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHotelTourDetailDal:IEntityRepository<HotelTourDetail>
    {
     HotelDetailDTOs GetHotelDetail(Expression<Func<HotelDetailDTOs, bool>> filter);

    }
}
