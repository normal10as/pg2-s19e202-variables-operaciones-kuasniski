Imports System

Module variables
    Sub Main(args As String())
        Dim nombre, apellido As String
        Dim fechaNacimiento As Date
        Console.Write("Ingrese nombre: ")
        nombre = Console.ReadLine
        Console.Write("Ingrese apellido: ")
        apellido = Console.ReadLine()
        Console.Write("Ingrese fecha de nacimiento: ")
        fechaNacimiento = Console.ReadLine()

        Console.WriteLine(apellido + " " + nombre + " nacio el " + fechaNacimiento)
        Console.Read()

    End Sub
End Module
