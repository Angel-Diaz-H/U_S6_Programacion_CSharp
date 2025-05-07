/*
8.	Realizar un programa que calcule el perímetro de un cuadrado. 
*/

Console.WriteLine("Programa para calcular el perímetro de un cuadrado");

static double Entrada()
{
    Console.WriteLine("Ingresa el lado del cuadrado: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    return num1;
}

static double Operacion(double Pnum1)
{
    return Pnum1 * 4;
}

static void MostrarResultado(double Pnum1){
    Console.WriteLine($"El perímetro del cuadrado es: {Pnum1}");
}


double num1 = Entrada();
num1 = Operacion(num1);
MostrarResultado(num1);

Console.ReadKey();