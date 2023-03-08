using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_API.Model
{
    public class EmployeeList
    {
        public int id {get; set;}
        public string name{get; set;}
        public string age{get; set;}
        public string gender{get; set;}
        public string designation{get; set;}
        public string DateOfJoin{ get; set;}
        public double CTC{get; set;}
    }
}
