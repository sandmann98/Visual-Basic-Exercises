Imports System

Public Enum DirectionType
    North
    East
    South
    West
End Enum

Public Class RobotSimulator
    Private _direction As DirectionType
    Private _x As Integer
    Private _y As Integer

    Public Sub New(ByVal direction As DirectionType, ByVal x As Integer, ByVal y As Integer)
        _direction = direction
        _x = x
        _y = y
    End Sub

    Public ReadOnly Property Direction As DirectionType
        Get
            Return _direction
        End Get
    End Property

    Public ReadOnly Property X As Integer
        Get
            Return _x
        End Get
    End Property

    Public ReadOnly Property Y As Integer
        Get
            Return _y
        End Get
    End Property

    Public Sub Move(ByVal instructions As String)
        For Each instruction As Char In instructions
            Select Case instruction
                Case "R"
                    TurnRight()
                Case "L"
                    TurnLeft()
                Case "A"
                    Advance()
                Case Else
                    Throw New ArgumentException("Invalid instruction: " & instruction)
            End Select
        Next
    End Sub

    Private Sub TurnRight()
        Select Case _direction
            Case DirectionType.North
                _direction = DirectionType.East
            Case DirectionType.East
                _direction = DirectionType.South
            Case DirectionType.South
                _direction = DirectionType.West
            Case DirectionType.West
                _direction = DirectionType.North
        End Select
    End Sub

    Private Sub TurnLeft()
        Select Case _direction
            Case DirectionType.North
                _direction = DirectionType.West
            Case DirectionType.East
                _direction = DirectionType.North
            Case DirectionType.South
                _direction = DirectionType.East
            Case DirectionType.West
                _direction = DirectionType.South
        End Select
    End Sub

    Private Sub Advance()
        Select Case _direction
            Case DirectionType.North
                _y += 1
            Case DirectionType.East
                _x += 1
            Case DirectionType.South
                _y -= 1
            Case DirectionType.West
                _x -= 1
        End Select
    End Sub
End Class
