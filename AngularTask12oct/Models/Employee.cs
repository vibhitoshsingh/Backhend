using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularTask12oct.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
       
    }
}