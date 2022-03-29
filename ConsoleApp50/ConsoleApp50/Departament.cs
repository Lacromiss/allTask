using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp50
{
    internal class Department
    {
        public int EmployeeLimit { get; set; }
        private Employee[] _employees;

        public Department(int employeeLimit)
        {
            _employees = new Employee[0];
            EmployeeLimit = employeeLimit;
        }

        public void AddEmployee(Employee employee)
        {
            if (_employees.Length < EmployeeLimit)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
                return;
            }

            throw new CapacityLimitException("limit doldu...");
        }
        public Employee GetEmployeeById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            foreach (var employee in _employees)
            {
                if (employee.Id == id)
                    return employee;
            }

            return null;
        }
        public Employee[] GetAllEmployees()
        {
            return _employees;
        }
    }
}