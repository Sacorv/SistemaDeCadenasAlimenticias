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
            ViewBag.Cadenas = _sucursalServicio.ListarCadenas();
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

        public IActionResult Filtrar(int Id)
        {
            if(Id!=0)
            {
                ViewBag.Cadenas = _sucursalServicio.ListarCadenas();
                ViewBag.SucursalesFiltradas = _sucursalServicio.FiltrarSucursales(Id);
            }
            else
            {
                ViewBag.SucursalesFiltradas = null;
            }
           

            return View("ListaSucursales");
        }
    }
}
