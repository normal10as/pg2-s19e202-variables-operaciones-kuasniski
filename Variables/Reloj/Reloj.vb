Imports System
Imports System.DateTime
Module Reloj
    Sub Main(args As String())
        Console.WriteLine("D�as del a�o: " & Now.DayOfYear)
        Console.WriteLine("Mes: " & Now.Month)
        Console.WriteLine("Hora: " & Now.Hour)
        Console.WriteLine("Minutos: " & Now.Minute)
        Console.Read()
    End Sub
End Module
