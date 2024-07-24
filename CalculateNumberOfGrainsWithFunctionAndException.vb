Imports System

Public Module Grains
    ' Calculate the number of grains on a specific square (n)
    Public Function Square(ByVal n As Integer) As ULong
        If n < 1 Or n > 64 Then
            Throw New ArgumentOutOfRangeException(NameOf(n), "Square must be between 1 and 64")
        End If
        ' Number of grains on the nth square is 2^(n-1)
        Return CULng(Math.Pow(2, n - 1))
    End Function

    ' Calculate the total number of grains on the chessboard
    Public Function Total() As ULong
        Dim totalGrains As ULong = 0

        ' Loop through each square and sum up the grains
        For i As Integer = 1 To 64
            totalGrains += Square(i)
        Next

        Return totalGrains
    End Function
End Module