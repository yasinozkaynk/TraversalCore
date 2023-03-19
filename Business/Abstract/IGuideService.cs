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
        IDataResult<List<Guide>> GetAll();
        IResult Add(Guide guide);
        IResult Update(Guide guide);
        IResult Delete(Guide guide);
        IDataResult<List<Guide>> GetById(int id);
    }
}
