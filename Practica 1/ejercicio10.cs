/*10) Escribir un programa que imprima en la consola todos los múltiplos de 17 o de 29 comprendidos entre 1 y 1000 */

for (int num = 1; num < 1000; num++)
{
    if ((num % 17 == 0) || (num %29 == 0))
    {
        Console.WriteLine(num);
    }
}