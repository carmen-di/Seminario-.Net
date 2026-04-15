/*8) Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué circunstancias es 
preferible utilizar StringBuilder en lugar de utilizar string? Implementar un caso de ejemplo en el que el 
rendimiento sea claramente superior utilizando StringBuilder en lugar de string y otro en el que no.

El objeto String es inmutable. Cada vez que se usa uno de los métodos de la clase System.String, se crea un objeto 
de cadena en la memoria, lo que requiere una nueva asignación de espacio para ese objeto. En las situaciones en las 
que es necesario realizar modificaciones repetidas en una cadena, la sobrecarga asociada a la creación de un objeto 
String puede ser costosa.

La clase System.Text.StringBuilder se puede usar para modificar una cadena sin crear un objeto. Por ejemplo, el uso
de la clase StringBuilder puede mejorar el rendimiento al concatenar muchas cadenas en un bucle.

Se debe usar String:
- Cuando la cantidad de cambios que su aplicación realizará en una cadena es pequeña.
- Cuando está realizando un número fijo de operaciones de concatenación.
- Cuando se realizan operaciones de búsqueda extensas al construir la cadena.

Se debe usar StringBuilder:
- Cuando espera que su aplicación realice un número desconocido o una cantidad significativa de cambios en una cadena.

using System.Text; //StringBuilder esta definido en el espacio System.Text, por eso escribo esto. */

//Ejemplo
using System.Text;

string st = "Numeros del 1 al 1000: "; 
for (int i = 0; i < 1000 ; i++) {
    st += i.ToString() + ""; 
}

StringBuilder num = new StringBuilder("Numeros del 1 al 1000: ");
for (int i = 1; i < 1000; i++)
{
    num.Append(i.ToString());
}
Console.WriteLine(num);

