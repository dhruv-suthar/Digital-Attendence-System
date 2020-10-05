Imports Bunifu

Public Class Loading_page
    Dim i As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        RectangleShape2.Width += 3
        'If RectangleShape2.Width >= 50 Then
        '    Timer1.Interval = 50

        'End If
        BunifuCircleProgressbar1.Value += 3

        If (RectangleShape2.Width >= 505) Then
            Timer1.Stop()
            Menus.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Loading_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'RectangleShape1.Visible = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        i = i + 3
        Label5.Text = i & " " & "%"

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BunifuSlider1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
