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

    }
}
