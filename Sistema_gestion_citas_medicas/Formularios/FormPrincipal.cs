namespace Sistema_gestion_citas_medicas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formularios.FormPacientes().ShowDialog();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formularios.FormMedicos().ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formularios.FormEspecialidades().ShowDialog();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formularios.FormCitas().ShowDialog();
        }
    }
}
