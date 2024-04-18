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
    public class CategoriasController : ApiController
    {
        LogicCategoria logicCategoria;

        public CategoriasController()
        {
            logicCategoria = new LogicCategoria();
        }

        // GET: api/Categorias
        public IHttpActionResult Get()
        {
            List<categoria> categorias = logicCategoria.ListarCategorias();
            return Ok(categorias);
        }

        // GET: api/Categorias/5
        public IHttpActionResult Get(int id)
        {
            categoria categoria = logicCategoria.ObtenerCategoriaPorID(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return Ok(categoria);
        }

        // POST: api/Categorias
        public IHttpActionResult Post([FromBody] categoria nuevaCategoria)
        {
            if (logicCategoria.AñadirCategoria(nuevaCategoria))
            {
                return CreatedAtRoute("DefaultApi", new { id = nuevaCategoria.id }, nuevaCategoria);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT: api/Categorias/5
        public IHttpActionResult Put(int id, [FromBody] categoria categoriaActualizada)
        {
            categoriaActualizada.id = id; // Asegúrate de que el cliente actualizado tenga el mismo ID que el cliente que se está actualizando
            if (logicCategoria.ActualizarCategoria(categoriaActualizada))
            {
                return Ok();
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Categorias/5
        public IHttpActionResult Delete(int id)
        {
            categoria categoriaEliminar = logicCategoria.ObtenerCategoriaPorID(id);
            if (categoriaEliminar != null)
            {
                if (logicCategoria.EliminarCategoria(categoriaEliminar))
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
