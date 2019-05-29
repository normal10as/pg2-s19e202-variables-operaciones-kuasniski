Imports System

Module Tabla_booleana
    Sub Main(args As String())
        Dim v, f, r1, r2, r3, r4 As Boolean

        v = True
        f = False

        '-----------------AND------------
        r1 = v And v
        r2 = v And f
        r3 = f And v
        r4 = f And f

        Console.WriteLine("---------AND---------")
        Console.WriteLine("  V  ˄  V   = " & r1)
        Console.WriteLine("  V  ˄  F   = " & r2)
        Console.WriteLine("  F  ˄  V   = " & r3)
        Console.WriteLine("  F  ˄  F   = " & r4)
        '---------------OR--------------
        r1 = v Or v
        r2 = v Or f
        r3 = f Or v
        r4 = f Or f


        Console.WriteLine("---------OR---------")
        Console.WriteLine("  V  ˅  V   = " & r1)
        Console.WriteLine("  V  ˅  F   = " & r2)
        Console.WriteLine("  F  ˅  V   = " & r3)
        Console.WriteLine("  F  ˅  F   = " & r4)
        '---------------XOR--------------
        r1 = v Xor v
        r2 = v Xor f
        r3 = f Xor v
        r4 = f Xor f


        Console.WriteLine("---------XOR---------")
        Console.WriteLine("  V  ˅  V   = " & r1)
        Console.WriteLine("  V  ˅  F   = " & r2)
        Console.WriteLine("  F  ˅  V   = " & r3)
        Console.WriteLine("  F  ˅  F   = " & r4)
        '---------------NOT--------------
        r1 = Not v
        r2 = Not f

        Console.WriteLine("---------NOT---------")
        Console.WriteLine(" ¬V         = " & r1)
        Console.WriteLine(" ¬F         = " & r2)
        Console.Read()

    End Sub
End Module
