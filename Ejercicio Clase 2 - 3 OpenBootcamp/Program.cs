/*
Ejercicio 3

Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/

//1
int numero = 5;
if(numero >= 18)
{
    Console.WriteLine("El numero es mayor");
};

char caracter = 'a';
if(caracter == 'a')as
{
    Console.WriteLine("El caracter es a");
};

bool a = false;
bool b = true;

if(b && a)
{
    Console.WriteLine("La condicion b y a son ambas verdaderas");
};

if (a || b)
{
    Console.WriteLine("Una de las dos condiciones es verdadera");
};