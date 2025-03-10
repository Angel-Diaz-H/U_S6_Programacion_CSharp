/* Descripción:
Lista de nombres

Crea una lista de nombres.
Agrega al menos 5 nombres.
Imprime todos los nombres.
Pregunta al usuario un nombre, si sí agregarlo.
Eliminar el primer nombre.
Vuelve a imprimir la lista actualizada.
*/

List<string> LNombres = new List<string>();

for (int i = 1; i<=5; i++){
	Console.Write($"Ingresa el nombre {i}: ");
	string Nombre = Console.ReadLine();
	LNombres.Add(Nombre);
}

Console.WriteLine("Los nombres ingresados son: ");
foreach (string Nombre in LNombres){
	Console.Write($"[{Nombre}]");
}

Console.WriteLine();

Console.Write("¿Desea agregar un nombre? (S/N): ");

if (Convert.ToChar(Console.ReadLine().ToUpper()) == 'S'){
	Console.Write("Ingrese el nombre: ");
	string Nombre = Console.ReadLine();
    LNombres.Add(Nombre);
}

LNombres.RemoveAt(0);

Console.WriteLine("¡Se ha eliminado el primer nombre y se ha agregado uno nuevo!");

Console.WriteLine("Lista de nombres actualizados:");

foreach (string nombre in LNombres){
	Console.Write($"[{nombre}]");
}

Console.ReadKey();