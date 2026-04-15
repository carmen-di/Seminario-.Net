/*8) Señalar errores de compilación y/o ejecución en el siguiente código*/

object obj = new int[10];
dynamic dyna = 13;
Console.WriteLine(obj.Length);  // Object no tiene incorporado un metodo .Length -> Error de compilación
Console.WriteLine(dyna.Length); // Int no tiene incorporado un metodo .Length -> Error de ejecución