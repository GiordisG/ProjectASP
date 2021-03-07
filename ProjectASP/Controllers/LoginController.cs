using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ProjectASP.Models;
using ProjectASP.DB;
using Dapper;

namespace ProjectASP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();

        }
        // GET: Logout
        public ActionResult Logout()
        {

            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Access", "Login");

        }

        // GET: Access
        public ActionResult Access()
        {
            if (Session["User"] != null)
            {
                return RedirectToAction("Index", "Peliculas");
            }
            return View();
        }

        // POST: Access
        [HttpPost]
        public ActionResult Access(LoginModel model)
        {
            using (var cn = Conexion.conexion())
            {
                string sql = "SELECT * FROM usuarios WHERE user ='" + model.User + "' AND password = '" + model.Password + "'";
                var result = cn.Query<LoginModel>(sql).ToList();
                if (result.Count == 1)
                {
                    Session["User"] = model.User;
                    FormsAuthentication.SetAuthCookie(Session["User"].ToString(), true);
                    return RedirectToAction("Index", "Peliculas");
                }
                else
                {
                    return Content("<script language='javascript' type='text/javascript'>" +
                        "alert('Usuario o contraseña invalido.');" +
                        " window.location.href = '../Login/Access';" +
                        "</script>");
                }
            }
        }
    }
}