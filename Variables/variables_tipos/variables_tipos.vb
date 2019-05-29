Imports System

Module variables_tipos
    Sub Main(args As String())
        Dim Nombre As String
        Dim NumDocumento As UInteger
        Dim LugarNacimiento As String
        Dim FechaNacimiento As Date
        Dim AlturaCorporal As Single
        Dim esArgentino As Boolean
        Dim TemperaturaAmbiente As Byte
        Dim NombreCalle As String
        Dim AlturaCalle As UShort
        Dim DistanciaEntreCiudades As Integer
        Dim ProfundidadMar As UShort
        Dim CantidadHabitantes As UInteger
        Dim PesoProducto As Decimal
        Dim MontoArticulo As Decimal

        Nombre = "Fabricio"
        NumDocumento = 34971203
        LugarNacimiento = "Posadas,Misiones,Argentina"
        FechaNacimiento = #1990/02/16#
        AlturaCorporal = 1.78
        esArgentino = True
        TemperaturaAmbiente = 27
        NombreCalle = "Alondra"
        AlturaCalle = 6666
        DistanciaEntreCiudades = 1500
        ProfundidadMar = 8380
        CantidadHabitantes = 45206012
        PesoProducto = 2.5
        MontoArticulo = 499.99

        Console.WriteLine("Nombre: " & Nombre)
        Console.WriteLine("Num. Doumento: " & NumDocumento)
        Console.WriteLine("Lugar de nacimiento: " & LugarNacimiento)
        Console.WriteLine("Fecha de nacimiento: " & FechaNacimiento)
        Console.WriteLine("Altura Corporal: " & AlturaCorporal)
        Console.WriteLine("es Argentino: " & esArgentino)
        Console.WriteLine("Temperatura del Ambiente: " & TemperaturaAmbiente)
        Console.WriteLine("Cale: " & NombreCalle)
        Console.WriteLine("Altura Calle: " & AlturaCalle)
        Console.WriteLine("Disatacia entre ciudades: " & DistanciaEntreCiudades)
        Console.WriteLine("Profundidad de mar: " & ProfundidadMar)
        Console.WriteLine("Cantidad de habitantes actual: " & CantidadHabitantes)
        Console.WriteLine("Peso producto: " & PesoProducto)
        Console.WriteLine("Monto articulo: " & MontoArticulo)

        Console.Read()

    End Sub
End Module
