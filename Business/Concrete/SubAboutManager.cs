﻿using Business.Abstract;
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
    public class SubAboutManager : ISubAboutService
    {
        private ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }
        public IResult Add(SubAbout subAbout)
        {
            _subAboutDal.Add(subAbout);
            return new SuccessResult();
        }

        public IResult Delete(SubAbout subAbout)
        {
            _subAboutDal.Delete(subAbout);
            return new SuccessResult();
        }

        public IDataResult<List<SubAbout>> GetAll()
        {
            return new SuccessDataResult<List<SubAbout>>(_subAboutDal.GetAll());
        }

        public IDataResult<List<SubAbout>> GetById(int id)
        {
            return new SuccessDataResult<List<SubAbout>>(_subAboutDal.GetAll(x=>x.SubAboutID==id));
        }

        public List<SubAbout> GetList()
        {
            return _subAboutDal.GetAll();
        }

        public IResult Update(SubAbout subAbout)
        {
            _subAboutDal.Update(subAbout);
            return new SuccessResult();
        }
    }
}
