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
    /// ----- Writen Date : 18-05-2017
    /// ----- Description : Create teacher model and uer will enter teacter 
    ///                     information and save it in database.
    /// ******************************************************************************
    /// ==============================================================================
    /// </summary>
    public class Teacher
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "The teacher name is require!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        [Display(Name = "Teacher Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The teacher email is require!")]
        [StringLength(320, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }


        [Required(ErrorMessage = "The teacher contact number is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contect Number")]
        public string ContactNo { get; set; }


        [Required(ErrorMessage = "The teacher address is require!")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [Required(ErrorMessage = "The teacher designation is require!")]
        [Display(Name = "Designation")]
        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public virtual Designation Designation { get; set; }


        [Required(ErrorMessage = "The department name is require!")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}