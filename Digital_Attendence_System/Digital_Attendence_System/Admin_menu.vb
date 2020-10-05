Public Class Admin_menu

    Private Sub DataRepeater1_CurrentItemIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Select_Option.Show()
        Me.Close()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Search_attendence.Show()
        Me.Close()
    End Sub

    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.FromArgb(64, 0, 64)

    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black

    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = Image.FromFile("/vb_new_images/Admin_purple.png")



        'PictureBox1.Image = ImageList1.Images("Admin_purple.png")
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = Image.FromFile("/vb_new_images/Admin_64.png")




        'PictureBox1.Image = ImageList1.Images("Admin_64.png")

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Practical_info.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = Image.FromFile("d:/vb_new_images/Practical_purple.png")

        'PictureBox2.Image = ImageList1.Images("Practical_purple.png")
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = Image.FromFile("/vb_new_images/Practical_64.png")

        'PictureBox2.Image = ImageList1.Images("Practical_64.png")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Change_password.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Image = Image.FromFile("/vb_new_images/Change_Password_Purple.png")

        'PictureBox3.Image = ImageList1.Images("Change_Password_purple.png")
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = Image.FromFile("/vb_new_images/Change_Password_64.png")

        'PictureBox3.Image = ImageList1.Images("Change_Password_64.png")
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        About_us.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        PictureBox4.Image = Image.FromFile("/vb_new_images/About_purple.png")

        'PictureBox4.Image = ImageList1.Images("About_purple.png")
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = Image.FromFile("/vb_new_images/About.png")

        'PictureBox4.Image = ImageList1.Images("About.png")
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Practical_info.Show()
        Me.Close()

    End Sub

    Private Sub Label2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.FromArgb(64, 0, 64)

    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Change_password.Show()
        Me.Close()

    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Label3.ForeColor = Color.FromArgb(64, 0, 64)

    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Black

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        About_us.Show()
        Me.Close()
    End Sub

    Private Sub Label4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseHover
        Label4.ForeColor = Color.FromArgb(64, 0, 64)

    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Label1.ForeColor = Color.Black

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Menus.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        PictureBox5.Image = Image.FromFile("/vb_new_images/Exit_purple.png")
        'PictureBox5.Image = ImageList2.Images("Exit_purple.png")
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = Image.FromFile("/vb_new_images/Exit_49.png")
        'PictureBox5.Image = ImageList2.Images("Exit_49.png")
    End Sub

    Private Sub OvalShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape2.Click

    End Sub

    Private Sub Admin_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class