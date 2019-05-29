Imports System

Module Mayor
    Sub Main(args As String())
        Dim a, b, c As Decimal
        a = 2.1
        b = 2.3
        c = 2.2
        If a > b And a > c Then
            Console.Write("El mayor es a = " & a)
        ElseIf b > a And b > c Then
            Console.Write("El mayor es b = " & b)
        Else
            Console.Write("El mayor es c = " & c)
        End If
        Console.Read()

    End Sub
End Module
