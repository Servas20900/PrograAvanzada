using System.Web.Mvc;
using WebClases.Models;

//get devuelve solo la vista, los post reciben datos del formulario y los procesan, por lo que dentro del controldor lleva una logica.
// los post van sobre botones que tiene funcionalidades, para enviar datos, guardar, etc.
namespace WebClases.Controllers
{
    public class HomeController : Controller
    {
        #region IniciarSession
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            return RedirectToAction("Principal","Home");
        }
        #endregion

        #region Registro

        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Usuario usuario)
        {
            return View();
        }

        #endregion

        #region RecuperarAcceso
        [HttpGet]
        public ActionResult RecuperarAcceso()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult RecuperarAcceso(Usuario usuario)
        {
            return View();
        }

        #endregion

        [HttpGet]
        public ActionResult Principal()
        {
            return View();
        }
    }
}