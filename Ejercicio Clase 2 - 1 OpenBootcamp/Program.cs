/*
Ejercicio 1

Variables Escribe un programa que reciba datos de una persona y genera un mensaje,
usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
*/

Console.WriteLine("Escriba su nombre: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Escriba su apellido: ");
string? apellido = Console.ReadLine();

Console.WriteLine("Escriba su edad: ");
int? edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿Sabe programar? [Si/No]: ");
string? respuestaStr = Console.ReadLine();
bool? respuesta = null;
respuesta = respuestaStr == "Si" ? true : false;

string mensaje = "Su nombre completo es " + nombre + apellido + ", tiene " + edad + " años y " + respuestaStr + " sabe programar.";
Console.WriteLine(mensaje);