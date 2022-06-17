Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim txtUsername As String = TextBox2.Text.ToString
        Dim txtPassword As String = TextBox3.Text.ToString

        Dim user As String = ""
        Dim pass As String = ""
        Dim fullname As String = ""

        cn.Open()
        cm.CommandText = "SELECT * FROM login where user ='" & txtUsername & "' and " _
            & "pass = '" & txtPassword & "'"

        cm.Connection = cn
        sdr = cm.ExecuteReader()

        If (sdr.Read() = True) Then
            user = sdr("user")
            pass = sdr("pass")
            fullname = sdr("fullname")
            userlogin = fullname

            MsgBox("Selamat Datang " + fullname)
            Form1.ShowDialog()
            Me.Hide()
        Else
            MsgBox("Login gagal Sila cuba sekali lagi")
        End If


        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Signup.ShowDialog()

    End Sub
End Class