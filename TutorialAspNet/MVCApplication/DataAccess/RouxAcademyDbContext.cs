using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApplication.DataAccess
{
    public class RouxAcademyDbContext: DbContext
    {
        public RouxAcademyDbContext() : base("RouxAcademyDatabase")//calling base constructor
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
}