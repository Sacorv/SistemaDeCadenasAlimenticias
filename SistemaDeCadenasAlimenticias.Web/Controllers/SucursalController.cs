using Microsoft.AspNetCore.Mvc;
using SistemaDeCadenasAlimenticias.Data.Entidades;
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

        public IActionResult CrearSucursal()
        {
            ViewBag.Cadenas = _sucursalServicio.ListarCadenas();
            return View();
        }

        [HttpPost]
        public IActionResult CrearSucursal(Sucursal sucursal)
        {
            _sucursalServicio.Agregar(sucursal);
            return RedirectToAction("ListaSucursales");
        }
    }
}
