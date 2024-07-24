Imports System

Public Module ArmstrongNumbers
    Public Function IsArmstrongNumber(ByVal number As Integer) As Boolean
        ' Convert the number to a string to iterate through its digits
        Dim numberAsString As String = number.ToString()

        ' Calculate the number of digits in the number
        Dim numberOfDigits As Integer = numberAsString.Length

        ' Initialize sum variable to store the sum of digits raised to the power of numberOfDigits
        Dim sum As Integer = 0

        ' Iterate through each digit in the number
        For Each digitChar As Char In numberAsString
            ' Convert the character digit back to integer
            Dim digit As Integer = Integer.Parse(digitChar.ToString())

            ' Calculate digit^numberOfDigits and add to sum
            sum += CInt(Math.Pow(digit, numberOfDigits))
        Next

        ' Check if the calculated sum equals the original number
        Return sum = number
    End Function
End Module