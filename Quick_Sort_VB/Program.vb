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

    Sub quick_sort(ByVal vect() As Int64, ByVal start_ As Int64, ByVal end_ As Int64)
        If start_ < end_ Then
            index_pivot = partitie(vect, start_, end_)
            quick_sort(vect, start_, index_pivot - 1)
            quick_sort(vect, index_pivot + 1, end_)
        End If
    End Sub

    Function partitie(vect() As Int64, start_ As Int64, end_ As Int64)
        Dim pivot As Int64 = vect(end_)
        Dim index_partition As Int64 = start_
        For i = start_ To end_ - 1
            If vect(i) <= pivot Then
                swap(vect(i), vect(index_partition))
                index_partition += 1
            End If
        Next
        swap(vect(end_), vect(index_partition))
        Return index_partition
    End Function

    Sub swap(ByRef x As Int64, ByRef y As Int64)
        Dim temp As Int64 = x
        x = y
        y = temp

    End Sub
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        citeste_vector(vect)

        afiseaza_vector(vect)
        quick_sort(vect, 1, n)
        afiseaza_vector(vect)

        Console.ReadLine()
    End Sub
End Module
