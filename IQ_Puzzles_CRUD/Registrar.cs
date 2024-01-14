using EL;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQ_Puzzles_CRUD
{
    public partial class Registrar : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public bool verificar { get; set; }
        public Registrar()
        {
            InitializeComponent();
        }

        public void Iniciar()
        {
            if (ID_Usuario < 0)
            {
                ID_Usuario = 1;
            }
            return;
        }

        private bool validarRegistro()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                string text = "Ingresar Nombre";
                string caption = "Error";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                string text = "Ingresar Correo";
                string caption = "Error";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                string text = "Ingresar Username";
                string caption = "Error";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                string text = "Ingresar Contraseña";
                string caption = "Error";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtContrasena2.Text))
            {
                string text = "Confirmar Contraseña";
                string caption = "Error";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                return false;
            }
            if (!(txtContrasena.Text == txtContrasena2.Text))
            {
                string text = "Las contraseñas no coinciden.";
                string caption = "Error";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                return false;
            }
            if (!ValidatePassword(txtContrasena.Text))
            {
                string text = "La contraseña debe tener una longitud mínima de 8 caracteres, debe incluir al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.";
                string caption = "Error";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

        private void registrarUsuario()
        {
            try
            {
                Usuario user = new Usuario();
                RolUsuario rolUsuario = new RolUsuario();
                if (validarRegistro())
                {
                    if (ID_Rol < 1)
                    {
                        ID_Rol = 1;
                    }
                    //user.PermisoID = 1;
                    user.Nombre = txtNombre.Text;
                    user.Username = txtUsuario.Text;
                    user.Correo = txtCorreo.Text;
                    user.Contrasena = BL_Usuario.Sha256(txtContrasena.Text);
                    user.usuarioRegistro = ID_Usuario;
                    if (BL_Usuario.Insert(user).ID > 0)
                    {
                        rolUsuario.RolID = 1;
                        rolUsuario.UsuarioID = BL_Usuario.getUserIDSiLoginValido(txtUsuario.Text); ;
                        BL_RolUsuario.Insert(rolUsuario);
                        MessageBox.Show("Se ha registro el usuario con exito");
                        return;
                    }
                    MessageBox.Show("No se registro el usuario");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Login = txtUsuario.Text;

            if (validarRegistro())
            {
                if (BL_Usuario.verificarUsuarioExiste(Login))
                {
                    string text = "El nombre de usuario ya existe en la base de datos. Por favor, elija uno diferente.";
                    string caption = "Error";
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBox.Show(text, caption, btn, MessageBoxIcon.Warning);
                }
                else
                {
                    registrarUsuario();
                    if (verificar == false)
                    {
                        LOGIN login = new LOGIN();
                        login.Show();
                    }
                    else
                    {
                        menuPrincipal mainMenu = Application.OpenForms.OfType<menuPrincipal>().FirstOrDefault();
                        if (mainMenu == null)
                        {
                            mainMenu = new menuPrincipal();
                        }

                        mainMenu.ID_Usuario = this.ID_Usuario;
                        mainMenu.ID_Rol = this.ID_Rol;
                        verificar = false;
                        mainMenu.Show();
                    }
                    this.Hide();
                }
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (verificar == false)
            {
                LOGIN login = new LOGIN();
                login.Show();
            }
            else
            {
                menuPrincipal mainMenu = Application.OpenForms.OfType<menuPrincipal>().FirstOrDefault();
                if (mainMenu == null)
                {
                    mainMenu = new menuPrincipal();
                }

                mainMenu.ID_Usuario = this.ID_Usuario;
                mainMenu.ID_Rol = this.ID_Rol;
                verificar = false;
                mainMenu.Show();
            }
            this.Hide();
        }
    }
}
