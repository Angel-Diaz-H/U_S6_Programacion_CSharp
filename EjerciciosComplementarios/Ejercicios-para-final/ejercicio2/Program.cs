static int RecibirEdad()
{
    Console.WriteLine("Ingresa la edad: ");
    int edad = int.Parse(Console.ReadLine());
    return edad;
}

static void EvaluarEdad()
{
    int edad = RecibirEdad();
    if (edad >= 18)
    {
        Console.WriteLine("La persona es mayor de edad.");
    }
    else {
        Console.WriteLine("La persona es menor de edad.");
    }
}

EvaluarEdad();