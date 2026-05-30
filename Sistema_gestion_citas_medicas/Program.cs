using Sistema_gestion_citas_medicas.Notificaciones;
using Sistema_gestion_citas_medicas.Repositorios;
using Sistema_gestion_citas_medicas.Services;
using Sistema_gestion_citas_medicas.Servicios;

namespace Sistema_gestion_citas_medicas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var context = new AppDbContext();

            context.Database.EnsureCreated();

            var pacienteService = new PacienteService(new PacienteRepository(context));
            var medicoService = new MedicoService(new MedicoRepository(context));
            var especialidadService = new EspecialidadService(new EspecialidadRepository(context));
            var citaService = new CitaService(new CitaRepository(context));
            var recordatorioService = new RecordatorioService(
                new RecordatorioRepository(context),
                    new EnviadorEmail(context));

            Application.Run(new FormPrincipal(pacienteService, medicoService, especialidadService, citaService, recordatorioService));
        }
    }
}
