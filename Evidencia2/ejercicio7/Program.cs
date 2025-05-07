/*
7.	Realizar un programa que obtenga el área del cuadrado. 
*/

Console.WriteLine("Programa para calcular el área de un cuadrado: ");

static double leerDatos()
{
    double lado;
    Console.Write("Ingrese el valor de un lado");
    lado = Convert.ToDouble(Console.ReadLine());
    return lado;
}

static double operacion(double PLado)
{
    return PLado = PLado * PLado;
}

static void mostrarResultado(double PLado){
    Console.WriteLine($"El área del cuadrado es: {PLado}");
}

double lado = leerDatos();
lado = operacion(lado);
mostrarResultado(lado);

Console.ReadKey();