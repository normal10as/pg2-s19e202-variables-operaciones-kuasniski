Imports System
Imports System.Math

Module Matematica1
    Sub Main(args As String())
        Dim NumIngresado, ValorAbsoluto, Potencia, RaizCuadrada As Double
        Console.Write("Ingrese un número: ")
        NumIngresado = Console.ReadLine()

        ValorAbsoluto = Math.Abs(NumIngresado)
        Potencia = Math.Pow(ValorAbsoluto, 10)
        RaizCuadrada = Math.Sqrt(NumIngresado)

        Console.WriteLine("Valor absoluto: " & ValorAbsoluto)
        Console.WriteLine("Resultado elevado decima potencia: " & Potencia)
        Console.WriteLine("Resultado raiz Cuadrada: " & RaizCuadrada)
        Console.Read()

    End Sub
End Module
