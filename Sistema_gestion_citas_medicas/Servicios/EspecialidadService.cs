using Sistema_gestion_citas_medicas.Interfaces;
using Sistema_gestion_citas_medicas.Models;

namespace Sistema_gestion_citas_medicas.Services
{
    public class EspecialidadService
    {
        private readonly IEspecialidad _repo;

        public EspecialidadService(IEspecialidad repo)
            => _repo = repo;

        public List<Especialidad> ObtenerTodas()
            => _repo.ObtenerTodos();

        public void Registrar(Especialidad especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad.Nombre))
                throw new Exception("El nombre de la especialidad es obligatorio.");

            _repo.Agregar(especialidad);
        }

        public void Actualizar(Especialidad especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad.Nombre))
                throw new Exception("El nombre de la especialidad es obligatorio.");

            _repo.Actualizar(especialidad);
        }

        public void Eliminar(int id)
            => _repo.Eliminar(id);
    }
}