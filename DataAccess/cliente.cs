// NOMBRE APELLIDOS: MARIO ANDR�S VACA MORA
// PARALELO: 3228
// SI � INTEGRACI�N DE SISTEMAS 
// FECHA: 21/04/2024
// PR�CTICA No. # 04

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class cliente
    {
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int idCategoria { get; set; }
    
        public virtual categoria categoria { get; set; }
    }
}
