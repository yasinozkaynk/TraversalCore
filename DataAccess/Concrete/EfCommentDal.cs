﻿using Core.DataAccess;
using Core.DataAccess.EntityFremawork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremawork.Context;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, Context>, ICommentDal
    {

    }
}
