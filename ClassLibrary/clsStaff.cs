﻿using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
    }
}