Imports System
Imports System.DateTime

Module Ajustar_reloj
    Sub Main(args As String())
        Dim AñoActual, MesActual, minuto, segundo As Date
        Dim DiaIngresado, HoraIngresado, FechaModi As String

        AñoActual = AñoActual.Now
        MesActual = MesActual.Now
        minuto = minuto.Now
        segundo = segundo.Now
        Console.Write("Ingrese dia: ")
        DiaIngresado = Console.ReadLine()
        Console.Write("Ingrese hora: ")
        HoraIngresado = Console.ReadLine()
        FechaModi = New DateTime(AñoActual.Year, MesActual.Month, DiaIngresado, HoraIngresado, minuto.Minute, segundo.Second)
        Console.WriteLine("Fecha modificada: " & FechaModi)
        Console.Read()

    End Sub
End Module
