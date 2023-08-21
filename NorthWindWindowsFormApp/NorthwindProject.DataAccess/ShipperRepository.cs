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
    public class ShipperRepository
    {
        public List<Shipper> GetAll()
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var categoryList = conn.Query<Shipper>(SqlText.getAllShippers).ToList();
                    return categoryList;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Shipper>();
            }
        }
        public Shipper Find(int shipperID)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var shipper = conn.QuerySingleOrDefault<Shipper>(SqlText.findSingleShipper, new { shipperID});
                    return shipper;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return null;
            }
        }
        public bool Add(Shipper shipper)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.addShipper, shipper);
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Update(Shipper shipper)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.updateShipper, shipper);
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Remove(Shipper shipper)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.removeShipper, shipper);
                    return result > 0 ? true : false;
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
