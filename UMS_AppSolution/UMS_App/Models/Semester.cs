using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UMS_App.Models
{
    /// <summary>
    /// ==============================================================================
    /// ******************************************************************************
    /// ----- Author Name : Md. Sumon Miah.
    /// ----- Writen Date : 17-05-2017.
    /// ----- Description : Create semester model for database table purpose. And its 
    ///                     has no UI for entering semester name.
    /// *******************************************************************************
    /// ===============================================================================
    /// </summary>
    public class Semester
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "The semester name is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Semester Name")]
        public string SemesterName { get; set; }
        public virtual ICollection<Course> Courses { get; set; } 
    }
}