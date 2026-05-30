using Sistema_gestion_citas_medicas.Models;
using Sistema_gestion_citas_medicas.Repositorios;
using Sistema_gestion_citas_medicas.Services;

namespace Sistema_gestion_citas_medicas.Formularios
{
    public partial class FormMedicos : Form
    {
        private readonly MedicoService _medicoService;
        private readonly EspecialidadService _especialidadService;

        public FormMedicos(MedicoService medicoService, EspecialidadService especialidadService)
        {
            InitializeComponent();
            _especialidadService = especialidadService;
            _medicoService = medicoService;
        }

        private void FormMedicos_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            CargarMedicos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var medico = new Medico
                {
                    Cedula = txtCedula.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    EspecialidadId = Convert.ToInt32(cmbEspecialidad.SelectedValue)
                };

                _medicoService.Registrar(medico);
                LimpiarCampos();
                CargarMedicos();
                MessageBox.Show("Medico guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarEspecialidades()
        {
            cmbEspecialidad.DataSource = _especialidadService.ObtenerTodas();
            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "Id";
        }

        private void CargarMedicos()
        {
            dgvMedicos.DataSource = _medicoService.ObtenerTodos()
                .Select(m => new
                {
                    m.Id,
                    Cedula = m.Cedula,
                    m.Nombre,
                    m.Apellido,
                    m.Email,
                    m.Telefono,
                    Especialidad = m.Especialidad != null ? m.Especialidad.Nombre : ""
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
        }
    }
}
