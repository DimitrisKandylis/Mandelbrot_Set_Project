Public Class Form11
    Public colors(10) As Color
    ' This function returns the array of colors needed for the drawing of the set.
    Public Function getColors() As Color()
        Return colors
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        Button1.BackColor = ColorDialog1.Color
        colors(0) = ColorDialog1.Color
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        Button2.BackColor = ColorDialog1.Color
        colors(1) = ColorDialog1.Color
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.ShowDialog()
        Button3.BackColor = ColorDialog1.Color
        colors(2) = ColorDialog1.Color
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        Button4.BackColor = ColorDialog1.Color
        colors(3) = ColorDialog1.Color
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ColorDialog1.ShowDialog()
        Button5.BackColor = ColorDialog1.Color
        colors(4) = ColorDialog1.Color
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ColorDialog1.ShowDialog()
        Button6.BackColor = ColorDialog1.Color
        colors(5) = ColorDialog1.Color
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ColorDialog1.ShowDialog()
        Button7.BackColor = ColorDialog1.Color
        colors(6) = ColorDialog1.Color
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ColorDialog1.ShowDialog()
        Button8.BackColor = ColorDialog1.Color
        colors(7) = ColorDialog1.Color
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ColorDialog1.ShowDialog()
        Button9.BackColor = ColorDialog1.Color
        colors(8) = ColorDialog1.Color
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ColorDialog1.ShowDialog()
        Button10.BackColor = ColorDialog1.Color
        colors(9) = ColorDialog1.Color
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If CheckBox1.Checked Then
            Me.Hide()
        Else
            MessageBox.Show("Check the 'Complete' box when you're done selecting the colors.", "Error")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Button1.BackColor = DefaultBackColor Or Button2.BackColor = DefaultBackColor Or Button3.BackColor = DefaultBackColor Or Button4.BackColor = DefaultBackColor Or Button5.BackColor = DefaultBackColor Or Button6.BackColor = DefaultBackColor Or Button7.BackColor = DefaultBackColor Or Button8.BackColor = DefaultBackColor Or Button9.BackColor = DefaultBackColor Or Button10.BackColor = DefaultBackColor Then
            MessageBox.Show("You must select all colors!", "Error")
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = False
    End Sub
End Class