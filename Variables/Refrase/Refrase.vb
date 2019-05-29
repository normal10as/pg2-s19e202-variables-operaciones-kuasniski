Module Refrase

    Sub Main()
        Dim Frase As String = " Aunque la cadena sea de oro, sirve para lo mismo."
        Dim PalabraActIngr, PalabraNuevIngr, NuevaFrase As String
        Console.WriteLine(Frase)
        Console.Write("Ingrese palabra a reemplazar: ")
        PalabraActIngr = Console.ReadLine()
        Console.Write("Ingrese palabra nueva: ")
        PalabraNuevIngr = Console.ReadLine()

        NuevaFrase = Replace(Frase, PalabraActIngr, PalabraNuevIngr)
        Console.WriteLine("Frase nueva: " & NuevaFrase)
        Console.ReadLine()
    End Sub

End Module
