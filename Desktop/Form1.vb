Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If passtxt.Text = "admin" And usertxt.Text = "admin" Then
            Me.Hide()
            Form2.Show()
        Else
            usertxt.Clear()
            passtxt.Clear()
            MsgBox("Nome de utilizador ou Password errados", MsgBoxStyle.Critical, "Erro ao entrar")
        End If
    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged
        If My.Computer.Keyboard.CapsLock Then
        End If
        If passtxt.Text = "" Then
            Button1.Enabled = False
            CheckBox1.Enabled = False
            PictureBox1.Enabled = False
            Button1.Text = "Entrar"
        Else
            Button1.Enabled = True
            CheckBox1.Enabled = True
            PictureBox1.Enabled = True
            Button1.Text = "ENTRAR"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim controlo As Integer = 0
        If CheckBox1.Checked Then
            controlo = 1
        End If
        If controlo = 1 Then
            passtxt.UseSystemPasswordChar = False
            controlo = 0
        ElseIf controlo = 0 Then
            passtxt.UseSystemPasswordChar = True
            controlo = 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        CheckBox1.Enabled = False
        PictureBox1.Enabled = False
        usertxt.Focus()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        splscreen.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim close As Integer
        close = MsgBox("Sair do Programa?", MsgBoxStyle.Question + vbYesNo, "Sair")
        If close = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If passtxt.Text = "admin" And usertxt.Text = "admin" Then
            Me.Hide()
            Form2.Show()
        Else
            usertxt.Clear()
            passtxt.Clear()
            MsgBox("Nome de utilizador ou Password errados", MsgBoxStyle.Critical, "Erro ao entrar")
        End If
    End Sub
End Class
