namespace IQ_Puzzles_CRUD
{
    partial class RolUsuarios
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
            label1 = new Label();
            gridRolUsuarios = new DataGridView();
            label3 = new Label();
            comboboxRoles = new ComboBox();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridRolUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(269, 20);
            label1.TabIndex = 0;
            label1.Text = "Lista de roles asignados por usuario:";
            // 
            // gridRolUsuarios
            // 
            gridRolUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRolUsuarios.Location = new Point(12, 27);
            gridRolUsuarios.Name = "gridRolUsuarios";
            gridRolUsuarios.RowTemplate.Height = 25;
            gridRolUsuarios.Size = new Size(636, 303);
            gridRolUsuarios.TabIndex = 1;
            gridRolUsuarios.CellContentClick += gridRolUsuarios_CellContentClick;
            gridRolUsuarios.DoubleClick += gridRolUsuarios_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(12, 350);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 4;
            label3.Text = "Roles:";
            // 
            // comboboxRoles
            // 
            comboboxRoles.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboboxRoles.FormattingEnabled = true;
            comboboxRoles.Location = new Point(63, 347);
            comboboxRoles.Name = "comboboxRoles";
            comboboxRoles.Size = new Size(248, 25);
            comboboxRoles.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(160, 160, 236);
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.ForeColor = Color.WhiteSmoke;
            btnInsertar.Location = new Point(400, 347);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(248, 25);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Asignar rol";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // RolUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 130);
            ClientSize = new Size(660, 382);
            Controls.Add(btnInsertar);
            Controls.Add(comboboxRoles);
            Controls.Add(label3);
            Controls.Add(gridRolUsuarios);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RolUsuarios";
            Text = "RolUsuarios";
            Load += RolUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)gridRolUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView gridRolUsuarios;
        private Label label3;
        private ComboBox comboboxRoles;
        private Button btnInsertar;
    }
}