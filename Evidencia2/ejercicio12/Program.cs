/*
12.	Realizar un programa que calcule el área de un triángulo. 
*/

Console.WriteLine("Programa para calcular el área de un triángulo");

//Entrada, proceso y salida.
static (double, double) entrada(){
    Console.Write("Ingresa la base del triángulo: ");
    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa la altura del triángulo: ");
    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
    return (baseTriangulo, alturaTriangulo);
}

static double proceso(double baseTriangulo, double alturaTriangulo){
    // área = (base * altura) / 2
    return (baseTriangulo * alturaTriangulo) / 2;
}

static void MostrarResultado(double area){
    Console.WriteLine($"El área del triángulo es: {area}.");
}

(double baseTriangulo, double alturaTriangulo) = entrada();
double area = proceso(baseTriangulo, alturaTriangulo);
MostrarResultado(area);

Console.ReadKey();