using Core.DataAccess.EntityFremawork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremawork.Context;
using Entity.Concrete;
using Entity.DTOs.HotelDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfHotelTourDetailDal : EfEntityRepositoryBase<HotelTourDetail, Context>, IHotelTourDetailDal
    {
        public HotelDetailDTOs GetHotelDetail(Expression<Func<HotelDetailDTOs, bool>> filter)
        {
            using (Context context = new Context())
            {
                var result = from b in context.HotelTourDetails
                             join c in context.HotelTours
                             on b.HotelId equals c.Id
                             select new HotelDetailDTOs
                             {
                                 HotelId=b.HotelId,
                                 City=c.City,
                                 Citydistrict=c.Citydistrict,
                                 Explanation=c.Explanation,
                                 HotelFeatures1=b.HotelFeatures1,
                                 HotelFeatures2=b.HotelFeatures2,
                                 HotelFeatures3=b.HotelFeatures3,
                                 HotelFeatures4=b.HotelFeatures4,
                                 HotelFeatures5=b.HotelFeatures5,
                                 HotelFeatures6=b.HotelFeatures6,
                                 HotelInformation=b.HotelInformation,
                                 HotelName=c.HotelName,
                                 HotelRom1=b.HotelRom1,
                                 HotelRom2=b.HotelRom2,
                                 Image1=b.Image1,
                                 Image2=b.Image2,
                                 Image3=b.Image3,
                                 Offer1=c.Offer1,
                                 Offer2=c.Offer2,
                                 Offer3=c.Offer3,
                                 Price=c.Price,
                             };
                return result.SingleOrDefault();
            }
        }
    }
}
