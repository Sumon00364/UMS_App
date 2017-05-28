using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// ----- Writen Date : 20-05-2017.
    /// ----- Description : Create a Course Assign to Teacher class. Here uer will 
    ///                     select department, teacher, Course and its related data 
    ///                     are auto fill.
    /// ******************************************************************************
    /// ============================================================================== 
    /// </summary>
    public class CourseAssign
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }


        [Required]
        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }


        [Display(Name = "Credit to be Taken")]
        [Editable(false)]
        [DefaultValue(0.0)]
        public double CreditTaken { get; set; }


        [Display(Name = "Remaining Credit")]
        [Editable(false)]
        [DefaultValue(0.0)]
        public double CreditLeft { get; set; }


        [Required]
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }


        public string Name { get; set; }


        public double Credit { get; set; }
    }
}