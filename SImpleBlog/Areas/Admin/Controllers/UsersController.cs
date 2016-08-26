using System.Linq;
using System.Web.Mvc;
using NHibernate.Linq;
using SimpleBlog.Infrastructure;
using SimpleBlog.Models;
using SImpleBlog.Areas.Admin.ViewModels;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("users")]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return View(new UsersIndex
            {
                Users = Database.Session.Query<User>().ToList()
            });
        }
    }
}