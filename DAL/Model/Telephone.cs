using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Telephone
    {
         
        public string? PhoneNumber { get; set; }
        

        //navigation proporties
        public virtual Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
