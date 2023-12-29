namespace IQ_Puzzles_CRUD
{
    partial class Usuarios
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
            gridUsuarios = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label4 = new Label();
            comboboxPermisos = new ComboBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtContrasena = new TextBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBloquear = new Button();
            btnDesbloquear = new Button();
            btnRegistrar = new Button();
            label7 = new Label();
            txtContrasena2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gridUsuarios
            // 
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Location = new Point(12, 27);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.Size = new Size(389, 342);
            gridUsuarios.TabIndex = 0;
            gridUsuarios.DoubleClick += gridUsuarios_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Listado de usuarios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(421, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(421, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(421, 67);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(421, 85);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(243, 23);
            txtUsuario.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(421, 124);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 6;
            label4.Text = "Permisos:";
            // 
            // comboboxPermisos
            // 
            comboboxPermisos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboboxPermisos.FormattingEnabled = true;
            comboboxPermisos.Location = new Point(421, 142);
            comboboxPermisos.Name = "comboboxPermisos";
            comboboxPermisos.Size = new Size(243, 25);
            comboboxPermisos.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(421, 183);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 8;
            label5.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(421, 201);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(243, 23);
            txtCorreo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(421, 243);
            label6.Name = "label6";
            label6.Size = new Size(88, 17);
            label6.TabIndex = 10;
            label6.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(421, 261);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(243, 23);
            txtContrasena.TabIndex = 11;
            txtContrasena.Enter += txtContrasena_Enter;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(160, 160, 236);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.WhiteSmoke;
            btnEditar.Location = new Point(12, 386);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(160, 160, 236);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(102, 386);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBloquear
            // 
            btnBloquear.BackColor = Color.FromArgb(160, 160, 236);
            btnBloquear.FlatAppearance.BorderSize = 0;
            btnBloquear.FlatStyle = FlatStyle.Flat;
            btnBloquear.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBloquear.ForeColor = Color.WhiteSmoke;
            btnBloquear.Location = new Point(196, 386);
            btnBloquear.Name = "btnBloquear";
            btnBloquear.Size = new Size(75, 23);
            btnBloquear.TabIndex = 14;
            btnBloquear.Text = "Bloquear";
            btnBloquear.UseVisualStyleBackColor = false;
            btnBloquear.Click += btnBloquear_Click;
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.BackColor = Color.FromArgb(160, 160, 236);
            btnDesbloquear.FlatAppearance.BorderSize = 0;
            btnDesbloquear.FlatStyle = FlatStyle.Flat;
            btnDesbloquear.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDesbloquear.ForeColor = Color.WhiteSmoke;
            btnDesbloquear.Location = new Point(286, 386);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(115, 23);
            btnDesbloquear.TabIndex = 15;
            btnDesbloquear.Text = "Desbloquear";
            btnDesbloquear.UseVisualStyleBackColor = false;
            btnDesbloquear.Click += btnDesbloquear_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(160, 160, 236);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.WhiteSmoke;
            btnRegistrar.Location = new Point(421, 375);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(243, 34);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar nuevo usuario";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(421, 304);
            label7.Name = "label7";
            label7.Size = new Size(154, 17);
            label7.TabIndex = 18;
            label7.Text = "Confirmar contraseña:";
            // 
            // txtContrasena2
            // 
            txtContrasena2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena2.Location = new Point(421, 322);
            txtContrasena2.Name = "txtContrasena2";
            txtContrasena2.Size = new Size(243, 23);
            txtContrasena2.TabIndex = 19;
            txtContrasena2.Enter += txtContrasena2_Enter;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 130);
            ClientSize = new Size(676, 421);
            Controls.Add(txtContrasena2);
            Controls.Add(label7);
            Controls.Add(btnRegistrar);
            Controls.Add(btnDesbloquear);
            Controls.Add(btnBloquear);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(txtContrasena);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(comboboxPermisos);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridUsuarios;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtUsuario;
        private Label label4;
        private ComboBox comboboxPermisos;
        private Label label5;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtContrasena;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBloquear;
        private Button btnDesbloquear;
        private Button btnRegistrar;
        private Label label7;
        private TextBox txtContrasena2;
    }
}