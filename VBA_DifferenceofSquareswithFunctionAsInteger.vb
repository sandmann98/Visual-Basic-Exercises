
Imports System
Imports System.Linq

Public Module DifferenceOfSquares
    Public Function CalculateSquareOfSum(ByVal max As Integer) As Integer
        ' Calculate the sum of the first max natural numbers
        Dim sum As Integer = Enumerable.Range(1, max).Sum()
        ' Return the square of the sum
        Return sum * sum
    End Function

    Public Function CalculateSumOfSquares(ByVal max As Integer) As Integer
        ' Calculate the sum of the squares of the first max natural numbers
        Dim sumOfSquares As Integer = Enumerable.Range(1, max).Sum(Function(x) x * x)
        ' Return the sum of the squares
        Return sumOfSquares
    End Function

    Public Function CalculateDifferenceOfSquares(ByVal max As Integer) As Integer
        ' Calculate the difference between the square of the sum and the sum of the squares
        Return CalculateSquareOfSum(max) - CalculateSumOfSquares(max)
    End Function
End Module