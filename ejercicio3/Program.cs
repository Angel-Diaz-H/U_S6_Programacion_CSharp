﻿//3. Realizar un programa que pida 2 números al usuario y sume dichos números.

int num1, num2;

Console.WriteLine("Programa para sumar dos valores.");

Console.Write("Ingrese el primer valor: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el segundo valor: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"El resultado de la suma de {num1} + {num2} es {num1 + num2}");

Console.ReadKey();