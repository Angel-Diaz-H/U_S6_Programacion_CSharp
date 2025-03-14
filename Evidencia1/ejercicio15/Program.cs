//15. Realizar un programa que convierta de dólares a pesos.

Console.WriteLine("Programa para convertir de dólares a pesos");

//Entrada, proceso y salida.
static (double, double) entrada() {
    Console.Write("Ingresa la cantidad en dólares: ");
    double dolares = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa el tipo de cambio (1 dólar a cuántos pesos equivale): ");
    double tipoCambio = Convert.ToDouble(Console.ReadLine());
    return (dolares, tipoCambio);
}

static double proceso(double dolares, double tipoCambio) {
    // conversión = dólares * tipo de cambio
    return dolares * tipoCambio;
}

static void MostrarResultado(double pesos) {
    Console.WriteLine($"El equivalente en pesos es: {pesos}.");
}

(double dolares, double tipoCambio) = entrada();
double pesos = proceso(dolares, tipoCambio);
MostrarResultado(pesos);

Console.ReadKey();