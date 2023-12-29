using BL;
using EL;
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
    public partial class Ventas : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public short ID_Factura { get; set; }

        private short getDetalle;
        public Ventas()
        {
            InitializeComponent();
        }

        private void cargarCombobox()
        {
            List<Cliente> listaClientes = BL_Cliente.Lista();

            cmbboxCliente.DisplayMember = "Nombre";
            cmbboxCliente.ValueMember = "ID";
            cmbboxCliente.DataSource = listaClientes;
        }

        private void cargarGridFacturas()
        {
            try
            {
                gridFacturas.DataSource = null;
                gridFacturas.DataSource = BL_Factura.Lista();
                gridFacturas.Columns["Activo"].Visible = false;
                gridFacturas.Columns["Detalles"].Visible = false;
                gridFacturas.Columns["Cliente"].Visible = false;
                gridFacturas.Columns["Usuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarGridDetalles(short facturaID)
        {
            try
            {
                var detallesFactura = BL_Factura.listDetalleCompraFactura(facturaID);
                gridDetalles.DataSource = detallesFactura;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewVenta_Click(object sender, EventArgs e)
        {
            if (cmbboxCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar cliente");
                return;
            }
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol, 6) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Factura f = new Factura();
                f.ClienteID = Convert.ToInt16(cmbboxCliente.SelectedValue);
                f.UsuarioID = ID_Usuario;
                f.usuarioRegistro = ID_Usuario;
                this.ID_Factura = BL_Factura.Insert(f).ID;
                if (this.ID_Factura > 0)
                {
                    crearFactura nextForm = new crearFactura();
                    nextForm.ID_Usuario = this.ID_Usuario;
                    nextForm.ID_Rol = this.ID_Rol;
                    nextForm.ID_Permiso = this.ID_Permiso;
                    nextForm.ID_Factura = this.ID_Factura;
                    nextForm.Show();
                    this.Hide();
                }
            }
            

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cargarGridFacturas();
            cargarCombobox();
            if (ID_Permiso == 1)
            {
                btnNewVenta.Enabled = false;
            }
        }

        private void gridFacturas_DoubleClick(object sender, EventArgs e)
        {
            getDetalle = Convert.ToInt16(gridFacturas.CurrentRow.Cells["ID"].Value.ToString());
            cargarGridDetalles(getDetalle);
        }
    }
}
