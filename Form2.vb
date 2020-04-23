Imports System.Drawing.Drawing2D

Public Class Mandelbrot_Set
    Dim Max_Width As Integer
    Dim Max_Height As Integer
    Dim Posx As Integer
    Dim Posy As Integer
    Dim Zom As Double

    ' This button closes the app.
    Private Sub CloseApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseApplicationToolStripMenuItem.Click
        Me.Close()
        Welcome.Close()
        Form3.Close()
    End Sub
    ' This button closes the form and return to the selection form.
    Private Sub ReturnToPreviousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToPreviousToolStripMenuItem.Click
        Form3.Show()
        Me.Close()
    End Sub
    ' Depending on the color set, a form appears explaining each color.
    Private Sub ExplainTheColorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExplainTheColorsToolStripMenuItem.Click
        Form4.Show()
    End Sub
    ' Information about the Mandelbrot Set.
    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        Form5.Show()
    End Sub
    ' Limited zoom.
    Private Sub PictureBox_MouseWheel(sender As System.Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        If e.Delta <> 0 Then
            If e.Delta <= 0 Then
                If PictureBox1.Width < 1295 Then Exit Sub
            Else
                If PictureBox1.Width > 7000 Then Exit Sub
            End If

            PictureBox1.Width += CInt(PictureBox1.Width * e.Delta / 1000)
            PictureBox1.Height += CInt(PictureBox1.Height * e.Delta / 1000)
        End If

        PictureBox1.Refresh()
    End Sub
    ' This button saves the image in the bin folder.
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If Form3.RadioButton1.Checked Then
            PictureBox1.Image.Save("SeahorseValley.Jpeg")
            MessageBox.Show("Image saved as Jpeg File.", "Saved")
        ElseIf Form3.RadioButton2.Checked Then
            PictureBox1.Image.Save("LimitPoints.Jpeg")
            MessageBox.Show("Image saved as Jpeg File.", "Saved")
        ElseIf Form3.RadioButton3.Checked Then
            PictureBox1.Image.Save("BodyLimits.Jpeg")
            MessageBox.Show("Image saved as Jpeg File.", "Saved")
        ElseIf Form3.RadioButton4.Checked Then
            PictureBox1.Image.Save("Seahorses.Jpeg")
            MessageBox.Show("Image saved as Jpeg File.", "Saved")
        ElseIf Form3.RadioButton5.Checked Then
            PictureBox1.Image.Save("DoubleSpirals.Jpeg")
            MessageBox.Show("Image saved as Jpeg File.", "Saved")
        ElseIf Form3.RadioButton6.Checked Then
            PictureBox1.Image.Save("MandelbrotSet.Jpeg")
            MessageBox.Show("Image saved as Jpeg File.", "Saved")
        End If
    End Sub
    ' Load parameters for Mandelbrot Set
    Private Sub PictureBox1_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted
        Max_Width = Me.PictureBox1.Width
        Max_Height = Me.PictureBox1.Height
        Posx = -(Me.PictureBox1.Width) / 2
        Posy = -(Me.PictureBox1.Height) / 2
        Zom = 0.25
    End Sub
    ' Freroam - Zoom
    Private Sub Mandelbrot_Set_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp, MyBase.KeyDown
        If Form3.RadioButton6.Checked = True Then
            Select Case e.KeyCode
                Case Keys.Right
                    Posx += 100
                    Form3.Move_Around(Posx, Posy, Zom)
                    e.Handled = True
                Case Keys.Left
                    Posx -= 100
                    Form3.Move_Around(Posx, Posy, Zom)
                    e.Handled = True
                Case Keys.Up
                    Posy -= 100
                    Form3.Move_Around(Posx, Posy, Zom)
                    e.Handled = True
                Case Keys.Down
                    Posy += 100
                    Form3.Move_Around(Posx, Posy, Zom)
                    e.Handled = True
                Case Keys.F1
                    Zom += 0.25
                    Form3.Move_Around(Posx, Posy, Zom)
                    e.Handled = True
                Case Keys.F2
                    Zom -= 0.25
                    Form3.Move_Around(Posx, Posy, Zom)
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub ControlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlsToolStripMenuItem.Click
        Form6.Show()
    End Sub
End Class