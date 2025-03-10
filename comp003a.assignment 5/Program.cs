﻿// Author: roman villagran
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#


using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace comp003a.assignment_5
{

   
    public class Program
    {
      
        public static void Main(string[] args)
        {
            try
            {
                //Create an employee
                Console.WriteLine("Enter Employee Details:");
                Console.Write("Enter Employee ID: ");
                string employeeId = Console.ReadLine();

                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Middle Name (Press Enter to skip): ");
                string middleName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                // Create Employee instance
                Employee emp = new Employee(employeeId, firstName, lastName, salary, middleName);
                Console.WriteLine("\nEmployee Created Successfully!\n");

                // Display employee info
                emp.DisplayEmployeeInfo();

                Console.WriteLine(); //blank line

                //Create department instances
                HRDepartment hr = new HRDepartment(); // Create HR department
                ITDepartment it = new ITDepartment(); // Create IT department

                // Display department info and perform operations
                Console.WriteLine("\nDepartment Details:");
                hr.DisplayDepartmentInfo(); // Display HR department info
                hr.Operate(); // Perform HR operations

                Console.WriteLine(); // blank line 

                it.DisplayDepartmentInfo(); // Display IT department info
                it.Operate(); // Perform IT operations
            }
            catch
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid value.");
            }
         
        }
    }
}
