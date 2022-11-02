using System;
using System.Collections.Generic;

namespace SistemaDeCadenasAlimenticias.Data.Entidades
{
    public partial class Cadena
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; } = null!;

        public virtual Sucursal? Sucursal { get; set; }
    }
}
