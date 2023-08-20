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
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var categoryList = conn.Query<Category>(SqlText.getAllCategories).ToList();
                    return categoryList;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Category>();
            }
        }
        public Category Find(int categoryID) 
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var category = conn.QuerySingleOrDefault<Category>(SqlText.findSingleCategory, new {categoryID});
                    return category;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return null;
            } 
        }
        public bool Add(Category category)
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.addCategory,category);
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        public bool Update(Category category) 
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.updateCategory,category);
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError (ex.ToString());
                return false;
            }
        }
        public bool Remove(Category category) 
        {
            try
            {
                using (var conn = new SqlConnection(SqlText.ConnectionString))
                {
                    var result = conn.Execute(SqlText.removeCategory,category);
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
