using CrudDemo.Models;
using CrudDemo.VeiwModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudDemo.Services
{
    interface IEmployeeService
    {
    
        /// get list of all employees
       
        List<Employees> GetEmployeesList();

   
        /// get employee details by employee id
        /// <param name="empId"></param>
     
        Employees GetEmployeeDetailsById(int empId);

        ///  add edit employee
        /// <param name="employeeModel"></param>
    
        ResponseModel SaveEmployee(Employees employeeModel);


       
        /// delete employee
        /// <param name="employeeId"></param>
      
        ResponseModel DeleteEmployee(int employeeId);
    }
}
