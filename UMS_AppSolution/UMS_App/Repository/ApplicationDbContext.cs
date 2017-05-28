using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using UMS_App.Models;

namespace UMS_App.Repository
{
    /// <summary>
    /// ==============================================================================
    /// ******************************************************************************
    /// ----- Author Name : Md. Sumon Miah.
    /// ----- Writen Date : 16-05-2017 to final presentation day.
    /// ----- Description : ApplicationDbContext class ia a database connection class.
    ///                     Hare all DbSet list are database table representator.
    /// ******************************************************************************
    /// ==============================================================================
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
       
    }
}