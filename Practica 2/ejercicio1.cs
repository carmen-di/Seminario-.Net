/* 1) Sea el siguiente código:

object o1 = "A";
object o2 = o1;
o2 = "Z";
Console.WriteLine(o1 + " " + o2);

El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas variables están
apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la consola no sea “Z Z”? 

Cuando se hace o2 = o1, las dos variables comparten la misma referencia es decir, apuntan al mismo valor. 
Pero cuando se hace o2 = "Z", se asigna un nuevo espacio en memoria HEAP para almacenar el contenido, porque
el tipo de dato String es de referencia. Entonces, no modifica el valor en esa referencia, sino que utiliza 
un nuevo espacio en memoria heap para almacenar el valor.*/

