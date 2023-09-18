namespace ClassLibrary_EjercicioEnClase_Clase_04
{
    public class App
    {
        public string nombre;
        public double size;

        public App(string nombre, double size)
        {
            this.nombre = nombre;
            this.size = size;
        }

        // Sobrecarga del operador explícito para convertir App a string
        public static explicit operator string(App app)
        {
            return $"{app.nombre} ({app.size} GB)";
        }

        // Sobrecarga del operador explícito para convertir App a double
        public static implicit operator double(App app)
        {
            return app.size;
        }
    }
}