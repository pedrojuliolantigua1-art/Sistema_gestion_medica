using Microsoft.EntityFrameworkCore;
using Sistema_gestion_citas_medicas.Interfaces;
using System.Net;
using System.Net.Mail;

namespace Sistema_gestion_citas_medicas.Notificaciones
{
    public class EnviadorEmail : IEnviadorRecordatorio
    {
        private readonly AppDbContext _context;

        public EnviadorEmail(AppDbContext context)
        {
            _context = context;
        }

        public void Enviar(int citaId)
        {
            var cita = _context.Citas
                .Include(c => c.Paciente)
                .Include(c => c.Medico)
                .FirstOrDefault(c => c.Id == citaId);

            if (cita == null)
                throw new Exception("La cita no existe.");

            if (string.IsNullOrWhiteSpace(cita.Paciente.Email))
                throw new Exception("El paciente no tiene email registrado.");

            var correoOrigen = "pedrojuliolantigua1@gmail.com";
            var claveAplicacion = "gnjf vtuk vrxl byhv";

            using var cliente = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(correoOrigen, claveAplicacion)
            };

            using var mensaje = new MailMessage
            {
                From = new MailAddress(correoOrigen),
                Subject = "Recordatorio de cita medica",
                Body = $"Hola {cita.Paciente.Nombre}, recuerda tu cita con {cita.Medico.NombreCompleto} el {cita.FechaHora:g}.",
                IsBodyHtml = false
            };

            mensaje.To.Add(cita.Paciente.Email);
            cliente.Send(mensaje);
        }
    }
}