using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Employees1
    {
        public Employees1()
        {
            InverseManager = new HashSet<Employees1>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? ManagerId { get; set; }

        public virtual Employees1 Manager { get; set; }
        public virtual ICollection<Employees1> InverseManager { get; set; }
    }
}
