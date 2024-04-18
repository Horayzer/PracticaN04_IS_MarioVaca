// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 21/04/2024
// PRÁCTICA No. # 04

using System.Collections.Generic;

namespace Data
{
    public interface IData<T>
    {
        List<T> Listar();
        bool Insertar(T item);
        bool Actualizar(T item);
        bool Eliminar(T item);
    }
}
