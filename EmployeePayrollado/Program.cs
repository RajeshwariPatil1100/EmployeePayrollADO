using EmployeePayrollADO.Repository;
using System;

namespace EmployeePayrollADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employee = new EmployeeRepository();
            employee.CreateDatabase();
        }
    }
}