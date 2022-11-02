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
            throw new NotImplementedException();
        }

        public List<Sucursal> Listar()
        {
            return _context.Sucursals.ToList();
        }
    }
}
