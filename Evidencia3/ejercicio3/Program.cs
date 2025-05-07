/*
Realizar un programa que permita leer tres valores y almacenarlos en las variables Num1, Num2, Num3 respectivamente. El programa debe imprimir cuál es el mayor. Recuerde constatar que los tres valores introducidos por el teclado sean valores distintos.
*/

Console.WriteLine("Programa para determinar el mayor de tres valores distintos.");

// Entrada
static (int, int, int) entrada()
{
    int num1, num2, num3;
    do
    {
        Console.Write("Ingresa el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el tercer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 || num2 == num3 || num1 == num3)
        {
            Console.WriteLine("Los números deben ser distintos. Intenta nuevamente.");
        }
    } while (num1 == num2 || num2 == num3 || num1 == num3);

    return (num1, num2, num3);
}

// Proceso
static int proceso(int num1, int num2, int num3)
{
    if (num1 > num2 && num1 > num3)
        return num1;
    else if (num2 > num1 && num2 > num3)
        return num2;
    else
        return num3;
}

// Mostrar resultado
static void MostrarResultado(int mayor)
{
    Console.WriteLine($"El mayor de los tres números es: {mayor}");
}

(int num1, int num2, int num3) = entrada();
int mayor = proceso(num1, num2, num3);
MostrarResultado(mayor);

Console.ReadKey();