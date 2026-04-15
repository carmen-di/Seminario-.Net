/* 7) ¿Cuál es la salida por consola del siguiente fragmento de código? ¿Por qué la tercera y sexta línea producen 
resultados diferentes? */

char c1 = 'A';
char c2 = 'A';
Console.WriteLine(c1 == c2); // imprime true, porque compara dos variables del mismo tipo, por lo que compara el 
                             // valor de cada una.
object o1 = c1; 
object o2 = c2;
Console.WriteLine(o1 == o2); // imprime false, porque object es de tipo referencia, por lo que se compara si la variables
                             // tienen la misma referencia, es decir si apuntan al mismo lugar de la heap.

