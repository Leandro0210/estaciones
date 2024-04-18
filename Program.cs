using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una estación del año (primavera, verano, otoño, invierno):");
        string estacion = Console.ReadLine().ToLower();

        // Validar que la estación ingresada sea válida
        if (estacion == "primavera" || estacion == "verano" || estacion == "otoño" || estacion == "invierno")
        {
            // Definir el rango de fechas para cada estación (pueden variar según el país)
            string rangoFechas = ObtenerRangoFechas(estacion);
            Console.WriteLine($"El rango de fechas para {estacion} es: {rangoFechas}");
        }
        else
        {
            Console.WriteLine("Estación no válida. Por favor, ingrese una estación válida.");
        }
    }

    static string ObtenerRangoFechas(string estacion)
    {
        switch (estacion)
        {
            case "primavera":
                return "23 de septiembre al 20 de diciembre";
            case "verano":
                return "21 de diciembre y 20 de marzo";
            case "otoño":
                return "21 de marzo y 20 de junio";
            case "invierno":
                return "21 de junio y 22 de septiembre";
            default:
                return "Error: estación no reconocida";
        }
    }
}

