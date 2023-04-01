using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGuideService
    {
        List<Guide> GetAll();
        IResult Add(Guide guide);
        IResult Update(Guide guide);
        IResult Delete(Guide guide);
        Guide GetById(int id);
        void ChangeToFalseByGuide(int id);
        void ChangeToTrueByGuide(int id);
    }
}
