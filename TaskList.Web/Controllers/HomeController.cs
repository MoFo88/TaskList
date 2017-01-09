using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TaskList.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TaskListControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}