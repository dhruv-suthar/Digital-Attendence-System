Imports System.Data
Imports System.Data.OleDb
Public Class Individual_Attendence
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    Private Sub Individual_Attendence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label6.Text = Search_attendence.DataGridView1.SelectedRows(0).Cells(0).Value
        Label7.Text = Search_attendence.DataGridView1.SelectedRows(0).Cells(1).Value
        Label8.Text = Search_attendence.DataGridView1.SelectedRows(0).Cells(2).Value
        Label9.Text = Search_attendence.DataGridView1.SelectedRows(0).Cells(3).Value
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If


        Dim total_att As Integer = 0
        Dim command = "select count(*) from Student_Table where ROLL_NO= " & Label6.Text & ""

        Dim cmd
        cmd = New OleDbCommand(command, cnn)

        'cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
        'If Not cnn.State = ConnectionState.Open Then

        'End If
        ' cmd.Connection = cnn

        'cmd.CommandText = "select * from Student_Table where  ROLL_NO=" & roll_no.ToString & " AND  PASSWORD='" & pass & "' "

        'Dim dt As New DataTable
        total_att = cmd.ExecuteScalar()



        'i = cmd.ExecuteNonQuery()

        'If i <> 0 Then
        '    ' MsgBox("login successfull")
        '    inset_data()

        'Else
        '    MsgBox("create already acc")

        'End If





        Label10.Text = total_att


        cnn.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub
End Class