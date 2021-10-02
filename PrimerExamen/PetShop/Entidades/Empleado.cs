using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private string usuario;
        private string password;
        private double sueldo;
        private EPuesto puesto;
        private string[] diasLaborales;
        private DateTime horarioEntrada;
        private DateTime horarioSalida;
        private int idEmpleado;
        private static int idCliente = 0;
        private static int idProducto = 0;

        #region Constructor
        /// <summary>
        /// Inicializa los datos de un empleado
        /// </summary>
        /// <param name="usuario">Usuario del empleado</param>
        /// <param name="password">Password del empleado</param>
        /// <param name="sueldo">Sueldo del empleado</param>
        /// <param name="puesto">Puesto del empleado</param>
        /// <param name="diasLaborales">Dias laborales del empleado</param>
        /// <param name="horarioEntrada">Horario de llegada del empleado</param>
        /// <param name="horarioSalida">Horario de llegada del empleado</param>
        /// <param name="idEmpleado">ID del empleado</param>
        /// <param name="nombre">Nombre del empleado</param>
        /// <param name="apellido">Apellido del empleado</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del empleado</param>
        /// <param name="dni">DNI del empleado</param>
        /// <param name="sexo">Sexo del empleado</param>
        /// <param name="nacionalidad">Nacionalidad del empleado</param>
        /// <param name="domicilio">Domicilio del empleado</param>
        public Empleado(string usuario, string password, double sueldo, EPuesto puesto, string[] diasLaborales, DateTime horarioEntrada, DateTime horarioSalida, int idEmpleado, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
            : base(nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio)
        {
            this.Usuario = usuario;
            this.Password = password;
            this.Sueldo = sueldo;
            this.Puesto = puesto;
            this.DiasLaborales = diasLaborales;
            this.HorarioEntrada = horarioEntrada;
            this.HorarioSalida = horarioSalida;
            this.IdEmpleado = idEmpleado;
        }
        #endregion

        #region AdministrarCliente
        /// <summary>
        /// Crea un nuevo cliente
        /// </summary>
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

        /// <summary>
        /// Elimina un cliente de una lista de clientes
        /// </summary>
        /// <param name="listaClientes">Lista de clientes</param>
        /// <param name="cliente">Cliente a eliminar</param>
        public static void BajaCliente(List<Cliente> listaClientes, Cliente cliente)
        {
            listaClientes.Remove(cliente);
        }

        /// <summary>
        /// Muestra los datos de un cliente
        /// </summary>
        /// <param name="cliente">Cliente a mostrar</param>
        /// <returns>Retorna un string con todos los datos</returns>
        public static string MostrarCliente(Cliente cliente)
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Nombre y apellido: {cliente.Nombre} {cliente.Apellido}");
            st.AppendLine($"Fecha de nacimiento: {cliente.FechaNacimiento.Day}/{cliente.FechaNacimiento.Month}/{cliente.FechaNacimiento.Year}");
            st.AppendLine($"DNI: {cliente.Dni}");
            st.AppendLine($"Sexo: {cliente.Sexo}");
            st.AppendLine($"Nacionalidad: {cliente.Nacionalidad}");
            st.AppendLine($"Domicilio: {cliente.Domicilio}");

            return st.ToString();
        }
        #endregion

        #region AdministrarProductos
        /// <summary>
        /// Crea un nuevo producto
        /// </summary>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="peso">Peso del producto</param>
        /// <param name="stock">Stock del producto</param>
        /// <returns>Retorna el producto creado</returns>
        public static Producto AltaProducto(string nombre, string marca, ETipo tipo, double precio, double peso, int stock)
        {
            idProducto++;

            Producto productoNuevo = new Producto(nombre, marca, tipo, precio, peso, stock, idProducto);

            return productoNuevo;
        }

        /// <summary>
        /// Elimina un producto de una lista de productos
        /// </summary>
        /// <param name="listaProductos">Lista de productos</param>
        /// <param name="producto">Producto a eliminar</param>
        public static void BajaProducto(List<Producto> listaProductos, Producto producto)
        {
            listaProductos.Remove(producto);
        }
        #endregion

        /// <summary>
        /// Muestra los datos de un producto empleado
        /// </summary>
        /// <returns>Retorna un string con todos los datos</returns>
        public override string Mostrar()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Sueldo: {this.Sueldo}");
            st.AppendLine($"Puesto: {this.Puesto}");
            st.Append("Días laborales: ");
            for (int j = 0; j < this.DiasLaborales.Length; j++)
            {
                st.Append(this.DiasLaborales[j] + " ");
            }
            st.AppendLine("");
            st.AppendLine($"Horario de entrada: {this.HorarioEntrada.Hour}:{this.HorarioEntrada.Minute}hs.");
            st.AppendLine($"Horario de salida: {this.HorarioSalida.Hour}:{this.HorarioSalida.Minute}hs.");

            return base.Mostrar() + st.ToString();
        }

        #region Getters/Setters
        /// <summary>
        /// Devuelve o establece el valor de usuario
        /// </summary>
        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }

        /// <summary>
        /// Devuelve o establece el valor de password
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

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
        /// Devuelve o establece el puesto
        /// </summary>
        public EPuesto Puesto
        {
            get
            {
                return this.puesto;
            }
            set
            {
                this.puesto = value;
            }
        }

        /// <summary>
        /// Devuelve o establece los diasLaborales
        /// </summary>
        public string[] DiasLaborales
        {
            get
            {
                return this.diasLaborales;
            }
            set
            {
                this.diasLaborales = value;
            }
        }

        /// <summary>
        /// Devuelve o establece el horarioEntrada
        /// </summary>
        public DateTime HorarioEntrada
        {
            get
            {
                return this.horarioEntrada;
            }
            set
            {
                this.horarioEntrada = value;
            }
        }

        /// <summary>
        /// Devuelve o establece el horarioSalida
        /// </summary>
        public DateTime HorarioSalida
        {
            get
            {
                return this.horarioSalida;
            }
            set
            {
                this.horarioSalida = value;
            }
        }

        /// <summary>
        /// Devuelve el idEmpleado
        /// </summary>
        public int IdEmpleado
        {
            get
            {
                return this.idEmpleado;
            }
            set
            {
                this.idEmpleado = value;
            }
        }
        #endregion

        #region Validaciones
        /// <summary>
        /// Valida que el sueldo sea mayor o igual a 0
        /// </summary>
        /// <param name="sueldo">Número a validar</param>
        /// <returns>Retorna true si el sueldo es válido o false si no</returns>
        public static bool ValidarSueldo(double sueldo)
        {
            bool retorno = false;

            if (sueldo >= 0)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el sueldo sea mayor o igual a 0
        /// </summary>
        /// <param name="sueldo">Número a validar</param>
        /// <returns>Retorna true si el sueldo es válido o false si no</returns>
        public static bool ValidarHora(string horaMinutos)
        {
            bool retorno = false;
            int hora;
            int minutos;
            string[] arrayHorasMinutos = horaMinutos.Split(":");

            if (int.TryParse(arrayHorasMinutos[0], out hora) && hora < 24 && int.TryParse(arrayHorasMinutos[1], out minutos) && minutos < 60)
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
