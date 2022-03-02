using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //navigation proporties
        public virtual ICollection<Telephone>? Telephones{ get; set; }
        public virtual ICollection<Email>? EmailAddress { get; set; }
        public virtual ICollection<Mentorship>? Mentorships{ get; set; }
        public virtual ICollection<Department>? Departments { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

        




        

      
       
    }
}
