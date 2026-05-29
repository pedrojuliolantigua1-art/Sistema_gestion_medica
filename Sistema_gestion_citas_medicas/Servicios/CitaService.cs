using Sistema_gestion_citas_medicas.Interfaces;
using SistemaCitas.Models;

namespace Sistema_gestion_citas_medicas.Services
{
    public class CitaService
    {
        private readonly ICitaRepository _repo;

        public CitaService(ICitaRepository repo)
            => _repo = repo;

        public List<Cita> ObtenerTodas()
            => _repo.ObtenerTodos();

        public List<Cita> ObtenerPorPaciente(int pacienteId)
            => _repo.ObtenerPorPaciente(pacienteId);

        public List<Cita> ObtenerPorMedico(int medicoId)
            => _repo.ObtenerPorMedico(medicoId);

        public void Agendar(Cita cita)
        {
            if (cita.PacienteId == 0)
                throw new Exception("Debe seleccionar un paciente.");

            if (cita.MedicoId == 0)
                throw new Exception("Debe seleccionar un médico.");

            if (cita.FechaHora < DateTime.Now)
                throw new Exception("La fecha no puede ser en el pasado.");

            var citasDelMedico = _repo.ObtenerPorMedico(cita.MedicoId);
            bool ocupado = citasDelMedico.Any(c =>
                c.Estado != EstadoCita.Cancelada &&
                c.FechaHora == cita.FechaHora);

            if (ocupado)
                throw new Exception("El médico ya tiene una cita a esa hora.");

            cita.Estado = EstadoCita.Pendiente;
            _repo.Agregar(cita);
        }

        public void Cancelar(int citaId)
        {
            var cita = _repo.ObtenerPorId(citaId);

            if (cita == null)
                throw new Exception("La cita no existe.");

            if (cita.Estado == EstadoCita.Cancelada)
                throw new Exception("La cita ya está cancelada.");

            cita.Estado = EstadoCita.Cancelada;
            _repo.Actualizar(cita);
        }

        public void Reprogramar(int citaId, DateTime nuevaFecha)
        {
            var cita = _repo.ObtenerPorId(citaId);

            if (cita == null)
                throw new Exception("La cita no existe.");

            if (cita.Estado == EstadoCita.Cancelada)
                throw new Exception("No se puede reprogramar una cita cancelada.");

            if (nuevaFecha < DateTime.Now)
                throw new Exception("La nueva fecha no puede ser en el pasado.");

            cita.FechaHora = nuevaFecha;
            cita.Estado = EstadoCita.Reprogramada;
            _repo.Actualizar(cita);
        }
    }
}
