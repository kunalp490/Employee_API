using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee_API.Model;
namespace Employee_API.Repository.Interface
{
    public interface IEmployee
    {
        List<EmployeeList> getAll_Employees();
        EmployeeList getEmployee_byID(int id);
        string remove_Employee_byID();
    }
}
