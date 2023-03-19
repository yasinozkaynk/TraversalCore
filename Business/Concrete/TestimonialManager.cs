using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public IResult Add(Testimonial testimonial)
        {
            _testimonialDal.Add(testimonial);
            return new SuccessResult();
        }

        public IResult Delete(Testimonial testimonial)
        {
            _testimonialDal.Delete(testimonial);
            return new SuccessResult();
        }

        public IDataResult<List<Testimonial>> GetAll()
        {
            return new SuccessDataResult<List<Testimonial>>(_testimonialDal.GetAll());
        }

        public IDataResult<List<Testimonial>> GetById(int id)
        {
            return new SuccessDataResult<List<Testimonial>>(_testimonialDal.GetAll(x=>x.TestimonialID==id));
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetAll();
        }

        public IResult Update(Testimonial testimonial)
        {
            _testimonialDal.Update(testimonial);
            return new SuccessResult();
        }
    }
}
