/*
Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo.
Tienes completa libertad para elegir el formato de la salida.
*/

Console.WriteLine("Comprobador de numeros positivos o negativos.");
Console.WriteLine("Escriba la cantidad de numeros que desea analizar");
int cantidadNumeros = Convert.ToInt32(Console.ReadLine());
int[] listaNumeros = new int[cantidadNumeros];

for (int i = 0; i < cantidadNumeros; i++)
{
    Console.WriteLine("\nNumero " + (i + 1));
    listaNumeros[i] = Convert.ToInt32(Console.ReadLine());
}

int index = 1;
int cantidadPositivos = 0;
int cantidadNegativos = 0;
int cantidadCeros = 0;
foreach (int numero in listaNumeros)
{
    bool esPositivo = numero > 0;
    bool esCero = numero == 0;
    if (esPositivo)
    {
        Console.WriteLine("El numero " + numero + " es positivo.");
        cantidadPositivos++;
    }
    else if (esCero)
    {
        Console.WriteLine("El numero " + numero + " es cero.");
        cantidadCeros++;
    }
    else
    {
        Console.WriteLine("El numero " + numero + " es negativo.");
        cantidadNegativos++;
    }
    index++;
}

Console.WriteLine("\nQueda un total de \nNumeros positivos:" + cantidadPositivos + "\nNumeros negativos:" + cantidadNegativos + "\nCeros:" + cantidadCeros);