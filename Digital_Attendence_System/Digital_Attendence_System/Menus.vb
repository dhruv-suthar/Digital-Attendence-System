Public Class Menus

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Student_login.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        'PictureBox1.Image = Image.FromFile("D:/vb_new_images/User_login.png")
        'PictureBox1.Image = Image.FromHbitmap("User_login.png")
        PictureBox1.Image = ImageList1.Images("User_login.png")

    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        'PictureBox1.Image = Image.FromFile("D:/vb_new_images/img_hover1.png")
        PictureBox1.Image = ImageList1.Images("img_hover1.png")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Teacher_Login.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        'PictureBox2.Image = Image.FromFile("D:/vb_new_images/Teacher_login.png")
        PictureBox2.Image = ImageList1.Images("Teacher_login.png")

    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        'PictureBox2.Image = Image.FromFile("D:/vb_new_images/Teacher_login_simple.png")
        PictureBox2.Image = ImageList1.Images("Teacher_login_simple.png")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Admin_login.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        'PictureBox3.Image = Image.FromFile("D:/vb_new_images/Admin.png")
        PictureBox3.Image = ImageList1.Images("Admin.png")
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        'PictureBox3.Image = Image.FromFile("D:/vb_new_images/Admin_login_simple.png")
        PictureBox3.Image = ImageList1.Images("Admin_login_simple.png")
    End Sub

    

   

    Private Sub Menus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Loading_page.Close()
    End Sub

    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        'Button4.Image = Image.FromFile("d:/vb_new_images/Exit_hover.png")
        Button4.Image = ImageList2.Images("Exit_hover.png")
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        'Button4.Image = Image.FromFile("d:/vb_new_images/Exit.png")
        Button4.Image = ImageList2.Images("Exit.png")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Student_login.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Teacher_Login.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Admin_login.Show()
        Me.Close()

    End Sub
    
    Private Sub Menus_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
End Class