using System.Text;

namespace ClassLibrary_Ejercicio_02_Clase03
{
    public class Estudiante
    {
        private string _apellido;
        private string _legajo;
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;

        static Estudiante()
        {
            _random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
           this._apellido = apellido;
            this._legajo = legajo;
            this._nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this._notaPrimerParcial = nota;
        }


        public void SetNotaSegundoParcial(int nota)
        {
            this._notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float notaFinal;

            notaFinal = (float)(this._notaPrimerParcial + this._notaSegundoParcial) / 2;

            return notaFinal;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal=-1;

            if(this._notaPrimerParcial>3 && this._notaSegundoParcial>3)
            {
                notaFinal = _random.Next(6, 10);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Alumno: {this._nombre} {this._apellido}\nLegajo: {this._legajo}");
            sb.AppendLine($"Nota primer parcial: {this._notaPrimerParcial}\nNota segundo parcial: {this._notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            if (this.CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota Final: {this.CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }

            return sb.ToString();
        }
    }
}