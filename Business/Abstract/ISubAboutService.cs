using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubAboutService
    {
        IDataResult<List<SubAbout>> GetAll();
        List<SubAbout> GetList();
        IResult Add(SubAbout subAbout);
        IResult Update(SubAbout subAbout);
        IResult Delete(SubAbout subAbout);
        IDataResult<List<SubAbout>> GetById(int id);
    }
}
