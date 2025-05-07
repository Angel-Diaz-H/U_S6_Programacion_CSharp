/*
Realizar un programa que determine si un número es mayor a 0, menor a 0 o igual a 0.
*/

Console.WriteLine("Programa para determinar si un número es mayor, menor o igual a 0.");

// Entrada
static int entrada()
{
    Console.Write("Ingresa un número: ");
    return Convert.ToInt32(Console.ReadLine());
}

// Proceso
static string proceso(int numero)
{
    if (numero > 0)
        return "El número es mayor a 0.";
    else if (numero < 0)
        return "El número es menor a 0.";
    else
        return "El número es igual a 0.";
}

// Mostrar resultado
static void MostrarResultado(string resultado)
{
    Console.WriteLine(resultado);
}

int numero = entrada();
string resultado = proceso(numero);
MostrarResultado(resultado);

Console.ReadKey();