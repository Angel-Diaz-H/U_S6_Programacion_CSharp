//16. Realizar un programa que convierta de dólares a euros.

Console.WriteLine("Programa para convertir de dólares a euros");

//Entrada, proceso y salida.
static (double, double) entrada() {
    Console.Write("Ingresa la cantidad en dólares: ");
    double dolares = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa el tipo de cambio (1 dólar a cuántos euros equivale): ");
    double tipoCambio = Convert.ToDouble(Console.ReadLine());
    return (dolares, tipoCambio);
}

static double proceso(double dolares, double tipoCambio) {
    // conversión = dólares * tipo de cambio
    return dolares * tipoCambio;
}

static void MostrarResultado(double euros) {
    Console.WriteLine($"El equivalente en euros es: {euros}.");
}

(double dolares, double tipoCambio) = entrada();
double euros = proceso(dolares, tipoCambio);
MostrarResultado(euros);

Console.ReadKey();