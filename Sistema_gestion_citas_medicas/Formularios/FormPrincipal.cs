using Sistema_gestion_citas_medicas.Services;
using Sistema_gestion_citas_medicas.Servicios;

namespace Sistema_gestion_citas_medicas
{
    public partial class FormPrincipal : Form
    {
        private readonly PacienteService _pacienteService;
        private readonly MedicoService _medicoService;
        private readonly EspecialidadService _especialidadService;
        private readonly CitaService _citaService;
        private readonly RecordatorioService _recordatorioService;

        public FormPrincipal(PacienteService pacienteService, MedicoService medicoService, EspecialidadService especialidadService, CitaService citaService, RecordatorioService recordatorioService)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
            _medicoService = medicoService;
            _especialidadService = especialidadService;
            _citaService = citaService;
            _recordatorioService = recordatorioService;
            AbrirFormulario(new Formularios.FormCitas(_citaService, _pacienteService, _medicoService, _recordatorioService));
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formularios.FormPacientes(_pacienteService));
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formularios.FormMedicos(_medicoService, _especialidadService));
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formularios.FormEspecialidades(_especialidadService));
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formularios.FormCitas(_citaService, _pacienteService, _medicoService, _recordatorioService));
        }

        private void AbrirFormulario(Form formulario)
        {
            foreach (Form formAbierto in MdiChildren)
            {
                formAbierto.Close();
            }

            formulario.MdiParent = this;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.Show();
        }
    }
}
