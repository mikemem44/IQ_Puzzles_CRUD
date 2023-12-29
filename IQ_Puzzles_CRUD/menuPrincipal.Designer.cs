namespace IQ_Puzzles_CRUD
{
    partial class menuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnLogout = new Button();
            btnClientes = new Button();
            imagenLogo = new PictureBox();
            btnProductos = new Button();
            panelSubmenu = new Panel();
            btnUsuarios = new Button();
            btnAccesos = new Button();
            btnRoles = new Button();
            btnReporte = new Button();
            btnConfig = new Button();
            panelContainer = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenLogo).BeginInit();
            panelSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(imagenLogo);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(panelSubmenu);
            panelMenu.Controls.Add(btnReporte);
            panelMenu.Controls.Add(btnConfig);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 421);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(40, 40, 40);
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.LightGray;
            btnLogout.Location = new Point(0, 381);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 40);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(40, 40, 40);
            btnClientes.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10);
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.LightGray;
            btnClientes.Location = new Point(0, 73);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(200, 40);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // imagenLogo
            // 
            imagenLogo.BackColor = Color.WhiteSmoke;
            imagenLogo.Image = Properties.Resources.WhatsApp_Image_2022_12_01_at_8_47_03_PM;
            imagenLogo.Location = new Point(0, 0);
            imagenLogo.Name = "imagenLogo";
            imagenLogo.Size = new Size(200, 75);
            imagenLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imagenLogo.TabIndex = 0;
            imagenLogo.TabStop = false;
            imagenLogo.Click += imagenLogo_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(40, 40, 40);
            btnProductos.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10);
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.LightGray;
            btnProductos.Location = new Point(0, 110);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(200, 40);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // panelSubmenu
            // 
            panelSubmenu.Controls.Add(btnUsuarios);
            panelSubmenu.Controls.Add(btnAccesos);
            panelSubmenu.Controls.Add(btnRoles);
            panelSubmenu.Location = new Point(0, 225);
            panelSubmenu.Margin = new Padding(2);
            panelSubmenu.Name = "panelSubmenu";
            panelSubmenu.Size = new Size(200, 114);
            panelSubmenu.TabIndex = 0;
            panelSubmenu.Visible = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            btnUsuarios.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10);
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.LightGray;
            btnUsuarios.Location = new Point(31, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(169, 40);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnAccesos
            // 
            btnAccesos.BackColor = Color.FromArgb(40, 40, 40);
            btnAccesos.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10);
            btnAccesos.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAccesos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAccesos.FlatStyle = FlatStyle.Flat;
            btnAccesos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccesos.ForeColor = Color.LightGray;
            btnAccesos.Location = new Point(31, 73);
            btnAccesos.Name = "btnAccesos";
            btnAccesos.Size = new Size(169, 40);
            btnAccesos.TabIndex = 8;
            btnAccesos.Text = "Accesos";
            btnAccesos.UseVisualStyleBackColor = false;
            btnAccesos.Click += btnAccesos_Click;
            // 
            // btnRoles
            // 
            btnRoles.BackColor = Color.FromArgb(40, 40, 40);
            btnRoles.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10);
            btnRoles.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoles.ForeColor = Color.LightGray;
            btnRoles.Location = new Point(31, 37);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(169, 40);
            btnRoles.TabIndex = 7;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = false;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(40, 40, 40);
            btnReporte.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10);
            btnReporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporte.ForeColor = Color.LightGray;
            btnReporte.Location = new Point(0, 147);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(200, 40);
            btnReporte.TabIndex = 3;
            btnReporte.Text = "Ventas";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(40, 40, 40);
            btnConfig.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10);
            btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfig.ForeColor = Color.LightGray;
            btnConfig.Location = new Point(0, 184);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(200, 40);
            btnConfig.TabIndex = 5;
            btnConfig.Text = "Configuracion";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(71, 71, 71);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(200, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(676, 421);
            panelContainer.TabIndex = 1;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(876, 421);
            Controls.Add(panelContainer);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "menuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menuPrincipal";
            Load += menuPrincipal_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenLogo).EndInit();
            panelSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnProductos;
        private Button btnClientes;
        private PictureBox imagenLogo;
        private Panel panelContainer;
        private Button btnConfig;
        private Button btnReporte;
        private Button btnLogout;
        private Panel panelSubmenu;
        private Button btnAccesos;
        private Button btnRoles;
        private Button btnUsuarios;
    }
}