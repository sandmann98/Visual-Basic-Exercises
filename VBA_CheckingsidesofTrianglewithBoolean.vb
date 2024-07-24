Imports System

Public Module Triangle
    Public Function IsScalene(ByVal side1 As Double, ByVal side2 As Double, ByVal side3 As Double) As Boolean
        ' Check if all sides are different and triangle inequalities hold
        Return side1 <> side2 AndAlso side1 <> side3 AndAlso side2 <> side3 AndAlso IsValidTriangle(side1, side2, side3)
    End Function

    Public Function IsIsosceles(ByVal side1 As Double, ByVal side2 As Double, ByVal side3 As Double) As Boolean
        ' Check if at least two sides are equal and triangle inequalities hold
        Return (side1 = side2 OrElse side1 = side3 OrElse side2 = side3) AndAlso IsValidTriangle(side1, side2, side3)
    End Function

    Public Function IsEquilateral(ByVal side1 As Double, ByVal side2 As Double, ByVal side3 As Double) As Boolean
        ' Check if all sides are equal and triangle inequalities hold
        Return side1 = side2 AndAlso side1 = side3 AndAlso IsValidTriangle(side1, side2, side3)
    End Function

    Private Function IsValidTriangle(ByVal a As Double, ByVal b As Double, ByVal c As Double) As Boolean
        ' Check triangle inequalities
        Return a > 0 AndAlso b > 0 AndAlso c > 0 AndAlso
               a + b >= c AndAlso
               b + c >= a AndAlso
               a + c >= b
    End Function
End Module

