Imports System.Numerics
Imports System.Drawing

Public Class Form3
    ' Exit button closes the app
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Welcome.Close()
    End Sub
    ' Begin button draws the set after giving coordinates, choosing a color set and a specific area of the set.
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim go As Boolean = True

        ' Elegxos gia ta 3 stoixeia.
        If RadioButton1.Checked() Or RadioButton2.Checked() Or RadioButton3.Checked() Or RadioButton4.Checked() Or RadioButton5.Checked() Then
            If Form11.CheckBox1.Checked = False Then
                go = False
            End If
        Else
            If Not IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Then
                go = False
            End If
            If Not RadioButton1.Checked And Not RadioButton2.Checked And Not RadioButton3.Checked And Not RadioButton4.Checked And Not RadioButton5.Checked And Not RadioButton6.Checked Then
                go = False
            End If
            If Form11.CheckBox1.Checked = False Then
                go = False
            End If
        End If

        If go = True Then
            Me.Hide()
            Mandelbrot_Set.Show()
            If RadioButton1.Checked Then
                Draw_Seahorse_Valley()
            ElseIf RadioButton2.Checked Then
                Draw_Oriaka(Mandelbrot_Set.PictureBox1.Width, Mandelbrot_Set.PictureBox1.Height)
            ElseIf RadioButton3.Checked Then
                Draw_Body_orio()
            ElseIf RadioButton4.Checked Then
                Draw_Seahorses()
            ElseIf RadioButton5.Checked Then
                Draw_Double_Spirals()
            ElseIf RadioButton6.Checked Then
                Draw_Set(Mandelbrot_Set.PictureBox1.Width, Mandelbrot_Set.PictureBox1.Height)
            End If
        Else
            MessageBox.Show("Incorrect Input! Please try again.")
        End If
    End Sub
    ' The Draw_Set sub draws the whole Mandelbrot set.
    ' It determines the color of every pixel according to the number of iterations it takes
    ' for its magnitude to surpass 2.0.
    Public Sub Draw_Set(input_width As Integer, input_Height As Integer)
        Dim diag As New Bitmap(input_width, input_Height)
        Dim diag_graphics As Graphics = Graphics.FromImage(diag)
        Dim xrwmata() As Color = Form11.getColors()

        For x As Integer = 0 To input_width - 1 Step 1
            For y As Integer = 0 To input_Height - 1 Step 1
                Dim a As Double = (x - (input_width) / 2) / (input_width / 4)
                Dim b As Double = (y - (input_Height) / 2) / (input_Height / 4)
                Dim c As New Complex(a, b)
                Dim z As New Complex(0, 0)
                Dim iteration As Integer = 0

                Do While iteration < 1000
                    iteration += 1
                    z = z * z
                    z = z + c

                    If z.Magnitude > 2.0 Then
                        Exit Do
                    End If
                Loop
                If x.ToString() = TextBox1.Text And y.ToString() = TextBox2.Text Then
                    If iteration < 1000 Then
                        diag.SetPixel(x, y, Color.Red)
                    End If

                Else
                    If iteration < 10 Then
                        diag.SetPixel(x, y, xrwmata(0))
                    ElseIf iteration >= 10 And iteration < 25 Then
                        diag.SetPixel(x, y, xrwmata(1))
                    ElseIf iteration >= 25 And iteration < 50 Then
                        diag.SetPixel(x, y, xrwmata(2))
                    ElseIf iteration >= 50 And iteration < 75 Then
                        diag.SetPixel(x, y, xrwmata(3))
                    ElseIf iteration >= 75 And iteration < 100 Then
                        diag.SetPixel(x, y, xrwmata(4))
                    ElseIf iteration >= 100 And iteration < 250 Then
                        diag.SetPixel(x, y, xrwmata(5))
                    ElseIf iteration >= 250 And iteration < 500 Then
                        diag.SetPixel(x, y, xrwmata(6))
                    ElseIf iteration >= 500 And iteration < 750 Then
                        diag.SetPixel(x, y, xrwmata(7))
                    ElseIf iteration >= 750 And iteration < 1000 Then
                        diag.SetPixel(x, y, xrwmata(8))
                    Else
                        diag.SetPixel(x, y, xrwmata(9))
                    End If
                End If
            Next
        Next
        Mandelbrot_Set.PictureBox1.Image = diag
    End Sub
    ' Info button opens a messagebox which has info for drawing the set.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("The Coordinates symbolize the pixels of the image and start from Point(0,0), which is the top left corner of the Window. The specific Point can be spoted if you Draw the Mandelbrot Set (check the specific radio button). Select the Colors you prefer and the part of the Set you would like to draw. The selection of the coordinates do not change anything in the outcome of the Set, it just marks your selected Point in the Set.", "Information")
    End Sub
    ' The Draw_Set sub draws specific limit points of the Mandelbrot set.
    ' It determines the color of every pixel according to the number of iterations it takes
    ' for its magnitude to surpass 2.0.
    Public Sub Draw_Oriaka(input_width As Integer, input_Height As Integer)
        Dim diag As New Bitmap(Mandelbrot_Set.PictureBox1.Width, Mandelbrot_Set.PictureBox1.Height)
        Dim diag_graphics As Graphics = Graphics.FromImage(diag)
        Dim xrwmata() As Color = Form11.getColors()

        For x As Integer = 0 To Mandelbrot_Set.PictureBox1.Width - 1 Step 1
            For y As Integer = 0 To Mandelbrot_Set.PictureBox1.Height - 1 Step 1
                Dim a As Double = (x + 300) / (2.9 * Mandelbrot_Set.PictureBox1.Width)
                Dim b As Double = (y + 650) / (2.9 * Mandelbrot_Set.PictureBox1.Height)
                Dim c As New Complex(a, b)
                Dim z As New Complex(0, 0)
                Dim iteration As Integer = 0

                Do While iteration < 1000
                    iteration += 1
                    z = z * z
                    z = z + c

                    If z.Magnitude > 2.0 Then
                        Exit Do
                    End If
                Loop
                If iteration < 10 Then
                    diag.SetPixel(x, y, xrwmata(0))
                ElseIf iteration >= 10 And iteration < 25 Then
                    diag.SetPixel(x, y, xrwmata(1))
                ElseIf iteration >= 25 And iteration < 50 Then
                    diag.SetPixel(x, y, xrwmata(2))
                ElseIf iteration >= 50 And iteration < 75 Then
                    diag.SetPixel(x, y, xrwmata(3))
                ElseIf iteration >= 75 And iteration < 100 Then
                    diag.SetPixel(x, y, xrwmata(4))
                ElseIf iteration >= 100 And iteration < 250 Then
                    diag.SetPixel(x, y, xrwmata(5))
                ElseIf iteration >= 250 And iteration < 500 Then
                    diag.SetPixel(x, y, xrwmata(6))
                ElseIf iteration >= 500 And iteration < 750 Then
                    diag.SetPixel(x, y, xrwmata(7))
                ElseIf iteration >= 750 And iteration < 1000 Then
                    diag.SetPixel(x, y, xrwmata(8))
                Else
                    diag.SetPixel(x, y, xrwmata(9))
                End If
            Next
        Next
        Mandelbrot_Set.PictureBox1.Image = diag
    End Sub
    ' The Colors button opens the form with the color set selection.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form11.Show()
    End Sub
    ' The Draw_Set sub draws the valley that forms at the body of the Mandelbrot set.
    ' It determines the color of every pixel according to the number of iterations it takes
    ' for its magnitude to surpass 2.0.
    Public Sub Draw_Body_orio()
        Dim diag As New Bitmap(Mandelbrot_Set.PictureBox1.Width, Mandelbrot_Set.PictureBox1.Height)
        Dim diag_graphics As Graphics = Graphics.FromImage(diag)
        Dim xrwmata() As Color = Form11.getColors()

        For x As Integer = 0 To Mandelbrot_Set.PictureBox1.Width - 1 Step 1
            For y As Integer = 0 To Mandelbrot_Set.PictureBox1.Height - 1 Step 1
                Dim a As Double = (x + 2300) / (8 * Mandelbrot_Set.PictureBox1.Width)
                Dim b As Double = (y - 350) / (8 * Mandelbrot_Set.PictureBox1.Height)
                Dim c As New Complex(a, b)
                Dim z As New Complex(0, 0)
                Dim iteration As Integer = 0

                Do While iteration < 1000
                    iteration += 1
                    z = z * z
                    z = z + c

                    If z.Magnitude > 2.0 Then
                        Exit Do
                    End If
                Loop
                If iteration < 10 Then
                    diag.SetPixel(x, y, xrwmata(0))
                ElseIf iteration >= 10 And iteration < 25 Then
                    diag.SetPixel(x, y, xrwmata(1))
                ElseIf iteration >= 25 And iteration < 50 Then
                    diag.SetPixel(x, y, xrwmata(2))
                ElseIf iteration >= 50 And iteration < 75 Then
                    diag.SetPixel(x, y, xrwmata(3))
                ElseIf iteration >= 75 And iteration < 100 Then
                    diag.SetPixel(x, y, xrwmata(4))
                ElseIf iteration >= 100 And iteration < 250 Then
                    diag.SetPixel(x, y, xrwmata(5))
                ElseIf iteration >= 250 And iteration < 500 Then
                    diag.SetPixel(x, y, xrwmata(6))
                ElseIf iteration >= 500 And iteration < 750 Then
                    diag.SetPixel(x, y, xrwmata(7))
                ElseIf iteration >= 750 And iteration < 1000 Then
                    diag.SetPixel(x, y, xrwmata(8))
                Else
                    diag.SetPixel(x, y, xrwmata(9))
                End If
            Next
        Next
        Mandelbrot_Set.PictureBox1.Image = diag
    End Sub
    ' The Draw_Set sub draws the Seahorse Valley that forms between the head and the body of the Mandelbrot set.
    ' It determines the color of every pixel according to the number of iterations it takes
    ' for its magnitude to surpass 2.0.
    Public Sub Draw_Seahorse_Valley()
        Dim diag As New Bitmap(Mandelbrot_Set.PictureBox1.Width, Mandelbrot_Set.PictureBox1.Height)
        Dim diag_graphics As Graphics = Graphics.FromImage(diag)
        Dim xrwmata() As Color = Form11.getColors()

        For x As Integer = 0 To Mandelbrot_Set.PictureBox1.Width - 1 Step 1
            For y As Integer = 0 To Mandelbrot_Set.PictureBox1.Height - 1 Step 1
                Dim a As Double = (x - 5000) / (5 * Mandelbrot_Set.PictureBox1.Width)
                Dim b As Double = (y + 200) / (5 * Mandelbrot_Set.PictureBox1.Height)
                Dim c As New Complex(a, b)
                Dim z As New Complex(0, 0)
                Dim iteration As Integer = 0

                Do While iteration < 1000
                    iteration += 1
                    z = z * z
                    z = z + c

                    If z.Magnitude > 2.0 Then
                        Exit Do
                    End If
                Loop
                If iteration < 10 Then
                    diag.SetPixel(x, y, xrwmata(0))
                ElseIf iteration >= 10 And iteration < 25 Then
                    diag.SetPixel(x, y, xrwmata(1))
                ElseIf iteration >= 25 And iteration < 50 Then
                    diag.SetPixel(x, y, xrwmata(2))
                ElseIf iteration >= 50 And iteration < 75 Then
                    diag.SetPixel(x, y, xrwmata(3))
                ElseIf iteration >= 75 And iteration < 100 Then
                    diag.SetPixel(x, y, xrwmata(4))
                ElseIf iteration >= 100 And iteration < 250 Then
                    diag.SetPixel(x, y, xrwmata(5))
                ElseIf iteration >= 250 And iteration < 500 Then
                    diag.SetPixel(x, y, xrwmata(6))
                ElseIf iteration >= 500 And iteration < 750 Then
                    diag.SetPixel(x, y, xrwmata(7))
                ElseIf iteration >= 750 And iteration < 1000 Then
                    diag.SetPixel(x, y, xrwmata(8))
                Else
                    diag.SetPixel(x, y, xrwmata(9))
                End If
            Next
        Next
        Mandelbrot_Set.PictureBox1.Image = diag
    End Sub
    ' The Draw_Set sub draws Seahorses that form at the Seahorse Valley.
    ' It determines the color of every pixel according to the number of iterations it takes
    ' for its magnitude to surpass 2.0.
    Public Sub Draw_Seahorses()
        Dim diag As New Bitmap(Mandelbrot_Set.PictureBox1.Width, Mandelbrot_Set.PictureBox1.Height)
        Dim diag_graphics As Graphics = Graphics.FromImage(diag)
        Dim xrwmata() As Color = Form11.getColors()

        For x As Integer = 0 To Mandelbrot_Set.PictureBox1.Width - 1 Step 1
            For y As Integer = 0 To Mandelbrot_Set.PictureBox1.Height - 1 Step 1
                Dim a As Double = (x - 12700) / (14 * Mandelbrot_Set.PictureBox1.Width)
                Dim b As Double = (y + 1000) / (14 * Mandelbrot_Set.PictureBox1.Height)
                Dim c As New Complex(a, b)
                Dim z As New Complex(0, 0)
                Dim iteration As Integer = 0

                Do While iteration < 1000
                    iteration += 1
                    z = z * z
                    z = z + c

                    If z.Magnitude > 2.0 Then
                        Exit Do
                    End If
                Loop
                If iteration < 10 Then
                    diag.SetPixel(x, y, xrwmata(0))
                ElseIf iteration >= 10 And iteration < 25 Then
                    diag.SetPixel(x, y, xrwmata(1))
                ElseIf iteration >= 25 And iteration < 50 Then
                    diag.SetPixel(x, y, xrwmata(2))
                ElseIf iteration >= 50 And iteration < 75 Then
                    diag.SetPixel(x, y, xrwmata(3))
                ElseIf iteration >= 75 And iteration < 100 Then
                    diag.SetPixel(x, y, xrwmata(4))
                ElseIf iteration >= 100 And iteration < 250 Then
                    diag.SetPixel(x, y, xrwmata(5))
                ElseIf iteration >= 250 And iteration < 500 Then
                    diag.SetPixel(x, y, xrwmata(6))
                ElseIf iteration >= 500 And iteration < 750 Then
                    diag.SetPixel(x, y, xrwmata(7))
                ElseIf iteration >= 750 And iteration < 1000 Then
                    diag.SetPixel(x, y, xrwmata(8))
                Else
                    diag.SetPixel(x, y, xrwmata(9))
                End If
            Next
        Next
        Mandelbrot_Set.PictureBox1.Image = diag
    End Sub
    ' The Draw_Set sub draws Double Spirals that form at the Seahorse Valley.
    ' It determines the color of every pixel according to the number of iterations it takes
    ' for its magnitude to surpass 2.0.
    Public Sub Draw_Double_Spirals()
        Dim diag As New Bitmap(Mandelbrot_Set.PictureBox1.Width, Mandelbrot_Set.PictureBox1.Height)
        Dim diag_graphics As Graphics = Graphics.FromImage(diag)
        Dim xrwmata() As Color = Form11.getColors()

        For x As Integer = 0 To Mandelbrot_Set.PictureBox1.Width - 1 Step 1
            For y As Integer = 0 To Mandelbrot_Set.PictureBox1.Height - 1 Step 1
                Dim a As Double = (x - 13700) / (14 * Mandelbrot_Set.PictureBox1.Width)
                Dim b As Double = (y + 1100) / (14 * Mandelbrot_Set.PictureBox1.Height)
                Dim c As New Complex(a, b)
                Dim z As New Complex(0, 0)
                Dim iteration As Integer = 0

                Do While iteration < 1000
                    iteration += 1
                    z = z * z
                    z = z + c

                    If z.Magnitude > 2.0 Then
                        Exit Do
                    End If
                Loop
                If iteration < 10 Then
                    diag.SetPixel(x, y, xrwmata(0))
                ElseIf iteration >= 10 And iteration < 25 Then
                    diag.SetPixel(x, y, xrwmata(1))
                ElseIf iteration >= 25 And iteration < 50 Then
                    diag.SetPixel(x, y, xrwmata(2))
                ElseIf iteration >= 50 And iteration < 75 Then
                    diag.SetPixel(x, y, xrwmata(3))
                ElseIf iteration >= 75 And iteration < 100 Then
                    diag.SetPixel(x, y, xrwmata(4))
                ElseIf iteration >= 100 And iteration < 250 Then
                    diag.SetPixel(x, y, xrwmata(5))
                ElseIf iteration >= 250 And iteration < 500 Then
                    diag.SetPixel(x, y, xrwmata(6))
                ElseIf iteration >= 500 And iteration < 750 Then
                    diag.SetPixel(x, y, xrwmata(7))
                ElseIf iteration >= 750 And iteration < 1000 Then
                    diag.SetPixel(x, y, xrwmata(8))
                Else
                    diag.SetPixel(x, y, xrwmata(9))
                End If
            Next
        Next
        Mandelbrot_Set.PictureBox1.Image = diag
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form11.colors(0) = Color.Cyan
        Form11.Button1.BackColor = Color.Cyan

        Form11.colors(1) = Color.DodgerBlue
        Form11.Button2.BackColor = Color.DodgerBlue

        Form11.colors(2) = Color.DeepSkyBlue
        Form11.Button3.BackColor = Color.DeepSkyBlue

        Form11.colors(3) = Color.CornflowerBlue
        Form11.Button4.BackColor = Color.CornflowerBlue

        Form11.colors(4) = Color.DarkOrchid
        Form11.Button5.BackColor = Color.DarkOrchid

        Form11.colors(5) = Color.SlateBlue
        Form11.Button6.BackColor = Color.SlateBlue

        Form11.colors(6) = Color.Blue
        Form11.Button7.BackColor = Color.Blue

        Form11.colors(7) = Color.MediumAquamarine
        Form11.Button8.BackColor = Color.MediumAquamarine

        Form11.colors(8) = Color.DarkSlateBlue
        Form11.Button9.BackColor = Color.DarkSlateBlue

        Form11.colors(9) = Color.DarkBlue
        Form11.Button10.BackColor = Color.DarkBlue

        Form11.CheckBox1.Checked = True
    End Sub

    Public Sub Move_Around(ix As Integer, iy As Integer, j As Double)
        Dim diag As New Bitmap(Mandelbrot_Set.PictureBox1.Width, Mandelbrot_Set.PictureBox1.Height)
        Dim diag_graphics As Graphics = Graphics.FromImage(diag)
        Dim xrwmata() As Color = Form11.getColors()

        For x As Integer = 0 To Mandelbrot_Set.PictureBox1.Width - 1 Step 1
            For y As Integer = 0 To Mandelbrot_Set.PictureBox1.Height - 1 Step 1
                Dim a As Double = (x + ix) / (Mandelbrot_Set.PictureBox1.Width * j)
                Dim b As Double = (y + iy) / (Mandelbrot_Set.PictureBox1.Height * j)
                Dim c As New Complex(a, b)
                Dim z As New Complex(0, 0)
                Dim iteration As Integer = 0

                Do While iteration < 1000
                    iteration += 1
                    z = z * z
                    z = z + c

                    If z.Magnitude > 2.0 Then
                        Exit Do
                    End If
                Loop
                If x.ToString() = TextBox1.Text And y.ToString() = TextBox2.Text Then
                    If iteration < 1000 Then
                        diag.SetPixel(x, y, Color.Red)
                    End If

                Else
                    If iteration < 10 Then
                        diag.SetPixel(x, y, xrwmata(0))
                    ElseIf iteration >= 10 And iteration < 25 Then
                        diag.SetPixel(x, y, xrwmata(1))
                    ElseIf iteration >= 25 And iteration < 50 Then
                        diag.SetPixel(x, y, xrwmata(2))
                    ElseIf iteration >= 50 And iteration < 75 Then
                        diag.SetPixel(x, y, xrwmata(3))
                    ElseIf iteration >= 75 And iteration < 100 Then
                        diag.SetPixel(x, y, xrwmata(4))
                    ElseIf iteration >= 100 And iteration < 250 Then
                        diag.SetPixel(x, y, xrwmata(5))
                    ElseIf iteration >= 250 And iteration < 500 Then
                        diag.SetPixel(x, y, xrwmata(6))
                    ElseIf iteration >= 500 And iteration < 750 Then
                        diag.SetPixel(x, y, xrwmata(7))
                    ElseIf iteration >= 750 And iteration < 1000 Then
                        diag.SetPixel(x, y, xrwmata(8))
                    Else
                        diag.SetPixel(x, y, xrwmata(9))
                    End If
                End If
            Next
        Next
        Mandelbrot_Set.PictureBox1.Image = diag
    End Sub
End Class