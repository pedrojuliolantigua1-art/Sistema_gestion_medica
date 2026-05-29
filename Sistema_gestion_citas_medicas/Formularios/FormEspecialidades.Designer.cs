namespace Sistema_gestion_citas_medicas.Formularios
{
    partial class FormEspecialidades
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private DataGridView dgvEspecialidades;

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
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            dgvEspecialidades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Text = "Especialidades";
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 85);
            lblNombre.Text = "Nombre";
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(300, 85);
            lblDescripcion.Text = "Descripcion";
            txtNombre.Location = new Point(35, 110);
            txtNombre.Size = new Size(230, 27);
            txtDescripcion.Location = new Point(300, 110);
            txtDescripcion.Size = new Size(360, 27);
            btnGuardar.Location = new Point(35, 165);
            btnGuardar.Size = new Size(150, 38);
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(35, 235);
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.Size = new Size(720, 260);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 540);
            Controls.Add(dgvEspecialidades);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FormEspecialidades";
            Text = "Especialidades";
            Load += FormEspecialidades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
