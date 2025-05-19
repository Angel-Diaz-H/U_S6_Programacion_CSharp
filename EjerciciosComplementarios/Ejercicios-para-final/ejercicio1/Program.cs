// Suma de dos números enteros.

static int RecibeNumeros(int num1, int num2)
{
    return num1 + num2;
}

static void SolicitarDatos()
{
    Console.WriteLine($"Ingresa el primer número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Ingresa el segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    int Resultado = RecibeNumeros(num1, num2);

    Console.WriteLine($"La suma de {num1} y {num2} es: {Resultado}");
}

SolicitarDatos();