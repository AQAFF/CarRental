
Imports System.Data.OleDb

Module Module1
    Public cn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\TUF\OneDrive\Documents\DbProject.mdb")
    Public cm As New OleDb.OleDbCommand
    Public ds As New DataSet
    Public da As New OleDb.OleDbDataAdapter


    Public sdr As OleDb.OleDbDataReader
    Public userlogin As String = ""
End Module
