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
    public class AboutCardManager : IAboutCardService
    {
        private IAboutCardDal _aboutCardDal;
        public AboutCardManager(IAboutCardDal aboutCardDal)
        {
            _aboutCardDal = aboutCardDal;
        }

        public IResult Add(AboutCard aboutCard)
        {
            _aboutCardDal.Add(aboutCard);
            return new SuccessResult();
        }

        public IResult Delete(AboutCard aboutCard)
        {
            _aboutCardDal.Delete(aboutCard);
            return new SuccessResult();
        }

        public IDataResult<List<AboutCard>> GetAll()
        {
            return new SuccessDataResult<List<AboutCard>>(_aboutCardDal.GetAll());
        }

        public IDataResult<List<AboutCard>> GetById(int id)
        {
            return new SuccessDataResult<List<AboutCard>>(_aboutCardDal.GetAll(x=>x.AboutCardID==id));
        }

        public IResult Update(AboutCard aboutCard)
        {
            _aboutCardDal.Update(aboutCard);
            return new SuccessResult();
        }
    }
}
