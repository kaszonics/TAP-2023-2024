Imports System

Module Program
    Dim vect(100) As Int64
    Dim n As Int64
    Dim index_pivot As Int64

    Sub citeste_vector(vect() As Int64)
        Console.Write("Numar de elemente in vector:")
        n = Console.ReadLine()
        For i As Int64 = 1 To n
            Console.Write("vect[" & i & "]=")
            vect(i) = Console.ReadLine
        Next
    End Sub

    Sub afiseaza_vector(vect() As Int64)
        Console.Write("Vector:")
        For i As Int64 = 1 To n
            Console.Write(vect(i) & ", ")
        Next
        Console.WriteLine()

    End Sub

    Sub swap(ByRef x As Int64, ByRef y As Int64)
        Dim temp As Int64 = x
        x = y
        y = temp

    End Sub

    Sub bubble_sort(vect() As Int64, n As Int64)
        For i As Int64 = 1 To n
            For j As Int64 = 1 To n - i
                If vect(j) > vect(j + 1) Then
                    swap(vect(j), vect(j + 1))
                End If
            Next
        Next
    End Sub

    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        citeste_vector(vect)

        afiseaza_vector(vect)
        bubble_sort(vect, n)
        afiseaza_vector(vect)

        Console.ReadLine()
    End Sub
End Module
