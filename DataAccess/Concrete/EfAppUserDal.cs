using Core.DataAccess.EntityFremawork;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremawork.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfAppUserDal:EfEntityRepositoryBase<AppUser,Context>,IAppUserDal
    {
    }
}
