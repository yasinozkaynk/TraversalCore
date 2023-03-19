using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.UI.ViewComponets.Comment
{
    public class _CommentList:ViewComponent
    {
        ICommentService _commentService;

        public _CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _commentService.GetDestinationById(id);
            return View(result);
        }
    }
}
