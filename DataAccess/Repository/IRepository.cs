using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepository
    {
        int InsertRecords(DynamicParameters parameters, string sql);

        IEnumerable<dynamic> GetAllRecords(DynamicParameters parameters, string sql);
    }
}

