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
    public class OrderRepository
    {
        public List<Order> GetAll()
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    return conn.Query<Order>(SqlText.getAllOrders).ToList();
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Order>();
            }
        }
        public Order Find(int orderID)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    return conn.QuerySingleOrDefault<Order>(SqlText.findSingleOrder, new { orderID });
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return null;
            }
        }
        public bool Add(Order order)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var orderID = conn.ExecuteScalar<int>(SqlText.addOrder, order);

                    foreach (var orderDetail in order.OrderDetails)
                    {
                        orderDetail.OrderID = orderID;
                        var result = conn.Execute(SqlText.addOrderDetail, orderDetail);
                        if (result > 0)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Update(Order order)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.updateOrder,order);
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Remove(Order order)
        {
            
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.removeOrder, new { order.OrderID });
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
