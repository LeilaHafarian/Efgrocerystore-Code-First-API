using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public class Product
    {
        
        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public decimal Price {get; set; }
        public int NuminStore {get; set;}
        public DateTime ExpDate {get; set; } = DateTime.Today.AddDays(40);
        public DateTime LastCount {get; set;}
        public string? ListOfIngredients {get; set;}



        //Navigation properties
        public virtual Employee? Employee { get; set; }
        public int EmployeeId { get; set; }

        public virtual Campain? Campain { get; set; }
        public int CampainId { get; set; }

      
        public virtual ICollection<ProductDepartment> ProductDepartments { get; set; }


    }
}









