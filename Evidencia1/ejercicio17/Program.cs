//17. Realizar un programa que convierta de Pesos a dólares.

Console.WriteLine("Programa para convertir de Pesos a dólares");

//Entrada, proceso y salida.
static (double, double) entrada() {
    Console.Write("Ingresa la cantidad en Pesos: ");
    double pesos = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa el tipo de cambio (1 dólar a cuántos pesos equivale): ");
    double tipoCambio = Convert.ToDouble(Console.ReadLine());
    return (pesos, tipoCambio);
}

static double proceso(double pesos, double tipoCambio) {
    // conversión = pesos / tipo de cambio
    return pesos / tipoCambio;
}

static void MostrarResultado(double dolares) {
    Console.WriteLine($"El equivalente en dólares es: {dolares}.");
}

(double pesos, double tipoCambio) = entrada();
double dolares = proceso(pesos, tipoCambio);
MostrarResultado(dolares);

Console.ReadKey();