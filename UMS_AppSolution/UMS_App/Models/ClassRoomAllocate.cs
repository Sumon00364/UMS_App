﻿using System;
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




        [Required(ErrorMessage = "The course name is require!")]
        [Display(Name = "Course")]
        public int CourseId { get; set; }




        [Required(ErrorMessage = "The room number is require!")]
        [Display(Name = "Room No.")]
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }


        [Required(ErrorMessage = "The day is require!")]
        [Display(Name = "Day")]
        public int DayId { get; set; }
        [ForeignKey("DayId")]
        public virtual Day Day { get; set; }


        [Required(ErrorMessage = "The start time is require!")]
        [DataType(DataType.Time)]
        [Display(Name = "From")]
        public TimeSpan FromTime { get; set; }


        [Required(ErrorMessage = "The end time is require!")]
        [DataType(DataType.Time)]
        [Display(Name = "To")]
        public TimeSpan ToTime { get; set; }
    }
}