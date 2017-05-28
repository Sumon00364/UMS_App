using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UMS_App.Models
{
    /// <summary>
    /// =============================================================================
    /// *****************************************************************************
    /// ----- Author Name : Md. Sumon Miah.
    /// ----- Writen Date : 19-05-2017.
    /// ----- Description : Create a Student model for entering student regitration 
    ///                     information.
    /// ******************************************************************************
    /// ==============================================================================
    /// </summary>
    public class Student
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "The student name is require!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 4)]
        [DataType(DataType.Text)]
        [Display(Name = "Student Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The student email is require!")]
        [StringLength(320, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }


        [Required(ErrorMessage = "The student contact number is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; }


        [Required(ErrorMessage = "The registration date is require!")]
        [DataType(DataType.Date)]
        [Display(Name = "Registration Date")]
        public DateTime Date { get; set; }


        [Required(ErrorMessage = "The student address is require!")]
        [StringLength(250, ErrorMessage = "The {0} must be at {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [Required(ErrorMessage = "The department name is require")]
        [Display(Name = "Department Name")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}