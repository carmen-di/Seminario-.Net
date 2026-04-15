/*16) Analizar el siguiente código. ¿Cuál es la salida por consola? */

int i = 1;
if (--i == 0)
{
    Console.WriteLine("cero");
}
if (i++ == 0)
{
    Console.WriteLine("cero");
}
    Console.WriteLine(i);

/* La salida es:
cero
cero
1
En el primer writeln decrementa primero la variable y después evalúa
En el segundo writeln primero evaluo y después incremento

*/