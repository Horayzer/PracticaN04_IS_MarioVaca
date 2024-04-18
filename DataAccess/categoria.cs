// NOMBRE APELLIDOS: MARIO ANDR�S VACA MORA
// PARALELO: 3228
// SI � INTEGRACI�N DE SISTEMAS 
// FECHA: 21/04/2024
// PR�CTICA No. # 04

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class categoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categoria()
        {
            this.cliente = new List<cliente>();
        }
    
        public int id { get; set; }
        public string tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<cliente> cliente { get; set; }
    }
}
