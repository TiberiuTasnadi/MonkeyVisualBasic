﻿Public Class Gcode
    Private nomGcode As String
    Private tipusMaterialSuportat As String
    Private nicknameCreador As String

    Sub New(ByVal nomGcode As String, ByVal tipusMaterialSuportat As String, ByVal nicknameCreador As String)
        Me.nomGcode = nomGcode
        Me.tipusMaterialSuportat = tipusMaterialSuportat
        Me.nicknameCreador = nicknameCreador
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetNomGcode.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetNomGcode.Equals(obj.GetSetNomGcode)
        End If
        Return False
    End Function

    Property GetSetNomGcode
        Get
            Return Me.nomGcode
        End Get
        Set(value)
            Me.nomGcode = value
        End Set
    End Property

    Property GetSetTipusMaterialSuportat
        Get
            Return Me.tipusMaterialSuportat
        End Get
        Set(value)
            Me.tipusMaterialSuportat = value
        End Set
    End Property

    Property GetSetNicknameCreador
        Get
            Return Me.nicknameCreador
        End Get
        Set(value)
            Me.nicknameCreador = value
        End Set
    End Property
End Class
