using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace EmployeePayrollADO.Repository
{ 
    internal class EmployeeRepository
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2LOKNJ2\SQLEXPRESS;Initial Catlog=master;Integrated Security=true;");

        public void CreateDatabase()
        {
            SqlCommand cmd = new SqlCommand("Create database EmpPayroll");
            connection.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Database created successfully");
        }

    }
}
