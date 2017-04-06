using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using Models.Service;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoadService = new LoadService();
            var UV = LoadService.FindStation(@"http://opendata.epa.gov.tw/ws/Data/UV/?format=xml");



            //test
            //Console.Write(UV[0].SiteName);

            Console.Read();
        }
    }
}
