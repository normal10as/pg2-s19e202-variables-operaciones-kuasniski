Imports System
Imports System.DateTime
Module dias
    Enum DiasDeLaSemana
        Lunes = 1
        Martes = 2
        Miercoles = 3
        Jueves = 4
        Viernes = 5
        Sabado = 6
        Domingo = 7
    End Enum
    Sub Main(args As String())
        Dim NumDiaActual As DiasDeLaSemana
        Dim DiaActual As DateTime
        DiaActual = DiaActual.Now
        NumDiaActual = DiaActual.DayOfWeek

        Console.WriteLine("El dia de hoy es: " & NumDiaActual.ToString)
        Console.Read()

    End Sub
End Module
