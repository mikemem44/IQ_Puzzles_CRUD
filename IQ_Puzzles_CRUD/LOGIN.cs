using BL;
using EL;

namespace IQ_Puzzles_CRUD
{
    public partial class LOGIN : Form
    {
        public static short ID_Usuario;
        public static short ID_Rol;
        public static short ID_Permiso;
        public LOGIN()
        {
            InitializeComponent();
        }

        private bool ValidarCampo()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingresar usuario");
                return false;
            }
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Ingresar contraseña");
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }


        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCampo())
                {
                    Usuario user = new Usuario();
                    RolUsuario rolUsuario = new RolUsuario();
                    user.Username = txtUsuario.Text;
                    byte[] Contrasena = BL_Usuario.Sha256(txtContrasena.Text);
                    ID_Usuario = BL_Usuario.getUserIDSiLoginValido(txtUsuario.Text);
                    if (ID_Usuario < 1)
                    {
                        MessageBox.Show("Usuario incorrecto");
                        LimpiarCampos();
                        return;
                    }
                    if (BL_Usuario.verificarLogin(txtUsuario.Text, Contrasena))
                    {
                        user.ID = ID_Usuario;
                        if ((BL_Usuario.verificarUsuarioBloqueado(user)) == true)
                        {
                            string text = "Su usuario ha sido bloqueado. Contactese con un administrador para desbloquearlo.";
                            string caption = "Error";
                            MessageBoxButtons btn = MessageBoxButtons.OK;
                            MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            ID_Rol = BL_RolUsuario.getRolID(user.ID);
                            if (ID_Rol <= 1)
                            {
                                string text = "Su usuario aún está en revisión. Contacte al administrador para recibir un rol.";
                                string caption = "Error";
                                MessageBoxButtons btn = MessageBoxButtons.OK;
                                MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                ID_Permiso = BL_Usuario.getPermisoID(user.ID);
                                menuPrincipal mainMenu = new menuPrincipal();
                                mainMenu.ID_Usuario = user.ID;
                                mainMenu.ID_Permiso = ID_Permiso;
                                mainMenu.ID_Rol = ID_Rol;
                                mainMenu.Show();
                                this.Hide();
                            }
                        }


                    }
                    else
                    {
                        user.ID = ID_Usuario;
                        BL_Usuario.agregarContadorBloqueo(user);
                        if ((BL_Usuario.verificarUsuarioBloqueado(user)) == true)
                        {
                            string text = "Su usuario ha sido bloqueado. Contactese con un administrador para desbloquearlo.";
                            string caption = "Error";
                            MessageBoxButtons btn = MessageBoxButtons.OK;
                            MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string text = "El usuario y contraseña introducidos son incorrectos. Intente de nuevo.";
                            string caption = "Error";
                            MessageBoxButtons btn = MessageBoxButtons.OK;
                            MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linklblRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
            this.Hide();
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }
    }
}