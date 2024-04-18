// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 21/04/2024
// PRÁCTICA No. # 04

using DataAccess;
using System.Collections.Generic;
using System.Linq;


namespace Data
{
    public class DataStoreProcedure
    {
        serviciosEntities contexto;

        public DataStoreProcedure()
        {
            contexto = new serviciosEntities();
        }

        public List<ObtenerClientesConCategoria_Result> ObtenerClientesConCategoria()
        {
            return contexto.ObtenerClientesConCategoria().ToList();
        }
    }
}
