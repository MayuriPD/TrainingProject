using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
//using System.Activities.Statements;

namespace DataAccess
{
    class Repository : IRepository
    {

        private SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);

            IEnumerable<dynamic> IRepository.GetAllRecords(DynamicParameters parameters, string sql)
        {
            using (var sql = new SqlConnection())
            {
                    using (var scope = new (con))
                    {

                    }
            }
                throw new NotImplementedException();
        }

        int IRepository.InsertRecords(DynamicParameters parameters, string sql)
        {
            throw new NotImplementedException();
        }
    }
}
