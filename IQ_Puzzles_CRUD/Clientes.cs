using BL;
using EL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQ_Puzzles_CRUD
{
    public partial class Clientes : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
        private void loadGridClientes()
        {
            try
            {
                gridClientes.DataSource = null;
                gridClientes.DataSource = BL_Cliente.Lista();
                gridClientes.Columns["Activo"].Visible = false;
                gridClientes.Columns["Facturas"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertarCliente()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingresar nombre");
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingresar apellido");
                return;
            }

            Cliente client = new Cliente();
            client.Nombre = txtNombre.Text;
            client.Apellido = txtApellido.Text;
            client.Correo = txtCorreo.Text;
            client.Telefono = txtTelefono.Text;
            client.usuarioRegistro = ID_Usuario;
            if (BL_Cliente.Insert(client).ID > 0)
            {
                MessageBox.Show("Se ha registro el cliente con exito");
                loadGridClientes();
                Clear();
                return;
            }
            MessageBox.Show("No se registro el cliente");
            return;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarCliente();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            loadGridClientes();
            if (ID_Permiso == 1)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void gridClientes_DoubleClick(object sender, EventArgs e)
        {
            this.txtNombre.Text = gridClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            this.txtApellido.Text = gridClientes.CurrentRow.Cells["Apellido"].Value.ToString();
            this.txtCorreo.Text = gridClientes.CurrentRow.Cells["Correo"].Value.ToString();
            this.txtTelefono.Text = gridClientes.CurrentRow.Cells["Telefono"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingresar nombre");
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingresar apellido");
                return;
            }

            Cliente client = new Cliente();
            client.ID = Convert.ToInt16(gridClientes.CurrentRow.Cells["ID"].Value.ToString());
            client.Nombre = txtNombre.Text;
            client.Apellido = txtApellido.Text;
            client.Correo = txtCorreo.Text;
            client.Telefono = txtTelefono.Text;
            client.usuarioActualiza = ID_Usuario;
            BL_Cliente.Update(client);
            MessageBox.Show("Se actualizo el cliente correctamente");
            loadGridClientes();
            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            client.ID = Convert.ToInt16(gridClientes.CurrentRow.Cells["ID"].Value.ToString());
            client.usuarioActualiza = ID_Usuario;
            if (!(BL_Cliente.Archivar(client)))
            {
                MessageBox.Show("No se pudo eliminar el cliente");
                loadGridClientes();
                Clear();
            }
            else
            {
                MessageBox.Show("Se elimino el cliente correctamente");
                loadGridClientes();
                Clear();
            }
        }
    }
}
