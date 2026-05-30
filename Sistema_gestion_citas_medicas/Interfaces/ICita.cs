using Sistema_gestion_citas_medicas.Models;

namespace Sistema_gestion_citas_medicas.Interfaces
{
    public interface ICitaRepository : ICrud<Cita>
    {
        List<Cita> ObtenerPorPaciente(int pacienteId);
        List<Cita> ObtenerPorMedico(int medicoId);
    }
}
