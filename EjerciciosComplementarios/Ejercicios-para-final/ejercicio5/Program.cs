//Implementa una función que reciba dos enteros y los multiplique usando solo sumas sucesivas, sin usar el operador *.

static int MultiplicarNumeros()
{
    Console.WriteLine("Ingrese el primer valor: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo valor: ");
    int num2 = int.Parse(Console.ReadLine());

    int i = 0;
    int resultado = 0;
    while (i < num2)
    {
        resultado = resultado + num1;
        i++;
    }
    return resultado;
}

int resultado = MultiplicarNumeros();
Console.WriteLine($"El resultado de multiplicar los números indicado es: {resultado}");