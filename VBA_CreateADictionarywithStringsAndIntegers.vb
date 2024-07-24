
Imports System
Imports System.Collections.Generic

Public Module Etl
    Public Function Transform(ByVal old As Dictionary(Of Integer, String())) As Dictionary(Of String, Integer)
        ' Create a new dictionary to store the transformed data
        Dim newDictionary As New Dictionary(Of String, Integer)()

        ' Iterate over each entry in the old dictionary
        For Each entry In old
            Dim score As Integer = entry.Key
            Dim letters As String() = entry.Value

            ' Iterate over each letter in the letters array
            For Each letter As String In letters
                ' Add the lowercase letter with its corresponding score to the new dictionary
                newDictionary(letter.ToLower()) = score
            Next
        Next

        Return newDictionary
    End Function
End Module