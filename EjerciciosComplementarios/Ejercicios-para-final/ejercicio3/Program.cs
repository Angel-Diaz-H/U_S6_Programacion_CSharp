static (int Celsius, int Fahrenheit) ConvertirCelsiusAFahrenheit()
{
    Console.WriteLine("Ingresa el valor de los grados Celcius (C°): ");
    int Celsius = int.Parse(Console.ReadLine());

    int Fahrenheit = (Celsius * 9 / 5) + 32;
    return (Celsius, Fahrenheit);
}

static void MostrarCelsius()
{
    var (Celsius, Fahrenheit) = ConvertirCelsiusAFahrenheit();
    Console.WriteLine($"La conversión de {Celsius} C° a F° es: {Fahrenheit}");
}

MostrarCelsius();