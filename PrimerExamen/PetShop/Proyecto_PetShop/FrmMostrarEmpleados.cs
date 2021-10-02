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
    public partial class FrmMostrarEmpleados : Form
    {
        #region Carga de datos
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmMostrarEmpleados()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMostrarEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();

            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra todos los empleados
        /// </summary>
        private void MostrarEmpleados()
        {
            Empleado empleado;
            StringBuilder ids = new StringBuilder();
            StringBuilder nombres = new StringBuilder();
            StringBuilder apellidos = new StringBuilder();
            StringBuilder dnis = new StringBuilder();
            StringBuilder sueldos = new StringBuilder();
            StringBuilder puestos = new StringBuilder();
            StringBuilder diasLaborales = new StringBuilder();
            StringBuilder horaEntrada = new StringBuilder();
            StringBuilder horaSalida = new StringBuilder();

            for (int i = 0; i < FrmLogin.Empleados.Count; i++)
            {
                empleado = FrmLogin.Empleados[i];

                ids.AppendLine(empleado.IdEmpleado.ToString());
                nombres.AppendLine(empleado.Nombre);
                apellidos.AppendLine(empleado.Apellido);
                dnis.AppendLine(empleado.Dni.ToString());
                sueldos.AppendLine(empleado.Sueldo.ToString());
                puestos.AppendLine(empleado.Puesto.ToString());

                for (int j = 0; j < empleado.DiasLaborales.Length; j++)
                {
                    diasLaborales.Append(empleado.DiasLaborales[j] + " ");
                }
                diasLaborales.AppendLine("");
                
                horaEntrada.AppendLine($"{empleado.HorarioEntrada.Hour}:{empleado.HorarioEntrada.Minute}");
                horaSalida.AppendLine($"{empleado.HorarioSalida.Hour}:{empleado.HorarioSalida.Minute}");

                lblId.Visible = true;
                lblNombres.Visible = true;
                lblApellidos.Visible = true;
                lblDni.Visible = true;
                lblSueldo.Visible = true;
                lblPuesto.Visible = true;
                lblDiasLaborales.Visible = true;
                lblHoraEntrada.Visible = true;
                lblHoraSalida.Visible = true;

                lblId.Text = ids.ToString();
                lblNombres.Text = nombres.ToString();
                lblApellidos.Text = apellidos.ToString();
                lblDni.Text = dnis.ToString();
                lblSueldo.Text = sueldos.ToString();
                lblPuesto.Text = puestos.ToString();
                lblDiasLaborales.Text = diasLaborales.ToString();
                lblHoraEntrada.Text = horaEntrada.ToString();
                lblHoraSalida.Text = horaSalida.ToString();
            }
        }
        #endregion
    }
}
