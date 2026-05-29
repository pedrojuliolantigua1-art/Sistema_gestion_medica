using Sistema_gestion_citas_medicas.Interfaces;
using Sistema_gestion_citas_medicas.Models;

namespace Sistema_gestion_citas_medicas.Services
{
    public class PacienteService
    {
        private readonly IPaciente _repo;

        public PacienteService(IPaciente repo)
            => _repo = repo;

        public List<Paciente> ObtenerTodos()
            => _repo.ObtenerTodos();

        public void Registrar(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(paciente.Apellido))
                throw new Exception("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(paciente.Email))
                throw new Exception("El email es obligatorio.");

            _repo.Agregar(paciente);
        }

        public void Actualizar(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(paciente.Apellido))
                throw new Exception("El apellido es obligatorio.");

            _repo.Actualizar(paciente);
        }

        public void Eliminar(int id)
            => _repo.Eliminar(id);
    }
}