using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDestinationService
    {
        IDataResult<List<Destination>> GetAll();
        IResult Add(Destination destination);
        List<Destination> GetList();
        IResult Update(Destination destination);
        IResult Delete(Destination destination);
        Destination GetById(int id);
        List<Destination> GetAllById(int id);



    }
}
