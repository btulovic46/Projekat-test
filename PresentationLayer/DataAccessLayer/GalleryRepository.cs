using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
     public class GalleryRepository
    {
        public int InsertGallery(Gallery g)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Gallery VALUES ('{0}','{1}','{2}','{3})", g.Name,  g.Adress, g.City, g.Email);

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
