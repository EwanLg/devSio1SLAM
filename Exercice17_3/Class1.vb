Public Class Pile
    Private Const MAX As Integer = 100
    Private tabPile(MAX - 1) As String
    Private positionlibre As Integer
    Public Sub New()
        positionlibre = 0
    End Sub
    Public Function Empiler(ByVal valeur As String) As Boolean
        If positionlibre < MAX Then
            tabPile(positionlibre) = valeur
            positionlibre += 1
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Depiler() As String
        If positionlibre > 0 Then
            positionlibre -= 1
            Return tabPile(positionlibre)
        Else
            Return Nothing
        End If
    End Function
    Public Function EstVide() As Boolean
        Return positionlibre = 0
    End Function
    Public Function NombreDElements() As Integer
        Return positionlibre
    End Function
    Public Overrides Function ToString() As String
        Dim contenu As String = "-----" & vbCrLf
        For i As Integer = positionlibre - 1 To 0 Step -1
            contenu &= tabPile(i) & vbCrLf
        Next
        contenu &= "-----"
        Return contenu
    End Function
End Class
