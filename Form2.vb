Imports System.Data.OleDb
Imports System.Data
Public Class Form2
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim source As New BindingSource

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asekho gunya\Desktop\devsProject\Login Table.accdb"
        con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Insert into LoginTable values(?,?,?,?,?,?,?,?)", con)
        cmd.Parameters.Add(New OleDbParameter("Username", (txtUsername.Text)))
        cmd.Parameters.Add(New OleDbParameter("Password", (txtPassword.Text)))
        cmd.Parameters.Add(New OleDbParameter("Surname", (txtSurname.Text)))
        cmd.Parameters.Add(New OleDbParameter("Name", (txtName.Text)))
        cmd.Parameters.Add(New OleDbParameter("ID_Number", (txtIDnumber.Text)))
        cmd.Parameters.Add(New OleDbParameter("Address", (txtAddress.Text)))
        cmd.Parameters.Add(New OleDbParameter("CellNumber", (txtCellNumber.Text)))
        cmd.Parameters.Add(New OleDbParameter("Email", (txtEmail.Text)))


        cmd = New OleDbCommand("insert into admin values (?,?,?,?,?,?)", con)
        cmd.Parameters.Add(New OleDbParameter("Address", (txtAddress.Text)))
        cmd.Parameters.Add(New OleDbParameter("ID_Number", (txtIDnumber.Text)))
        cmd.Parameters.Add(New OleDbParameter("Name", (txtName.Text)))
        cmd.Parameters.Add(New OleDbParameter("Surname", (txtSurname.Text)))
        cmd.Parameters.Add(New OleDbParameter("CellNumber", (txtCellNumber.Text)))
        cmd.Parameters.Add(New OleDbParameter("Email", (txtEmail.Text)))
        Try

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("You Are Successfully registered")
            txtName.Clear()
            txtSurname.Clear()
            txtIDnumber.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtAddress.Clear()
            txtCellNumber.Clear()
            txtEmail.Clear()
            con.Close()
            MessageBox.Show("YOU ARE NOW BEING DIRECTED TO THE LOGIN PAGE")
            Me.Hide()
            LOGIN.Show()
        Catch ex As Exception
            MessageBox.Show(ex.message)
            txtUsername.Clear()
            txtPassword.Clear()
            txtAddress.Clear()
            txtCellNumber.Clear()
            txtEmail.Clear()

        End Try
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        LOGIN.Show()
        Me.Hide()
    End Sub
End Class
