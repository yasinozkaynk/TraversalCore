using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFremawork.Context
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = DESKTOP-14HE78G\SQLEXPRESS2019; initial catalog =TraversalDB; integrated security = true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutCard> AboutCards { get; set; }
        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<UserCrediCart> UserCrediCarts  { get; set; }
        public DbSet<Feature> Features  { get; set; }
        public DbSet<Guide> Guides  { get; set; }
        public DbSet<HolidayTourDetail> HolidayTourDetails { get; set; }
        public DbSet<Newslatter> Newslatters  { get; set; }
        public DbSet<SubAbout> SubAbouts  { get; set; }
        public DbSet<Testimonial> Testimonials  { get; set; }
        public DbSet<Comment> Comments  { get; set; }
        public DbSet<HolidayTourReservation> HolidayTourReservations  { get; set; }
        public DbSet<ContactUs> ContactUs  { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Subcategory> SubCategories  { get; set; }
        public DbSet<Subheading> Subheadings  { get; set; }
        public DbSet<Ofer> Ofers  { get; set; }
        public DbSet<HolidayTour> HolidayTours  { get; set; }

    }
}
