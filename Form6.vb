Imports System.Data
Imports System.Data.OleDb
Public Class Form6
    Dim conn As New OleDb.OleDbConnection
    Dim otp As String = "15A6bK79"
    Private Sub btnCONF_Click(sender As Object, e As EventArgs) Handles btnCONF.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asekho gunya\Desktop\devsProject\Login Table.accdb"
        conn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("select * from BankDetails", conn)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If sdr.Read() = True Then
            MessageBox.Show(otp)
            conn.Close()
        Else
            MessageBox.Show("You made a mistake on the information above, please try to re-enter your details correctly")
            txtDate.Clear()
            txtCC.Clear()
            txtAma.Clear()
            conn.Close()
        End If


    End Sub

    Private Sub btnPAY_Click(sender As Object, e As EventArgs) Handles btnPAY.Click
        If otp = "15A6bK79" Then
            MessageBox.Show("PAYMENT SUCCESSFUL")
        Else
            MessageBox.Show("ENTER CORRECT OTP")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class