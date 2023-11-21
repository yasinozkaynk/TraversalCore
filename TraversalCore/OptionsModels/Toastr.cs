using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.OptionsModels
{
    public class Toastr
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public Toastr(string message, string title="Information", ToastrType type=ToastrType.Info)
        {
            this.Message = message;
            this.Title = title;
        }
    }
    public enum ToastrType
    {
        Info = 0,
        Success = 1,
        Warning = 2,
        Error=4,
    }
}
