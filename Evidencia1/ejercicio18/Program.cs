//18. Realizar un programa que convierta de Pesos a euros.

Console.WriteLine("Programa para convertir de Pesos a euros");

//Entrada, proceso y salida.
static (double, double) entrada() {
    Console.Write("Ingresa la cantidad en Pesos: ");
    double pesos = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa el tipo de cambio (1 euro a cuántos pesos equivale): ");
    double tipoCambio = Convert.ToDouble(Console.ReadLine());
    return (pesos, tipoCambio);
}

static double proceso(double pesos, double tipoCambio) {
    // conversión = pesos / tipo de cambio
    return pesos / tipoCambio;
}

static void MostrarResultado(double euros) {
    Console.WriteLine($"El equivalente en euros es: {euros}.");
}

(double pesos, double tipoCambio) = entrada();
double euros = proceso(pesos, tipoCambio);
MostrarResultado(euros);

Console.ReadKey();