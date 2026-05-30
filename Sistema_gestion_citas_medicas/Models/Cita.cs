using Sistema_gestion_citas_medicas.Models;

namespace Sistema_gestion_citas_medicas.Models
{
    public enum EstadoCita
    {
        Pendiente,
        Cancelada,
        Completada,
        Reprogramada
    }

    public class Cita
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        public DateTime FechaHora { get; set; }
        public EstadoCita Estado { get; set; } = EstadoCita.Pendiente;
        public string Motivo { get; set; }
    }
}