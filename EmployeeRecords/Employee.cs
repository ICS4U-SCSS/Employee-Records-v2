using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeRecords
{
    class Employee
    {
        public string id, firstName, lastName, date, salary;

        public Employee(string _id, string _firstName, string _lastName, string _date, string _salary)
        {
            id = _id;
            firstName = _firstName;
            lastName = _lastName;
            date = _date;
            salary = _salary;
        }
    }
}
