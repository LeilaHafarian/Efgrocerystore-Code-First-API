using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DepartmentEmailDTO
    {
        public string DepartmentName { get; set; }
        public List<string>? Email { get; set; }
    }
}
