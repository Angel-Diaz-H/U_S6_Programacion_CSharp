/*
10.	Realizar un programa que calcule el perímetro de un círculo.
*/

Console.WriteLine("Programa para calcular el perímetro de un círculo");

//Entrada, proceso y salida.
static double entrada(){
    Console.Write("Ingresa el radio del círculo: ");
    double radio = Convert.ToDouble(Console.ReadLine());
    return radio;
}

static double proceso(double radio){
    // perímetro = 2 * pi * r
    return 2 * Math.PI * radio;
}

static void MostrarResultado(double perimetro){
    Console.WriteLine($"El perímetro del círculo es: {perimetro}.");
}

double radio = entrada();
double perimetro = proceso(radio);
MostrarResultado(perimetro);

Console.ReadKey();