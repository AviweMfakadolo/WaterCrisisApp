Public Class Form4
    Private Sub btnBuyWater_Click(sender As Object, e As EventArgs) Handles btnBuyWater.Click
        Me.Hide()

        Form5.Show()

    End Sub

    Private Sub btnPayServices_Click(sender As Object, e As EventArgs) Handles btnPayServices.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LOGIN.Show()
        Me.Hide()
    End Sub
End Class