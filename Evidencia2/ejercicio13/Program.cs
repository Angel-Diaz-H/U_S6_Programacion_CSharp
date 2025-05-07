/*
13.	Realizar un programa que calcule el porcentaje de una cantidad.
*/

Console.WriteLine("Programa para calcular el porcentaje de una cantidad");

//Entrada, proceso y salida.
static (double, double) entrada() {
    Console.Write("Ingresa la cantidad total: ");
    double total = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa el porcentaje a calcular: ");
    double porcentaje = Convert.ToDouble(Console.ReadLine());
    return (total, porcentaje);
}

static double proceso(double total, double porcentaje) {
    // porcentaje de una cantidad = (total * porcentaje) / 100
    return (total * porcentaje) / 100;
}

static void MostrarResultado(double resultado) {
    Console.WriteLine($"El resultado es: {resultado}.");
}

(double total, double porcentaje) = entrada();
double resultado = proceso(total, porcentaje);
MostrarResultado(resultado);

Console.ReadKey();