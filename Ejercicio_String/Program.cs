using Ejercicio_String;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(TextOperations.ContarLetras("Diego"));

        Console.WriteLine(TextOperations.ContarPalabras("Hola mi nombre es Diego"));

        Console.WriteLine(TextOperations.ContarVocales("Hola mi nombre es Diego"));

        Console.WriteLine(TextOperations.ContarConsonantes("Hola mi nombre es Diego"));

        Console.WriteLine(TextOperations.ReemplazarCaracter("elefante", 'e', 'u'));

        int numero = 0;
        Console.WriteLine(TextOperations.ConvertirStringAEntero("dos", ref numero));
        Console.WriteLine($"Numero: {numero}");

        Console.WriteLine(TextOperations.ConvertirStringASB("electrodinamica"));

        Console.WriteLine(TextOperations.ConvertirParrafoASB("Hola soy Diego.Vivo en Argentina.Tengo 24 años."));

        TextOperations.MostrarTexto("Todos cuentan cuentos", "Pero como yo los cuento cuantos");

        StringBuilder myStringBuilder = new StringBuilder("De los guerreros de Dios soy el gladiador");
        TextOperations.MostrarTextoSB(myStringBuilder);
    }
}