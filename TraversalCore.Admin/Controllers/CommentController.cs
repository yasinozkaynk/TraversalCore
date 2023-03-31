using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Admin.Controllers
{
    [AllowAnonymous]

    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestination();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var result = _commentService.GetById(id);
           _commentService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
