Public Class DeleteCarN

    Public Sub UpdateSub()
        On Error Resume Next
        ds.Clear()
        cm = cn.CreateCommand
        cm.CommandText = "select * from tbCar"
        da.SelectCommand = cm
        da.Fill(ds, "tbCar")
        txId.DataBindings.Add("Text", ds.Tables("tbCar"), "ID")
        txtName.DataBindings.Add("Text", ds.Tables("tbCar"), "CarName")
        txtModel.DataBindings.Add("Text", ds.Tables("tbCar"), "CarModel")
        cbStatus.DataBindings.Add("Text", ds.Tables("tbCar"), "CarStatus")
        dgvCar.DataSource = ds.Tables(0)
    End Sub

    Private Sub DeleteCarN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateSub()
        txId.Enabled = False
        txtName.Enabled = False
        txtModel.Enabled = False
        cbStatus.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txId.Enabled = True
        txtName.Enabled = False
        txtModel.Enabled = False
        cbStatus.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txId.Enabled = True
        txtName.Enabled = True
        txtModel.Enabled = True
        cbStatus.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this record?", "DeleteRecord",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
            cn.Open()
            Dim Del As OleDb.OleDbCommand = New OleDb.OleDbCommand()
            Del.CommandText = "Delete From tbCar Where ID = " & txId.Text
            Del.Connection = cn
            Del.ExecuteNonQuery()


            cn.Close()
            UpdateSub()
            MessageBox.Show("Data Have Been Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Me.Refresh()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error Resume Next
        cn.Open()
        cm.CommandText = "UPDATE tbCar SET CarName = '" & UCase(txtName.Text) & " ', " _
        & "CarModel = '" & UCase(txtModel.Text) & " ', " _
        & "CarStatus = '" & UCase(cbStatus.Text) & " ' " _
        & "WHERE ID=" & txId.Text
        cm.Connection = cn
        cm.ExecuteNonQuery()
        cn.Close()
        UpdateSub()

        MessageBox.Show("Information Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txId.Text = ""
        txtName.Text = ""
        txtModel.Text = ""
        cbStatus.Text = ""
    End Sub
End Class