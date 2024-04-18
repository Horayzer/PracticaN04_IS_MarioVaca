// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 21/04/2024
// PRÁCTICA No. # 04

using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class DataCliente : IData<cliente>
    {
        serviciosEntities contexto;

        public DataCliente()
        {
            contexto = new serviciosEntities();
        }

        public bool Actualizar(cliente item)
        {
            try
            {
                var clienteExistente = contexto.cliente.Find(item.id);
                if (clienteExistente != null)
                {
                    contexto.Entry(clienteExistente).CurrentValues.SetValues(item);
                    contexto.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(cliente item)
        {
            try
            {
                var clienteExistente = contexto.cliente.Find(item.id);
                if (clienteExistente != null)
                {
                    contexto.cliente.Remove(clienteExistente);
                    contexto.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Insertar(cliente item)
        {
            try
            {
                contexto.cliente.Add(item);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<cliente> Listar()
        {
            return contexto.cliente.ToList();
        }
    }
}
