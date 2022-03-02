using DAL.Model;
using System.Collections.Generic;

namespace API.DTO
{
    public class DepartmentEmailAddressDTO
    {
        public string DepartmentName { get; set; }
        public List<string> Email { get; set; }
    }

}
