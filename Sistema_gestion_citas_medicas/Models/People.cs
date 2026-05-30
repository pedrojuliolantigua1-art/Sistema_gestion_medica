using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";

        public void ValidarDatosBasicos()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(Apellido))
                throw new Exception("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(Email))
                throw new Exception("El email es obligatorio.");
        }
    }
}
