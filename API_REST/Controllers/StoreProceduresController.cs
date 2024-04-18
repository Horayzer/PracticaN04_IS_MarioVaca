// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 21/04/2024
// PRÁCTICA No. # 04

using DataAccess;
using Logic;
using System.Collections.Generic;
using System.Web.Http;

namespace API_REST.Controllers
{
    public class StoreProceduresController : ApiController
    {
        LogicStoreProcedure logicStoreProcedure;
        public StoreProceduresController()
        {
            logicStoreProcedure = new LogicStoreProcedure();
        }

        // GET: api/StoreProcedures
        public IHttpActionResult Get()
        {
            List<ObtenerClientesConCategoria_Result> storeProcedure = logicStoreProcedure.obtenerClientesConCategoria_Results();
            return Ok(storeProcedure);
        }
    }
}
