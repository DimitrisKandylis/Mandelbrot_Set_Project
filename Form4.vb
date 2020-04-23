Public Class Form4
    ' Exit button closes the app.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Mandelbrot_Set.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Form11.colors(0)
        PictureBox2.BackColor = Form11.colors(1)
        PictureBox3.BackColor = Form11.colors(2)
        PictureBox4.BackColor = Form11.colors(3)
        PictureBox5.BackColor = Form11.colors(4)
        PictureBox6.BackColor = Form11.colors(5)
        PictureBox7.BackColor = Form11.colors(6)
        PictureBox8.BackColor = Form11.colors(7)
        PictureBox9.BackColor = Form11.colors(8)
        PictureBox10.BackColor = Form11.colors(9)
    End Sub
End Class