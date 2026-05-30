using Sistema_gestion_citas_medicas.Models;

namespace Sistema_gestion_citas_medicas.Interfaces
{
    public interface IRecordatorio
    {
        void Agregar(Recordatorio recordatorio);
        List<Recordatorio> ObtenerPorCita(int citaId);
        void ActualizarEstado(int id, EstadoRecordatorio estado);
    }
}
