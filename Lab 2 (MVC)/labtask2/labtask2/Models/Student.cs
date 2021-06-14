using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace labtask2.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please put your name")]
        [MaxLength(5, ErrorMessage = "Max Length 5")]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]
        public double CGPA { get; set; }
        [Required]
        public int Dept_Id { get; set; }
    }
}