﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AboutManager>().As<IAboutService>().SingleInstance();
            builder.RegisterType<EfAboutDal>().As<IAboutDal>().SingleInstance();

            builder.RegisterType<DestinationManager>().As<IDestinationService>().SingleInstance();
            builder.RegisterType<EfDestinationDal>().As<IDestinationDal>().SingleInstance();

            builder.RegisterType<FeatureManager>().As<IFeatureService>().SingleInstance();
            builder.RegisterType<EfFeatureDal>().As<IFeatureDal>().SingleInstance();
            
            builder.RegisterType<SubAboutManager>().As<ISubAboutService>().SingleInstance();
            builder.RegisterType<EfSubAboutDal>().As<ISubAboutDal>().SingleInstance();

            builder.RegisterType<TestimonialManager>().As<ITestimonialService>().SingleInstance();
            builder.RegisterType<EfTestimonialDal>().As<ITestimonialDal>().SingleInstance();

            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();

            builder.RegisterType<GuideManager>().As<IGuideService>().SingleInstance();
            builder.RegisterType<EfGuideDal>().As<IGuideDal>().SingleInstance();
        }
    }
}
