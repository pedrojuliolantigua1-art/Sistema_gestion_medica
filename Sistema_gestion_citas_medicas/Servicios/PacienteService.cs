using Sistema_gestion_citas_medicas.Interfaces;
using Sistema_gestion_citas_medicas.Models;

namespace Sistema_gestion_citas_medicas.Services
{
    public class PacienteService
    {
        private readonly ICrud<Paciente> _repo;

        public PacienteService(ICrud<Paciente> repo)
            => _repo = repo;

        public List<Paciente> ObtenerTodos()
            => _repo.ObtenerTodos();

        public void Registrar(Paciente paciente)
        {
            paciente.ValidarDatosBasicos();
            _repo.Agregar(paciente);
        }

        public void Actualizar(Paciente paciente)
        {
            paciente.ValidarDatosBasicos();

            _repo.Actualizar(paciente);
        }

        public void Eliminar(int id)
            => _repo.Eliminar(id);
    }
}
