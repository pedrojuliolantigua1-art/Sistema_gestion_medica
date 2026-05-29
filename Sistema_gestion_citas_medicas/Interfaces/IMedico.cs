using Sistema_gestion_citas_medicas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Interfaces
{
    public interface IMedicoRepository : ICrud<Medico>
    {
        List<Medico> ObtenerPorEspecialidad(int especialidadId);
    }

}
