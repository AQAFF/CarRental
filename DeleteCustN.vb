
Public Class DeleteCustN
    Public Sub UpdateSubCust()
        On Error Resume Next
        ds.Clear()
        cm = cn.CreateCommand
        cm.CommandText = "select * from tbcustomer"
        da.SelectCommand = cm
        da.Fill(ds, "tbcustomer")
        txId.DataBindings.Add("Text", ds.Tables("tbcustomer"), "ID")
        txtName.DataBindings.Add("Text", ds.Tables("tbcustomer"), "Customer")
        txtNum.DataBindings.Add("Text", ds.Tables("tbcustomer"), "phone")
        txtIC.DataBindings.Add("Text", ds.Tables("tbcustomer"), "IDCard")
        dgvCustomer.DataSource = ds.Tables(0)
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this record?", "DeleteRecord",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
            cn.Open()
            Dim Del As OleDb.OleDbCommand = New OleDb.OleDbCommand()
            Del.CommandText = "Delete From tbcustomer Where ID = " & txId.Text
            Del.Connection = cn
            Del.ExecuteNonQuery()


            cn.Close()
            UpdateSubCust()
            MessageBox.Show("Data Have Been Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Me.Refresh()
        End If
    End Sub

    Private Sub DeleteCustN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateSubCust()
        txId.Enabled = False
        txtName.Enabled = False
        txtNum.Enabled = False
        txtIC.Enabled = False


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txId.Enabled = True
        txtName.Enabled = False
        txtNum.Enabled = False
        txtIC.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error Resume Next
        cn.Open()
        cm.CommandText = "UPDATE tbcustomer SET Customer = '" & UCase(txtName.Text) & " ', " _
        & "phone = '" & UCase(txtNum.Text) & " ', " _
        & "IDCard = '" & UCase(txtIC.Text) & " ' " _
        & "WHERE ID=" & txId.Text
        cm.Connection = cn
        cm.ExecuteNonQuery()
        cn.Close()
        UpdateSubCust()

        MessageBox.Show("Information Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txId.Enabled = True
        txtName.Enabled = True
        txtNum.Enabled = True
        txtIC.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txId.Text = ""
        txtName.Text = ""
        txtNum.Text = ""
        txtIC.Text = ""

    End Sub
End Class