using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private double sueldo;
        private int antiguedad;
        private EPuesto puesto;
        private bool trabajaActualmente;
        private DateTime horarioLlegada;
        private DateTime horarioSalida;
        private static int idCliente = 0;

        #region Constructor
        /// <summary>
        /// Inicializa los datos de un empleado
        /// </summary>
        /// <param name="sueldo">Sueldo del empleado</param>
        /// <param name="antiguedad">Antiguedad del empleado en anios del empleado</param>
        /// <param name="trabajaActualmente">Trabaja actualmente o es un ex empleado</param>
        /// <param name="horarioLlegada">Horario de llegada del empleado</param>
        /// <param name="horarioSalida">Horario de llegada del empleado</param>
        /// <param name="nombre">Nombre del empleado</param>
        /// <param name="apellido">Apellido del empleado</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del empleado</param>
        /// <param name="dni">DNI del empleado</param>
        /// <param name="sexo">Sexo del empleado</param>
        /// <param name="nacionalidad">Nacionalidad del empleado</param>
        /// <param name="domicilio">Domicilio del empleado</param>
        public Empleado(double sueldo, int antiguedad, EPuesto puesto, bool trabajaActualmente, DateTime horarioLlegada, DateTime horarioSalida, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio) : base(nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio)
        {
            this.Sueldo = sueldo;
            this.Antiguedad = antiguedad;
            this.puesto = puesto;
            this.trabajaActualmente = trabajaActualmente;
            this.horarioLlegada = horarioLlegada;
            this.horarioSalida = horarioSalida;
        }
        #endregion

        /// <summary>
        /// Carga a un cliente en la lista
        /// </summary>
        /// <param name="clientes">Lista donde estarán los clientes</param>
        /// <param name="saldo">Cantidad de plata que tiene el cliente</param>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="apellido">Apellido del cliente</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del cliente</param>
        /// <param name="dni">DNI del cliente</param>
        /// <param name="sexo">Sexo del cliente</param>
        /// <param name="nacionalidad">Nacionalidad del cliente</param>
        /// <param name="domicilio">Domicilio del cliente</param>
        public static Cliente AltaCliente(double saldo, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
        {
            idCliente++;

            Cliente clienteNuevo = new Cliente(saldo, idCliente, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);

            return clienteNuevo;
        }

        public static string MostrarCliente(Cliente cliente)
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Nombre y apellido: {cliente.Nombre} {cliente.Apellido}");
            st.AppendLine($"Fecha de nacimiento: {cliente.FechaNacimiento}");
            st.AppendLine($"DNI: {cliente.Dni}");
            st.AppendLine($"Sexo: {cliente.Sexo}");
            st.AppendLine($"Nacionalidad: {cliente.Nacionalidad}");
            st.AppendLine($"Domicilio: {cliente.Domicilio}");

            return st.ToString();
        }

        public override string Mostrar()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Sueldo: {this.Sueldo}");
            st.AppendLine($"Antigüedad: {this.Antiguedad}");
            st.AppendLine($"Puesto: {this.puesto}");
            st.AppendLine($"Trabaja actualmente: {this.trabajaActualmente}");
            st.AppendLine($"Horario de entrada: {this.horarioLlegada}");
            st.AppendLine($"Horario de salida: {this.horarioSalida}");

            return base.Mostrar() + st.ToString();
        }

        #region Getters/Setters
        /// <summary>
        /// Devuelve o establece el valor de sueldo
        /// </summary>
        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                if (ValidarSueldo(value))
                {
                    this.sueldo = value;
                }
            }
        }

        /// <summary>
        /// Devuelve o establece el valor de antiguedad
        /// </summary>
        public int Antiguedad
        {
            get
            {
                return this.antiguedad;
            }
            set
            {
                if (ValidarAntiguedad(value))
                {
                    this.antiguedad = value;
                }
            }
        }
        #endregion

        #region Validaciones
        /// <summary>
        /// Valida que el sueldo sea mayor o igual a 0
        /// </summary>
        /// <param name="sueldo">Número a validar</param>
        /// <returns>Retorna true si el sueldo es válido o false si no</returns>
        private bool ValidarSueldo(double sueldo)
        {
            bool retorno = false;

            if (sueldo >= 0)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que la antiguedad sea mayor o igual a 0 y menor a 130
        /// </summary>
        /// <param name="antiguedad">Número a validar</param>
        /// <returns>Retorna true si la antiguedad es válida o false si no</returns>
        private bool ValidarAntiguedad(int antiguedad)
        {
            bool retorno = false;

            if (antiguedad >= 0 && antiguedad < 130)
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
