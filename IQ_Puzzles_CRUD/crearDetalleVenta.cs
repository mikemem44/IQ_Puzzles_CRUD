using BL;
using EL;
using Microsoft.VisualBasic.Logging;
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
    public partial class crearDetalleVenta : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public short ID_Factura { get; set; }
        public short ID_Detalle { get; set; }

        private float precio;
        private short cantidad;
        private float descuento;
        private float total;


        public crearDetalleVenta()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {
            try
            {
                gridProductos.DataSource = BL_Producto.listProductoDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validar()
        {
            if (numPrecioVenta.Value <= 0)
            {
                MessageBox.Show("Ingrese un precio valido");
                return false;
            }
            if (numPrecioVenta.Value > 10000)
            {
                MessageBox.Show("Precio maximo es 10,000.00");
                return false;
            }
            if (numCantidad.Value < 1)
            {
                MessageBox.Show("Ingrese una cantidad valida");
                return false;
            }
            if (numCantidad.Value > Convert.ToInt16(gridProductos.CurrentRow.Cells["Stock"].Value.ToString()))
            {
                MessageBox.Show("La cantidad de productos a vender no puede superar el stock");
                return false;
            }
            if (numDescuento.Value < 0)
            {
                MessageBox.Show("Ingrese un monto de descuento valido.");
                return false;
            }
            if (numDescuento.Value >= numPrecioVenta.Value)
            {
                MessageBox.Show("La cantidad de descuento maxima es el precio unitario del producto");
                return false;
            }

            return true;
        }

        private float calcularTotal(float precio, short cantidad, float descuento)
        {
            //(precio venta * cantidad) - descuento
            total = 0.0f;
            total = (precio * cantidad) - descuento;
            return total;
        }

        private void btnAddtoFactura_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("No se ha calculado el total del detalle");
                return;
            }
            else
            {
                Detalle d = new Detalle();
                d.ProductoID = Convert.ToInt16(gridProductos.CurrentRow.Cells["ProductoID"].Value.ToString());
                d.FacturaID = ID_Factura;
                d.precioVenta = precio;
                d.Cantidad = cantidad;
                d.Descuento = descuento;
                d.totalDetalle = total;
                d.usuarioRegistro = ID_Usuario;
                this.ID_Detalle = BL_Detalle.Insert(d).ID;
                if (this.ID_Detalle > 0)
                {
                    MessageBox.Show("Se ha registrado el detalle con exito");
                    loadGrid();

                    crearFactura f = new crearFactura();
                    f.ID_Usuario = this.ID_Usuario;
                    f.ID_Rol = this.ID_Rol;
                    f.ID_Permiso = this.ID_Permiso;
                    f.ID_Factura = this.ID_Factura;
                    f.ID_Detalle = this.ID_Detalle;
                    f.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se registro el detalle");
                    return;
                }
                {

                }

            }

            crearFactura factura = Application.OpenForms.OfType<crearFactura>().FirstOrDefault();
            if (factura == null)
            {
                factura = new crearFactura();
            }
            factura.ID_Usuario = this.ID_Usuario;
            factura.ID_Rol = this.ID_Rol;
            factura.ID_Permiso = this.ID_Permiso;
            factura.Show();
            this.Hide();
        }


        private void crearDetalleVenta_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void gridProductos_DoubleClick(object sender, EventArgs e)
        {
            this.lblNombreProd.Text = gridProductos.CurrentRow.Cells["Nombre"].Value.ToString();
            this.numPrecioVenta.Value = Convert.ToInt16(gridProductos.CurrentRow.Cells["PrecioUnitario"].Value.ToString());

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                precio = Convert.ToSingle(numPrecioVenta.Value);
                cantidad = Convert.ToInt16(numCantidad.Value);
                descuento = Convert.ToSingle(numDescuento.Value);
                total = calcularTotal(precio, cantidad, descuento);
                MessageBox.Show("Se ha calculado el total del detalle");
                this.lblTotalDetalle.Text = total.ToString();
            }
        }
    }
}
