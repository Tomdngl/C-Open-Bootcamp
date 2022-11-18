/*
Ejercicio 1

Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
*/

using System.Text;

Cliente miCliente = new Cliente("Tomas Esteban Dangelo", "+54 1132024575", "Almirante Brown, Buenos Aires", "tomidngl@gmail.com", true);
Console.WriteLine(miCliente);

public struct Cliente
{
    public Cliente (string nombre, string telefono, string direccion, string email, bool esNuevo)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        EsNuevo = esNuevo;
    }

    public string Nombre { get; set;}

    public string Telefono { get; set;}

    public string Direccion { get; set;}

    public string Email { get; set;}

    public bool EsNuevo { get; set;}

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        string esNuevoStr = EsNuevo == true ? "Si" : "No";
        sb.AppendLine($"Nombre: {this.Nombre} \nTelefono: {this.Telefono} \nDireccion: {this.Direccion} \nEmail: {this.Email} \n¿Es nuevo?: {esNuevoStr}");
        return sb.ToString();
    }
}
