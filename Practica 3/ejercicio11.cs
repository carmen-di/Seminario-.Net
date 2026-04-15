/*11) Señalar errores de ejecución en el siguiente código*/

List<int> a = [ 1, 2, 3, 4 ];
a.Remove(5);    // Error: el 5 no se encuentra en la lista
a.RemoveAt(4);  // Error: quiere remover el elemento de la lista en la posición 4, pero los índices van de de 0 a 3.