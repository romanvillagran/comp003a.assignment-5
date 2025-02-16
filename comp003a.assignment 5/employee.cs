using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.assignment_5
{
    using System;

  
    public class Employee
    {
        // Private fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        /// <summary>
        /// Gets or sets the employee ID
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: Employee ID cannot be empty or null.");
                    return;
                }
                _employeeId = value;
            }
        }

        /// <summary>
        /// Gets or sets the first name. The value cannot be empty or null.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: First name cannot be empty or null.");
                    return;
                }
                _firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the middle name. 
        /// </summary>
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: Last name cannot be empty");
                    return;
                }
                _lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets the salary. The value cannot be less than 0.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Salary cannot be less than 0.");
                    return;
                }
                _salary = value;
            }
        }

        /// <summary>
        /// starts a new instance of the Employee class.
        /// </summary>
        /// <param name="employeeId">The employee ID. Cannot be empty or null.</param>
        /// <param name="firstName">The first name. Cannot be empty or null.</param>
        /// <param name="lastName">The last name. Cannot be empty or null</param>
        /// <param name="salary">The salary. Cannot be less than 0.</param>
        /// <param name="middleName">The middle name. Can be empty but not null.</param>
        public Employee(string employeeId, string firstName, string lastName, double salary, string middleName = "")
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            MiddleName = middleName;
        }

        /// <summary>
        /// Prints the full name of the employee, including first, middle, and last names.
        /// </summary>
        public void PrintFullName()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Middle Name: {MiddleName}");
            Console.WriteLine($"Last Name: {LastName}");
        }

        /// <summary>
        /// Displays the employee's information, including ID, full name, and salary.
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            PrintFullName();
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }
}
