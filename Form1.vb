Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Установка начального значения через специальный метод
        NumericTextBox1.SetText("123")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Попытка изменить текст из кода - не сработает
        NumericTextBox1.Text = "456"

        ' Вывод текущего значения
        MessageBox.Show("Текущее значение: " & NumericTextBox1.Text)
    End Sub
End Class