using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GuideManager : IGuideService
    {
        private IGuideDal _guideDal;
        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }
        public IResult Add(Guide guide)
        {
            _guideDal.Add(guide);
            return new SuccessResult();
        }

        public void ChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalseByGuide(id);
        }

        public void ChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public IResult Delete(Guide guide)
        {
            _guideDal.Delete(guide);
            return new SuccessResult();
        }

        public List<Guide> GetAll()
        {
            return _guideDal.GetAll();
        }

        public Guide GetById(int id)
        {
           return _guideDal.Get(x=>x.GuideID==id);
        }

        public IResult Update(Guide guide)
        {
            _guideDal.Update(guide);
            return new SuccessResult();
        }

       
    }
}
