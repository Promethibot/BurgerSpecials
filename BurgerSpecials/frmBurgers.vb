Public Class frmBurgers
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picPrime.Visible = False
        picVeggie.Visible = True
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picVeggie.Visible = False
        picPrime.Visible = True
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnVeggie.Enabled = False
        btnPrime.Enabled = False
        btnSelectMeal.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub
End Class
