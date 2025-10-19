using System.Web.Mvc;
using WebClases.EF;
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
            using (var context = new PorgraAvanzadaEntities())
            {
                //var nuevoUsuario = new T_Usuario
                //{
                //    ID = usuario.ID,
                //    Name = usuario.Name,
                //    Email = usuario.Email,
                //    Password = usuario.Password,
                //    Estado = true,
                //    IdPerfil = 2
                //};
                //context.T_Usuario.Add(nuevoUsuario);
                //context.SaveChanges();
                

                context.CrearUsuarios (usuario.ID, usuario.Name, usuario.Email, usuario.Password);
            }
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