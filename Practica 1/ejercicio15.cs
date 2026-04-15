/*15) ¿Cuál es el problema del código siguiente y cómo se soluciona? 

using System.Timers;

int i = 0;
for (int i = 1; i <= 10;)
{
    Console.WriteLine(i++);
}

El problema es que declara dos veces la variable i. Para solucionarlo elimino una de las declaraciones de la 
variable i */

for (int i = 1; i <= 10;)
{
    Console.WriteLine(i++);
}