using Microsoft.AspNetCore.Mvc;
using SistemaDeCadenasAlimenticias.Logica;

namespace SistemaDeCadenasAlimenticias.Web.Controllers
{
    public class SucursalController : Controller
    {
        private ISucursalServicio _sucursalServicio;
        public SucursalController(ISucursalServicio sucursalServicio)
        {
            _sucursalServicio = sucursalServicio;
        }

        public IActionResult ListaSucursales()
        {
            return View(_sucursalServicio.Listar());
        }
    }
}
