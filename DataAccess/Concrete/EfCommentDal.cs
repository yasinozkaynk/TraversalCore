using Core.DataAccess;
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
    public class EfCommentDal:EfEntityRepositoryBase<Comment,Context>,ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Destination).ToList();
            }
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            throw new NotImplementedException();
        }

        //    public List<Comment> GetListCommentWithDestinationAndUser(int id)
        //    {
        //        using (var c = new Context())
        //        {
        //            return c.Comments.Where(x => x.DestinationID == id).Include().ToList();
        //        }

        //    }
    }
}
