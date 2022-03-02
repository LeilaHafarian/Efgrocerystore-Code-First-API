using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Mentorship

    {

        public int Mentor { get; set; }
        public int Mentee { get; set; }
        public DateTime ExpDate { get; set; }

        //Navigation Properties
        public virtual Employee? Employee { get; set; }
        public int EmployeeId { get; set; }


    }
}
