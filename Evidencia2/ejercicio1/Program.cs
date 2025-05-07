/*Realizar un programa que me permita mostrar en la pantalla lo siguiente: 
a.	Tu nombre es (nombre completo).
b.	Tu edad es.
c.	Tu dirección es.
*/

string Nombre, Direccion;
int Edad;

Console.WriteLine("Ingresa tu nombre completo: ");
Nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu edad: ");
Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa tu dirección: ");
Direccion = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine($"Tu nombre es: {Nombre}");
Console.WriteLine($"Tu edad es: {Edad}");
Console.WriteLine($"Tu dirección es: {Direccion}");