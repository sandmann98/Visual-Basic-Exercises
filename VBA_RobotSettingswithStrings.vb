Imports System
Imports System.Collections.Generic

Public Class Robot
    Private Shared ReadOnly UsedNames As New HashSet(Of String)()

    Private _name As String

    Public Sub New()
        Reset()
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

    Public Sub Reset()
        GenerateUniqueName()
    End Sub

    Private Sub GenerateUniqueName()
        Dim random As New Random()
        Dim newName As String

        ' Generate a unique name that hasn't been used before
        Do
            newName = GenerateRandomName(random)
        Loop While UsedNames.Contains(newName)

        ' Add the new name to used names
        UsedNames.Add(newName)
        _name = newName
    End Sub

    Private Function GenerateRandomName(random As Random) As String
        Dim letters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim digits As String = "0123456789"

        Dim nameChars(4) As Char
        nameChars(0) = letters(random.Next(0, letters.Length))
        nameChars(1) = letters(random.Next(0, letters.Length))
        nameChars(2) = digits(random.Next(0, digits.Length))
        nameChars(3) = digits(random.Next(0, digits.Length))
        nameChars(4) = digits(random.Next(0, digits.Length))

        Return New String(nameChars)
    End Function
End Class

