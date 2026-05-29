namespace Sistema_gestion_citas_medicas
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem medicosToolStripMenuItem;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private Label lblTitulo;

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
            menuStripPrincipal = new MenuStrip();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            medicosToolStripMenuItem = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            lblTitulo = new Label();
            menuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.ImageScalingSize = new Size(20, 20);
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { gestionToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(760, 28);
            menuStripPrincipal.TabIndex = 0;
            menuStripPrincipal.Text = "menuStripPrincipal";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, medicosToolStripMenuItem, especialidadesToolStripMenuItem, citasToolStripMenuItem });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(73, 24);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(224, 26);
            pacientesToolStripMenuItem.Text = "Pacientes";
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click;
            // 
            // medicosToolStripMenuItem
            // 
            medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            medicosToolStripMenuItem.Size = new Size(224, 26);
            medicosToolStripMenuItem.Text = "Medicos";
            medicosToolStripMenuItem.Click += medicosToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(224, 26);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            especialidadesToolStripMenuItem.Click += especialidadesToolStripMenuItem_Click;
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(224, 26);
            citasToolStripMenuItem.Text = "Citas";
            citasToolStripMenuItem.Click += citasToolStripMenuItem_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(35, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(379, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema de citas medicas";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(760, 430);
            Controls.Add(lblTitulo);
            Controls.Add(menuStripPrincipal);
            MainMenuStrip = menuStripPrincipal;
            Name = "FormPrincipal";
            Text = "Sistema de citas medicas";
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
