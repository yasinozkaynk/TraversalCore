using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Areas.MemberArea.Models
{
    public class UserCrediCartViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Imageurl { get; set; }
        public int CartNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CVV { get; set; }
        public int AvailableBalance { get; set; }
        public List<UserCrediCart> UserCrediCarts { get; set; }
        public UserCrediCart userCrediCart { get; set; }

    }
}
