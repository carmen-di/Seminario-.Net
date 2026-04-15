/*16) Escribir un programa que reciba una lista de nombres como parámetro por la línea de comandos e imprima por 
consola un saludo personalizado para cada uno de ellos.
a) Utilizando la sentencia for
b) Utilizando la sentencia foreach*/

// usando for
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Hola: " + args[i]);
}

// usando foreach
foreach (string nombre in args)
{
    Console.WriteLine("Hola: " + nombre);
}