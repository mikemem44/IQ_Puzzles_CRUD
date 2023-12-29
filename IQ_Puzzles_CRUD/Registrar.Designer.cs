namespace IQ_Puzzles_CRUD
{
    partial class Registrar
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsuario = new TextBox();
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            txtContrasena2 = new TextBox();
            btnRegistrar = new Button();
            btnVolver = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(174, 59);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(167, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(100, 61);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(107, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(108, 147);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 3;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(77, 188);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 4;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(11, 230);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 17);
            label5.TabIndex = 5;
            label5.Text = "Confirmar contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(174, 103);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(167, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(174, 145);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(167, 23);
            txtCorreo.TabIndex = 7;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(174, 186);
            txtContrasena.Margin = new Padding(2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(167, 23);
            txtContrasena.TabIndex = 8;
            txtContrasena.Enter += txtContrasena_Enter;
            // 
            // txtContrasena2
            // 
            txtContrasena2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena2.Location = new Point(174, 230);
            txtContrasena2.Margin = new Padding(2);
            txtContrasena2.Name = "txtContrasena2";
            txtContrasena2.Size = new Size(167, 23);
            txtContrasena2.TabIndex = 9;
            txtContrasena2.Enter += txtContrasena2_Enter;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(40, 40, 40);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.LightGray;
            btnRegistrar.Location = new Point(61, 290);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(280, 30);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar usuario";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(40, 40, 40);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.LightGray;
            btnVolver.Location = new Point(61, 342);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(280, 30);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(93, 9);
            label6.Name = "label6";
            label6.Size = new Size(248, 30);
            label6.TabIndex = 12;
            label6.Text = "REGISTRAR USUARIO";
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(415, 395);
            Controls.Add(label6);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Controls.Add(txtContrasena2);
            Controls.Add(txtContrasena);
            Controls.Add(txtCorreo);
            Controls.Add(txtUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Registrar";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsuario;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private TextBox txtContrasena2;
        private Button btnRegistrar;
        private Button btnVolver;
        private Label label6;
    }
}