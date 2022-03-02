using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        

        //Navigation Properties
        public virtual Employee? Employee { get; set; }
        public int EmployeeId { get; set; }

      
        public virtual ICollection<ProductDepartment> ProductDepartments { get; set; }

      
        //public int ProductId { get; set; }

    }
}


