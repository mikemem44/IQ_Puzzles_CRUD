using BL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQ_Puzzles_CRUD
{
    public partial class Usuarios : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public bool verificar { get; set; }

        public Usuarios()
        {
            InitializeComponent();
        }

        private void cargarCombobox()
        {
            List<Permiso> listaPermisos = BL_Permiso.Lista();

            comboboxPermisos.DisplayMember = "nombrePermiso";
            comboboxPermisos.ValueMember = "ID";
            comboboxPermisos.DataSource = listaPermisos;
        }

        private void cargarGrid()
        {
            try
            {
                gridUsuarios.DataSource = null;
                gridUsuarios.DataSource = BL_Usuario.Lista();
                gridUsuarios.Columns["PermisoID"].Visible = false;
                gridUsuarios.Columns["Contrasena"].Visible = false;
                gridUsuarios.Columns["Activo"].Visible = false;
                gridUsuarios.Columns["Permiso"].Visible = false;
                gridUsuarios.Columns["Facturas"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validarUpdate()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingresar Nombre");
                return;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Ingresar Correo");
                return;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingresar Username");
                return;
            }
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Ingresar Contraseña");
                return;
            }
            if (string.IsNullOrEmpty(txtContrasena2.Text))
            {
                MessageBox.Show("Confirmar Contraseña");
                return;
            }
            if (!(txtContrasena.Text == txtContrasena2.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            if (!ValidatePassword(txtContrasena.Text))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos mínimos.");
                return;
            }
            if (comboboxPermisos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar Permiso");
                return;
            }

            Usuario user = new Usuario();
            user.ID = Convert.ToInt16(gridUsuarios.CurrentRow.Cells["ID"].Value.ToString());
            user.Nombre = txtNombre.Text;
            user.Username = txtUsuario.Text;
            user.PermisoID = Convert.ToInt16(comboboxPermisos.SelectedValue);
            user.Correo = txtCorreo.Text;
            user.Contrasena = BL_Usuario.Sha256(txtContrasena.Text);
            user.usuarioActualiza = ID_Usuario;
            BL_Usuario.Update(user);
            MessageBox.Show("Se actualizo el usuario correctamente");
            cargarGrid();
            Clear();
        }

        private bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            string specialCharacters = @"!@#$%^&*()-_=+[]{}|;:'<>,.?/";
            if (!password.Any(c => specialCharacters.Contains(c)))
            {
                return false;
            }
            return true;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            cargarGrid();
            cargarCombobox();
            if (ID_Permiso == 1)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnRegistrar.Enabled = false;
                btnBloquear.Enabled = false;
                btnDesbloquear.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.ID_Usuario = this.ID_Usuario;
            registrar.ID_Rol = this.ID_Rol;
            registrar.ID_Permiso = this.ID_Permiso;
            registrar.verificar = true;
            registrar.Show();
            this.Hide();
        }

        private void Clear()
        {
            txtNombre.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            txtContrasena2.Text = string.Empty;

            comboboxPermisos.SelectedIndex = -1;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            validarUpdate();
        }

        private void gridUsuarios_DoubleClick(object sender, EventArgs e)
        {
            this.txtNombre.Text = gridUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            this.txtUsuario.Text = gridUsuarios.CurrentRow.Cells["Username"].Value.ToString();
            Permiso permiso = new Permiso();
            permiso.ID = Convert.ToInt16(gridUsuarios.CurrentRow.Cells["PermisoID"].Value.ToString());
            if (BL_Permiso.getPermiso(permiso.ID) != null)
            {
                this.comboboxPermisos.Text = BL_Permiso.getPermiso(permiso.ID);
            }
            else
            {
                this.comboboxPermisos.Text = "Lectura";
            }
            this.txtCorreo.Text = gridUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            txtContrasena.Text = string.Empty;
            txtContrasena2.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.ID = Convert.ToInt16(gridUsuarios.CurrentRow.Cells["ID"].Value.ToString());
            user.usuarioActualiza = ID_Usuario;
            if (!(BL_Usuario.Archivar(user)))
            {
                MessageBox.Show("No se pudo eliminar el usuario");
                cargarGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Se elimino el usuario correctamente");
                cargarGrid();
                Clear();
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
        }

        private void txtContrasena2_Enter(object sender, EventArgs e)
        {
            txtContrasena2.UseSystemPasswordChar = true;
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.ID = Convert.ToInt16(gridUsuarios.CurrentRow.Cells["ID"].Value.ToString());
            user.usuarioActualiza = ID_Usuario;
            if (!(BL_Usuario.bloquearUsuarioMenu(user)))
            {
                MessageBox.Show("No se pudo bloquear el usuario");
                cargarGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Se bloqueo el usuario correctamente");
                cargarGrid();
                Clear();
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.ID = Convert.ToInt16(gridUsuarios.CurrentRow.Cells["ID"].Value.ToString());
            user.usuarioActualiza = ID_Usuario;
            if (!(BL_Usuario.desbloquearUsuario(user)))
            {
                MessageBox.Show("No se pudo desbloquear el usuario");
                cargarGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Se desbloqueo el usuario correctamente");
                cargarGrid();
                Clear();
            }
        }
    }

}
