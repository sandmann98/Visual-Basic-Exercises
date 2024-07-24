Public Module TwoFer
    ' Function to generate dialogue based on the given name
    Public Function Speak(Optional ByVal name As String = Nothing) As String
        If name IsNot Nothing AndAlso name <> "" Then
            Return "One for " & name & ", one for me."
        Else
            Return "One for you, one for me."
        End If
    End Function
End Module
