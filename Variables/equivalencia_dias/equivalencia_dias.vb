Imports System

Module equivalencia_dias
    Const DiasPorSemana As Int16 = 7
    Const HorasPorDias As Int16 = 24
    Const MinutosPorHora As Int16 = 60
    Dim DiasIngresados, CantSemanas, CantHoras, CantMinutos As Decimal

    Sub Main(args As String())

        Console.Write("Ingrese cantidad de dias cualquiera: ")
        DiasIngresados = Console.ReadLine
        CantSemanas = DiasIngresados / DiasPorSemana
        CantHoras = DiasIngresados * HorasPorDias
        CantMinutos = DiasIngresados * MinutosPorHora
        Console.WriteLine("{0} dias equivalen a {1} semanas:", DiasIngresados, CantSemanas)
        Console.WriteLine("{0} dias equivalen a {1} Horas: ", DiasIngresados, CantHoras)
        Console.WriteLine("{0} dias equivalen a {1} minutos: ", DiasIngresados, CantMinutos)
        Console.Read()

    End Sub
End Module
