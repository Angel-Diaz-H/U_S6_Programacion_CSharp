//20. Realizar un programa que convierta de euros a dólares.

Console.WriteLine("Programa para convertir de euros a dólares");

//Entrada, proceso y salida.
static (double, double) entrada() {
    Console.Write("Ingresa la cantidad en euros: ");
    double euros = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa el tipo de cambio (1 euro a cuántos dólares equivale): ");
    double tipoCambio = Convert.ToDouble(Console.ReadLine());
    return (euros, tipoCambio);
}

static double proceso(double euros, double tipoCambio) {
    // conversión = euros * tipo de cambio
    return euros * tipoCambio;
}

static void MostrarResultado(double dolares) {
    Console.WriteLine($"El equivalente en dólares es: {dolares}.");
}

(double euros, double tipoCambio) = entrada();
double dolares = proceso(euros, tipoCambio);
MostrarResultado(dolares);

Console.ReadKey();