using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UMS_App.Models
{
    public class Department
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "The department name is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "Department Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The department code is require!")]
        [StringLength(7, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Department Code")]
        public string Code { get; set; }

        //public virtual ICollection<Course> Courses { get; set; }
        //public virtual ICollection<Teacher> Teachers { get; set; }
        //public virtual ICollection<Student> Students { get; set; }

    }
}