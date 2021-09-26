using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmBajaModificacionCliente : Form
    {
        /// <summary>
        /// Inicializa los componentes gráficos de este formulario
        /// </summary>
        public FrmBajaModificacionCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra los datos ddel cliente con el ID ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            StringBuilder fechaNacimiento = new StringBuilder();

            if (!FrmMenu.FlagPrimeraVezClientes)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    if (nupIdClientes.Value == cliente.IdCliente)
                    {
                        fechaNacimiento.Append($"{cliente.FechaNacimiento.Day}/{cliente.FechaNacimiento.Month}/{cliente.FechaNacimiento.Year}");

                        lblInfo.Visible = false;
                        OcultarTextBox();
                        MostrarLebel();

                        lblNombreCliente.Text = cliente.Nombre;
                        lblApellidoCliente.Text = cliente.Apellido;
                        lblFechaNacimientoCliente.Text = fechaNacimiento.ToString();
                        lblDniCliente.Text = cliente.Dni.ToString();
                        lblSexoCliente.Text = cliente.Sexo;
                        lblNacionalidadCliente.Text = cliente.Nacionalidad;
                        lblDomicilioCliente.Text = cliente.Domicilio;
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                        OcultarLebel();
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
            }
        }

        /// <summary>
        /// Entra en el modo modificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            OcultarLebel();
            MostrarTextBox();
            btnAplicarCambios.Visible = true;
        }

        /// <summary>
        /// Sobreescribe los datos deseados del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            long dni;
            Cliente cliente;

            if (!FrmMenu.FlagPrimeraVezClientes)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    if (nupIdClientes.Value == cliente.IdCliente)
                    {
                        lblInfo.Visible = false;

                        if (MessageBox.Show("¿Seguro que desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (txtNombre.Text != string.Empty)
                            {
                                cliente.Nombre = txtNombre.Text;
                            }
                            if (txtApellido.Text != string.Empty)
                            {
                                cliente.Apellido = txtApellido.Text;
                            }
                            if (txtFechaNacimiento.Text != string.Empty)
                            {
                                cliente.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                            }
                            if (txtDni.Text != string.Empty)
                            {
                                if (!long.TryParse(txtDni.Text, out dni))
                                {
                                    MessageBox.Show("El DNI es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                cliente.Dni = dni;
                            }
                            if (cmbSexo.SelectedItem != null)
                            {
                                cliente.Sexo = cmbSexo.SelectedItem.ToString();
                            }
                            if (txtNacionalidad.Text != string.Empty)
                            {
                                cliente.Nacionalidad = txtNacionalidad.Text;
                            }
                            if (txtDomicilio.Text != string.Empty)
                            {
                                cliente.Domicilio = txtDomicilio.Text;
                            }
                            LimpiarTextBox();
                        }
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
            }
        }

        /// <summary>
        /// Elimina el cliente con el ID seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente;

            if (!FrmMenu.FlagPrimeraVezClientes)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    if (nupIdClientes.Value == cliente.IdCliente)
                    {
                        if(MessageBox.Show("¿Estás seguro que desea eliminar este cliente?\nEsta acción no se puede deshacer", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            FrmMenu.Clientes.Remove(cliente);
                            OcultarLebel();
                        }
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
            }

            if (FrmMenu.Clientes.Count == 0)
            {
                FrmMenu.FlagPrimeraVezClientes = true;
            }
        }

        #region Visibilidad Label/TextBox
        /// <summary>
        /// Establece la visibilidad de los text box en false
        /// </summary>
        private void OcultarTextBox()
        {
            btnAplicarCambios.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtFechaNacimiento.Visible = false;
            txtDni.Visible = false;
            cmbSexo.Visible = false;
            txtNacionalidad.Visible = false;
            txtDomicilio.Visible = false;
        }

        /// <summary>
        /// Establece la visibilidad de los lebel en false
        /// </summary>
        private void OcultarLebel()
        {
            lblNombreCliente.Visible = false;
            lblApellidoCliente.Visible = false;
            lblFechaNacimientoCliente.Visible = false;
            lblDniCliente.Visible = false;
            lblSexoCliente.Visible = false;
            lblNacionalidadCliente.Visible = false;
            lblDomicilioCliente.Visible = false;
        }

        /// <summary>
        /// Establece la visibilidad de los text box en true
        /// </summary>
        private void MostrarTextBox()
        {
            btnAplicarCambios.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtFechaNacimiento.Visible = true;
            txtDni.Visible = true;
            cmbSexo.Visible = true;
            txtNacionalidad.Visible = true;
            txtDomicilio.Visible = true;
        }

        /// <summary>
        /// Establece la visibilidad de los lebel en true
        /// </summary>
        private void MostrarLebel()
        {
            lblNombreCliente.Visible = true;
            lblApellidoCliente.Visible = true;
            lblFechaNacimientoCliente.Visible = true;
            lblDniCliente.Visible = true;
            lblSexoCliente.Visible = true;
            lblNacionalidadCliente.Visible = true;
            lblDomicilioCliente.Visible = true;
        }

        /// <summary>
        /// Borra cualquier texto que haya en los text box
        /// </summary>
        private void LimpiarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtDni.Text = string.Empty;
            cmbSexo.SelectedItem = null;
            txtNacionalidad.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
        }
        #endregion
    }
}
