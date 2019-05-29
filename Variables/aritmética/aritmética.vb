Imports System

Module aritmética
    Sub Main(args As String())
        Dim a, b As Integer
        a = 7
        b = 12
        Dim c, d, resultado As Decimal
        c = 1.5
        d = 3.14
        resultado = a + b
        Console.WriteLine("Suma de entero con entero: " & resultado)
        resultado = a + d
        Console.WriteLine("Suma de entero con flotante: " & resultado)
        resultado = b - a
        Console.WriteLine("Resta de entero con entero: " & resultado)
        resultado = d - c
        Console.WriteLine("Resta de flotante con flotante: " & resultado)
        resultado = b * c
        Console.WriteLine("Multiplicacion de entero con flotante: " & resultado)
        resultado = b * a
        Console.WriteLine("Multiplicacion de entero con entero: " & resultado)
        resultado = d / c
        Console.WriteLine("Division de flotante con flotante: " & resultado)
        resultado = b / c
        Console.WriteLine("division de entero con flotante: " & resultado)
        Console.Read()

    End Sub
End Module
