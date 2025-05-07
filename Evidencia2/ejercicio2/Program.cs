/*Realizar un programa que pida 2 números al usuario y sume dichos números.
*/

int num1, num2;

Console.WriteLine("Programa para sumar dos valores.");

Console.WriteLine("Ingresa el primer número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine($"El resultado de la suma de {num1} + {num2} es: {num1 + num2}");

Console.ReadKey();