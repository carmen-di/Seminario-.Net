/*13) ¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?*/

Console.WriteLine(args == null); // -> imprime false, pues args <> null
Console.WriteLine(args.Length);  // -> imprime 0.  
                                 // Cuando se hace args.Length, devuelve la cantidad de elementos recibidos. 
                                 // En este caso, imprime 0, ya que no recibe ningun argumento. 