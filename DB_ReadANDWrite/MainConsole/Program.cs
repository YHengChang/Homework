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
                db.Create(uv);
            });


            //test
            //Console.Write(UV[0].SiteName);

            Console.Read();
        }
    }
}
