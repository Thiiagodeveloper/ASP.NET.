//Este comentario es de una sola linea

using System.Diagnostics;
using System.Threading.Channels;

string nombre = "Santiago";
var apellido = "Montero Garcia";

int miNumeroEntero = 100;
int otroNumeroEntero = -500;

float miFloatNumero = 62.36f;

double miDoubleNumero = 96.25;

decimal miDecimalNumero = 324.3m;

byte miByteNumero = 2;

bool statusProducto = true;

string miCadena = "Esta es mi cadena de texto";

char miCarecter = 'A';

const int miConstanteNumerica = 500;

Console.WriteLine("Hello " + nombre + apellido);

//OPERACIONES

Console.WriteLine("Porfavor ingrese su primer numero:");
var primerNumeroString = Console.ReadLine();
//if(primerNumeroString is null || primerNumeroString == "")
//{
//    Console.WriteLine("Ingreso un valor nullo, termino el programa");
//    return;
//}

if (string.IsNullOrEmpty(primerNumeroString) )
{
    Console.WriteLine("El valor es null o vacio");
    return;
}

//Algortimo para evaluar si un texto tiene la nomenclatura de numero
//su es posible convertir texto a numero

//1. Declarr una variable resultado posible
//2. Condicionar si el texto esta realmente escrito en una nomenclatura numerica
//3. En caso de que no sea un numero, entonces termina el programa.
//4. En caso de que si sea un numero entonces continia la ejecucion del programa
//5. 

int primeroNumeroInt = 0;
if( !int.TryParse(primerNumeroString,out primeroNumeroInt))
{
    Console.WriteLine("El valor ingresado no es numero");
    return;
}

if ( primeroNumeroInt >= 100)
{
    Console.WriteLine("Su numero es mayor que 100");
}
else{
    Console.WriteLine("Su numero es menor que 100");
}

if(primeroNumeroInt <= 10)
{
    Console.WriteLine("Es menor que 10");
}
else if( primeroNumeroInt >10 && primeroNumeroInt <= 20)
{
    Console.WriteLine("Es mayor que 10 y menor igual que 20");
}
else
{
    Console.WriteLine("El numero es mayor que 20");
}

//var primeroNumeroInt = int.Parse(primerNumeroString!);

Console.WriteLine("Por favor ingrese le segundo numero");
var segundoNumeroString = Console.ReadLine();

if(string.IsNullOrEmpty(segundoNumeroString))
{
    Console.WriteLine("El segundo numero esta en blanco o nulo");
    return;
}
var segundoNumeroInt = 0;

if(!int.TryParse(segundoNumeroString, out segundoNumeroInt))
{
    Console.WriteLine("El valor ingresado no es null");
}

Console.WriteLine("Selecciona: 1) suma, 2) Resta, 3) Multiplicacion, 4) Divison");
int tipoOpcion = int.TryParse(Console.ReadLine(), out tipoOpcion) ? tipoOpcion : 0;

var total = 0;
switch (tipoOpcion)
{
    case 1: total = primeroNumeroInt + segundoNumeroInt;
        Console.WriteLine($"{primeroNumeroInt} + {segundoNumeroInt} = {total}");
        break;

    case 2: total = primeroNumeroInt - segundoNumeroInt;
        Console.WriteLine($"{primeroNumeroInt} - {segundoNumeroInt} = {total}");
        break;

    case 3:
        total = primeroNumeroInt * segundoNumeroInt;
        Console.WriteLine($"{primeroNumeroInt} * {segundoNumeroInt} = {total}");
        break;

    case 4:
        total = primeroNumeroInt / segundoNumeroInt;
        Console.WriteLine($"{primeroNumeroInt} / {segundoNumeroInt} = {total}");
        break;

    default:
        Console.WriteLine("Ingreo un valor erroneo, debe ingresar un valor del 1 al 4");
        return;
}

