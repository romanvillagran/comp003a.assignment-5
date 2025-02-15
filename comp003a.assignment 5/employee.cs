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
        }

        public string FirstName
            { get { return _firstName; } }

        public string MiddleName
            { get { return _middleName; } }

        public string LastName
            { get { return _lastName; } }

        public double Salary
            { get { return _salary; } }


    }
}
