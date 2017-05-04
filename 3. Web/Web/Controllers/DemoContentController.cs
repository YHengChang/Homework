using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DemoContentController : Controller
    {
        public ActionResult Index()
        {

            var stationRepository = new Models.Repository.DB_Repository();

            var stations = stationRepository.FindALL();
            var message = string.Format("共{0}筆資料<br/>", stations.Count);
            stations.ForEach(x =>
            {
                message += string.Format("地點名稱：{0}    , 紫外線強度:{1}    , 發布者:{2}<br/>更新時間:{3}<br/><br/>", x.SiteName , x.UVI , x.PublishAgency ,x.PublishTime);


            });
            return Content(message);
        }
    }
}