Public Class splscreen
    Dim a As Integer = 0
    Dim b As Boolean = False
    Dim c As Integer = 0
    Private Sub desvanecerform()
        Dim icount As Integer
        For icount = 90 To 10 Step -2
            Me.Opacity = icount / 100
            Me.Refresh()
            Threading.Thread.Sleep(20)
        Next
    End Sub
    Private Sub splscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        b = True
        If b Then
            a = a + 1
            If a = 25 Then
                desvanecerform()
                Me.Hide()
                Form1.Show()
            End If
        End If
    End Sub
End Class