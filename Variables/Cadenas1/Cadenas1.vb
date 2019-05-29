Module Cadenas1

    Sub Main()
        Dim PalabraIngresada, PalabraInvertida As String
        Dim PrimeraA, PrimeraO As Int16
        Console.Write("Ingrese una palabra: ")

        PalabraIngresada = Console.ReadLine()
        PrimeraA = InStr(PalabraIngresada, "a")
        PrimeraO = InStr(PalabraIngresada, "o")
        PalabraInvertida = StrReverse(PalabraIngresada)

        Console.WriteLine("Posición de la primera 'a': " & PrimeraA)
        Console.WriteLine("Posición de la primera 'o': " & PrimeraO)
        Console.WriteLine("Palabra invertida: " & PalabraInvertida)
        Console.ReadLine()
    End Sub

End Module
