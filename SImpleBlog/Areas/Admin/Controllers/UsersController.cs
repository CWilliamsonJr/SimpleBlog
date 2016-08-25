using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return Content("USERS!");
        }
    }
}