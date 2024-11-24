Imports System.Data.DataTable
Imports System.Data.OleDb
Public Class LOGIN
    Dim Status As String = " "
    Dim con As New OleDb.OleDbConnection
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim messi As String
        Dim User As String
        Dim Pass As String
        User = CStr(txtUsername.Text)
        Pass = CStr(txtPassword.Text)
        messi = login(User, Pass)

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Function login(ByVal user As String, ByVal pass As String) As String
        Dim messa As String
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asekho gunya\Desktop\devsProject\Login Table.accdb"
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * from LoginTable where Username = '" & txtUsername.Text & "' AND [Password] ='" & txtPassword.Text & "'", con)
        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If radCustomer.Checked = True Then
            sdr.Read()
            messa = ("login successful")
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
            txtPassword.Focus()
            Me.Hide()
            Form4.Show()
            con.Close()

        ElseIf radAdmin.Checked = True Then
            sdr.Read()
            messa = ("login successful")
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
            txtPassword.Focus()
            Me.Hide()
            Form7.Show()
            con.Close()
        Else
            messa = ("INFORMATION PROVIDED IS NOT ENOUGH")
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
            txtPassword.Focus()
            con.Close()


        End If
        Return messa
    End Function
End Class