using log4net;
using MVCApplication.CommonClass;
using MVCApplication.Models.Account;
using MVCApplication.Repository;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Web.Mvc;

namespace MVCApplication.Controllers.Account
{

    public class AccountController : Controller
    {
        #region Variable Declarations
        ILog logger = LogManager.GetLogger(typeof(AccountController));

        private static readonly LoginRepository loginRepository = new LoginRepository();

        #endregion

        #region Private Methods

        /// <summary>
        /// After Registeration Send and email to User
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HandleError]
        private bool SendMail(string email, string name, string password)
        {
            try
            {
                string strRegisterTemplate = ConfigurationManager.AppSettings["Register_Template"];
                string strBody = SendEmail.ReadTemplateFile(strRegisterTemplate);
                strBody = strBody.Replace("#password#", password);
                strBody = strBody.Replace("#name#", name);
                return SendEmail.SendEmailMessage(email, strBody);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            return (false);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Redirect to Login View
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Redirect to Register View
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            Registration reg = new Registration();
            return View(reg);
        }

        /// <summary>
        /// Redirect to default Error Page
        /// </summary>
        /// <returns></returns>
        public ActionResult ErrorPage()
        {
            return View();
        }

        /// <summary>
        /// Redirect to Dashboard Page After Login
        /// </summary>
        /// <returns></returns>
        //[Authorize(Roles = "Admin")]
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Welcome to my Dashboard !";
            return View();
        }

        /// <summary>
        /// To Register a new User
        /// </summary>
        /// <param name="objUserData"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult AddUser(Registration objUserData)
        {

            if (ModelState.IsValid)
            {
                string regData = JsonConvert.SerializeObject(objUserData);
               // string result = loginRepository.RegisterUser(objUserData.first_name, objUserData.last_name, objUserData.email, objUserData.mobile_number, objUserData.password, objUserData.retype_password, objUserData.user_name);
                string result = loginRepository.RegisterUser(regData);
                if (result == "success")
                {
                    SendMail(objUserData.email, objUserData.first_name + " " + objUserData.last_name, objUserData.password);
                    Registration obj = new Registration();
                    return View("~/Views/Account/Register.cshtml", obj);
                }

            }
            return View("~/Views/Account/Register.cshtml", objUserData);
        }

        /// <summary>
        /// Validate Login Credentials
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public JsonResult ValidateLogin(string username, string password)
        {
            try
            {
                string result = loginRepository.ValidateLoginCredentials(username, password);
                if (result == "success")
                {

                    return Json("success");
                }

                return Json("fail");
            }
            catch (Exception ex)
            {

                logger.Error(ex.Message);
                return Json(ex.Message);
            }

        }

        #endregion

    }
}