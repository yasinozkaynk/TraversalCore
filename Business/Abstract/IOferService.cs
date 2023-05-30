using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface IOferService
    {
        void Add();
        void Delete(Ofer ofer );
        void Update(Ofer ofer);
        List<Ofer> GetAll();
    }
}
