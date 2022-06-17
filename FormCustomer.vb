

Public Class FormCustomer
    Public Sub UpdateSubCust()
        On Error Resume Next
        ds.Clear()
        cm = cn.CreateCommand
        cm.CommandText = "select * from tbcustomer"
        da.SelectCommand = cm
        da.Fill(ds, "tbcustomer")
        dgvCustomer.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error Resume Next
        cm.Connection = cn
        cm.Connection.Open()
        cm.CommandText = "INSERT INTO tbcustomer ([Customer], [phone],[IDCard])" _
        & "Values (" _
        & "'" & UCase(txtCust.Text) & "'," _
        & "'" & UCase(txtPhone.Text) & "'," _
        & "'" & UCase(txtID.Text) & "')"


        cm.ExecuteNonQuery()
        UpdateSubCust()
        cn.Close()

        txtCust.Text = ""
        txtPhone.Text = ""
        txtID.Text = ""
        txtCust.Focus()
        MessageBox.Show("Data Have Been Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class