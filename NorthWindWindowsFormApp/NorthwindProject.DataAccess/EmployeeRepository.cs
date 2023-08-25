using Dapper;
using NorthwindProject.DataAccess.RepositoryConstTexts;
using NorthwindProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess
{
    public class EmployeeRepository
    {
        public List<Employee> GetAll()
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var employeeList = conn.Query<Employee>(SqlText.getAllEmployees).ToList();
                    return employeeList;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Employee>();
            }
        }
        public Employee Find(int employeeID)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var employee = conn.QuerySingleOrDefault<Employee>(SqlText.findSingleEmployee, new { employeeID });
                    return employee;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return null;
            }
        }
        public bool Add(Employee employee)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    conn.Execute(SqlText.addEmployee, employee);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;

            }
        }
        public bool Update(Employee employee)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {

                    var affectedRows = conn.Execute(SqlText.updateEmployee, employee);
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Remove(Employee employee)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.removeEmployee, new { employee.EmployeeID });
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
    }
}
