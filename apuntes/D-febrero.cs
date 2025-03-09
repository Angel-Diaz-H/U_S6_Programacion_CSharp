//Apuntes de Diego, febrero 2025.
/*Procedimientos y Funciones */

/*La razón de porqué implementar las Funciones: encapsular (es código que se pueda reutilizar y hacer menos lineas de código) Estan obligadas a
NOTIFICAR un valor (Saber que pasó algo).

Los procedimiento tienen como finalidad realizar acciones pero no esta olbigado a avisar que se realizó */

/*En C# no importa en donde pongas las funciones (a diferencia de python que deben estar arriba) */

//Bloque Principal -> Solo lo manda a llamar
/*Aquí se recolectan los datos */
int Numero1 = 9;
int Numero2 = 10;

Suma(Numero1, Numero2); //Es el llamado del procedimiento (estos son ARGUMENTOS, los de static void son PARAMETROS)
Resta(Numero1,Numero2);
Resta(20, 90); //Sale -70 (Se esta reutilizando el código)
Divi(Numero1, Numero2);
Multi(Numero1, Numero2);

Console.ReadKey();
//////

//Procedimiento ->Ejecuta
/*Debes aprender a delegar funciones */
//-> La P no es necesaria, es solo para saber si es un parametro (Se sabe que es un procedimiento pq es VOID y no regresa nada)
static void Suma(int PNumero1, int PNumero2 ) 
{
    Console.WriteLine($"La suma es: {Numero1 + Numero2}");
}

static void Resta(int PNumero1, int PNumero2 ) 
{
    Console.WriteLine($"La resta es: {Numero1 - Numero2}");
}

static void Divi(int PNumero1, int PNumero2 ) 
{
    Console.WriteLine($"La división es: {Numero1 / Numero2}");
}

static void Multi(int PNumero1, int PNumero2 ) 
{
    Console.WriteLine($"La multiplicación es: {Numero1 * Numero2}");
}

//Función -

int Numero1 = 9;
int Numero2 = 10;

Console.WriteLine(Suma(Numero1, Numero2)); //Para que se vea se debe mandar a imprimir

Console.ReadKey();

static String Suma (int PNumero1, int PNumero2 ) 
{
    return $"La suma es: {Numero1 + Numero2}";
}


//Otra forma de hacerlo (auque no correcta, a menos que tenga más usos)
int Numero1 = 9;
int Numero2 = 10;

string Resultado = Suma(Numero1, Numero2);
Console.WriteLine(Resultado); //Nadamas sirve para almacenar, tiene un periodo de vida corto

Console.ReadKey();

static String Suma (int PNumero1, int PNumero2 ) 
{
    return $"La suma es: {Numero1 + Numero2}";
}

///////////////////////////
int Numero1 = 9;
int Numero2 = 10;

Console.WriteLine($"La suma es: {Suma(Numero1, Numero2)}");

Console.ReadKey();

static int Suma (int PNumero1, int PNumero2 ) 
{
    return (PNumero1 + PNumero2};
}


///////////////////////////

Console.WriteLine(Operaciones(10, 30, 1)); //El tercer parametro determina que acción va a realizar
Console.WriteLine(Operaciones(20, 20, 1));
Console.WriteLine(Operaciones(5, 9, 1));

Console.ReadKey();
///Las funciones no deben tener multiples salidas (solo un return)

Static string Operaciones(int PNumero1, int PNumero2, int POpc)
    
    string Resultado = "";
    switch (POpc)
    {
        case 1:
            Resultado = $"La suma es: {PNumero1 + PNumero2}";
            break;
        case 2:
            Resultado = $"La resta es: {PNumero1 - PNumero2}";
            break;
         case 3:
            Resultado = $"La división es: {PNumero1 / PNumero2}";
            break;
        case 4:
            Resultado = $"La multiplicación es: {PNumero1 * PNumero2}";
            break;
    }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 7 de Febrero del 2025
