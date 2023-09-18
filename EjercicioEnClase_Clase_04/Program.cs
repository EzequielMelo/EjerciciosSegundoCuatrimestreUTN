using System.Diagnostics.Contracts;
using ClassLibrary_EjercicioEnClase_Clase_04;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> agenda = new List<string>();
        agenda.Add("1111");
        agenda.Add("2222");
        agenda.Add("3333");

        Celular celular1 = new Celular(EMarca.Samsung, "J7", 4, 64, agenda);

        Console.WriteLine(celular1.AlternarEncendido());

        //Console.WriteLine(celular1.AlternarEncendido());
        //celular1.Llamar("5555");

        //celular1.Llamar("1111");

        Contacto miContacto = new Contacto("Juan", "5555");

        celular1.Llamar(miContacto);

        Console.WriteLine("****************************************");

        App app1 = new App("Tinder", 40f);
        App app2 = new App("WhatsApp", 20f);
        App app3 = new App("Instagram", 15f);

        List<App> listaApps = new List<App>();
        listaApps.Add(app1);
        listaApps.Add(app2);
        listaApps.Add(app3);
        bool exito;
        foreach (App aplicacion in listaApps)
        {
            exito = celular1 + aplicacion;
            if (exito)
            {
                Console.WriteLine($"Exito al instalar {aplicacion.nombre}");
            }
            else
            {
                Console.WriteLine($"No se pudo instalar {aplicacion.nombre} por falta de memoria");

            }
        }

        Console.WriteLine(celular1.ToString());

        Console.WriteLine("*********************EXPLICIT e IMPLICIT*********************************");
        //PRUEBA DE OPERADORES EXPLICITOS E IMPLICITOS DE LA CLASE APP

        App unaApp = new App("Pokemon Go", 45f);

        string appString;

        appString = (string)unaApp;

        Console.WriteLine(appString);

        double capacidad;

        capacidad = unaApp;

        Console.WriteLine($"La capacidad del celular es: {capacidad}");
    }
}