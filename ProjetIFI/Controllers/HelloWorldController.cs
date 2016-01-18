using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int x = 1, int ID = 5)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.x = x;
            
            return View();
        }
    }
}