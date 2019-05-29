Imports System
Imports System.Math

Module Redondeo
    Sub Main(args As String())
        Dim NumIngresado, Exceso, Defecto, Redondeo As Decimal
        Console.Write("Ingrese un número de tipo real: ")
        NumIngresado = Console.ReadLine()

        Exceso = Math.Ceiling(NumIngresado)
        Defecto = Math.Floor(NumIngresado)
        Redondeo = Math.Round(NumIngresado)

        Console.WriteLine("Exceso= " & Exceso & " Defecto= " & Defecto & " Redondeo= " & Redondeo)

        Console.Read()

    End Sub
End Module
