Imports System
Imports System.Collections.Generic

Public Module NucleotideCount
    Public Function Count(ByVal sequence As String) As IDictionary(Of Char, Integer)
        ' Initialize a dictionary to store the counts of each nucleotide
        Dim nucleotideCounts As New Dictionary(Of Char, Integer) From {
            {"A"c, 0},
            {"C"c, 0},
            {"G"c, 0},
            {"T"c, 0}
        }

        ' Iterate through each character in the DNA sequence
        For Each nucleotide As Char In sequence
            ' Check if the character is a valid nucleotide
            If nucleotideCounts.ContainsKey(nucleotide) Then
                ' Increment the count of the nucleotide
                nucleotideCounts(nucleotide) += 1
            Else
                ' If an invalid character is found, throw an exception
                Throw New ArgumentException("Invalid character in DNA sequence.")
            End If
        Next

        ' Return the dictionary with the counts of each nucleotide
        Return nucleotideCounts
    End Function
End Module