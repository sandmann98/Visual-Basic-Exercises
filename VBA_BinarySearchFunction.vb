Imports System

Public Module BinarySearch
    Public Function Find(ByVal input As Integer(), ByVal value As Integer) As Integer
        ' Initialize variables to track the start and end of the search range
        Dim left As Integer = 0
        Dim right As Integer = input.Length - 1

        ' Perform binary search
        While left <= right
            ' Find the middle element of the current range
            Dim middle As Integer = left + (right - left) \ 2

            ' Check if the middle element is the value we're looking for
            If input(middle) = value Then
                Return middle ' Return the index of the found value
            ElseIf input(middle) < value Then
                ' If the middle element is less than the value, search the right half
                left = middle + 1
            Else
                ' If the middle element is greater than the value, search the left half
                right = middle - 1
            End If
        End While