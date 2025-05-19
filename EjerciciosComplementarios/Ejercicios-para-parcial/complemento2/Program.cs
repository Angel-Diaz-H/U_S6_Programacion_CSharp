/*
Escribe un programa que sume todos los números positivos ingresados por el usuario. El programa debe dejar de pedir números cuando el usuario ingrese un número negativo.
*/

Console.WriteLine("Programa para recibir números positivos.")

int i = 1, suma = 0;

while (i == 1){
    Console.Write("Ingresa un número positivo entero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    if (num1 < 0){
        Console.WriteLine("¡Haz ingresado un valor negativo. El programa ha finalizado!");
        i = 0;
    }
    else{
        suma += num1;
        Console.WriteLine($"El número ingresado es: {num1}");
    }

    Console.WriteLine($"La suma de los valores positivos es: {suma}");
}