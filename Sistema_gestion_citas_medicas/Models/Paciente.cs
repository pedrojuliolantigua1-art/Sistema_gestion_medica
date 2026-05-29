using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Models
{
    public class Paciente : People
    {
        public DateTime FechaNacimiento { get; set; }
    }
}
