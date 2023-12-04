using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Collaborative_Knowledge.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
