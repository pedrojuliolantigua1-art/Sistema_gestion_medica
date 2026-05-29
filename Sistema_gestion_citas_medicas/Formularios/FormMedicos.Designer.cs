namespace Sistema_gestion_citas_medicas.Formularios
{
    partial class FormMedicos
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblCedula;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblEspecialidad;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private ComboBox cmbEspecialidad;
        private Button btnGuardar;
        private DataGridView dgvMedicos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCedula = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblEspecialidad = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            cmbEspecialidad = new ComboBox();
            btnGuardar = new Button();
            dgvMedicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            SuspendLayout();
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Text = "Medicos";
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(35, 85);
            lblCedula.Text = "Cedula";
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(280, 85);
            lblNombre.Text = "Nombre";
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(525, 85);
            lblApellido.Text = "Apellido";
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(35, 155);
            lblEmail.Text = "Email";
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(280, 155);
            lblTelefono.Text = "Telefono";
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(525, 155);
            lblEspecialidad.Text = "Especialidad";
            txtCedula.Location = new Point(35, 110);
            txtCedula.Size = new Size(210, 27);
            txtNombre.Location = new Point(280, 110);
            txtNombre.Size = new Size(210, 27);
            txtApellido.Location = new Point(525, 110);
            txtApellido.Size = new Size(210, 27);
            txtEmail.Location = new Point(35, 180);
            txtEmail.Size = new Size(210, 27);
            txtTelefono.Location = new Point(280, 180);
            txtTelefono.Size = new Size(210, 27);
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.Location = new Point(525, 180);
            cmbEspecialidad.Size = new Size(210, 28);
            btnGuardar.Location = new Point(35, 235);
            btnGuardar.Size = new Size(150, 38);
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Location = new Point(35, 300);
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowHeadersWidth = 51;
            dgvMedicos.Size = new Size(820, 260);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(900, 600);
            Controls.Add(dgvMedicos);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEspecialidad);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(lblTitulo);
            Name = "FormMedicos";
            Text = "Medicos";
            Load += FormMedicos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
