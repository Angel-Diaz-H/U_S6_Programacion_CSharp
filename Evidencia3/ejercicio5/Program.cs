/*
Realizar un programa que le pida un valor numérico e indicar si es par o no es par.
*/

Console.WriteLine("Programa para determinar si un número es par o impar");

// Entrada
static int entrada()
{
    Console.Write("Ingresa un número: ");
    return Convert.ToInt32(Console.ReadLine());
}

// Proceso
static string proceso(int numero)
{
    // Si el resultado da 0 es par, si da decimal, es inpar.
    return numero % 2 == 0 ? "El número es par." : "El número es impar.";
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