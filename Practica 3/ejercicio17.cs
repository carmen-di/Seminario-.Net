/*17) Implementar un programa que permita al usuario ingresar números por la consola. Debe ingresarse
un número por línea finalizado el proceso cuando el usuario ingresa una línea vacía. A medida que se
van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos.
Utilizar double.Parse() y try/catch para validar que la entrada ingresada sea un número válido,
en caso contrario advertir con un mensaje al usuario y proseguir con el ingreso de datos.*/

using System.Text.Json.Serialization;

string dato = "ok";
double num = 0;

while (dato != "")
{
    try
    {
        Console.WriteLine("Ingrese un numero");
        dato = Console.ReadLine();

        if (dato != "")
        {
            num = num + double.Parse(dato);
            Console.WriteLine("Suma acumulada {0}", num);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Error, no se ingreso un numero");
    }
}