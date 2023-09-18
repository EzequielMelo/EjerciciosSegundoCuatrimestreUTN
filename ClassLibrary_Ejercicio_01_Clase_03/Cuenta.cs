using System.Text;

namespace ClassLibrary_Ejercicio_01_Clase_03
{
    public class Cuenta
    {
        public string _titular;
        public float _cantidad;

        public Cuenta(string _titular, float _cantidad)
        {
            this._titular = _titular;
            this._cantidad = _cantidad;
        }

        public string getTitular()
        {
            return _titular;
        }

        public float getCantidad()
        {
            return _cantidad;
        }

        public string cuentaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Titular: {getTitular()}\nCantidad: {getCantidad()}");

            return sb.ToString();
        }

        public void ingresarDinero(float ingresar)
        {
            if (ingresar > 0)
            {
                this._cantidad += ingresar;
            }
        }

        public void retirarDinero(float retirar)
        {
            this._cantidad -= retirar;
        }
    }
}