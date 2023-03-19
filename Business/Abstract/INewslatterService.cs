using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INewslatterService
    {
        IDataResult<List<Newslatter>> GetAll();
        IResult Add(Newslatter newslatter);
        IResult Update(Newslatter newslatter);
        IResult Delete(Newslatter newslatter);
        IDataResult<List<Newslatter>> GetById(int id);
    }
}
