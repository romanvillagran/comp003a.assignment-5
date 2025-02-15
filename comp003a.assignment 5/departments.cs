using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.assignment_5
{
   public abstract class department
    {
        //property for department name
        public string DepartmentName { get; set; }

        //abstract method to get department details
        public abstract string GetDepartmentDetails();

        //this displays department details
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
            Console.WriteLine($"Details: {GetDepartmentDetails()}");
        }
    }
}
