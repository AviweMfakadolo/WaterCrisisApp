Imports System.Data
Imports System.Data.OleDb


Public Class Form5
    Dim price As Integer
    Dim conn As New OleDb.OleDbConnection

    Dim otp As Integer = 3789
    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asekho gunya\Desktop\devsProject\Login Table.accdb"
        conn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Insert into BankDetails values(?,?,?)", conn)
        cmd.Parameters.Add(New OleDbParameter("CARDNUMBER", (txtCardNum.Text)))
        cmd.Parameters.Add(New OleDbParameter("CVV", (txtCCV.Text)))
        cmd.Parameters.Add(New OleDbParameter("EXPIRYDATE", (txtEXP.Text)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            MessageBox.Show("your details are correct, press CHECK to recieve OTP")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If (IsNumeric(txtOTP.Text)) = True Then
            MessageBox.Show("YOUR PURCHASE WAS SUCCESSFUL, THANK YOU!")
        End If
    End Sub

    Private Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click


        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asekho gunya\Desktop\devsProject\Login Table.accdb"
        conn.Open()
        If rad500L.Checked = True Then
            price = 150
        ElseIf rad1500L.Checked = True Then
            price = 320
        ElseIf rad2500L.Checked = True Then
            price = 580
        ElseIf rad8000L.Checked = True Then
            price = 830
        Else
            MessageBox.Show("Nothing")

        End If
        Dim cmd As OleDbCommand = New OleDbCommand("select * from BankDetails where CardNumber ='" & txtCardNum.Text & "' AND CVV = '" & txtCCV.Text & "' AND ExpiryDate = '" & txtEXP.Text & "' ", conn)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If sdr.Read() = True Then
            MessageBox.Show(otp)
            conn.Close()
        Else
            MessageBox.Show("You made a mistake on the information above, please try to re-enter your details correctly")
            txtEXP.Clear()
            txtCardNum.Clear()
            txtCCV.Clear()
            conn.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class