// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 21/04/2024
// PRÁCTICA No. # 04

using Data;
using DataAccess;
using System.Collections.Generic;


namespace Logic
{
    public class LogicStoreProcedure
    {
        DataStoreProcedure data;

        public LogicStoreProcedure()
        {
            data = new DataStoreProcedure();
        }

        public List<ObtenerClientesConCategoria_Result> obtenerClientesConCategoria_Results()
        {
            List<ObtenerClientesConCategoria_Result> list = data.ObtenerClientesConCategoria();
            return list;
        }
    }
}
