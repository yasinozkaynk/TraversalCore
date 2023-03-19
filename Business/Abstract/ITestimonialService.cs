using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITestimonialService
    {
        IDataResult<List<Testimonial>> GetAll();
        List<Testimonial> GetList();
        IResult Add(Testimonial testimonial);
        IResult Update(Testimonial testimonial);
        IResult Delete(Testimonial testimonial);
        IDataResult<List<Testimonial>> GetById(int id);
    }
}
