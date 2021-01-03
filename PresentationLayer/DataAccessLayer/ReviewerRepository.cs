using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ReviewerRepository
    {
        public int InsertReviewer (Reviewer r)
        {
            using(SqlConnection sqlConnection= new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Reviewer VALUES ('{0}','{1}','{2}','{3}','{4}',{5})", r.Name, r.LastName, r.Email, r.Adress, r.City, r.PhoneNumber);

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
