/*15) Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros cuando se invoca 
desde la línea de comandos.*/

Console.WriteLine("¡Hola {0}!", args[0]);

/*Si se pasan parámetros el programa imprimirá ¡Hola! + el primer argumento recibido
  Si no se pasan parámetros y no los definí previamente el programa dará error ya que args[0] no está definido*/
