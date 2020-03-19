using Microsoft.AspNetCore.Antiforgery;
using NewDemo.Controllers;

namespace NewDemo.Web.Host.Controllers
{
    public class AntiForgeryController : NewDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
