using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Dapper :BaseObject
    {
       // public IRepository _Repo;
        public IEnumerable<dynamic> RetrieveRecords(DynamicParameters parameters,string sql)
        {
            try
            {
                return _Repo.GetAllRecords(parameters, sql);
            }

            catch(Exception)
            {
                throw;
            }
        }

        public dynamic ExecuteRecords(DynamicParameters parameters, string sql)
        {

            try
            {
                return _Repo.InsertRecords(parameters, sql);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
