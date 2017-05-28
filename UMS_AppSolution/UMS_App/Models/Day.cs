using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UMS_App.Models
{
    /// <summary>
    /// ==========================================================================
    /// **************************************************************************
    /// ----- Author Name : Md. Sumon Miah.
    /// ----- Writen Date : 20-05-2017
    /// ----- Description : Create Day class where only save seven days in a week.
    /// **************************************************************************
    /// ==========================================================================
    /// </summary>
    public class Day
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "The day is require")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        [Display(Name = "Day")]
        public string DayName { get; set; }
        public virtual ICollection<ClassRoomAllocate> ClassRooms { get; set; } 
    }
}