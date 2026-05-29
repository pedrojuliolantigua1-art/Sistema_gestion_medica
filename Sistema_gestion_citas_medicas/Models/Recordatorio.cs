namespace SistemaCitas.Models
{
    public enum TipoRecordatorio
    {
        Email
    }

    public enum EstadoRecordatorio
    {
        Pendiente,
        Enviado,
        Fallido
    }

    public class Recordatorio
    {
        public int Id { get; set; }
        public int CitaId { get; set; }
        public TipoRecordatorio Tipo { get; set; }
        public EstadoRecordatorio Estado { get; set; }
        public DateTime? EnviadoEn { get; set; }
    }
}