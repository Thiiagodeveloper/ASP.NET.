//Este comentario es de una sola linea

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
var primeroNumeroInt = int.Parse(primerNumeroString!);

Console.WriteLine("Por favor ingrese le segundo numero");
var segundoNumeroString = Console.ReadLine();
var segundoNumeroInt = int.Parse(segundoNumeroString!);

var resultSuma = primeroNumeroInt + segundoNumeroInt;
Console.WriteLine("El resultado de la suma es: " + resultSuma);

var resultResta = primeroNumeroInt - segundoNumeroInt;
Console.WriteLine("El resultado de la resta es: " + resultResta);

var resultMultiplicacion = primeroNumeroInt * segundoNumeroInt;
Console.WriteLine("El resultado de la multiplicacion es: " + resultMultiplicacion);

var resultDivision = primeroNumeroInt / segundoNumeroInt;
Console.WriteLine("El resultado de la Divison es: " + resultDivision);