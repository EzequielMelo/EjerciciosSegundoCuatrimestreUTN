namespace ClassLibrary_Ejercicio_01_Clase_04_Sumador
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int sumas)
        {
            this.cantidadSumas = sumas;
        }

        public Sumador() : this(0) 
        {

        }

        public long Sumar(long a, long b)
        {
            cantidadSumas += 1;
            return a + b;
        }

        public string Sumar(string a, string b) 
        {
            cantidadSumas += 1;
            return a + b;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }
    }
}