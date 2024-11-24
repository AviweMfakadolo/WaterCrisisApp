Imports System.Data
Imports System.Data.OleDb


Public Class Form7
    Dim ojc As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        ojc.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asekho gunya\Desktop\devsProject\Login Table.accdb"
        ojc.Open()
        tables = ds.Tables
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from admin ", ojc)
        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "admin")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = source
        ojc.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        LOGIN.Show()
        Me.Hide()
    End Sub
End Class