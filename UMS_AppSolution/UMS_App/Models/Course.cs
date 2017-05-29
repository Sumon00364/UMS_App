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
    /// ----- Description : Create course model and uer will enter some course related 
    ///                     data in the database.
    /// *******************************************************************************
    /// ===============================================================================
    /// </summary>
    public class Course
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "The Course name is require!")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 4)]
        [DataType(DataType.Text)]
        [Display(Name = "Course Name")]
        public string CoueseName { get; set; }


        [Required(ErrorMessage = "The course code is require!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }


        [Required(ErrorMessage = "The course credit is require!")]
        [Range(0.5, 5.0, ErrorMessage = "The {0} must be at least {2}.")]
        [DataType(DataType.Text)]
        [Display(Name = "Course Credit")]
        public double CourseCredit { get; set; }


        [StringLength(250, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "The department name is require!")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }


        [Required(ErrorMessage = "The Semester name is require!")]
        [Display(Name = "Semester")]
        public int SemesterId { get; set; }
        [ForeignKey("SemesterId")]
        public virtual Semester Semester { get; set; }
        public virtual ICollection<ClassRoomAllocate> ClassRoomAllocates { get; set; }
    }
}