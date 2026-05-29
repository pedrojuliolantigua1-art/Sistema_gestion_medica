using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Interfaces
{
    public interface ICrud<T>
    {
        List<T> ObtenerTodos();
        T ObtenerPorId(int id);
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(int id);
    }
}
