using Sistema_gestion_citas_medicas.Models;
using Sistema_gestion_citas_medicas.Interfaces;

namespace Sistema_gestion_citas_medicas.Services
{
    public class MedicoService
    {
        private readonly IMedicoRepository _repo;

        public MedicoService(IMedicoRepository repo)
            => _repo = repo;

        public List<Medico> ObtenerTodos()
            => _repo.ObtenerTodos();

        public List<Medico> ObtenerPorEspecialidad(int especialidadId)
            => _repo.ObtenerPorEspecialidad(especialidadId);

        public void Registrar(Medico medico)
        {
            if (string.IsNullOrWhiteSpace(medico.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(medico.Apellido))
                throw new Exception("El apellido es obligatorio.");

            if (medico.EspecialidadId == 0)
                throw new Exception("Debe seleccionar una especialidad.");

            _repo.Agregar(medico);
        }

        public void Actualizar(Medico medico)
        {
            if (string.IsNullOrWhiteSpace(medico.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (medico.EspecialidadId == 0)
                throw new Exception("Debe seleccionar una especialidad.");

            _repo.Actualizar(medico);
        }

        public void Eliminar(int id)
            => _repo.Eliminar(id);
    }
}
