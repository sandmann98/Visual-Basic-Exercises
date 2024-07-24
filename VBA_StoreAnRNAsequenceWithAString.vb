Imports System

Public Module RnaTranscription
    Public Function ToRna(ByVal nucleotide As String) As String
        ' Initialize an empty string to store the RNA sequence
        Dim rnaSequence As String = String.Empty

        ' Loop through each character in the DNA nucleotide sequence
        For Each dnaChar As Char In nucleotide
            ' Translate each DNA nucleotide to its RNA complement
            Select Case dnaChar
                Case "G"c
                    rnaSequence &= "C"
                Case "C"c
                    rnaSequence &= "G"
                Case "T"c
                    rnaSequence &= "A"
                Case "A"c
                    rnaSequence &= "U"
                Case Else
                    ' Handle unexpected characters
                    Throw New ArgumentException("Invalid DNA nucleotide found.")
            End Select
        Next

        ' Return the resulting RNA sequence
        Return rnaSequence
    End Function
End Module