/*10) Comprobar el funcionamiento del siguiente programa y dibujar el estado de la pila y la memoria
heap cuando la ejecución alcanza los puntos indicados (comentarios en el código) */

using System.Text;

object[] v = new object[10];
v[0] = new StringBuilder("Net");
for (int i = 1; i < 10; i++)
{
    v[i] = v[i - 1]; 
}
(v[5] as StringBuilder).Insert(0, "Framework .");
foreach (StringBuilder s in v)
    Console.WriteLine(s);

//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución

/*
En este caso, asignamos a todos los objetos del vector, el contenido del objeto en v[0], al ser por referencia, 
todos apuntan a la misma dirección del Heap, pues se comparte la dirección del objeto v[0].

Heap
[StringBuilder: "Framework .Net"]

Stack
v → [ref, ref, ref, ref, ref, ref, ref, ref, ref, ref]
        ↓
TODOS apuntan a "Framework .Net"
*/

v[5] = new StringBuilder("CSharp");   // SOLO cambia la referencia en la posición 5
foreach (StringBuilder s in v)
    Console.WriteLine(s);

//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución
/*
En el CASO 2, creamos un nuevo StringBuilder y lo asignamos a v[5], entonces, ahora v[5] va a estar apuntando a una 
dirección distinta, mientras que el resto de los objetos del vector apuntan a la misma dirección pues comparten 1 
sóla dirección con v[0].

Heap
[StringBuilder: "Framework .Net"]
[StringBuilder: "CSharp"]

Stack
v[0] → "Framework .Net"
v[1] → "Framework .Net"
v[2] → "Framework .Net"
v[3] → "Framework .Net"
v[4] → "Framework .Net"
v[5] → "CSharp"          
v[6] → "Framework .Net"
v[7] → "Framework .Net"
v[8] → "Framework .Net"
v[9] → "Framework .Net"
*/