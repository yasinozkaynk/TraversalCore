using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserCrediCartManager : IUserCrediCartService
    {
        IUserCrediCartDal _userCrediCartDal;

        public UserCrediCartManager(IUserCrediCartDal userCrediCartDal)
        {
            _userCrediCartDal = userCrediCartDal;
        }

        public void Add(UserCrediCart userCrediCart)
        {
            _userCrediCartDal.Add(userCrediCart);
        }

        public void Delete(UserCrediCart userCrediCart)
        {
            _userCrediCartDal.Delete(userCrediCart);
        }

        public List<UserCrediCart> GetAll()
        {
            return _userCrediCartDal.GetAll();
        }

        public UserCrediCart GetById(int id)
        {
           return _userCrediCartDal.Get(x=>x.Id==id);
        }

        public void Update(UserCrediCart userCrediCart)
        {
            _userCrediCartDal.Update(userCrediCart);
        }
    }
}
