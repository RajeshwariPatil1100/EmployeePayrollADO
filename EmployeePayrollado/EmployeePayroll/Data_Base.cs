using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollado.EmployeePayroll
{
    public class Data_Base
    {
        public void CreateDatabass()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2LOKNJ2\SQLEXPRESS;Initial catalog=master;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create database Employee_Payroll", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Databass ctearted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
