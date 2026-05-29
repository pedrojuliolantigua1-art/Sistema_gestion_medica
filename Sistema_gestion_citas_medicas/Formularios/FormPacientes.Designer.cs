namespace Sistema_gestion_citas_medicas.Formularios
{
    partial class FormPacientes
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblCedula;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblFechaNacimiento;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnGuardar;
        private DataGridView dgvPacientes;

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
            lblFechaNacimiento = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnGuardar = new Button();
            dgvPacientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Text = "Pacientes";
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
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(525, 155);
            lblFechaNacimiento.Text = "Fecha nacimiento";
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
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(525, 180);
            dtpFechaNacimiento.Size = new Size(210, 27);
            btnGuardar.Location = new Point(35, 235);
            btnGuardar.Size = new Size(150, 38);
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(35, 300);
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(820, 260);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(900, 600);
            Controls.Add(dgvPacientes);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(lblTitulo);
            Name = "FormPacientes";
            Text = "Pacientes";
            Load += FormPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
