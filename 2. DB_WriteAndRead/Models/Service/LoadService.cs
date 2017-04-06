using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using System.Xml.Linq;

namespace Models.Service
{
    public class LoadService
    {
        public static List<Station> FindStation()
        {
            List<Station> stations = new List<Station>();

            var xml = XElement.Load(@"http://opendata.epa.gov.tw/ws/Data/UV/?format=xml");

            var UV = xml.Descendants("Data");

            UV.ToList().ForEach(uv =>
            {
                var SiteName = uv.Element("SiteName").Value.Trim();
                var UVI = uv.Element("UVI").Value.Trim();
                var PublishAgency = uv.Element("PublishAgency").Value.Trim();
                var County = uv.Element("County").Value.Trim();
                var WGS84Lon = uv.Element("WGS84Lon").Value.Trim();
                var WGS84Lat = uv.Element("WGS84Lat").Value.Trim();
                var PublishTime = uv.Element("PublishTime").Value.Trim();

                Station station = new Station();
                station.SiteName = SiteName;
                station.UVI = UVI;
                station.PublishAgency = PublishAgency;
                station.County = County;
                station.WGS84Lon = WGS84Lon;
                station.WGS84Lat = WGS84Lat;
                station.PublishTime = PublishTime;

                Console.Write(station.SiteName + "  ");
                Console.Write(station.UVI + "  ");
                Console.Write(station.PublishAgency + "  ");
                Console.Write(station.County + "  ");
                Console.Write(station.WGS84Lon + "  ");
                Console.Write(station.WGS84Lat + "  ");
                Console.WriteLine(station.PublishTime);


            });



            return stations;
        }


    }
}
