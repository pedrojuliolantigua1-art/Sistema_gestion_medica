namespace Sistema_gestion_citas_medicas.Formularios
{
    partial class FormCitas
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblPaciente;
        private Label lblMedico;
        private Label lblFechaHora;
        private Label lblMotivo;
        private ComboBox cmbPaciente;
        private ComboBox cmbMedico;
        private DateTimePicker dtpFechaHora;
        private TextBox txtMotivo;
        private Button btnAgendar;
        private Button btnCancelar;
        private Button btnReprogramar;
        private DataGridView dgvCitas;

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
            lblPaciente = new Label();
            lblMedico = new Label();
            lblFechaHora = new Label();
            lblMotivo = new Label();
            cmbPaciente = new ComboBox();
            cmbMedico = new ComboBox();
            dtpFechaHora = new DateTimePicker();
            txtMotivo = new TextBox();
            btnAgendar = new Button();
            btnCancelar = new Button();
            btnReprogramar = new Button();
            dgvCitas = new DataGridView();
            btnRecordatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(69, 32);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Citas";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(35, 85);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(64, 20);
            lblPaciente.TabIndex = 11;
            lblPaciente.Text = "Paciente";
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Location = new Point(300, 85);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(59, 20);
            lblMedico.TabIndex = 10;
            lblMedico.Text = "Medico";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(565, 85);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(92, 20);
            lblFechaHora.TabIndex = 9;
            lblFechaHora.Text = "Fecha y hora";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(35, 155);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(56, 20);
            lblMotivo.TabIndex = 8;
            lblMotivo.Text = "Motivo";
            // 
            // cmbPaciente
            // 
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaciente.Location = new Point(35, 110);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(230, 28);
            cmbPaciente.TabIndex = 7;
            // 
            // cmbMedico
            // 
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.Location = new Point(300, 110);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(230, 28);
            cmbMedico.TabIndex = 6;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.Location = new Point(565, 110);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(230, 27);
            dtpFechaHora.TabIndex = 5;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(35, 180);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(502, 27);
            txtMotivo.TabIndex = 4;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(35, 235);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(130, 38);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(185, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 38);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnReprogramar
            // 
            btnReprogramar.Location = new Point(335, 235);
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Size = new Size(130, 38);
            btnReprogramar.TabIndex = 1;
            btnReprogramar.Text = "Reprogramar";
            btnReprogramar.UseVisualStyleBackColor = true;
            btnReprogramar.Click += btnReprogramar_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(35, 300);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new Size(820, 260);
            dgvCitas.TabIndex = 0;
            // 
            // btnRecordatorio
            // 
            btnRecordatorio.Location = new Point(481, 235);
            btnRecordatorio.Name = "btnRecordatorio";
            btnRecordatorio.Size = new Size(145, 38);
            btnRecordatorio.TabIndex = 13;
            btnRecordatorio.Text = "Enviar recordatorio";
            btnRecordatorio.UseVisualStyleBackColor = true;
            btnRecordatorio.Click += btnRecordatorio_Click_1;
            // 
            // FormCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(900, 600);
            Controls.Add(btnRecordatorio);
            Controls.Add(dgvCitas);
            Controls.Add(btnReprogramar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(txtMotivo);
            Controls.Add(dtpFechaHora);
            Controls.Add(cmbMedico);
            Controls.Add(cmbPaciente);
            Controls.Add(lblMotivo);
            Controls.Add(lblFechaHora);
            Controls.Add(lblMedico);
            Controls.Add(lblPaciente);
            Controls.Add(lblTitulo);
            Name = "FormCitas";
            Text = "Citas";
            Load += FormCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnRecordatorio;
    }
}
