using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFeatureService
    {
        IDataResult<List<Feature>> GetAll();
        List<Feature> GetList();
        IResult Add(Feature feature);
        IResult Update(Feature feature);
        IResult Delete(Feature feature);
        IDataResult<List<Feature>> GetById(int id);
    }
}
