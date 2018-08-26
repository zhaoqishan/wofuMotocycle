using Microsoft.AspNetCore.Antiforgery;
using wofuMotocycle.Controllers;

namespace wofuMotocycle.Web.Host.Controllers
{
    public class AntiForgeryController : wofuMotocycleControllerBase
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
