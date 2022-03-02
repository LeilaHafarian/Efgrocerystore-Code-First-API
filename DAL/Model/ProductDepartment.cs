using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ProductDepartment
    {
     
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; }
    }
}
