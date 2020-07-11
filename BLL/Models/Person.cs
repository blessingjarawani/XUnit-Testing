﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
