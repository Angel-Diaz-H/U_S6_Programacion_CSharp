/*
6.	Realizar un programa que obtenga el cuadrado de un número. 
*/

Console.WriteLine("Programa para obtener el cuadrado de un número.");

int num1 = solicitarInfo();

static int solicitarInfo(){
	Console.Write("Ingresa el número: ");
	return Convert.ToInt32(Console.ReadLine());	
}

static void mostrarInfo(int Pnum1){
	Console.WriteLine($"El cuadrado del número {Pnum1} es: {Pnum1 * Pnum1}");
}

mostrarInfo(num1);

Console.ReadKey();