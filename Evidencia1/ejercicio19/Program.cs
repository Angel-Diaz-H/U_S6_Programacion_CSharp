//19. Realizar un programa que convierta de euros a pesos.

Console.WriteLine("Programa para convertir de euros a pesos");

//Entrada, proceso y salida.
static (double, double) entrada() {
    Console.Write("Ingresa la cantidad en euros: ");
    double euros = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa el tipo de cambio (1 euro a cuántos pesos equivale): ");
    double tipoCambio = Convert.ToDouble(Console.ReadLine());
    return (euros, tipoCambio);
}

static double proceso(double euros, double tipoCambio) {
    // conversión = euros * tipo de cambio
    return euros * tipoCambio;
}

static void MostrarResultado(double pesos) {
    Console.WriteLine($"El equivalente en pesos es: {pesos}.");
}

(double euros, double tipoCambio) = entrada();
double pesos = proceso(euros, tipoCambio);
MostrarResultado(pesos);

Console.ReadKey();