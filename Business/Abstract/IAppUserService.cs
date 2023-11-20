using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppUserService
    {
        void Add(AppUser appUser);
        void Update(AppUser appUser);
        void Delete(AppUser appUser);
        List<AppUser> GetAll();
        AppUser GetById(int id);

    }
}
