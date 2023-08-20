using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess.RepositoryConstTexts
{
    internal class SqlText
    {
        internal const string ConnectionString = "server=192.168.56.101;Database=Northwind;User Id=sa;Password=sjmnwt480;";
        internal const string getAllCategories = "select * from Categories";
        internal const string findSingleCategory = "select * from Categories where CategoryID = @CategoryID";
        internal const string addCategory = @"
insert into Categories
(CategoryName,Description)
values
(@CategoryName,@Description)";
        internal const string updateCategory = @"
update Categories
set CategoryName = @CategoryName,
    Description = @Description
where CategoryID = @CategoryID
";
        internal const string removeCategory = "delete Categories where CategoryID = @CategoryID";
    }
}
