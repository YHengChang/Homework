using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using Models.Service;
using Models.Repository;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoadService = new LoadService();
            var db = new DB_Repository();
            var UV = LoadService.FindStation(@"http://opendata.epa.gov.tw/ws/Data/UV/?format=xml");


            UV.ToList().ForEach(uv =>
            {
                db.Delete();
            });

            UV.ToList().ForEach(uv =>
            {

                db.Create(uv);
            });
            

            var stations = db.FindALL();

            Show(stations);


            Console.Read();
        }
        public static void Show(List<Station> stations)
        {

            Console.WriteLine(string.Format("有{0}筆資料", stations.Count));
            stations.ForEach(x =>
            {
                Console.Write(string.Format("{0} {1} {2} {3} {4} {5} {6}", x.SiteName , x.UVI , x.PublishAgency , x.County , x.WGS84Lat , x.WGS84Lon , x.PublishTime));
                Console.WriteLine();
            });

        }
    }
}
