class A
{
    private static int a; // Variable de clase estática de tipo entero
    private static readonly int b; // Variable de clase estática de solo lectura
    A() { } // Constructor privado
    public A(int i) : this() { } // Constructor público que recibe un entero e implementa el constructor privado de arriba
    static A() => b = 2; // Constructor estatico, se ejecuta en tiempos de compilacion.
    int c; // Variable privada de tipo entero
    public static void A1() => a = 1; // Método público y estático que asigna 1 a la variable a (y no retorna nada)
    public int A1(int a) => A.a + a; // Método público que recibe un entero y retorna otro
    public static int A2; //  Variable de instancia pública
    static int A3 => 3; // Propiedad de solo lectura
    private int A4() => 4; // Método privado que devuelve siempre 4
    public int A5 { get => 5; } // Propiedad pública de solo lectura que siempre retorna un 5
    int A6 { set => c = value; } // Propiedad de solo escritura que settea el valor de c
    public int A7 { get; set; } // Propiedad de lectura/escritura
    public int A8 { get; } = 8; //Propiedad de solo lectura
    public int this[int i] => i; //Indizador que retorna un entero pasado por parámetro
}