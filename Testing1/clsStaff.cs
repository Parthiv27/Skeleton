using System;

namespace Testing1
{
    internal class clsStaff
    {
        public int StaffId { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Email { get; internal set; }
        public DateTime HireDate { get; internal set; }
        public bool Active { get; internal set; }
        public decimal Salary { get; internal set; }
    }
}