using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        List<Comment> GetAll();
        Comment GetById(int id);
        List<Comment> GetDestinationById(int id);
        List<Comment> TGetListCommentWithDestination();
        List<Comment> TGetListCommentWithDestinationAndUser(int id);
    }
}
