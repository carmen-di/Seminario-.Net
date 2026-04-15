/*9) Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos implementados en 
el ejercicio anterior.

EL tipo DateTime nos permite trabajar con tiempos estandarizados. Podemos definir valores pasados, futuros o recibir 
la información actual. Podemos utilizar distintos formatos predefinidos o definir el nuestro propio.

Para poder medir el tiempo de ejecución con DateTime, debemos establecer dos variables, una al inicio de la suseción
de lineas, y una al final del código a testear; luego realizamos la resta de ambas y exponemos la diferencia.

*/

// Usando string:
DateTime start = DateTime.Now;

string st = "Numeros del 1 al 1000: "; 
for (int i = 0; i < 1000 ; i++) {
    st += i.ToString() + ""; 
}

DateTime end = DateTime.Now;

TimeSpan tiempo = end - start; 
Console.WriteLine("Tiempo transcurrido usando string: " + tiempo);
// Imprime: Tiempo transcurrido usando string: 00:00:00.0091367

// Usando StringBuilder
//using System.Text;

DateTime start = DateTime.Now;

StringBuilder num = new StringBuilder("Numeros del 1 al 1000: ");
for (int i = 1; i < 1000; i++)
{
    num.Append(i.ToString());
}

DateTime end = DateTime.Now;

TimeSpan tiempo = end - start;
Console.WriteLine("Tiempo transcurrido usando StringBuilder: " + tiempo);

// Imprime: // Usando string:
DateTime start = DateTime.Now;

string st = "Numeros del 1 al 1000: "; 
for (int i = 0; i < 1000 ; i++) {
    st += i.ToString() + ""; 
}

DateTime end = DateTime.Now;

TimeSpan tiempo = end - start; 
Console.WriteLine("Tiempo transcurrido usando string: " + tiempo);
// Imprime: Tiempo transcurrido usando string: 00:00:00.0091367

// Usando StringBuilder
//using System.Text;

DateTime start = DateTime.Now;

StringBuilder num = new StringBuilder("Numeros del 1 al 1000: ");
for (int i = 1; i < 1000; i++)
{
    num.Append(i.ToString());
}

DateTime end = DateTime.Now;

TimeSpan tiempo = end - start;
Console.WriteLine("Tiempo transcurrido usando StringBuilder: " + tiempo);

// Imprime: Tiempo transcurrido usando StringBuilder: 00:00:00.0077065