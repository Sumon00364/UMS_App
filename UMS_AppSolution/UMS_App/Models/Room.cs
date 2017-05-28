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
    /// ----- Description : Create Room class where only save room number.
    /// **************************************************************************
    /// ==========================================================================
    /// </summary>
    public class Room
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Room number is require!")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [Display(Name = "Room Number")]
        public string RoomName { get; set; }

        public virtual ICollection<ClassRoomAllocate> ClassRooms { get; set; } 
    }
}