using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            Producto producto;
            int stock = (int)nudStock.Value;
            string mensaje;

            cliente = BuscarCliente();
            producto = BuscarProducto();

            mensaje = Venta.VenderProducto(producto, cliente, stock);
            
            lblVendido.Visible = true;
            lblVendido.Text = mensaje;

            if (mensaje == "¡Vendido!")
            {
                FrmLogin.Facturas.Add(cliente, producto);
                FrmLogin.Stocks.Add(cliente, stock);
                ReproducirSonidoExito();
            }
            else
            {
                ReproducirSonidoFallo();
            }
        }

        private void nudStock_ValueChanged(object sender, EventArgs e)
        {
            Producto producto = BuscarProducto();
            double precio = producto.Precio;
            int stock = (int)nudStock.Value;

            lblPrecioTotalProducto.Text = Venta.PrecioTotal(precio, stock).ToString();
        }

        private Cliente BuscarCliente()
        {
            Cliente cliente = null;

            if (FrmMenu.Clientes.Count > 0)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    if (nudIdClientes.Value == cliente.IdCliente)
                    {
                        lblInfoCliente.Visible = false;
                        lblNombreCliente.Visible = true;
                        lblApellidoCliente.Visible = true;
                        lblDniCliente.Visible = true;
                        break;
                    }
                    else
                    {
                        lblInfoCliente.Visible = true;
                        lblNombreCliente.Visible = false;
                        lblApellidoCliente.Visible = false;
                        lblDniCliente.Visible = false;
                        cliente = null;
                    }
                }
            }
            else
            {
                lblInfoCliente.Visible = true;
                lblNombreCliente.Visible = false;
                lblApellidoCliente.Visible = false;
                lblDniCliente.Visible = false;
                ReproducirSonidoFallo();
            }

            return cliente;
        }

        private Producto BuscarProducto()
        {
            Producto producto = null;

            if (FrmLogin.Productos.Count > 0)
            {
                for (int j = 0; j < FrmLogin.Productos.Count; j++)
                {
                    producto = FrmLogin.Productos[j];

                    if (nudIdProducto.Value == producto.IdProducto)
                    {
                        lblInfoProducto.Visible = false;
                        lblNombreProducto.Visible = true;
                        lblMarcaProducto.Visible = true;
                        lblPrecioProducto.Visible = true;
                        lblStockProducto.Visible = true;
                        break;
                    }
                    else
                    {
                        lblInfoProducto.Visible = true;
                        lblNombreProducto.Visible = false;
                        lblMarcaProducto.Visible = false;
                        lblPrecioProducto.Visible = false;
                        lblStockProducto.Visible = false;
                        producto = null;
                    }
                }
            }
            else
            {
                lblInfoProducto.Visible = true;
                lblNombreProducto.Visible = false;
                lblMarcaProducto.Visible = false;
                lblPrecioProducto.Visible = false;
                lblStockProducto.Visible = false;
                ReproducirSonidoFallo();
            }

            return producto;
        }

        private void nudIdClientes_ValueChanged(object sender, EventArgs e)
        {
            Cliente cliente = BuscarCliente();

            if (cliente != null)
            {
                lblNombreCliente.Text = cliente.Nombre;
                lblApellidoCliente.Text = cliente.Apellido;
                lblDniCliente.Text = cliente.Dni.ToString();

                lblNombreCliente.Visible = true;
                lblApellidoCliente.Visible = true;
                lblDniCliente.Visible = true;
            }
        }

        private void nudIdProducto_ValueChanged(object sender, EventArgs e)
        {
            Producto producto = BuscarProducto();

            if (producto != null)
            {
                lblNombreProducto.Text = producto.Nombre;
                lblMarcaProducto.Text = producto.Marca;
                lblPrecioProducto.Text = producto.Precio.ToString();
                lblStockProducto.Text = producto.Stock.ToString();

                lblNombreProducto.Visible = true;
                lblMarcaProducto.Visible = true;
                lblPrecioProducto.Visible = true;
                lblStockProducto.Visible = true;
            }
        }

        private void ReproducirSonidoExito()
        {
            SoundPlayer sonidoExito = new SoundPlayer(@"D:\UTN\Segundo cuatrimestre\Programacion II\Examenes\PrimerExamen\Sonidos\Exito.wav");
            sonidoExito.Play();
        }

        private void ReproducirSonidoFallo()
        {
            SoundPlayer sonidoFallo = new SoundPlayer(@"D:\UTN\Segundo cuatrimestre\Programacion II\Examenes\PrimerExamen\Sonidos\Fallo.wav");
            sonidoFallo.Play();
        }
    }
}
