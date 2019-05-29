Imports System

Module Concatenación
    Sub Main(args As String())
        Dim NombreEmpresa, NombreCalle As String
        Dim AlturaCalle As UInt16
        Dim InicioActividades As Date
        Console.Write("Ingrese nombre empresa: ")
        NombreEmpresa = Console.ReadLine
        Console.Write("Ingrese nombre de la calle: ")
        NombreCalle = Console.ReadLine
        Console.Write("Ingrese altura de la calle: ")
        AlturaCalle = Console.ReadLine
        Console.Write("Ingrese fecha inicio de actividades: ")
        InicioActividades = Console.ReadLine

        Console.WriteLine("Nombre de la empresa: " + NombreEmpresa + " Direccion: " + NombreCalle + " " + Convert.ToString(AlturaCalle) + " Inicio de Actividades: " + Convert.ToString(InicioActividades))

        Console.WriteLine("Nombre de la empresa: " & NombreEmpresa & " Direccion: " & NombreCalle & " " & AlturaCalle & " Inicio de Actividades: " & InicioActividades)

        Console.Read()


    End Sub
End Module
