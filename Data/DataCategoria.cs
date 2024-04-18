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
    public class DataCategoria : IData<categoria>
    {
        serviciosEntities contexto;
        public DataCategoria() 
        {
            contexto = new serviciosEntities();
        }

        public bool Actualizar(categoria item)
        {
            try
            {
                var categoriaExistente = contexto.categoria.Find(item.id);
                if (categoriaExistente != null)
                {
                    contexto.Entry(categoriaExistente).CurrentValues.SetValues(item);
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

        public bool Eliminar(categoria item)
        {
            try
            {
                var categoriaExistente = contexto.categoria.Find(item.id);
                if (categoriaExistente != null)
                {
                    contexto.categoria.Remove(categoriaExistente);
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

        public bool Insertar(categoria item)
        {
            try
            {
                contexto.categoria.Add(item);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<categoria> Listar()
        {
            return contexto.categoria.ToList();
        }
    }
}
