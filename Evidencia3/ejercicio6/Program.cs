/*
Realizar un programa que determine si una letra ingresada desde teclado es una Vocal o no.
*/
Console.WriteLine("Programa para determinar si una letra es una vocal");

// Entrada
static char entrada()
{
    Console.Write("Ingresa una letra: ");
    return Convert.ToChar(Console.ReadLine().ToLower());
}

// Proceso
static string proceso(char letra)
{
    if ("aeiou".Contains(letra))
        return "La letra es una vocal.";
    else
        return "La letra no es una vocal.";

    /* Alternativa con Switch.
    switch(letra){
    case "a":
        Console.WriteLine("La letra es una vocal.");
        break;
    case "e":
        Console.WriteLine("La letra es una vocal.");
        break;
    case "i":
        Console.WriteLine("La letra es una vocal.");
        break;
    case "o":
        Console.WriteLine("La letra es una vocal.");
        break;
    case "u":
        Console.WriteLine("La letra es una vocal.");
        break;
    defaul:
        Console.WriteLine("La letra no es una vocal.");   
        break;
    }
    */
}

// Mostrar resultado
static void MostrarResultado(string resultado)
{
    Console.WriteLine(resultado);
}

char letra = entrada();
string resultado = proceso(letra);
MostrarResultado(resultado);

Console.ReadKey();