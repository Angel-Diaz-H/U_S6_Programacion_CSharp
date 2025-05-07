/*
Ingresar por teclado 3 números enteros y mostrar el menor de los 3 números ingresados.
*/

Console.WriteLine("Programa para mostrar el menor de tres números");

// Entrada
static (int, int, int) entrada()
{
    Console.Write("Ingresa el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingresa el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingresa el tercer número: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    return (num1, num2, num3);
}

// Proceso
static int proceso(int num1, int num2, int num3)
{
    if (num1 < num2 && num1 < num3)
        return num1;
    else if (num2 < num1 && num2 < num3)
        return num2;
    else
        return num3;
}

// Mostrar resultado
static void MostrarResultado(int menor)
{
    Console.WriteLine($"El menor de los tres números es: {menor}");
}

(int num1, int num2, int num3) = entrada();
int menor = proceso(num1, num2, num3);
MostrarResultado(menor);

Console.ReadKey();