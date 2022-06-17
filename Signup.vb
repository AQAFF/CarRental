Public Class Signup
    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub UpdateSub()
        On Error Resume Next
        ds.Clear()
        cm = cn.CreateCommand
        cm.CommandText = "select * from login"
        da.SelectCommand = cm


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        cm.Connection = cn
        cm.Connection.Open()
        cm.CommandText = "INSERT INTO login ([user], [pass],[fullname])" _
        & "Values (" _
        & "'" & UCase(txtName.Text) & "'," _
        & "'" & UCase(txtPass.Text) & "'," _
        & "'" & UCase(txtUser.Text) & "')"


        cm.ExecuteNonQuery()
        UpdateSub()
        cn.Close()

        txtName.Text = ""
        txtPass.Text = ""
        txtUser.Text = ""
        txtName.Focus()
        MessageBox.Show("Data Have Been Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class