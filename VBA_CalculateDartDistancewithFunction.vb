Imports System

Public Module Darts
    Public Function Score(ByVal x As Double, ByVal y As Double) As Integer
        ' Calculate the distance from the origin (0,0) to the point (x,y)
        Dim distance As Double = Math.Sqrt(x * x + y * y)

        ' Determine the score based on the distance
        If distance > 10 Then
            ' Outside the target
            Return 0
        ElseIf distance > 5 Then
            ' Outer circle
            Return 1
        ElseIf distance > 1 Then
            ' Middle circle
            Return 5
        Else
            ' Inner circle
            Return 10
        End If
    End Function
End Module

