using System;

namespace Practica5;

public class Cuenta
{
    private int id = 0;
    private static int cuentasCreadas = 0;

    private static int cantDepositos = 0;
    private static int totalDepositado = 0;
    private static int cantExtracciones = 0;
    private static int totalExtraido = 0;
    private static int extDenegadas = 0;

    private int id_cuenta;
    private int saldo;

    private static List<Cuenta> cuentas = new List<Cuenta>();

    /* public static List<Cuenta> GetCuentas()  -> ejercicio 2
    {
        return new List<Cuenta>(cuentas);
    } */
    
    public static List<Cuenta> GetCuentas
    {
        get
        {
            return new List<Cuenta>(cuentas); 
        }
    }

    public Cuenta()
    {
        id++;
        id_cuenta = id;
        //cuentasCreadas++; -> ejercicio 1
        cuentas.Add(this);
        Console.WriteLine($"Se creó la cuenta Id={id}");
    }

    public Cuenta Depositar(int monto)
    {
        saldo += monto;
        cantDepositos++;
        totalDepositado += monto;
        Console.WriteLine($"Se depositó {monto} en la cuenta {id} (Saldo={saldo})");
        return this;
    }

    public Cuenta Extraer(int monto)
    {
        if (saldo >= monto)
        {
            saldo -= monto;
            cantExtracciones++;
            totalExtraido += monto;
            Console.WriteLine($"Se extrajo {monto} de la cuenta {id} (Saldo={saldo})");
        }
        else
        {
            extDenegadas++;
            Console.WriteLine("Operación denegada - Saldo insuficiente");
        }
        return this;
    }
    public static void ImprimirDetalle()
    {
        Console.WriteLine("DETALLE");
        Console.WriteLine($"CUENTAS CREADAS: {cuentasCreadas}");
        Console.WriteLine($"DEPÓSITOS      : {cantDepositos} - Total depositado: {totalDepositado}");
        Console.WriteLine($"EXTRACCIONES   : {cantExtracciones} - Total extraído: {totalExtraido}");
        Console.WriteLine($" - Saldo: {totalDepositado - totalExtraido}");
        Console.WriteLine($"* Se denegaron {extDenegadas} extracciones por falta de fondos");
    }
}
