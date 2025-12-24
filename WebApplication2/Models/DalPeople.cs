using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace WebApplication2.Models
{
    public class DalPeople
    {
        private readonly SqlConnection _sqlConnection;
        public DalPeople(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public int Count()
        {
            string query = @"SELECT count(*) FROM People";
            return _sqlConnection.QueryFirst<int>(query);
        }

        public List<People> Pages(int offSet, int pageSize)
        {
            string query = @"SELECT Id, Name FROM People ORDER BY Id OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
            IEnumerable<People> result = _sqlConnection.Query<People>(query, new { Offset = offSet, PageSize = pageSize });
            return result.AsList();
        }

        public Result<People> GetPages(int offSet, int pageSize)
        {            
            return new Result<People>(Count(), Pages(offSet, pageSize));
        }

        public bool Add(string name)
        {
            string query = @"INSERT INTO People (Name) VALUES (@Name)";
            return _sqlConnection.Execute(query, new { Name = name }) > 0;
        }
    }
}