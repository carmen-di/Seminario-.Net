/*1) Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos WriteLine() y 
Write() de la clase System.Console ¿Cómo funciona el método ReadKey() de la misma clase? Escribir un programa que
imprima en la consola la frase “Hola Mundo” haciendo una pausa entre palabra y palabra esperando a que el usuario 
presione una tecla para continuar.
Tip: usar los métodos ReadKey() y Write() de la clase System.Console

La diferencia es que:
WriteLine(): imprime en pantalla y al final hace un salto de linea.
Write(): imprime en pantalla sin hacer un salto de linea al final.

ReadKey(): Obtiene la siguiente tecla de carácter o de función presionada por el usuario. La tecla presionada se 
muestra en la ventana de la consola.
Uno de los usos más comunes del método es detener la ReadKey() ejecución del programa hasta que el usuario presiona
una tecla y la aplicación finaliza o muestra una ventana adicional de información.

*/

Console.Write("Hola");
Console.ReadKey();
Console.Write("Mundo");