Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const cost1 As Double = 0.08
        Const cost2 As Double = 0.05
        Const copyCap As Integer = 50
        Dim copies As Integer
        Dim copies2 As Integer
        Dim price1 As Double
        Dim price2 As Double
        Dim price3 As Double
        copies = CInt(txtCopies.Text)
        If copies <= copyCap Then
            price1 = cost1 * copies
            txtCost.Text = String.Format("{0:C}", price1)
        Else
            copies2 = copies - copyCap
            price1 = copyCap * cost1
            price2 = copies2 * cost2
            price3 = price1 + price2
            txtCost.Text = String.Format("{0:C}", price3)
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCost.Text = ""
        txtCopies.Text = ""
    End Sub
End Class
