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
    /// ----- Writen Date : 18-05-2017.
    /// ----- Description : Create a designation model where store the teacher 
    ///                     designation.
    /// *****************************************************************************
    /// =============================================================================
    /// 
    /// </summary>
    public class Designation
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "The designation name is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Designation")]
        public string DesignationName { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}