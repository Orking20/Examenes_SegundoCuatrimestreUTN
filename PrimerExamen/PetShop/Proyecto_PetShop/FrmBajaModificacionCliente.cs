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
    public partial class FrmBajaModificacionCliente : Form
    {
        #region Carga de datos
        /// <summary>
        /// Inicializa los componentes gráficos de este formulario
        /// </summary>
        public FrmBajaModificacionCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos cuando se abre el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBajaModificacionCliente_Load(object sender, EventArgs e)
        {
            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }
        #endregion

        #region BotonMostrar
        /// <summary>
        /// Muestra los datos del cliente con el ID ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cliente cliente;

            if (FrmMenu.Clientes.Count > 0)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    if (nupIdClientes.Value == cliente.IdCliente)
                    {
                        lblInfo.Visible = false;
                        OcultarLebel();
                        OcultarTextBox();
                        lblMostrar.Visible = true;
                        lblMostrar.Text = cliente.Mostrar();
                        ReproducirSonidoBoton();
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                        lblMostrar.Visible = false;
                        OcultarLebel();
                        ReproducirSonidoFallo();
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
                ReproducirSonidoFallo();
            }
        }
        #endregion

        #region BotonModificar_AplicarCambios
        /// <summary>
        /// Entra en el modo modificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (FrmMenu.Clientes.Count > 0)
            {
                OcultarLebel();
                MostrarLebel();
                MostrarTextBox();
                lblMostrar.Visible = false;
                btnAplicarCambios.Visible = true;
                ReproducirSonidoBoton();
            }
            else
            {
                lblInfo.Visible = true;
                ReproducirSonidoFallo();
            }
        }

        /// <summary>
        /// Sobreescribe los datos deseados del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            StringBuilder sb;

            for (int i = 0; i < FrmMenu.Clientes.Count; i++)
            {
                cliente = FrmMenu.Clientes[i];

                if (nupIdClientes.Value == cliente.IdCliente)
                {
                    lblInfo.Visible = false;

                    if (Validaciones(cliente, out sb))
                    {
                        MessageBox.Show($"Estos campos no son válidos.\nAsegurese de cambiarlos\n{sb}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(MessageBox.Show("¿Seguro que desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            OcultarLebel();
                            OcultarTextBox();
                            LimpiarTextBox();
                            lblMostrar.Text = cliente.Mostrar();
                            lblMostrar.Visible = true;
                            ReproducirSonidoExito();
                            break;
                        }
                    }
                }
                else
                {
                    lblInfo.Visible = true;
                    ReproducirSonidoFallo();
                }
            }
        }
        #endregion

        #region BotonEliminar
        /// <summary>
        /// Elimina el cliente con el ID seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente;

            if (FrmMenu.Clientes.Count > 0)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    if (nupIdClientes.Value == cliente.IdCliente)
                    {
                        lblInfo.Visible = false;

                        if (MessageBox.Show("¿Estás seguro que desea eliminar este cliente?\nEsta acción no se puede deshacer", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Empleado.BajaCliente(FrmMenu.Clientes, cliente);
                            OcultarLebel();
                            lblMostrar.Visible = false;
                            ReproducirSonidoExito();
                        }
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                        ReproducirSonidoFallo();
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
                ReproducirSonidoFallo();
            }
        }
        #endregion

        #region Validaciones
        private bool Validaciones(Cliente cliente, out StringBuilder sb)
        {
            bool error = false;
            long dni;
            sb = new StringBuilder();

            if (txtNombre.Text != string.Empty)
            {
                if (Cliente.ValidarNombre(txtNombre.Text))
                {
                    cliente.Nombre = txtNombre.Text;
                }
                else
                {
                    sb.AppendLine("Nombre");
                    error = true;
                }
            }
            if (txtApellido.Text != string.Empty)
            {
                if (Cliente.ValidarApellido(txtApellido.Text))
                {
                    cliente.Apellido = txtApellido.Text;
                }
                else
                {
                    sb.AppendLine("Apellido");
                    error = true;
                }
            }
            if (txtFechaNacimiento.Text != string.Empty)
            {
                if (Cliente.ValidarFechaNacimiento(txtFechaNacimiento.Text))
                {
                    cliente.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                }
                else
                {
                    sb.AppendLine("Fecha de nacimiento");
                    error = true;
                }
            }
            if (txtDni.Text != string.Empty)
            {
                if (long.TryParse(txtDni.Text, out dni) && Cliente.ValidarDni(dni))
                {
                    cliente.Dni = dni;
                }
                else
                {
                    sb.AppendLine("DNI");
                    error = true;
                }
            }
            if (cmbSexo.SelectedItem != null)
            {
                cliente.Sexo = cmbSexo.SelectedItem.ToString();
            }
            if (txtNacionalidad.Text != string.Empty)
            {
                if (Cliente.ValidarNacionalidad(txtNacionalidad.Text))
                {
                    cliente.Nacionalidad = txtNacionalidad.Text;
                }
                else
                {
                    sb.AppendLine("Nacionalidad");
                    error = true;
                }
            }
            if (txtDomicilio.Text != string.Empty)
            {
                if (Cliente.ValidarDomicilio(txtDomicilio.Text))
                {
                    cliente.Domicilio = txtDomicilio.Text;
                }
                else
                {
                    sb.AppendLine("Domicilio");
                    error = true;
                }
            }

            return error;
        }
        #endregion

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
            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblFechaNacimiento.Visible = false;
            lblDni.Visible = false;
            lblSexo.Visible = false;
            lblNacionalidad.Visible = false;
            lblDomicilio.Visible = false;
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
            lblNombre.Visible = true;
            lblApellido.Visible = true;
            lblFechaNacimiento.Visible = true;
            lblDni.Visible = true;
            lblSexo.Visible = true;
            lblNacionalidad.Visible = true;
            lblDomicilio.Visible = true;
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

        #region Sonido
        /// <summary>
        /// Reproduce un sonido indicando que todo salió correctamente
        /// </summary>
        private void ReproducirSonidoExito()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Exito.wav");
            sonido.Play();
        }

        /// <summary>
        /// Reproduce un sonido indicando que algo falló
        /// </summary>
        private void ReproducirSonidoFallo()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Fallo.wav");
            sonido.Play();
        }

        /// <summary>
        /// Reproduce un sonido indicando ¨que se presionó un botón
        /// </summary>
        private void ReproducirSonidoBoton()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Boton.wav");
            sonido.Play();
        }
        #endregion
    }
}
