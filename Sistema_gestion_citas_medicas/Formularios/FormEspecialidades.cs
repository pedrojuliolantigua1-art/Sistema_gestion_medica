using Sistema_gestion_citas_medicas.Models;
using Sistema_gestion_citas_medicas.Repositorios;
using Sistema_gestion_citas_medicas.Services;

namespace Sistema_gestion_citas_medicas.Formularios
{
    public partial class FormEspecialidades : Form
    {
        private readonly EspecialidadService _especialidadService;

        public FormEspecialidades()
        {
            InitializeComponent();
            var context = new AppDbContext();
            _especialidadService = new EspecialidadService(new EspecialidadRepository(context));
        }

        private void FormEspecialidades_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var especialidad = new Especialidad
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                _especialidadService.Registrar(especialidad);
                LimpiarCampos();
                CargarEspecialidades();
                MessageBox.Show("Especialidad guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarEspecialidades()
        {
            dgvEspecialidades.DataSource = _especialidadService.ObtenerTodas()
                .Select(e => new
                {
                    e.Id,
                    e.Nombre,
                    e.Descripcion
                })
                .ToList();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
        }
    }
}
