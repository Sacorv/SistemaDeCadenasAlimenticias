using SistemaDeCadenasAlimenticias.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadenasAlimenticias.Logica
{
    public interface ISucursalServicio
    {
        List<Sucursal> Listar();

        void Agregar(Sucursal sucursal);

        List<Cadena> ListarCadenas();
    }

    public class SucursalServicio : ISucursalServicio
    {
        private SistemaCadenasAlimenticiasParcial2PW3Context _context;
        public SucursalServicio(SistemaCadenasAlimenticiasParcial2PW3Context context)
        {
            _context = context;
        }

        public void Agregar(Sucursal sucursal)
        {
            var sucursalNueva = sucursal;

            _context.Sucursals.Add(sucursal);
            _context.SaveChanges();
        }

        public List<Sucursal> Listar()
        {
            return _context.Sucursals.ToList();
        }

        public List<Cadena> ListarCadenas()
        {
            return _context.Cadenas.OrderBy(c=>c.RazonSocial).ToList();
        }
    }
}
