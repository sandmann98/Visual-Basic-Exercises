Imports System

Public Module Isogram
    Public Function IsIsogram(ByVal word As String) As Boolean
        ' Convert the word to lowercase for case-insensitive comparison
        Dim lowerWord As String = word.ToLower()

        ' Use a HashSet to store seen characters
        Dim seenCharacters As New HashSet(Of Char)()

        ' Iterate over each character in the word
        For Each ch As Char In lowerWord
            ' Ignore spaces and hyphens
            If ch = " "c Or ch = "-"c Then
                Continue For
            End If

            ' If the character is already in the HashSet, it's not an isogram
            If seenCharacters.Contains(ch) Then
                Return False
            End If

            ' Add the character to the HashSet
            seenCharacters.Add(ch)
        Next

        ' If we haven't found any duplicate characters, it's an isogram
        Return True
    End Function
End Module