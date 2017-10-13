﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTask12oct.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildLastName { get; set; }
        public string ChildGender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
    }
}