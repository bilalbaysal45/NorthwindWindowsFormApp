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
    public class SupplierRepository
    {
        public List<Supplier> GetAll() 
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Query<Supplier>(SqlText.getAllSuppliers).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Supplier>();
            }
        }
        public Supplier Find(int id) { return null; }
        public bool Add(Supplier supplier)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.addSupplier, supplier);
                    
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Update(Supplier supplier) { return false; }
        public bool Remove(Supplier supplier) { return false; }
    }
}
