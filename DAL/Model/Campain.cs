using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Campain
    {
        public int CampainId { get; set; }
        public decimal Pricedrop { get; set; }


        //Navigation properties
        public virtual ICollection<Product>? Products { get; set; }

       
       
        
    }
}
