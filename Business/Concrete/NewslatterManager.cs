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
    public class NewslatterManager : INewslatterService
    {
        private INewslatterDal _newslatterDal;
        public NewslatterManager(INewslatterDal newslatterDal)
        {
            _newslatterDal = newslatterDal;
        }
        public IResult Add(Newslatter newslatter)
        {
            _newslatterDal.Add(newslatter);
            return new SuccessResult();
        }

        public IResult Delete(Newslatter newslatter)
        {
            _newslatterDal.Delete(newslatter);
            return new SuccessResult();
        }

        public IDataResult<List<Newslatter>> GetAll()
        {
            return new SuccessDataResult<List<Newslatter>>(_newslatterDal.GetAll());
        }

        public IDataResult<List<Newslatter>> GetById(int id)
        {
            return new SuccessDataResult<List<Newslatter>>(_newslatterDal.GetAll(x=>x.NewslaterID==id));

        }

        public IResult Update(Newslatter newslatter)
        {
            _newslatterDal.Update(newslatter);
            return new SuccessResult();
        }
    }
}
