Imports System.Data
Imports System.Data.OleDb
Public Class Change_password
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin_menu.Show()
        Me.Close()

    End Sub
    Private Sub update_data()
        'Dim roll_no As Integer
        'roll_no = TextBox1.Text
      
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If


        Dim command = "UPDATE Create_Student SET [PASSWORD]='" & TextBox3.Text & "'  where [ROLL_NO]=" & TextBox1.Text & " and [PASSWORD]='" & TextBox2.Text & "' "


        Dim cmd As New OleDb.OleDbCommand
        cmd = New OleDbCommand(command, cnn)




        ' Dim dr As OleDbDataReader = cmd.ExecuteReader

        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        'If dr.Read = True Then
        '    MsgBox("LOGIN SUCCESS")
        '    login = True

        'Else
        '    MsgBox("LOGIN NOT SUCCESS")
        ' End If
        If i <> 0 Then
            MsgBox("password change successfully")
            PictureBox1.Visible = False
            PictureBox2.Visible = False

            PictureBox3.Visible = False
            PictureBox4.Visible = False


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            
        Else
            MsgBox("password not change successfully")
            PictureBox1.Visible = False
            PictureBox2.Visible = False

            PictureBox3.Visible = False
            PictureBox4.Visible = False
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
        cnn.Close()



    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click



    End Sub

  

    Private Sub PictureBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseClick
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        TextBox2.PasswordChar = "•"
    End Sub

    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        If TextBox2.Text = "" Then
            'roll_no = TextBox1.Text
            PictureBox2.Visible = False


        Else
            PictureBox2.Visible = True


        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        'TextBox2.PasswordChar = Font.Siemens Logo


    End Sub

    Private Sub Change_password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnn As New OleDb.OleDbConnection
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        TextBox3.PasswordChar = ""
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        TextBox3.PasswordChar = "•"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim roll_no As Integer
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("please fill up textbox")
            PictureBox1.Visible = False
            PictureBox2.Visible = False

            PictureBox3.Visible = False
            PictureBox4.Visible = False


           
        Else
            roll_no = TextBox1.Text


            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()

            End If



            Dim command = "select ROLL_NO,PASSWORD from Create_Student where ROLL_NO= " & roll_no.ToString & "  AND PASSWORD= '" & TextBox2.Text & "'"

            Dim cmd
            cmd = New OleDbCommand(command, cnn)


            Dim dr As OleDbDataReader = cmd.ExecuteReader





            If dr.Read = False Then
                '    MsgBox("CREATE SUCCESSFULL")
                MsgBox("Invalid Username or password")
                PictureBox1.Visible = False
                PictureBox2.Visible = False

                PictureBox3.Visible = False
                PictureBox4.Visible = False
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""

            Else
                update_data()

            End If


            cnn.Close()

        End If

    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim roll_no As Integer
        If TextBox1.Text = "" Then

            PictureBox1.Visible = False
            PictureBox4.Visible = False

        Else
            roll_no = TextBox1.Text
            Dim command = "select ROLL_NO from Create_Student where ROLL_NO= " & roll_no.ToString & ""
            Dim cmd As New OleDb.OleDbCommand
            cmd = New OleDbCommand(command, cnn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader



            ''i = cmd.ExecuteNonQuery()
            If dr.Read = True Then
                PictureBox1.Visible = True
                PictureBox4.Visible = False

            Else
                'Dim x = MessageBox.Show("this rollno not available", "create acc", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'If x = Windows.Forms.DialogResult.Yes Then
                '    Create_Student.Show()
                '    Me.Close()
                'End If
                PictureBox4.Visible = True
                PictureBox1.Visible = False


            End If
            cnn.Close()




        End If
       
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp
        If TextBox3.Text = "" Then
            'roll_no = TextBox1.Text
            PictureBox3.Visible = False


        Else
            PictureBox3.Visible = True


        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
