/*
11.	Realizar un programa que calcule el área de un rectángulo. 
*/

Console.WriteLine("Programa para calcular el área de un rectángulo");

//Entrada, proceso y salida.
static (double, double) entrada(){
    Console.Write("Ingresa la base del rectángulo: ");
    double baseRectangulo = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa la altura del rectángulo: ");
    double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
    return (baseRectangulo, alturaRectangulo);
}

static double proceso(double baseRectangulo, double alturaRectangulo){
    // área = base * altura
    return baseRectangulo * alturaRectangulo;
}

static void MostrarResultado(double area){
    Console.WriteLine($"El área del rectángulo es: {area}.");
}

(double baseRectangulo, double alturaRectangulo) = entrada();
double area = proceso(baseRectangulo, alturaRectangulo);
MostrarResultado(area);

Console.ReadKey();