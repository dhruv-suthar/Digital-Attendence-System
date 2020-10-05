Public Class Admin_login

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Menus.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim uname As String
        Dim pass As String
        uname = TextBox1.Text
        pass = TextBox3.Text
        If uname = "Admin" And pass = "Admin" Then
            MessageBox.Show("Login successfull")
            'Search_attendence.Show()
            Admin_menu.Show()
            'Loading_page.Close()
            Me.Close()


        Else
            MsgBox("Login Unsuccessfull")
            TextBox1.Text = ""
            TextBox3.Text = ""

        End If
       

    End Sub

    Private Sub Admin_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class