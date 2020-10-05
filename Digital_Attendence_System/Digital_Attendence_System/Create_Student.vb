Imports System.Data
Imports System.Data.OleDb

Public Class Create_Student
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Menus.Show()
        Me.Close()

    End Sub
    Private Sub Refresh_data()
        Dim cmd As New OleDb.OleDbCommand
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb"
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("select * from Create_Student", cnn)
        Dim dt As New DataTable

        da.Fill(dt)
        'Me.DataGridView1.DataSource = dt


    End Sub
    Private Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""



    End Sub
    Private Sub inset_data()
        Dim i As Integer

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim roll_no As Integer = TextBox1.Text
        Dim pass As String = TextBox2.Text
        Dim name As String = TextBox3.Text
        Dim year As String = ComboBox2.Text
        Dim div As String = ComboBox1.Text

        Dim command = "insert into Create_Student " + "values (" & roll_no.ToString & ",'" & pass & "','" & name & "','" & year & "','" & div & "') ;"

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
        Dim roll_no As Integer
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedItem = "" Then
            MsgBox("please fill up textbox")

        Else
            roll_no = TextBox1.Text


            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()

            End If



            Dim command = "select ROLL_NO,PASSWORD,NAME,DIV from Create_Student where ROLL_NO= " & roll_no & ""

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
                clear_data()

            Else
                MsgBox("Already Create")
                clear_data()

            End If


            cnn.Close()
            Refresh_data()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub Create_Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = Date.Now.ToString("ddd                    dd-MM-yy                    hh:mm:ss tt")
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

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
    'Function validate_password(ByVal pass As String, Optional ByVal minlength As Integer = 8, Optional ByVal numupper As Integer = 2, Optional ByVal numlower As Integer = 2, Optional ByVal numNumbers As Integer = 2, Optional ByVal numSpecial As Integer = 2) As Boolean

    '    Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
    '    Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
    '    Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
    '    'special character
    '    Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")
    '    If Len(pass) < minlength Then
    '        Return False
    '    End If
    '    If upper.Matches(pass).Count < numupper Then
    '        Return False

    '    End If
    '    If lower.Matches(pass).Count < numlower Then
    '        Return False

    '    End If
    '    If number.Matches(pass).Count < numNumbers Then
    '        Return False
    '    End If
    '    If special.Matches(pass).Count < numSpecial Then
    '        Return False
    '    End If
    '    Return True
    'End Function
    Function validate_password(ByVal pass As String, Optional ByVal minlength As Integer = 8) As Boolean

      
        If Len(pass) > minlength Then
            Return False
        End If
      
        Return True
    End Function


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class