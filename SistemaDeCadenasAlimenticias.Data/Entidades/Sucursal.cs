using System;
using System.Collections.Generic;

namespace SistemaDeCadenasAlimenticias.Data.Entidades
{
    public partial class Sucursal
    {
        public int Id { get; set; }
        public string Direccion { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public int IdCadena { get; set; }

        public virtual Cadena IdNavigation { get; set; } = null!;
    }
}
