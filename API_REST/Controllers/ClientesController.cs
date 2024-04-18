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
    public class ClientesController : ApiController
    {
        LogicCliente logicCliente;

        public ClientesController()
        {
            logicCliente = new LogicCliente();
        }

        // GET: api/Clientes
        public IHttpActionResult Get()
        {
            List<cliente> clientes = logicCliente.ListarClientes();
            return Ok(clientes);
        }

        // GET: api/Clientes/5
        public IHttpActionResult Get(int id)
        {
            cliente cliente = logicCliente.ObtenerClientePorID(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        // POST: api/Clientes
        public IHttpActionResult Post([FromBody] cliente nuevoCliente)
        {
            if (logicCliente.AñadirCliente(nuevoCliente))
            {
                return CreatedAtRoute("DefaultApi", new { id = nuevoCliente.id }, nuevoCliente);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT: api/Clientes/5
        public IHttpActionResult Put(int id, [FromBody] cliente clienteActualizado)
        {
            clienteActualizado.id = id; // Asegúrate de que el cliente actualizado tenga el mismo ID que el cliente que se está actualizando
            if (logicCliente.ActualizarCliente(clienteActualizado))
            {
                return Ok();
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Clientes/5
        public IHttpActionResult Delete(int id)
        {
            cliente clienteAEliminar = logicCliente.ObtenerClientePorID(id);
            if (clienteAEliminar != null)
            {
                if (logicCliente.EliminarCliente(clienteAEliminar))
                {
                    return Ok();
                }
                else
                {
                    return InternalServerError();
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
