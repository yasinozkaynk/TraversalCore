using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHoildayTourService
    {
        void Add();
        void Delete(HoildayTour hoildayTour);
        void Update(HoildayTour hoildayTour);
        List<HoildayTour> GetAll();
        List<HoildayTour> GetAllById(int id);
        HoildayTour GetById(int id);

        
        
    }
}
