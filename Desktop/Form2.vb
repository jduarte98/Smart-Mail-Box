Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Form2
    Shared _continue As Boolean
    Shared _serialport As SerialPort
    Dim comPORT As String
    Dim receivedData As String = ""
    Sub recebersonar()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Open()
        SerialPort1.Write("1")
        SerialPort1.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Close()
        SerialPort1.PortName = "com6" 'change com port to match your Arduino port
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
        Timer1.Enabled = True
        SerialPort1.ReadTimeout = 10000

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim close As Integer
        close = MsgBox("Sair do Programa?", MsgBoxStyle.Question + vbYesNo, "Sair")
        If close = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SerialPort1.Open()
        SerialPort1.Write("2")
        SerialPort1.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SerialPort1.Open()
        SerialPort1.Write("1")
        SerialPort1.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SerialPort1.Open()
        SerialPort1.Write("2")
        SerialPort1.Close()
    End Sub
End Class
