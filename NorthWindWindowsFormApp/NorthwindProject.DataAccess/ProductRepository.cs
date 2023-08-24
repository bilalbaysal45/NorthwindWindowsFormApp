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
    public class ProductRepository
    {
        public List<Product> GetAll()
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var productList = conn.Query<Product>(SqlText.getAllProducts).ToList();
                    return productList;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Product>();
            }
        }
        public Product Find(int productID)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var product = conn.QuerySingleOrDefault<Product>(SqlText.findSingleProduct, new { productID });
                    return product;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return null;
            }
        }
        public bool Add(Product product)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    conn.Execute(SqlText.addProduct, product);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;

            }
        }
        public bool Update(Product product)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var affectedRows = conn.Execute(SqlText.updateProduct, product);
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Remove(Product product)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    conn.Execute(SqlText.removeProduct, new {product.ProductId});
                    return true;
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
