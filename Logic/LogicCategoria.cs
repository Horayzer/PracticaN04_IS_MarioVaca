// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 21/04/2024
// PRÁCTICA No. # 04

using Data;
using DataAccess;
using System.Collections.Generic;
using System.Linq;


namespace Logic
{
    public class LogicCategoria
    {
        DataCategoria data;
        public LogicCategoria()
        {
            data = new DataCategoria();
        }

        public List<categoria> ListarCategorias()
        {
            List<categoria> list = data.Listar();
            return list;
        }

        public bool AñadirCategoria(categoria categoria)
        {
            return data.Insertar(categoria);
        }

        public bool ActualizarCategoria(categoria categoria)
        {
            return data.Actualizar(categoria);
        }

        public bool EliminarCategoria(categoria categoria)
        {
            return data.Eliminar(categoria);
        }

        public categoria ObtenerCategoriaPorID(int id)
        {
            categoria cat = data.Listar().Where(c => c.id==id).SingleOrDefault();
            return cat;
        }
    }
}
