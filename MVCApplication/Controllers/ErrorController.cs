using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class ErrorController : Controller
    {
        #region Public Methods
        public ActionResult PageNotFound()
        {
            return View();
        }

        public ActionResult Badrequest()
        {
            return View();
        }

        public ActionResult Unauthorized()
        {
            return View();
        }

        public ActionResult Internalerror()
        {
            return View();
        }
        #endregion



    }
}