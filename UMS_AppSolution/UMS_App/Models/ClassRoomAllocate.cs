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
    /// ----- Description : Create Class Room Allocate class where only save 
    ///                     class room allocate system and time table.
    /// **************************************************************************
    /// ==========================================================================
    /// </summary>
    public class ClassRoomAllocate
    {
       
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "The department name is require!")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        
        [Required(ErrorMessage = "The course name is require!")]
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        
        [Required(ErrorMessage = "The room number is require!")]
        [Display(Name = "Room No.")]
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }


        [Required(ErrorMessage = "The day is require!")]
        [Display(Name = "Day")]
        public Day DayId { get; set; }
      

        [Required(ErrorMessage = "The start time is require!")]
        [DataType(DataType.Time)]
        [Display(Name = "From")]
        public TimeSpan FromTime { get; set; }


        [Required(ErrorMessage = "The end time is require!")]
        [DataType(DataType.Time)]
        [Display(Name = "To")]
        public TimeSpan ToTime { get; set; }
    }

    public enum Day
    {
        SaturDay,
        SunDay,
        MonDay,
        TuesDay,
        Wednesday,
        ThursDay,
        Friday
    }
}