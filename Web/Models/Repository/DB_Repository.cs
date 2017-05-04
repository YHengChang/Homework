using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    public class DB_Repository
    {
        private const string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HengChang\Desktop\Homework\DB_ReadANDWrite\MainConsole\AppData\UVdb.mdf;Integrated Security=True";

        public void Create(Model.Station station)
        {
            var connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = connectstring;
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("", connection);


            command.CommandText = string.Format(@"
            INSERT INTO Tablee(SiteName, UVI, PublishAgency, County, WGS84Lon, WGS84Lat, PublishTime) 
            VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')
            ", station.SiteName, station.UVI, station.PublishAgency, station.County, station.WGS84Lon, station.WGS84Lat, station.PublishTime);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete()
        {
            var connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = connectstring;
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("", connection);


            command.CommandText = string.Format(@"DELETE FROM table_name");

            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Model.Station> FindALL()
        {
            var result = new List<Model.Station>();
            var connection = new System.Data.SqlClient.SqlConnection(connectstring);
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("", connection);
            command.CommandText = @"Select * from Tablee";

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Model.Station item = new Model.Station();


                item.SiteName = reader["SiteName"].ToString();
                item.UVI = reader["UVI"].ToString();
                item.PublishAgency = reader["PublishAgency"].ToString();
                item.County = reader["County"].ToString();
                item.WGS84Lon = reader["WGS84Lon"].ToString();
                item.WGS84Lat = reader["WGS84Lat"].ToString();
                item.PublishTime = reader["PublishTime"].ToString();


                result.Add(item);
            }

            connection.Close();

            return result;
        }


    }
}
