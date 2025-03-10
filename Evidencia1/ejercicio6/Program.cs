class Program
{
    static double calif1, calif2, calif3, promedio;

    static void Main()
    {
        EntradaDatos();
        ProcesarDatos();
        SalidaDatos();
    }

    static void EntradaDatos()
    {
        // Validar la entrada de datos
        calif1 = ObtenerCalificacion("Ingresa la primera calificación: ");
        calif2 = ObtenerCalificacion("Ingresa la segunda calificación: ");
        calif3 = ObtenerCalificacion("Ingresa la tercera calificación: ");
    }

    static double ObtenerCalificacion(string mensaje)
    {
        double calificacion;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out calificacion) || calificacion < 0 || calificacion > 100)
        {
            Console.WriteLine("Por favor, ingresa un valor numérico válido entre 0 y 100.");
            Console.Write(mensaje);
        }
        return calificacion;
    }

    static void ProcesarDatos()
    {
        promedio = (calif1 + calif2 + calif3) / 3;
    }

    static void SalidaDatos()
    {
        Console.WriteLine($"El promedio de las calificaciones es: {promedio:F2}");
        if (promedio >= 60)
            Console.WriteLine("El estudiante aprobó.");
        else
            Console.WriteLine("El estudiante no aprobó.");
    }
}