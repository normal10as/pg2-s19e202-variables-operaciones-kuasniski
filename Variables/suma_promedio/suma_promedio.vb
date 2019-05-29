Imports System

Module suma_promedio
    Sub Main(args As String())
        Dim a, b, c, d, suma, media As Integer
        Console.Write("Ingrese valor: ")
        a = Console.ReadLine()
        Console.Write("Ingrese valor: ")
        b = Console.ReadLine()
        Console.Write("Ingrese valor: ")
        c = Console.ReadLine()
        Console.Write("Ingrese valor: ")
        d = Console.ReadLine()
        suma = a + b + c + d
        media = suma / 4
        Console.WriteLine("La suma es: " & suma)
        Console.WriteLine("La media es: " & media)
        Console.Read()

    End Sub
End Module