/*Bussiness Logic (Reglas de negocio): el comportamiento de algo */
//El código principal no debe hacer nada del proceso

//Regla de negocio: Los nombres solo pueden tener letras
string Nombre, APaterno, AMaterno;
int Edad;

Console.WriteLine("Ingresa tu nombre:");
Nombre = Console.Readline();

Console.WriteLine("Ingresa tu apellido paterno:");
APaterno = Console.Readline();

Console.WriteLine("Ingresa tu apellido materno:");
AMaterno = Console.Readline();

Console.WriteLine("Ingresa tu Edad:");
Edad = Console.Readline();

//Console.WriteLine(ValidaTexto(Nombre));

bool RNombre = ValidaTexto(Nombre);
bool RAPaterno = ValidaTexto(APaterno);
bool RAMaterno = ValidaTexto(AMaterno);
bool REdad = ValidaEdad(Edad);

if (!RNombre && !RAPaterno && !RAMaterno && REdad)
{
    Console.WriteLine("INFORMACIÓN GUARDADA CON ÉXITO");
}
else
{
    Console.WriteLine("Lista de Errores");
    if (RNombre)
    {
        Console.WriteLine("*Nombre");
    }
    if (RAPaterno)
    {
        Console.WriteLine("*Apellido Paterno");
    }
    if (RAMaterno)
    {
        Console.WriteLine("*Apellido Materno");
    }
    if (REdad)
    {
        Console.WriteLine("* Edad");
    }        
}

Console.ReadKey();

//Función
///Sirve como alerta para avisar algun error (1 es malo, 0 esta bien)
static bool ValidaTexto(string PTexto)
{
    bool Resultado = false;

    foreach(char Letra in Ptexto.Replace(" ","")) // .Replace Quita los espacios y junta todo (Por ejemplo en 2 nombres o un apellido compuesto)
    {
        //Console.WriteLine(Letra); //(Aquí sale cada letra de manera vertical)
        if (!char.IsLetter(Letra))
        {
            Resultado = true;
            break; //El break es para que si encuentra 1 se active (aunque haya más después)
        }
    }

    return Resultado;    
}

static bool ValidaEdad(int PEdad)
{
    bool Resultado = false;

    foreach(char Numero in PEdad) 
    {
        if (!char.IsDigit(Numero)) //Ver si el int funciona o se usa otra cosa (EJ. char para string)
        {
            Resultado = true;
            break; //El break es para que si encuentra 1 se active (aunque haya más después)
        }
    }

    return Resultado;    
}


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 13 de Febrero del 2025

/*Colecciones de datos o Estructuras de datos: se emplean cuando necesitas cierta cantidad de información (para no crear muchas variables) 
Listas: se guía por los indices (index),m en c# se debe definir con precisión de que forma se va a trabajar
Tuplas (en c# se llaman enumerables) 
 */

//Aquí se define la lista, se usa camel keys (en minusculas)
List<string> lstNombres = ["Lorena", "Juan","Pedro"]; //Se puede crear vacías o con valores

//Console.WriteLine(lstNombres); Solo te explica que características tiene

foreach (string lst in lstNombres) //Foreach: recurre conjunto de caracteres o listas, hace un recorrido por valores
{
    Console.WriteLine(lst);   //Imprime todos los nombres 
}

//Aquí le fuimos AGREGANDO, anteriormente ya estaban los valores predeterminados

List<string> lstNombres = [];

lstNombres.Add("Lorena");
lstNombres.Add("Juan");
lstNombres.Add("Pedro");

foreach (string lst in lstNombres) 
{
    Console.WriteLine(lst);   
}

//Ahora son numéricas
List<int> lstNumeros = [4,5,6];

foreach (var lst in lstNumeros) 
{
    Console.WriteLine(lst);   
}

//Si guardamos un valor cadena (dentro de la lista de numeros) dará error
/*Los valores de las listas deben ser HOMOGÉNEOS */

