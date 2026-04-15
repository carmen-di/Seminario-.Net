/*11) ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas las palabras 
(una por línea) de una frase ingresada por consola por el usuario.

El método Split sirve para dividir una cadena de texto (string) en subcadenas más pequeñas, utilizando un separador
o delimitador específico (como una coma, espacio, o guion). El resultado es un array o lista que contiene los fragmentos 
resultantes, facilitando el procesamiento, análisis y manipulación de datos formateados.
*/

Console.Write("Ingrese una oración: ");
string st = Console.ReadLine();

string[] palabras = st.Split(" ");

foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}