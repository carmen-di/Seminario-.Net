/*13) Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente expresión.
Tip: observar qué pasa cuando b = 0.
if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b); */

int a = int.Parse(Console.ReadLine());
int b= int.Parse(Console.ReadLine());

if ((b != 0) &&(a/b > 5)) Console.WriteLine(a/b);

/*El problema es que si b = 0 evalua la segunda condicion dentro del if, entoces hace la division por 0 y eso da 
error. La forma de corregirlo sería agregar && (condicional cortocircuito) para que evalue ambas condiciones, entonces 
si la primera condicion es falsa no evalua la segunda condicion y sigue con la ejecución del programa */