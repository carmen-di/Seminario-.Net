/*10) Verificar con un par de ejemplos si la sección opcional [:formatString] de formatos compuestos redondea 
o trunca cuando se formatean números reales restringiendo la cantidad de decimales. Plantear los ejemplos con 
cadenas de formato compuesto y con cadenas interpoladas.*/

double num = 10.888;

Console.WriteLine($"Valor = {num:0.0}");  // Imprime: Valor = 10.9
Console.WriteLine($"Valor = {num:0.00}"); // Imprime: Valor = 10.89
Console.WriteLine($"Valor: {num:0.000}"); // Imprime: Valor = 10.888