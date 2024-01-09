using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserCrediCartService
    {
        void Add(UserCrediCart userCrediCart);
        void Delete(UserCrediCart userCrediCart);
        void Update(UserCrediCart userCrediCart);
        UserCrediCart GetById(int id);
        List<UserCrediCart> GetAll();
    }
}
