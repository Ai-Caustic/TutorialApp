Imports System.Drawing.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, sum As Single
        num1 = Textbox1.Text
        num2 = TextBox2.Text
        sum = num1 + num2
        label1.Text = sum
    End Sub
End Class
