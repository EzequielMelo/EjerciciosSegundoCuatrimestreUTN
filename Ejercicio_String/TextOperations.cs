using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    internal class TextOperations
    {

        public static int ContarLetras(string palabra)
        {
            int contador = 0;

            foreach (char c in palabra)
            {
                contador++;
            }

            return contador;
        }

        public static int ContarPalabras(string palabra)
        {
            int contador = 1;

            foreach (char c in palabra)
            {
                if (c == ' ')
                {
                    contador++;
                }

            }

            return contador;
        }

        public static int ContarVocales(string palabra)
        {
            int contador = 0;
            palabra = palabra.ToLower();

            foreach (char c in palabra)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    contador++;
                }

            }

            return contador;
        }

        public static int ContarConsonantes(string palabra)
        {
            int contador = 0;
            palabra = palabra.ToLower();

            foreach (char c in palabra)
            {
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' && c != ' ')
                {
                    contador++;
                }

            }

            return contador;
        }

        public static string ReemplazarCaracter(string palabra, char original, char nuevo)
        {
            char[] caracteres = palabra.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == original)
                {
                    caracteres[i] = nuevo;
                }
            }

            string palabraFinal = new string(caracteres);

            return palabraFinal;
        }

        public static bool ConvertirStringAEntero(string texto, ref int numeroEntero)
        {
            bool isNumeric = int.TryParse(texto, out numeroEntero);

            return isNumeric;
        }


        public static StringBuilder ConvertirStringASB(string palabra)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(palabra);

            return sb;
        }

        public static StringBuilder ConvertirParrafoASB(string parrafo)
        {
            StringBuilder sb = new StringBuilder();
            string[] frase = parrafo.Split('.');

            foreach (string s in frase)
            {
                sb.AppendLine(s);
            }

            return sb;
        }

        public static void MostrarTexto(string mensaje, string texto)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Mensaje: {mensaje}\nTexto: {texto}");

            Console.WriteLine(sb.ToString());
        }

        public static void MostrarTextoSB(StringBuilder mensaje)
        {
            Console.WriteLine(mensaje.ToString());
        }
    }
}
