using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Add(AppUser appUser)
        {
            _appUserDal.Add(appUser);
        }

        public void Delete(AppUser appUser)
        {
            _appUserDal.Delete(appUser);
        }

        public List<AppUser> GetAll()
        {
            return _appUserDal.GetAll();
        }

        public AppUser GetById(int id)
        {
            return _appUserDal.Get(x=>x.Id==id);
        }

        public void Update(AppUser appUser)
        {
            _appUserDal.Update(appUser);
        }
    }
}