//Programa en que el usuario determinará cuántos números deseara evaluar, de esos números que ingreso deberemos decir cuales son PARES

//Números Pares
List<int> lstNumeros = [];
List<int> lstNumPares = [];

int Cantidad;
int Numero; 

Console.WriteLine("¿Cuántos números se van a evaluar?");
Cantidad = Convert.ToInt32(Console.Readline());

for (int Cont = 1; Cont <= Cantidad; Cont++)
{
    Console.WriteLine("Escribe un número para añadir");
    Numero = Convert.ToInt32(Console.Readline());
    
    lstNumeros.add(Numero);
}

Console.WriteLine("Los números pares son: ");

foreach (var lst in lstNumeros) 
{
    if (lst % 2 == 0 )
    {
        lstNumPares.add(lst);

        Console.WriteLine(lst);
    }

}

//Vocales
//Usuario desea cuántas letras desea ingresar y el programa buscará cuántas vocales hay, se despliegan las vocales en el orden en que estan 
//Usar ifs anidados
List<char> lstLetras = [];
List<char> lstVocales = [];

/*List<char> lstLetras = new List<char>();
List<char> lstVocales = new List<char>(); */

int Cantidad;
char Letra; 

Console.WriteLine("¿Cuántos letras se van a evaluar?");
Cantidad = Convert.ToInt32(Console.Readline());

for (int Cont = 0; Cont <= Cantidad; Cont++)
{
    Console.WriteLine("Escribe una letra para añadir");
    Letra = Console.Readline().ToLower();
    
    lstLetras.add(Letra);

    if (Letra == "a" || Letra == "e" || Letra == "i" || Letra == "o" || Letra == "u" )
    {
        lstVocales.add(Letra)
    }
}

Console.WriteLine("Las vocales son: ");

foreach (var lst in lstVocales) 
{
    Console.WriteLine(lst);
}

//Ejercicio 3
/*Hacer lo mismo, mostrar la lista original y decir cuántos pares hubo y cuántos impares tuvo 
"Se capturó esto y encontre estos pares, encontre estos impares"*/

List<int> lstNumeros = [];
List<int> lstNumPares = [];
List<int> lstNumImpares = [];

int Cantidad;
int Numero; 

Console.WriteLine("¿Cuántos números se van a evaluar?");
Cantidad = Convert.ToInt32(Console.Readline());

for (int Cont = 0; Cont <= Cantidad; Cont++)
{
    Console.WriteLine("Escribe un número para añadir");
    Numero = Convert.ToInt32(Console.Readline());
    
    lstNumeros.add(Numero);
}

foreach (int lst in lstNumeros) 
{
    if (lst % 2 == 0 )
    {
        lstNumPares.add(lst);
    }
    else
    {
        lstNumImpares.add(lst)
    }

}

Console.WriteLine("Se capturaron estos números: ");

foreach (var lst in lstNumeros) 
{
    Console.WriteLine(lst);
}

Console.WriteLine("Estos son los pares: ");

foreach (var lst in lstNumPares) 
{
    Console.WriteLine(lst);
}

Console.WriteLine("Estos son los impares: ");

