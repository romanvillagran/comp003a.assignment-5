using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.assignment_5
{
    internal class employee
    {
        //private fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        /// <summary>
        /// gets the employee ID. 
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Cannot be empty or null");
                }
                _employeeId = value;
            }
            
        }
        /// <summary>
        /// gets the first name.  
        /// </summary>
        public string FirstName
        {
            get { return _firstName; } 
            set { 
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error: cannot be empty or null.");
                  
                }
                _firstName = value;
            }           
        }
        /// <summary>
        /// gets the middle name 
        /// </summary>
        public string MiddleName
         { 
            get { return _middleName; }
            set {
                _middleName = value ?? string.Empty; // Allow empty but not null
            }
        }
        /// <summary>
        /// gets the last name 
        /// </summary>
        public string LastName
        {
            get { return _lastName; } 
            set { 
                if (string.IsNullOrEmpty(_lastName))
                {
                    Console.WriteLine("Error: cannot be empty or null");
                }
                _lastName = value;
            }
        }
        /// <summary>
        /// gets the salary
        /// </summary>
        public double Salary
         {
            get { return _salary; } 
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Salary cannot be less than 0.");
                    return; // Exit the setter
                }
                _salary = value;
            }
        }

       
        /// <summary>
        /// this the constructor
        /// </summary>
        /// <param name="employeeId">emplyee is cannot be empty</param>
        /// <param name="firstName">first name cannot be empty</param>
        /// <param name="lastName">last name cannot be empty</param>
        /// <param name="salary">salary cannot be equal or less than 0</param>
        /// <param name="middleName">middle name cannot be empty</param>
        public employee(string employeeId, string firstName, string lastName, double salary, string middleName = "")
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            MiddleName = middleName;
        }

       
        /// <summary>
        /// prints the names 
        /// </summary>
        public void printFullName()
        {
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Middle Name: {MiddleName}");
            Console.WriteLine($"Last Name: {LastName}");
        }

      
        /// <summary>
        /// this displays employee stuff like id and salary
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            printFullName();
            Console.WriteLine($"Salary: {Salary}");
        }
    }
    /// <summary>
    /// this prints employee detail 
    /// </summary>
    public class program
    {
        public static void Main(string[] args)
        {
            employee emp1 = new employee("0efwe9fi932lkwne23", "Alice", "Johnson", 75000, "Marie");
            emp1.DisplayEmployeeInfo();//displays enployee info

            Console.WriteLine();//this is here to add a blank line 

            HRDepartment hr = new HRDepartment();// makes HR department
            ITDepartment it = new ITDepartment();// makes IT department

            //displays department info
            hr.DisplayDepartmentInfo();//displays hr department info
            hr.Operate();//perform hr operations

            Console.WriteLine();//blank line

            it.DisplayDepartmentInfo();//displays it department info
            it.Operate();//performs it operations
        }
    }
}
