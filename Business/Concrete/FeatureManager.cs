using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public IResult Add(Feature feature)
        {
            _featureDal.Add(feature);
            return new SuccessResult();
        }

        public IResult Delete(Feature feature)
        {
            _featureDal.Delete(feature);
            return new SuccessResult();
        }

        public IDataResult<List<Feature>> GetAll()
        {
            return new SuccessDataResult<List<Feature>>(_featureDal.GetAll());
        }

        public IDataResult<List<Feature>> GetById(int id)
        {
            return new SuccessDataResult<List<Feature>>(_featureDal.GetAll(x=>x.FeatureID==id));
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetAll();
        }

        public IResult Update(Feature feature)
        {
            _featureDal.Update(feature);
            return new SuccessResult();
        }
    }
}
