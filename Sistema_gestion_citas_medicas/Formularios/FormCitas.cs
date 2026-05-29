using Sistema_gestion_citas_medicas.Repositorios;
using Sistema_gestion_citas_medicas.Services;
using SistemaCitas.Models;

namespace Sistema_gestion_citas_medicas.Formularios
{
    public partial class FormCitas : Form
    {
        private readonly CitaService _citaService;
        private readonly PacienteService _pacienteService;
        private readonly MedicoService _medicoService;

        public FormCitas()
        {
            InitializeComponent();
            var context = new AppDbContext();
            _citaService = new CitaService(new CitaRepository(context));
            _pacienteService = new PacienteService(new PacienteRepository(context));
            _medicoService = new MedicoService(new MedicoRepository(context));
        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarCitas();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                var cita = new Cita
                {
                    PacienteId = Convert.ToInt32(cmbPaciente.SelectedValue),
                    MedicoId = Convert.ToInt32(cmbMedico.SelectedValue),
                    FechaHora = dtpFechaHora.Value,
                    Motivo = txtMotivo.Text.Trim()
                };

                _citaService.Agendar(cita);
                LimpiarCampos();
                CargarCitas();
                MessageBox.Show("Cita agendada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var citaId = ObtenerCitaSeleccionada();
            if (citaId == 0)
                return;

            try
            {
                _citaService.Cancelar(citaId);
                CargarCitas();
                MessageBox.Show("Cita cancelada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReprogramar_Click(object sender, EventArgs e)
        {
            var citaId = ObtenerCitaSeleccionada();
            if (citaId == 0)
                return;

            try
            {
                _citaService.Reprogramar(citaId, dtpFechaHora.Value);
                CargarCitas();
                MessageBox.Show("Cita reprogramada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarCombos()
        {
            cmbPaciente.DataSource = _pacienteService.ObtenerTodos();
            cmbPaciente.DisplayMember = "NombreCompleto";
            cmbPaciente.ValueMember = "Id";

            cmbMedico.DataSource = _medicoService.ObtenerTodos();
            cmbMedico.DisplayMember = "NombreCompleto";
            cmbMedico.ValueMember = "Id";
        }

        private void CargarCitas()
        {
            dgvCitas.DataSource = _citaService.ObtenerTodas()
                .Select(c => new
                {
                    c.Id,
                    Paciente = c.Paciente != null ? c.Paciente.NombreCompleto : "",
                    Medico = c.Medico != null ? c.Medico.NombreCompleto : "",
                    c.FechaHora,
                    c.Estado,
                    c.Motivo
                })
                .ToList();
        }

        private int ObtenerCitaSeleccionada()
        {
            if (dgvCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita.");
                return 0;
            }

            return Convert.ToInt32(dgvCitas.CurrentRow.Cells["Id"].Value);
        }

        private void LimpiarCampos()
        {
            txtMotivo.Clear();
            dtpFechaHora.Value = DateTime.Now;
        }
    }
}
