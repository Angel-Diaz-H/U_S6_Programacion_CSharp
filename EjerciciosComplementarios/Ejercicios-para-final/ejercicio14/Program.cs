//Palíndromo.

static void SolicitarDatos()
{
    Console.WriteLine("Ingresa la palabra: ");
    string palabra = Console.ReadLine();

    bool esPalindromo = EvaluarPalindromo(palabra);

    if (esPalindromo)
    {
        Console.WriteLine($"La palabra {palabra} sí es palíndromo.");
    }
    else
    {
        Console.WriteLine($"La palabra {palabra} no es palíndromo.");
    }
}

static bool EvaluarPalindromo(string Fpalabra)
{
    string palabraLimpia = Fpalabra.Replace(" ", "").ToLower();
    char[] arr = palabraLimpia.ToCharArray();
    Array.Reverse(arr);
    string palabraInvertida = new string(arr);

    return palabraLimpia == palabraInvertida;
}

SolicitarDatos();