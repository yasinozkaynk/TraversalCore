using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.OptionsModels;

namespace TraversalCore.Services
{
    public static class ToastrService
    {
        private static readonly List<(DateTime Date, string SessionId, Toastr Toastr)> _toastrs
            = new List<(DateTime Date, string SessionId, Toastr Toastr)>();

        public static void AddUserQueue(Toastr toastr)
        {
        }
    }
}
