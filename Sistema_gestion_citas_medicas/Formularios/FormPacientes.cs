using Sistema_gestion_citas_medicas.Models;
using Sistema_gestion_citas_medicas.Repositorios;
using Sistema_gestion_citas_medicas.Services;

namespace Sistema_gestion_citas_medicas.Formularios
{
    public partial class FormPacientes : Form
    {
        private readonly PacienteService _pacienteService;

        public FormPacientes()
        {
            InitializeComponent();
            var context = new AppDbContext();
            _pacienteService = new PacienteService(new PacienteRepository(context));
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var paciente = new Paciente
                {
                    cedula = txtCedula.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    FechaNacimiento = dtpFechaNacimiento.Value.Date
                };

                _pacienteService.Registrar(paciente);
                LimpiarCampos();
                CargarPacientes();
                MessageBox.Show("Paciente guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarPacientes()
        {
            dgvPacientes.DataSource = _pacienteService.ObtenerTodos()
                .Select(p => new
                {
                    p.Id,
                    Cedula = p.cedula,
                    p.Nombre,
                    p.Apellido,
                    p.Email,
                    p.Telefono,
                    p.FechaNacimiento
                })
                .ToList();
        }

        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
        }
    }
}
