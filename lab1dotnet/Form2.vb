Public Class Form2

    Private Function GetNumber(txt As TextBox) As Double
        Dim n As Double
        If Double.TryParse(txt.Text, n) Then
            Return n
        Else
            Throw New Exception("Invalid input")
        End If
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim a = GetNumber(txtNum1)
        Dim b = GetNumber(txtNum2)
        txtResult.Text = (a + b).ToString()
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim a = GetNumber(txtNum1)
        Dim b = GetNumber(txtNum2)
        txtResult.Text = (a - b).ToString()
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        Dim a = GetNumber(txtNum1)
        Dim b = GetNumber(txtNum2)
        txtResult.Text = (a * b).ToString()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim a = GetNumber(txtNum1)
        Dim b = GetNumber(txtNum2)

        If b = 0 Then
            MessageBox.Show("Cannot divide by zero")
            Exit Sub
        End If

        txtResult.Text = (a / b).ToString()
    End Sub

    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelMain.Paint

    End Sub
End Class
