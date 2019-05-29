Imports System

Module Resto_division
    Sub Main(args As String())
        Dim ValorIngresado, Resto As Integer
        Console.Write("Ingresar un valor entero: ")
        ValorIngresado = Console.ReadLine()
        Resto = ValorIngresado Mod 2
        Console.WriteLine("El resto de dicho valor divido por dos es: " & Resto)
        Console.Read()

    End Sub
End Module
