/*
Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola.
Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
*/

Console.WriteLine("Escriba el numero que desea multiplicar");
int numero = Convert.ToInt32(Console.ReadLine());

int multiplicador = 1;

while (multiplicador <= 10)
{
    Console.WriteLine(numero + " x " + multiplicador + " = " + (numero * multiplicador));
    multiplicador++;
}

Console.WriteLine("Fin");