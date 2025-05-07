/*
Realizar un programa que genere el promedio de 5 materias que el usuario ingrese. Nota: Si el promedio está entre 60 y 100, deberá indicar que el estudiante APROBÓ el semestre, de lo contrario indicar que NO APROBÓ.
*/

Console.WriteLine("Programa para calcular el promedio de 5 materias y determinar si el estudiante aprobó.");

// Entrada
static double[] entrada()
{
    double[] calificaciones = new double[5];
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Ingresa la calificación de la materia {i + 1}: ");
        calificaciones[i] = Convert.ToDouble(Console.ReadLine());
    }
    return calificaciones;
}

// Proceso
static (double, string) proceso(double[] calificaciones)
{
    double promedio = 0;
    foreach (double calificacion in calificaciones)
    {
        promedio += calificacion;
    }
    promedio /= calificaciones.Length;

    // Si el resultado es mayor o igual a 60 y menor o igual que 100, aprobó, si no es así, no aprobó.
    string resultado = promedio >= 60 && promedio <= 100 ? "aprobó el semestre" : "no aprobó el semestre";
    return (promedio, resultado);
}

// Mostrar resultado
static void MostrarResultado(double promedio, string resultado)
{
    Console.WriteLine($"El promedio es: {promedio}.");
    Console.WriteLine($"El estudiante {resultado}.");
}

double[] calificaciones = entrada();
(double promedio, string resultado) = proceso(calificaciones);
MostrarResultado(promedio, resultado);

Console.ReadKey();