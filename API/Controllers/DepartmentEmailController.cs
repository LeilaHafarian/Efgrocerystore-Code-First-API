using API.DTO;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{
       [Route("departments")]
       [ApiController]
  public class DepartmentEmailController : ControllerBase
  {
    private readonly DepartmentService _departmentService;

    public DepartmentEmailController()
    {
        _departmentService = new DepartmentService();
    }


        [HttpGet]
    public List<DepartmentEmailAddressDTO> DepartmentPersonalEmail()   //new method
    {
        List<DepartmentEmailAddressDTO> newList = new List<DepartmentEmailAddressDTO>();    // skapa new list av DTO
        List<Email> Emaillist = new List<Email>();
        List<Service.DTO.DepartmentEmailDTO> service = _departmentService.DepartmentEmail();
        DepartmentEmailAddressDTO pass = new DepartmentEmailAddressDTO();

        foreach (Service.DTO.DepartmentEmailDTO s in service)
        {
            newList.Add(
                new DepartmentEmailAddressDTO()
                {
                    DepartmentName = s.DepartmentName,
                    Email = s.Email
                }
                    );
        }
            return newList;
    } 
  }
}