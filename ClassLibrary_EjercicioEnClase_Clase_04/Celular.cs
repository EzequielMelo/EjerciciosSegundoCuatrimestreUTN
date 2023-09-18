using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_EjercicioEnClase_Clase_04
{
    internal class Celular
    {

        #region Atributos

        private EMarca marca;
        private string modelo;
        private int ram;
        private double almacenamiento;
        private double almacenamientoActual;
        private bool encendido;
        private List<string> agenda;//Lista Contacto
        private List<string> apps;//Lista App
        #endregion


        #region Constructores
        public Celular(EMarca marca, string modelo, int ram, double almacenamiento, List<string> agenda) : this(marca, modelo, ram, almacenamiento)
        {
            this.Agenda = agenda;
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento) : this()
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ram = ram;
            this.Almacenamiento = almacenamiento;
            this.Encendido = false;
            this.AlmacenamientoActual = 0;
        }

        public Celular()
        {
            this.Apps = new List<string>();
            this.Agenda = new List<string>();
        }
        #endregion


        #region Propiedades



        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }

        public EMarca Marca { get => marca; set => marca = value; }

        public int Ram { get => ram; set => ram = value; }
        public double Almacenamiento
        {
            get => almacenamiento;
            set => almacenamiento = value;
        }
        public double AlmacenamientoActual { get => almacenamientoActual; set => almacenamientoActual = value; }
        public bool Encendido { get => encendido; set => encendido = value; }
        public List<string> Agenda { get => agenda; set => agenda = value; }
        public List<string> Apps { get => apps; set => apps = value; }


        #endregion


        #region Metodos Instancia
        public string AlternarEncendido()
        {

            this.Encendido = !this.Encendido;

            return this.Encendido ? "Encendiendo..." : "Apagando...";



            //string mensaje;
            //if(this.encendido == true)
            //{
            //    this.encendido = false;
            //    mensaje = "Apagando...";
            //}
            //else
            //{
            //    this.encendido = true;
            //    mensaje = "Encendiendo...";
            //}


            //return mensaje;
        }

        public void Llamar(string numero)
        {
            //Encendido
            if (this.encendido)
            {
                if (BuscarEnAgenda(numero))
                {
                    Console.WriteLine($"Llamando al numero: {numero}");
                }
                else
                {
                    Console.WriteLine("Numero no encontrado...");
                }
            }
            else
            {
                Console.WriteLine("El celular esta apagado");
            }
            //El numero tiene que estar agendado
        }

        public void Llamar(Contacto unContacto)
        {
            if (this.encendido)
            {
                if (BuscarEnAgenda(unContacto.numero))
                {
                    Console.WriteLine($"Llamando a: {unContacto.nombre}");
                }
                else
                {
                    Console.WriteLine("Contacto no encontrado...");
                }
            }
            else
            {
                Console.WriteLine("El celular esta apagado");
            }
        }


        private bool BuscarEnAgenda(string numeroIngresado)
        {
            bool estaEnAgenda;
            estaEnAgenda = false;

            foreach (string numero in this.agenda)
            {
                if (numero == numeroIngresado)
                {
                    estaEnAgenda = true;
                    break;
                }
            }

            return estaEnAgenda;
        }

        private bool InstalarApp(App aplicacion)
        {
            bool exito;
            exito = false;

            if (this.encendido && this != aplicacion && VerificarEspacio(aplicacion.size))
            {
                exito = true;
                this.apps.Add(aplicacion.nombre);
                this.almacenamientoActual += aplicacion.size;
            }
            //Encendido
            //app no este instalada
            //haya espacio


            return exito;
        }

        private bool VerificarEspacio(double nuevoSize)
        {
            return (this.almacenamientoActual + nuevoSize) < this.almacenamiento;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"RAM: {this.ram}");
            sb.AppendLine($"Almacenamiento: {this.almacenamiento}");
            sb.AppendLine("Aplicaciones instaladas");
            if (this.apps.Count > 0)
            {
                foreach (string aplicacion in apps)
                {
                    sb.AppendLine($"\t{aplicacion}");
                }
            }
            else
            {
                sb.AppendLine("No hay apps instaladas");
            }
            sb.AppendLine("*******************************************");
            return sb.ToString();
        }

        #endregion


        #region Sobrecarga de operadores
        public static bool operator ==(Celular miCelu, App miApp)
        {
            bool exito;
            exito = false;
            foreach (string aplicacion in miCelu.Apps)
            {
                if (aplicacion == miApp.nombre)
                {
                    exito = true;
                    break;
                }
            }

            return exito;
        }
        public static bool operator !=(Celular miCelu, App miApp)
        {
            return !(miCelu == miApp);
        }

        public static bool operator +(Celular miCelu, App miApp)
        {
            return miCelu.InstalarApp(miApp);
        }
        #endregion


    }
}
