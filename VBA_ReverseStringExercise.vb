Public Module ReverseString
    Public Function Reverse(ByVal inputString As String) As String
        ' Convert the input string to a character array
        Dim charArray As Char() = inputString.ToCharArray()

        ' Reverse the character array
        Array.Reverse(charArray)

        ' Convert the character array back to a string and return it
        Return New String(charArray)
    End Function
End Module