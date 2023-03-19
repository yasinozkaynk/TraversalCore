using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutCardService
    {
        IDataResult<List<AboutCard>> GetAll();
        IResult Add(AboutCard aboutCard);
        IResult Update(AboutCard aboutCard);
        IResult Delete(AboutCard aboutCard);
        IDataResult<List<AboutCard>> GetById(int id);
    }
}