foreach (var lst in lstNumImpares) 
{
    Console.WriteLine(lst);
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////14 de Febrero del 2025

/*Otra forma de realizar el ejercicio 3 */
//Expresiones lamba o linQ
List <int> lstNumeros = [4,5,6,59,90,19,45];
/* Forma tradicional
int CParte = 0;
int CImparte = 0;

foreach (int lst in lstNumeros)
{
    if (lst % 2 == 0)
    {
        CParte +=1;
    }
    else
    {
        CImparte +=1;
    }
}

 */
/*Forma mejor (parece BD) Lamba: se usa solo para las colecciones, es como foreach pero más efectivo*/
var CParte = lstNumeros.Where(lst => lst % 2 == 0).Count();
var CImparte = lstNumeros.Where(lst => lst % 2 != 0).Count();

Console.WriteLine($"Pares: {CParte}");
Console.WriteLine($"Impares: {CImparte}");

/*Hacer programa que pida al usuario ingresar n calificaciones, a partir de esas calificaciones sacar promedio, 
si es mayor o igual a 70 indicar que paso el semestre, sino pues ponerle Reprobado */

List<int> lstCalificaciones = [];

int Cantidad, Calificacion;
int Suma = 0;

Console.WriteLine("¿Cuántas calificaciones se van a evaluar?");
Cantidad = Convert.ToInt32(Console.Readline());

for (int Cont = 0; Cont <= Cantidad; Cont++)
{
    Console.WriteLine("Escribe una calificación para añadir");
    Calificacion = Convert.ToInt32(Console.Readline());
    
    lstCalificaciones.add(Calificacion);
}

/*foreach(int lst in lstCalificaciones)
{
    Suma = lst+Suma;
} */

//Se puede hacer esto en las listas
Suma = lstCalificaciones.Sum();
Promedio = lstCalificaciones.Average();
Minimo = lstCalificaciones.Min();
Maximo = lstCalificaciones.Max();

var CAprobado = lstCalificaciones.Where(lst => Suma() / Cantidad); //(Puede estar mal)

if (CAprobado >= 70)
{
    Console.WriteLine("Aprobaste!");
}
else
{
    Console.WriteLine("Reprobaste!");

}

//Usuario hace lo mismo (colección) al final arroje un resumen, cuantas a, cuantas e, cuantas i, cuantas o, cuantas u
/*
a:2
e:3
i:2
o:5
u:1 */

List<char> lstLetras = [];
List<char> lstVocales = [];

char Letra;
int Cantidad;

Console.WriteLine("¿Cuántas letras se van a evaluar?");
Cantidad = Convert.ToInt32(Console.Readline());

for (int Cont = 0; Cont <= Cantidad; Cont++)
{
    Console.WriteLine("Escribe una letra para añadir");
    Letra = Convert.ToInt32(Console.Readline());
    
    lstLetras.add(Letra);
}

if (Letra == "a" || Letra == "e" || Letra == "i" || Letra == "o" || Letra == "u" )
{
    lstVocales.add(Letra)
}



var CA = lstLetras.Where(lst => lstLetras Like ("a") || lstLetras Like ("A")).Count(); 
var CE = lstLetras.Where(lst => lstLetras Like ("e") || lstLetras Like ("E")).Count(); 
var CI = lstLetras.Where(lst => lstLetras Like ("i") || lstLetras Like ("I")).Count(); 
var CO = lstLetras.Where(lst => lstLetras Like ("o") || lstLetras Like ("O")).Count(); 
var CU = lstLetras.Where(lst => lstLetras Like ("u") || lstLetras Like ("U")).Count(); 

Console.WriteLine($"a: {CA}");
Console.WriteLine($"e: {CA}");
Console.WriteLine($"i: {CA}");
Console.WriteLine($"o: {CA}");
Console.WriteLine($"u: {CA}");


//Ejercicio 3
/*Obtener promedio de edad y de ahí mostrar, de 12 a 20 es población joven, 21 a 25 adolescente, 26 a 40 son adultos, 41 o más son Adulto Mayor 
(Buscar si se puede usar between
Capturar las edades que sean*/

/*N cantidad de edades, hacer promedio (average) y dependiendo lo que salga mostrar "La población es: x */
List<int> lstEdades = [];

int Cantidad, Edad;

Console.WriteLine("¿Cuántas calificaciones se van a evaluar?");
Cantidad = Convert.ToInt32(Console.Readline());

for (int Cont = 0; Cont <= Cantidad; Cont++)
{
    Console.WriteLine("Escribe una calificación para añadir");
    Edad = Convert.ToInt32(Console.Readline());
    
    lstEdades.add(Edad);
}

Promedio = lstEdades.Average();

