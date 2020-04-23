Public Class Form5
    ' Ok button closes the information form and returns to form2.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Mandelbrot_Set.Show()
    End Sub
End Class