/*Escribe un programa que muestre un menú de opciones para realizar diferentes operaciones matemáticas (suma, resta, multiplicación, división). El usuario debe poder seleccionar una de las opciones y luego ingresar dos números para realizar la operación seleccionada. El programa debe usar una estructura switch para manejar las diferentes opciones del menú.*/

//Entrada, operación y salida.
class Program{
    static void Main(){
        while (true) { 
            MenuMostrar();
            int opc = EntradaOpcion();
            if (opc == 5){
                Console.WriteLine("Gracias por visitar!");
                break;
            }
            (double num1, double num2) = EntradaValores();
            double resultado = Operacion(opc, num1, num2)
            Console.WriteLine($"El resultado de la operación es: {resultado}");;
            Console.ReadKey();
        }
    }

    static void MenuMostrar(){
        Console.WriteLine("Ingrese la opción deseada.");
        Console.WriteLine("1. Suma.");
        Console.WriteLine("2. Resta.");
        Console.WriteLine("3. Multiplicación.");
        Console.WriteLine("4. División.");
        Console.WriteLine("5. Salir.");
        Console.WriteLine("Opción: ");
    }

    static int EntradaOpcion(){
        while (true){
            Console.WriteLine("Opción (1-5): ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i >= 1 && i <= 5){
                break;
            }
            else{
                Console.WriteLine("Ingrese un número válido de 1 a 5.");
            }
        }
        return i;    
    }

    static (double, double) EntradaValores(){
        Console.Write("Ingresa el primer valor: ");
        double Pnum1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo valor: ");
        double Pnum2 = Convert.ToDouble(Console.ReadLine());

        return (Pnum1, Pnum2);
    }

    static double Operacion(int POpc, double PNum1, double PNum2){
        double resultado = 0;
        switch (POpc){
            case 1:
                resultado = PNum1 + Pnum2;
                Console.WriteLine("Opción suma.");
                break;
            case 2:
                resultado = PNum1 - Pnum2;
                Console.WriteLine("Opción resta.");
                break;
            case 3:
                resultado = PNum1 * Pnum2;
                Console.WriteLine("Opción multiplicación.");
                break;
            case 4:
                if (Pnum2 != 0){
                    resultado = Pnum1 / Pnum2;
                    Console.WriteLine("Opción división");
                } else {
                    Console.WriteLine("No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Opción salir.");
                break;
        }
        return resultado;
    }

}