using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using NewDemo.Controllers;

namespace NewDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : NewDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
