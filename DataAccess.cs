using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SqlDataAccessDemo
{
    class DataAccess
    {
        public List<Person> GetPeople(int Id)
        {
            // Data Access from DataBase with Dapper
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("CustomersInfoDB")))
            {
                var output = connection.Query<Person>($"select * from customer where Id = '{ Id}' ").ToList();
                return output;
            }
        }
    }
}
