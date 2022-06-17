

Public Class FormCar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        cm.Connection = cn
        cm.Connection.Open()
        cm.CommandText = "INSERT INTO tbCar ([CarName], [CarModel],[CarStatus])" _
        & "Values (" _
        & "'" & UCase(txtName.Text) & "'," _
        & "'" & UCase(txtModel.Text) & "'," _
        & "'" & UCase(comboStatus.Text) & "')"


        cm.ExecuteNonQuery()
        UpdateSub()
        cn.Close()

        txtName.Text = ""
        txtModel.Text = ""
        comboStatus.Text = ""
        txtName.Focus()
        MessageBox.Show("Data Have Been Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub



    Public Sub UpdateSub()
        On Error Resume Next
        ds.Clear()
        cm = cn.CreateCommand
        cm.CommandText = "select * from tbCar"
        da.SelectCommand = cm
        da.Fill(ds, "tbCar")
        dgvcar.DataSource = ds.Tables(0)

    End Sub
End Class