Imports System

Module Intereses
    Sub Main(args As String())
        Dim MontoIngresado, InteresAnual, InteresesAcumulado, CapitalAcumulado As Single
        Dim DiasIngresado As UInt16

        Console.Write("Ingrese el monto: ")
        MontoIngresado = Console.ReadLine()
        Console.Write("Ingrese interes Anual: ")
        InteresAnual = Console.ReadLine()
        Console.Write("Ingrese tiempo en dias : ")
        DiasIngresado = Console.ReadLine()

        InteresesAcumulado = (MontoIngresado * InteresAnual * DiasIngresado) / (360 * 100)
        CapitalAcumulado = MontoIngresado + InteresesAcumulado

        Console.WriteLine("Interes:${0} - Capital acumulado:${1} ", InteresesAcumulado, CapitalAcumulado)
        Console.Read()

    End Sub
End Module
