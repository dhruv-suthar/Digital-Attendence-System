Imports System.Data
Imports System.Data.OleDb
Public Class Practical_info
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
       


    End Sub
    Private Sub Practical_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    End Sub
    Private Sub insert_data()
        Dim i As Integer

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim Year As String = ComboBox1.SelectedItem
        Dim Sub1 As String = TextBox1.Text
        Dim Sub2 As String = TextBox2.Text
        Dim Sub3 As String = TextBox3.Text


        Dim command = "update  Subject_Table set Sub1='" & Sub1.ToString & "',Sub2='" & Sub2.ToString & "' ,Sub3='" & Sub3.ToString & "' where Year='" & Year.ToString & "'  "

        Dim cmd
        cmd = New OleDbCommand(command, cnn)

        i = cmd.ExecuteNonQuery()

        If i <> 0 Then
            MsgBox("Subject Update Successfully")
        Else
            MsgBox("Subject Update  not successfull")
        End If
        cnn.Close()
        ComboBox1.SelectedItem = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim year As String
        If ComboBox1.SelectedItem = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("please fill up textbox")
        End If

        year = ComboBox1.Text


        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If



        Dim command = "select Year from Subject_Table where Year= '" & year.ToString & "'"

        Dim cmd
        cmd = New OleDbCommand(command, cnn)

        'cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
        'If Not cnn.State = ConnectionState.Open Then

        'End If
        ' cmd.Connection = cnn

        'cmd.CommandText = "select * from Student_Table where  ROLL_NO=" & roll_no.ToString & " AND  PASSWORD='" & pass & "' "

        'Dim dt As New DataTable
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        'i = cmd.ExecuteNonQuery()

        'If i <> 0 Then
        '    ' MsgBox("login successfull")
        '    inset_data()

        'Else
        '    MsgBox("create already acc")

        'End If





        If dr.Read = False Then
            '    MsgBox("CREATE SUCCESSFULL")
            'inset_data()
            MsgBox("Already Create")
        Else
            insert_data()
        End If
        ComboBox1.SelectedItem = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        cnn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin_menu.Show()
        Me.Close()

    End Sub
End Class