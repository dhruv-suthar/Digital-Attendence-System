Imports System.Data
Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Search_attendence

    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb")
    Private Sub Refresh_data()
        Dim cmd As New OleDb.OleDbCommand
        'cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()

        End If
        Dim da As New OleDb.OleDbDataAdapter("select ROLL_NO,NAME,YEAR,DIV,PRACTICAL_NAME,DATE,LOGIN_TIME,LOGOUT_TIME from Student_Table", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt


    End Sub
    Private Sub Search_attendence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnn As New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_project\vb_project\attendence system\Digital_Attendence_System_1\Database1.accdb"
        Refresh_data()
        SaveFileDialog1.FileName = ""


        SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"
        SaveFileDialog1.InitialDirectory = "C:\Users\jay parjati\Documents\"

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin_menu.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp

        TextBox2.Text = ""



        TextBox3.Text = ""


        TextBox4.Text = ""


        Dim cmd As New OleDb.OleDbCommand
        'cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
        If TextBox1.Text = "" Then
            Refresh_data()
        Else

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()

            End If
            Dim da As New OleDb.OleDbDataAdapter("select ROLL_NO,NAME,YEAR,DIV,PRACTICAL_NAME,DATE,LOGIN_TIME,LOGOUT_TIME from Student_Table where DATE= '" & TextBox1.Text & "' ", cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
            cnn.Close()
        End If
    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp

        TextBox1.Text = ""



        TextBox3.Text = ""



        TextBox4.Text = ""


        Dim cmd As New OleDb.OleDbCommand
        'cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
        If TextBox2.Text = "" Then
            Refresh_data()
        Else

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()

            End If
            Dim da As New OleDb.OleDbDataAdapter("select ROLL_NO,NAME,YEAR,DIV,PRACTICAL_NAME,DATE,LOGIN_TIME,LOGOUT_TIME from Student_Table where   NAME= '" & TextBox2.Text & "' ", cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
            cnn.Close()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        TextBox1.Text = ""


        TextBox2.Text = ""



        TextBox4.Text = ""

        Dim cmd As New OleDb.OleDbCommand
        'cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
        If TextBox3.Text = "" Then
            Refresh_data()
        Else

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()

            End If
            Dim da As New OleDb.OleDbDataAdapter("select ROLL_NO,NAME,YEAR,DIV,PRACTICAL_NAME,DATE,LOGIN_TIME,LOGOUT_TIME from Student_Table where ROLL_NO= " & TextBox3.Text & " ", cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
            cnn.Close()
        End If
    End Sub

    Private Sub TextBox4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyUp

        TextBox1.Text = ""



        TextBox2.Text = ""



        TextBox3.Text = ""


        Dim cmd As New OleDb.OleDbCommand
        'cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dhruv\Documents\Database1.accdb"
        If TextBox4.Text = "" Then
            Refresh_data()
        Else

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()

            End If
            Dim da As New OleDb.OleDbDataAdapter("select ROLL_NO,NAME,YEAR,DIV,PRACTICAL_NAME,DATE,LOGIN_TIME,LOGOUT_TIME from Student_Table where PRACTICAL_NAME= '" & TextBox4.Text & "' ", cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
            cnn.Close()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Refresh_data()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As String
        'Dim path As String


        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            a = SaveFileDialog1.FileName

            If Windows.Forms.DialogResult.OK Then
                Dim Paragraph As New Paragraph ' declaration for new paragraph


                Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20) ' set pdf page size


                PdfFile.AddTitle("DIGITAL ATTENDENCE SYSTEM") ' set our pdf title


                Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream(a, FileMode.Create))


                PdfFile.Open()


                ' declaration font type


                Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)


                Dim pTable As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)


                ' insert title into pdf file


                Paragraph = New Paragraph(New Chunk("DIGITAL ATTENDENCE SYSTEM", pTitle))


                Paragraph.Alignment = Element.ALIGN_CENTER


                Paragraph.SpacingAfter = 6.0F


                ' set and add page with current settings


                PdfFile.Add(Paragraph)


                ' create data into table


                Dim PdfTable As New PdfPTable(DataGridView1.Columns.Count)


                ' setting width of table


                PdfTable.TotalWidth = 520.0F


                PdfTable.LockedWidth = True


                Dim widths(0 To DataGridView1.Columns.Count - 1) As Single


                For i As Integer = 0 To DataGridView1.Columns.Count - 1


                    widths(i) = 1.0F


                Next


                PdfTable.SetWidths(widths)


                PdfTable.HorizontalAlignment = 0


                PdfTable.SpacingBefore = 5.0F


                ' declaration pdf cells


                Dim pdfcell As PdfPCell = New PdfPCell


                ' create pdf header


                For i As Integer = 0 To DataGridView1.Columns.Count - 1


                    pdfcell = New PdfPCell(New Phrase(New Chunk(DataGridView1.Columns(i).HeaderText, pTable)))


                    ' alignment header table


                    pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT


                    ' add cells into pdf table


                    PdfTable.AddCell(pdfcell)


                Next


                ' add data into pdf table


                For i As Integer = 0 To DataGridView1.Rows.Count - 2


                    For j As Integer = 0 To DataGridView1.Columns.Count - 1


                        pdfcell = New PdfPCell(New Phrase(DataGridView1(j, i).Value.ToString(), pTable))


                        PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT


                        PdfTable.AddCell(pdfcell)


                    Next


                Next


                ' add pdf table into pdf document


                PdfFile.Add(PdfTable)


                PdfFile.Close() ' close all sessions


                ' show message if hasben exported


                MessageBox.Show("PDF format success exported !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Individual_Attendence.Show()


    End Sub
End Class