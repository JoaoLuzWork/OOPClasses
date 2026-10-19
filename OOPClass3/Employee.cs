using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass3
{
    class Employee
    {

        private int employeeId;
        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Employee ID cannot be negative.");
                }
                employeeId = value;
            }
        }
        private string employeeName;
        public string EmployeeName
        {
            get { return employeeName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Employee name cannot be null or empty.");
                }
                employeeName = value;
            }
        }
        private position employeePosition;
        public position EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }

        private Contact employeeContact;
        public Contact EmployeeContact
        {
            get { return employeeContact; }
            set { employeeContact = value; }
        }
        public Employee(int id, string name, position position)
        {
            EmployeeId = id;
            EmployeeName = name;
            EmployeePosition = position;
        }

        public string DisplayEmployeeInfo()
        {
            return $"ID: {EmployeeId}, Name: {EmployeeName}, Position: {EmployeePosition}, Email: {EmployeeContact.Email}, Phone: {EmployeeContact.Phone},
             Address: {EmployeeContact.Address}";
        }
    }
}