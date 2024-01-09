using Core.DataAccess.EntityFremawork;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremawork.Context;
using Entity.Concrete;
using Entity.DTOs.CategoryDTOs;
using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfHolidayTourDetailDal : EfEntityRepositoryBase<HolidayTourDetail, Context>, IHolidayTourDetailDal
    {
        public HolidayTourCardDTOs HolidayTourCard(Expression<Func<HolidayTourCardDTOs, bool>> filter)
        {
            using (Context context = new Context())
            {
                var result = from holidayTour in context.HolidayTours
                             join detail in context.HolidayTourDetails
                             on holidayTour.Id equals detail.HolidayTourId
                             select new HolidayTourCardDTOs
                             {
                                 Id = detail.Id,
                                 PaketName = detail.PaketName,
                                 Dinner = detail.Dinner,
                                 Title = holidayTour.Title,
                                 Subtitle = holidayTour.Subtitle,
                                 Image = holidayTour.Image,
                                 TourCapacity = detail.TourCapacity,
                                 Lunch = detail.Lunch,
                                 MorningMeal = detail.MorningMeal,
                                 RemainingCapacity = detail.RemainingCapacity,
                                 TourPrice = detail.TourPrice,
                                 HolidayTourId = detail.HolidayTourId,

                             };
                return result.SingleOrDefault(filter);

            }
        }

        public List<HolidayTourCardDTOs> HolidayTourGetAllCard(Expression<Func<HolidayTourCardDTOs, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var result = from holidayTour in context.HolidayTours
                             join detail in context.HolidayTourDetails
                             on holidayTour.Id equals detail.HolidayTourId
                             select new HolidayTourCardDTOs
                             {
                                 Id = detail.Id,
                                 PaketName = detail.PaketName,
                                 Dinner = detail.Dinner,
                                 Title = holidayTour.Title,
                                 Subtitle = holidayTour.Subtitle,
                                 Image = holidayTour.Image,
                                 TourCapacity = detail.TourCapacity,
                                 Lunch = detail.Lunch,
                                 MorningMeal = detail.MorningMeal,
                                 RemainingCapacity = detail.RemainingCapacity,
                                 TourPrice = detail.TourPrice,
                                 HolidayTourId = detail.HolidayTourId,

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
