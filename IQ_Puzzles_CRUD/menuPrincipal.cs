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
    public partial class menuPrincipal : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            imagenLogo_Click(null, e);
        }

        private void openChildForm(object childForm)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        private void imagenLogo_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.ID_Usuario = this.ID_Usuario;
            inicio.ID_Rol = this.ID_Rol;
            inicio.ID_Permiso = this.ID_Permiso;
            openChildForm(inicio);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol, 1) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Clientes clientes = new Clientes();
                clientes.ID_Usuario = this.ID_Usuario;
                clientes.ID_Rol = this.ID_Rol;
                clientes.ID_Permiso = this.ID_Permiso;
                openChildForm(clientes);
            }
            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol,7) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                panelSubmenu.Visible = true;
            }
            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol, 8) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Usuarios usuarios = new Usuarios();
                usuarios.ID_Usuario = this.ID_Usuario;
                usuarios.ID_Rol = this.ID_Rol;
                usuarios.ID_Permiso = this.ID_Permiso;
                openChildForm(usuarios);
                panelSubmenu.Visible = false;
            }
            
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol, 10) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                RolUsuarios rolusuarios = new RolUsuarios();
                rolusuarios.ID_Usuario = this.ID_Usuario;
                rolusuarios.ID_Rol = this.ID_Rol;
                rolusuarios.ID_Permiso = this.ID_Permiso;
                openChildForm(rolusuarios);
                panelSubmenu.Visible = false;
            }
            
        }

        private void btnAccesos_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol,11) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Accesos accesos = new Accesos();
                accesos.ID_Usuario = this.ID_Usuario;
                accesos.ID_Rol = this.ID_Rol;
                accesos.ID_Permiso = this.ID_Permiso;
                openChildForm(accesos);
                panelSubmenu.Visible = false;
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            login.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol,2) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Productos p = new Productos();
                p.ID_Usuario = this.ID_Usuario;
                p.ID_Rol = this.ID_Rol;
                p.ID_Permiso = this.ID_Permiso;
                openChildForm(p);
                panelSubmenu.Visible = false;
            }
            
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol, 5) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Ventas ventas = new Ventas();
                ventas.ID_Usuario = this.ID_Usuario;
                ventas.ID_Rol = this.ID_Rol;
                ventas.ID_Permiso = this.ID_Permiso;
                openChildForm(ventas);
            }
            

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol, 5) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Ventas ventas = new Ventas();
                ventas.ID_Usuario = this.ID_Usuario;
                ventas.ID_Rol = this.ID_Rol;
                ventas.ID_Permiso = this.ID_Permiso;
                openChildForm(ventas);
            }
        }
    }
}
