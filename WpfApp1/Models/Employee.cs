using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class Employee
    {
        public int Idemployee { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //public static implicit operator Employee(Employee v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
