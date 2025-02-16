using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.assignment_5
{
   public abstract class department
    {

        /// <summary>
        /// property for department name
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// abstract method to get department details
        /// </summary>
        /// <returns>a string describing the department</returns>
        public abstract string GetDepartmentDetails();

        /// <summary>
        /// this displays department details
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
            Console.WriteLine($"Details: {GetDepartmentDetails()}");
        }
    }
    /// <summary>
    /// this is for HR
    /// </summary>
    public class HRDepartment : department, IDepartmentOperations
    {
        /// <summary>
        /// starts a new instance for the HRDepartment class
        /// </summary>
        public HRDepartment()
        {
            DepartmentName = "Human Resources";//sets the department name
        }
        /// <summary>
        /// gets the details of the HR department 
        /// </summary>
        /// <returns>a string describing the HR deparment</returns>
        public override string GetDepartmentDetails()
        {
            return "Handles employee reelations recruitment";
        }
        /// <summary>
        /// perform hr specific operations
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing HR operations");
        }
    }
    /// <summary>
    /// represents the IT department
    /// </summary>
    public class ITDepartment : department, IDepartmentOperations
    {
        /// <summary>
        /// constructor to the department name
        /// </summary>
        public ITDepartment()
        {
            DepartmentName = "IT";//sets the department name
        }

        /// <summary>
        /// over turns the abstract method and returns it details
        /// </summary>
        /// <returns>a string describing the IT department</returns>
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure";
        }

        /// <summary>
        /// does operate method from idepartmentoperations
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing IT operations");
        }
    }

    /// <summary>
    /// Interface IDepartmentOperations
    /// </summary>
    public interface IDepartmentOperations
    {
        void Operate(); // Method signature for Operate
    }
}
