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
    public class CustomerRepository
    {
        public List<Customer> GetAll()
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var customerList = conn.Query<Customer>(SqlText.getAllCustomers).ToList();
                    return customerList;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Customer>();
            }
        }

        public Customer Find(string customerID)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var customer = conn.QuerySingleOrDefault<Customer>(SqlText.findSingleCustomer, new { customerID });
                    return customer;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return null;
            }
        }
        public bool Add(Customer customer)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    conn.Execute(SqlText.addCustomer, customer);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;

            }
        }
        public bool Update(Customer customer)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var affectedRows = conn.Execute(SqlText.updateCustomer, customer);
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Remove(Customer customer)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    conn.Execute(SqlText.removeCustomer, new { customer.CustomerID });
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public string CreateID(string customerName)
        {
            string customerID = string.Empty;
            string[] id = customerName.Trim().Split(' ');
            // customerName içinde 2 kelime varsa
            if (id.Length == 2)
            {
                for (int i = 0; i < id[0].Length; i++)
                {
                    customerID += id[0][i];
                    if (customerID.Length == 3)
                    {
                        break;
                    }
                }
                for (int i = 0; i < id[1].Length; i++)
                {
                    customerID += id[1][i];
                    if (customerID.Length == 5)
                    {
                        break;
                    }
                }
                return customerID.ToUpper();
            }
            // customerName içinde 3 kelime varsa
            else if (id.Length == 3)
            {
                for (int i = 0; i < id[0].Length; i++)
                {
                    customerID += id[0][i];
                    if (customerID.Length == 2)
                    {
                        break;
                    }
                }
                for (int i = 0; i < id[1].Length; i++)
                {
                    customerID += id[1][i];
                    if (customerID.Length == 4)
                    {
                        break;
                    }
                }
                for (int i = 0; i < id[2].Length; i++)
                {
                    customerID += id[2][i];
                    if (customerID.Length == 5)
                    {
                        break;
                    }
                }
                return customerID.ToUpper();
            }
            // customerName içinde tek kelime ve 5 harf veya 5 ten az sayıda harf varsa
            else if (customerName.Trim().Length <= 5)
            {
                return customerName.Trim().ToUpper();
            }
            // customerName içnde tek kelime ve 10 harf veya 10 dan az sayıda harf varsa
            else if (customerName.Trim().Length <= 10)
            {
                for (int i = 0; i < customerName.Length - 1; i++)
                {
                    customerID += customerName[i];
                }
                return customerID.ToUpper();
            }
            return string.Empty;
        }
    }
}
