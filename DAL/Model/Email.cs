using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Email
    {
        public readonly int DepartmentName;

        public string? EmailAddress { get; set; }

        //navigation proporties
        public virtual Employee Employee { get; set; }
        public int EmployeeId { get; set; }

    }
}
