/* 1) Ejecutar y analizar cuidadosamente el siguiente programa: */

Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End)
{
    Console.Clear();
    Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
    k = Console.ReadKey(true);
}

/*Comprobar tipeando teclas y modificadores (shift, ctrl, alt) para apreciar de qué manera se
puede acceder a esta información en el código del programa.*/

/*
Con Console.CursorVisible establezco si el cursor es no o visible mediante true/false.
En la variable k de tipo ConsoleKeyInfo se guardará que tecla presiono
Entro en loop y evaluo que k.Key sea distinto de la tecla End. Dentro del loop:
    Console.Clear(); --> limpio la consola.
    Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}"); --> se muestran en pantalla los modificadores, el identificador de la tecla presionada, y el valor de la misma.
    k = Console.ReadKey(true); --> el programa espera a que se presione una nueva tecla.
*/