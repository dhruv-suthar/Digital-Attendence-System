Imports System.Data
Imports System.Data.OleDb
Public Class Create_Teacher
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Menus.Show()
        Me.Close()

    End Sub
    Private Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

      


    End Sub
    Private Sub Refresh_data()
        Dim cmd As New OleDb.OleDbCommand
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb"
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("select * from Create_Teacher", cnn)
        Dim dt As New DataTable

        da.Fill(dt)
        'Me.DataGridView1.DataSource = dt


    End Sub
    Private Sub inset_data()
        Dim i As Integer

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim id As Integer = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim fac_name As String = TextBox3.Text

        Dim command = "insert into Create_Teacher " + "values (" & id.ToString & ",'" & password & "','" & fac_name & "') ;"

        Dim cmd
        cmd = New OleDbCommand(command, cnn)

        i = cmd.ExecuteNonQuery()

        If i <> 0 Then
            MsgBox("create successfull")
            clear_data()

        Else
            MsgBox("create not successfull")
            clear_data()

        End If
        cnn.Close()
        'Refresh_data()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim id As Integer
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("please fill up textbox")
        End If

        id = TextBox1.Text
      
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If



        Dim command = "select ID,PASSWORD,FAC_NAME from Create_Teacher where ID= " & id.ToString & ""

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
            inset_data()
        Else
            MsgBox("Already Create")
        End If


        cnn.Close()
        Refresh_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Create_Teacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("ddd                    dd-MM-yy                    hh:mm:ss tt")
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        Dim pass As String
        pass = TextBox2.Text
        If validate_password(pass) = True Then
            MsgBox(" Password is valid")
        Else
            MsgBox("Password is not valid Please try again.")
            TextBox2.Text = ""


        End If
    End Sub
    Function validate_password(ByVal pass As String, Optional ByVal minlength As Integer = 8) As Boolean


        If Len(pass) > minlength Then
            Return False
        End If

        Return True
    End Function

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class