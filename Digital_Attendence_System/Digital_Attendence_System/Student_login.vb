Imports System.Data
Imports System.Data.OleDb

Public Class Student_login
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    Dim login As Boolean
    Dim logout As Boolean

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Leave

    End Sub
    ' Dim valid As Boolean = False

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""


    End Sub
    Private Sub Refresh_data()
        'Dim cmd As New OleDb.OleDbCommand
        ''cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
        ''
        'cnn.Open()


        ''End If
        'Dim da As New OleDb.OleDbDataAdapter("insert into Student_Table (ROLL_NO,NAME,DIV,PRACTICAL_NAME,PASSWORD) " + "values (" & TextBox1.Text & ",'" & TextBox3.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "') ;", cnn)
        'Dim dt As New DataTable

        'da.Fill(dt)
        'Me.DataGridView1.DataSource = dt
        'Dim cmd As New OleDb.OleDbCommand
        '' Dim i As Integer

        'cmd.Connection = cnn
        'If Not cnn.State = ConnectionState.Open Then
        '    cnn.Open()
        'End If

        'cmd.CommandText = "INSERT INTO Student_Table (ROLL_NO,NAME,DIV,PRACTICAL_NAME,PASSWORD)" + " VALUES (" & TextBox1.Text & ",'" & TextBox3.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "')"
        'Dim da As New OleDb.OleDbDataAdapter("INSERT INTO Student_Table (ROLL_NO,NAME,DIV,PRACTICAL_NAME,PASSWORD)" + " VALUES (" & TextBox1.Text & ",'" & TextBox3.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "')", cnn)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'Search_attendence.DataGridView1.DataSource = dt
        'i = cmd.ExecuteNonQuery()
        'If i <> 0 Then
        '    MsgBox("data also updated")
        'Else
        '    MsgBox("data not updated")
        'End If
        Dim d1
        d1 = Date.Now.ToString("dd/MM/yy")
        Dim login_time
        login_time = Date.Now.ToString("hh:mm:ss tt")
        ' Dim logout_time
        'logout_time = Date.Now.ToString("hh:mm:ss tt")

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        login = True
        logout = False
        Dim command = "INSERT INTO Student_Table " & " VALUES (" & TextBox1.Text & ",'" & TextBox3.Text & "','" & ComboBox3.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & d1.ToString & "','" & login_time.ToString & "','" & " " & "','" & TextBox2.Text & "'," & login & "," & logout & ")"




        Dim cmd As New OleDb.OleDbCommand
        cmd = New OleDbCommand(command, cnn)




        Dim dr As OleDbDataReader = cmd.ExecuteReader

        ''  Dim i As Integer
        ''i = cmd.ExecuteNonQuery()
        If dr.Read = False Then
            MsgBox("LOGIN SUCCESS")

            'clear_data()
            ' ComboBox2.Items.Remove(ComboBox2.Items)
        Else
            MsgBox("INVALID PASSWORD")
            MsgBox("LOGIN NOT SUCCESS")

            clear_data()
            ComboBox2.Items.Remove(ComboBox2.Items)
        End If
        'If i <> 0 Then
        '    MsgBox("login success")
        '    login = True
        '    clear_data()

        'Else
        '    MsgBox("login not success")
        '    clear_data()
        'End If
        cnn.Close()






    End Sub
    Private Sub Student_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cnn As New OleDb.OleDbConnection
        ' cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Create_Student.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Menus.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'MessageBox.Show("Login successfully")
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox2.Text  = "" Then
            MsgBox("please fill up text")
        Else


            Dim roll_no As Integer
            roll_no = TextBox1.Text


            Dim pass As String = TextBox2.Text
            Dim command = "select LOGIN,LOGOUT from Student_Table where  ROLL_NO=" & roll_no.ToString & " AND PASSWORD='" & pass & "' AND PRACTICAL_NAME='" & ComboBox2.Text & "'  "

            Dim cmd As New OleDb.OleDbCommand
            cmd = New OleDbCommand(command, cnn)

            'cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()

            End If
            'Dim dt As New DataTable
            Dim dr As OleDbDataReader = cmd.ExecuteReader



            'i = cmd.ExecuteNonQuery()
            If dr.Read = True Then

                login = dr.GetValue(0)





            End If


            If login = False And login = False Then
                Refresh_data()
                clear_data()
            ElseIf login = True Then
                MsgBox("already login")
            End If
            clear_data()
            ComboBox2.Items.Clear()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("please fill up text")
        Else

            If login = True Then
                Dim logout_time
                logout_time = Date.Now.ToString("hh:mm:ss tt")

                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If
                logout = True
                Dim command = "update  Student_Table set LOGOUT_TIME='" & logout_time.ToString & "',LOGOUT=" & logout & "  where ROLL_NO=" & TextBox1.Text & " and PASSWORD='" & TextBox2.Text & "'  and PRACTICAL_NAME ='" & ComboBox2.Text & "' "
                Dim cmd As New OleDb.OleDbCommand
                cmd = New OleDbCommand(command, cnn)




                ' Dim dr As OleDbDataReader = cmd.ExecuteReader

                Dim i As Integer
                i = cmd.ExecuteNonQuery()
               
                If i <> 0 Then
                    MsgBox("logout success")
                    login = False
                    ComboBox2.Items.Remove(ComboBox2.Items)
                    clear_data()

                Else
                    MsgBox("logout not success")
                    ComboBox2.Items.Remove(ComboBox2.Items)
                    clear_data()

                End If
                cnn.Close()


            Else
                MsgBox("Please login before logout")



            End If

        End If

    End Sub

    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        'TextBox1.Text = ""


    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
      
        ComboBox2.Items.Clear()
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim roll_no As Integer
        If TextBox1.Text = "" Then
            'roll_no = TextBox1.Text
            TextBox3.Text = ""
            ComboBox3.Text = ""
            ComboBox1.Text = ""

        Else
            roll_no = TextBox1.Text

        End If
        Dim command = "select NAME,YEAR,DIV from Create_Student where ROLL_NO= " & roll_no.ToString & ""
        Dim cmd As New OleDb.OleDbCommand
        cmd = New OleDbCommand(command, cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader



        ''i = cmd.ExecuteNonQuery()
        If dr.Read = True Then
            TextBox3.Text = dr.GetValue(0)
            ComboBox3.Text = dr.GetValue(1)

            ComboBox1.Text = dr.GetValue(2)



        End If

        cnn.Close()


    End Sub
    Private Sub subject()
        ComboBox2.Items.Clear()
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim command = "select Sub1,Sub2,Sub3 from Subject_Table where year='" & ComboBox3.Text & "' "
        Dim cmd As New OleDb.OleDbCommand
        cmd = New OleDbCommand(command, cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If dr.Read = True Then

            ' ComboBox2.Items.Remove(ComboBox2.Text)
            Dim x() = {dr.GetValue(0), dr.GetValue(1), dr.GetValue(2)}
            ComboBox2.Items.AddRange(x(0))

        End If
        cnn.Close()
    End Sub




    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = Date.Now.ToString("ddd                    dd-MM-yy                    hh:mm:ss tt")
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim roll_no As Integer
        If TextBox1.Text <> "" Then
            roll_no = TextBox1.Text
            Dim command = "select ROLL_NO from Create_Student where ROLL_NO= " & roll_no.ToString & ""
            Dim cmd As New OleDb.OleDbCommand
            cmd = New OleDbCommand(command, cnn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader



            ''i = cmd.ExecuteNonQuery()
            If dr.Read = True Then
                MsgBox("valid Roll_no")
                subject()
            Else
                MsgBox("Invalid ROLL_NO")
                Dim x = MessageBox.Show("this rollno not available", "create acc", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If x = Windows.Forms.DialogResult.Yes Then
                    Create_Student.Show()
                    Me.Close()
                End If

            End If
            cnn.Close()
        Else
            MsgBox("Please Enter Roll_no")

        End If
       

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating

    End Sub

    Private Sub Button3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseClick

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim command = "select Sub1,Sub2,Sub3 from Subject_Table where year='" & ComboBox3.SelectedItem & "'"
        Dim cmd As New OleDb.OleDbCommand
        cmd = New OleDbCommand(command, cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If dr.Read = True Then
            ComboBox2.Items.Remove(ComboBox2.Items)
            Dim x() = {dr.GetValue(0), dr.GetValue(1), dr.GetValue(2)}



            ComboBox2.Items.AddRange(x)

        End If
        cnn.Close()
    End Sub
End Class