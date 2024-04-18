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
    public class LogicCliente
    {
        DataCliente data;
        public LogicCliente() 
        {
            data = new DataCliente();
        }

        public List<cliente> ListarClientes()
        {
            List<cliente> list = data.Listar();
            return list;
        }

        public bool AñadirCliente(cliente cliente)
        {
            return data.Insertar(cliente);
        }

        public bool ActualizarCliente(cliente cliente)
        {
            return data.Actualizar(cliente);
        }

        public bool EliminarCliente(cliente cliente) 
        {
            return data.Eliminar(cliente);
        }

        public cliente ObtenerClientePorID(int id)
        {
            cliente cli = data.Listar().Where(c => c.id == id).FirstOrDefault();
            return cli;
        }
    }
}
