using Entity.Concrete;
using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHolidayTourService
    {
        void Add();
        void Delete(HolidayTour hoildayTour);
        void Update(HolidayTour hoildayTour);
        List<HolidayTour> GetAll();
        List<HolidayTour> GetAllById(int id);
        HolidayTour GetById(int id);
        HolidayTourCardDTOs GetByCardId(int id);
        List<HolidayTourCardDTOs> GetByAllCard(int id);

        HolidayTour? GetOnlyHolidayTour(int id, bool trackChanges);

        
        
    }
}
