Imports System
Imports System.Math


Module Cuadratica
    Sub Main(args As String())
        Dim a, b, c As Integer
        Dim x As Decimal
        a = 1
        b = 5
        c = 2
        x = (Math.Pow(b, 2) - 4 * a * c) / 2 * a
        Console.WriteLine("X=(b2-4ac)/2a")
        Console.Write("X=" & x)

        Console.Read()

    End Sub
End Module
