//Apuntes de Diego, en enero 2025.
int Talla, Precio;
string Color;

Color = "Rojo";
Talla = "26";
Precio = "1300";

/*If simple */
/* if (Color == "Rojo" || Talla <= 27)
{
    Console.WriteLine("Comprar");
}
else
{
    Console.WriteLine("No Comprar");
} */

if (Color == "Rojo" && Talla <= 27 && Precio <= 1200) /*Aquí no cumpliría por el precio */
{
    Console.WriteLine("Comprar");
}
else
{
    Console.WriteLine("No Comprar");
}





/*If compuesto */

string Letra;

/*Se podría también usar un if simple con or */

if (Letra == "a" || Letra = "e")
{
    Console.WriteLine("Es una vocal")
}
else
{
    Console.WriteLine("No es una vocal")
}

/*If compuesto hecho correctamente pq lleva a un lugar distinto */
if (Letra == "a")
{
    Console.WriteLine("Es una vocal A");
}
else if (Letra = "e" )
{
    Console.WriteLine("Es una vocal E");
}
else
{
    Console.WriteLine("No es una vocal");
}




/*If anidado: Son los más raros, permiten llegar a una decisión muy particular, puede ir de más a más (segmentando) */





/*Switch */
switch (Letra)
{
    case "a"; //Letra == "a"
        Console.WriteLine("Es una vocal");
        break;
    case "e";
        Console.WriteLine("Es una vocal");
        break;
    case "i";
        Console.WriteLine("Es una vocal");
        break;
    case "o";
        Console.WriteLine("Es una vocal");
        break;
    case "u";
        Console.WriteLine("Es una vocal");
        break;
    default: // Else
        Console.WriteLine("No es una vocal");
        break;
}

/*Actividad CONDICIONALES 30 de Enero 2025 */

/*Ejercicio1 */
int numero;
Console.WriteLine("Ingresa un número: ")
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("El número de es mayor a cero.");
}
else if (numero < 0)
{
    Console.WriteLine("El número de es menor a cero.");
}
else
{
    Console.WriteLine("El número es igual a cero.");
}

/*Ejercicio2*/
double calif1, calif2, calif3, calif4, calif5, suma, promedio; 

Console.WriteLine("Ingresa una calificación: ");
calif1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa otra calificación: ");
calif2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa otra calificación: ");
calif3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa otra calificación: ");
calif4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa otra calificación: ");
calif5 = Convert.ToInt32(Console.ReadLine());

suma = calif1 + calif2 + calif3 + calif4 + calif5;
promedio = suma / 5;

If(promedio >= 60 && promedio <= 100)
{
    Console.WriteLine($"El promedio es {promedio}. El estudiante aprobó.")
}
else
{
    Console.WriteLine($"El promedio es {promedio}. El estudiante no aprobó.")
}

/*Ejercicio3 */
int num1, num2, num3;
Console.WriteLine("Ingresa el primer número: ")
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa el segundo número: ")
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa el tercer número: ")
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 !=  num2 && num1 != num3 && num2 != num3)
{
    if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.WriteLine($" El número mayor es: {num1}");
        }
        else
        {
            Console.WriteLine($" El número mayor es: {num3}");
        }
    }
    else
    {
        if (num2 > num3)
        {
            Console.WriteLine($" El número mayor es: {num2}");
        }
        else
        {
            Console.WriteLine($" El número mayor es: {num3}");
        }
    }
}
else
{
    Console.WriteLine("Los números deben ser distintos");
}

/*Ejercicio4 */

int num1, num2, num3, menor;

Console.WriteLine("Ingresa el primer número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el tercer número: ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num2 < menor)
{
    menor = num2;
}

if (num3 < menor)
{
    menor = num3;
}

Console.WriteLine($"El menor es: {menor}");

/*Ejercicio5*/

int numeropar;

Console.Write("Ingresa un número: ");
numeropar = Convert.ToInt32(Console.ReadLine());

if (numeropar % 2 == 0)
{
    Console.Write("El número es par");
}
else
{
    Console.Write("El número NO es par");
}

Console.ReadKey();

/*Ejercicio6 */
string letra;
Console.Write("Ingresa una letra: ");
letra = Console.ReadLine();

switch (letra)
{
    case "a"; //Letra == "a"
        Console.WriteLine("Es una vocal");
        break;
    case "e";
        Console.WriteLine("Es una vocal");
        break;
    case "i";
        Console.WriteLine("Es una vocal");
        break;
    case "o";
        Console.WriteLine("Es una vocal");
        break;
    case "u";
        Console.WriteLine("Es una vocal");
        break;
    default: // Else
        Console.WriteLine("No es una vocal");
        break;
}

Console.ReadKey();











/*Instrucciones iterativas: algo que ocupe iterar/ciclos */

/*Primer sección inicio de contador| Segunda sección. Condición a cumplir para que siga el ciclo| 
Tercera parte: los incrementos que va a tener el contador por cada iteración  */

/*Sale 10 veces .- Hola Grupo 61*/
for (init Cont = 1; Cont <= 10; Cont++)
{
    Console.WriteLine($"{Cont}.- Hola Grupo 61")
}
/*Usar CONT fuera del dominio no sirve */
Console.ReadKey();

for (init Cont = 1; Cont <= 10; Cont+=2) /*Salta de 2 en 2 Ej. 1, 3, 5, 7, 9 */
{
    Console.WriteLine($"{Cont}.- Hola Grupo 61")
}

Console.ReadKey();

















//For ascendente y descendente

//Asc (Va del 1 al 10)
for (init Cont = 1; Cont <= 10; Cont++)
{
    Console.WriteLine($"{Cont}.- Hola Grupo 61")
}

Console.WriteLine();

//Desc (Va del 10 al 1)
for (init Cont = 1; Cont >= 1; Cont--) //Los -- son Decrementos
{
    Console.WriteLine($"{Cont}.- Hola Grupo 61")
}

Console.ReadKey();



















//For es más para condiciones con números, while se usa para cadenas
/*While: Prioriza una condicionante siempre que cumpla (sea verdadero)  */

int Cont = 1;

//While debe tener algo para que se detenga, si se queda sin el cont de adentro siempre se hará el ciclo pq cont vale 1
//Usamos el true anteriormente, pero es peligroso pq nunca sabe cuando terminar

//Asc
while(Cont <= 10)
{
    Console.WriteLine($"{Cont}.- Hola Grupo 61");
    Cont++;
}

Console.WriteLine();

//Desc
while(Cont >= 1)
{
    Console.WriteLine($"{Cont}.- Hola Grupo 61");
    Cont--;
}

Console.ReadKey();

//Esto es algo que esta bien pero es mejor evitar
while(true)
{
    if (Cont <= 10)
        break;
}

Console.ReadKey();










/*Ejercicios Iteraciones (For y While) 31 DE ENERO */

//Ejercio1

int suma;

for (init Cont = 1; Cont <= 20; Cont+=2)
{
    Console.WriteLine($"La suma de los números pares (del 1 al 20) es de: {suma}");
}

while()
{
    Console.WriteLine($"La suma de los números pares (del 1 al 20) es de: {suma}");
}

