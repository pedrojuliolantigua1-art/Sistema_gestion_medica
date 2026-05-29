using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Models
{
    public class Medico : People
    {
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
    }
}
