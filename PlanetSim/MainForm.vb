Public Class MainForm

    Dim WithEvents Animator As New Timer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Animator
            .Interval = 17
        End With
    End Sub


    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SolarSystem.Invalidate()
    End Sub

    Private Sub bt_start_Click(sender As Object, e As EventArgs) Handles bt_start.Click
        Animator.Start()
    End Sub

    Private Sub Animator_Tick(sender As Object, e As EventArgs) Handles Animator.Tick
        For Each p As Planet In SolarSystem.Planets
            p.Animate()
        Next
        SolarSystem.Invalidate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Zoom(True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Zoom(False)
    End Sub

    Public Sub Zoom(ByVal ZoomIn As Boolean)
        For i = 1 To 30
            If ZoomIn Then
                SolarSystem.SolarSystem.Dimension += SolarSystem.SolarSystem.Dimension / 100
            Else
                SolarSystem.SolarSystem.Dimension -= SolarSystem.SolarSystem.Dimension / 100
            End If
            'Label1.Text = Math.Round(1 / SolarSystem.SolarSystem.Dimension, 3)
            SolarSystem.Invalidate()
            System.Threading.Thread.Sleep(5)
            My.Application.DoEvents()
        Next
    End Sub

    Private Sub SolarSystem_MouseHover(sender As Object, e As EventArgs) Handles SolarSystem.MouseHover
        SolarSystem.Focus()
    End Sub

    Private Sub SolarSystem_MouseWheel(sender As Object, e As MouseEventArgs) Handles SolarSystem.MouseWheel
        If e.Delta >= 0 Then
            Zoom(True)
        Else
            Zoom(False)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SolarSystem.SolarSystem.TimeFactor += SolarSystem.SolarSystem.TimeFactor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SolarSystem.SolarSystem.TimeFactor -= SolarSystem.SolarSystem.TimeFactor / 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        SolarSystem.Planets(3).MajorAxis += 0.1
    End Sub
End Class
