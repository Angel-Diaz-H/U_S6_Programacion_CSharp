//Función.
static bool NumeroPar(int Numero)
{
    if (Numero % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void SolicitarNumero()
{
    Console.WriteLine("Ingresa el número a evaluar: ");
    int Numero = int.Parse(Console.ReadLine());
    if (NumeroPar(Numero) == true)
    {
        Console.WriteLine($"El número {Numero} es par.");
    }
    else
    {
        Console.WriteLine($"El número {Numero} es impar.");
    }
}

SolicitarNumero();