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
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;


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

        public string MiddleName
         { 
            get { return _middleName; }
            set {
                _middleName = value ?? string.Empty; // Allow empty but not null
            }
        }

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

        //this the constructor
        public employee(string employeeId, string firstName, string lastName, double salary, string middleName = "")
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            MiddleName = middleName;
        }

        //prints the names 
        public void printFullName()
        {
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Middle Name: {MiddleName}");
            Console.WriteLine($"Last Name: {LastName}");
        }

        //this displays employee stuff like id and salary
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            printFullName();
            Console.WriteLine($"Salary: {Salary}");
        }


    }
}
