using DAL;
using DAL.Model;
using Service.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Service
{
    //2a:Skapa en endpoint som listar namnet på alla avdelningar i butiken tillsammans med en lista av e-postadresser
    //för den ansvariga personen på avdelningen.
    public class DepartmentService
    {

        private static DepartmentService _instance;
        public static DepartmentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartmentService();
                }
                return _instance;
            }
        }


        public List<DepartmentEmailDTO> DepartmentEmail()    //method
        {
            using (var context = new GroceryContext())      //kopla till database
            {
                var NewList = new List<DepartmentEmailDTO>();   //skaa ny list
                List<Department> departments = context.Departments.ToList();    // lämna Department på list
                List<Email> email = context.Emails.ToList();                   //lämna Email på listan

                foreach (Department depart in departments)              //loop över Department
                {
                    NewList.Add(
                        new DepartmentEmailDTO()
                        {
                            DepartmentName = depart.DepartmentName,
                            Email = email
                                .Where(a => a.EmployeeId == depart.EmployeeId)
                                .Select(e => e.EmailAddress.ToString())
                                .ToList()
                        }
                        );
                }
                return NewList;

            }




        }



    }
}
    