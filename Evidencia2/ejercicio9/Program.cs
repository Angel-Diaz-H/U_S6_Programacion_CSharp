/*
9.	Realizar un programa que calcule el área de un círculo.
*/

Console.WriteLine("Programa para calcular el área de un círculo");

//Entrada, proceso y salida.
static double entrada(){
    Console.Write("Ingresa el radio del círculo: ");
    double Pnum1 = Convert.ToDouble(Console.ReadLine());
    return Pnum1;
}

static double proceso(double radio){
    // área = pi * r ^ 2
    return Math.PI * radio * radio;
}

static void MostrarResultado( double PArea){
    Console.WriteLine($"El área del círculo es: {PArea}.");
}

double radio = entrada();
double area = proceso(radio);
MostrarResultado(area);

Console.ReadKey();