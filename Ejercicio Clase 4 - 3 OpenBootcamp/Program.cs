/*
Ejercicio 3 - For

Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y
use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos
que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

** **

** **

Input: 3, 4, 1, relleno = false

Output:

***

* *

* *

***
*/

using System.Drawing;
using System.Text;

Console.WriteLine("Escriba el ancho: ");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escriba el alto: ");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿Relleno? [Si/No]: ");
bool relleno = Console.ReadLine() == "Si" ? true : false;

Console.WriteLine("Escriba la cantidad de rectangulos que desea dibujar: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

StringBuilder rectangulo = new StringBuilder();

for (int i = 0; i< alto; i++)
    {
        rectangulo.AppendLine();
        if (i == 0)
        {
            for (int j = 0; j < ancho; j++)
            {
                    rectangulo.Append("*");
            }
        }

        if(!relleno)
        {
            if(i<alto-1 && i!=0)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (j==0 || j==ancho-1)
                    {
                        rectangulo.Append("*");
                    }
                    else
                    {
                        rectangulo.Append(" ");
                    }
                }
            }
        }
        else
        {
            if (i < alto - 1 && i != 0)
            {
                for (int j = 0; j < ancho; j++)
                {
                    rectangulo.Append("*");
                }
            }
        }

        if(i == alto-1)
        {
            for (int j = 0; j < ancho; j++)
            {
                    rectangulo.Append("*");
            }
        }
    }

for(int j = 0; j<cantidad; j++)
{
    Console.WriteLine(rectangulo.ToString());
}