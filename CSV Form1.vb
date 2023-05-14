Imports System.IO
Imports System.Data.SqlClient

Public Class Form1




    ' Dim BusinessClass As New BusinessClass
    Dim con As New OleDb.OleDbConnection

    ' Public Function GetFilePath() As String
    ' Dim FP As String
    ' FP = OpenFileDialog1.FileName
    ' Return FP

    ' End Function
    ' fekfjdtyh

    Private Sub btnImportCSV_Click(sender As Object, e As EventArgs) Handles btnImportCSV.Click


        Dim dsCSV As New DataSet
        Dim result As String
        Dim FP As String

        OpenFileDialog1.ShowDialog()
        FP = OpenFileDialog1.FileName

        If FP.Substring(0, 2) = "C:" Then


           










            result = GetConnection()
            TextBox1.Text = "Enter Log-Date"
            TextBox2.Text = " EnterLog-Date"

            If result = "true" Then

                dsCSV = GetCSVdata()

                If (dsCSV.Tables("dtCSV").Rows.Count <> 0) Then

                    If FP <> "" Then
                        Me.dgvCSVread.DataSource = dsCSV.Tables("dtCSV")
                    Else
                    End If
                Else
                    MsgBox("FilePath Empty")
                    MsgBox("No data found in the database")
                    Exit Sub
                End If

            Else
                MessageBox.Show("error", " No connection to database ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
        End If

        Exit Sub

    End Sub

    Public Function GetFilePath() As String
        Dim FP As String
        FP = OpenFileDialog1.FileName
        Return FP

    End Function







    Public Function GetConnection() As String


        Dim FileP As String

        'Dim FP As String
        'FP = OpenFileDialog1.FileName

        FileP = GetFilePath()

        GetConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileP

        Dim stringConn As String = "true"
        Try


            con.ConnectionString = GetConnection
        Catch ex As Exception
            stringConn = ex.Message.ToString()
        End Try

        Return stringConn
    End Function






    Private Sub cmbLogDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLogD.SelectedIndexChanged
        Dim results As String
        Dim dsCSVdetails As New DataSet
        results = GetConnection()
        If results = "true" Then
            dsCSVdetails = GetCSVlogdate(cmbLogD.SelectedItem)
            If dsCSVdetails.Tables("dtCSVdetails").Rows.Count <> 0 Then
                dgvCSVwrite.DataSource = dsCSVdetails.Tables("dtCSVdetails")

            Else
                MsgBox("No values found in the database")

            End If
        Else
            MessageBox.Show("ERROR", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
    End Sub



    Private Sub cmbLogD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsLogD As New DataSet
        Dim result As String

        If TextBox1.Text = "" Then

        Else


            result = GetConnection()

            If result = "true" Then
                dsLogD = GetLogDate()
                If (dsLogD.Tables("dtLogD").Rows.Count = 0) Then
                    MessageBox.Show("error", "No data values", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    For i As Integer = 0 To dsLogD.Tables("dtLogD").Rows.Count - 1

                        cmbLogD.Items.Add(dsLogD.Tables("dtLogD").Rows(i)!LogDate)

                    Next
                End If

            Else
                MessageBox.Show("error", " No connection to database ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub





    Private Sub cmbLogDate2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLogD2.SelectedIndexChanged
        Dim results As String
        Dim dsCSVdetails2 As New DataSet
        results = GetConnection()
        If results = "true" Then
            dsCSVdetails2 = GetCSVlogdate(cmbLogD2.SelectedItem)
            If dsCSVdetails2.Tables("dtCSVdetails").Rows.Count <> 0 Then
                dgvCSVwrite.DataSource = dsCSVdetails2.Tables("dtCSVdetails")

            Else
                MsgBox("No values found in the database")

            End If
        Else
            MessageBox.Show("ERROR", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
    End Sub



    Private Sub cmbLogD2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsLogD2 As New DataSet
        Dim result As String

        If TextBox2.Text = "" Then

        Else
            result = GetConnection()

            If result = "true" Then
                dsLogD2 = GetLogDate()
                If (dsLogD2.Tables("dtLogD").Rows.Count = 0) Then
                    MessageBox.Show("error", "No data values", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    For i As Integer = 0 To dsLogD2.Tables("dtLogD").Rows.Count - 1

                        cmbLogD2.Items.Add(dsLogD2.Tables("dtLogD").Rows(i)!LogDate)

                    Next
                End If

            Else
                MessageBox.Show("error", " No connection to database ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbLogD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLogD.SelectedIndexChanged

    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click



        '   Dim results As String
        '  Dim dsCSVdetails3 As New DataSet
        ' Dim dsCSVdetails4 As New DataSet
        ' results = GetConnection()
        ' If results = "true" Then
        'dsCSVdetails3 = GetCSVlogdate(TextBox1.Text)
        '' dsCSVdetails4 = GetCSVlogdate(TextBox2.Text)
        'If dsCSVdetails3.Tables("dtCSVdetails").Rows.Count <> 0 Then
        ' dgvCSVwrite.DataSource = dsCSVdetails3.Tables("dtCSVdetails")

        'Else
        'MsgBox("No values found in the database")

        'End If
        'Else
        'MessageBox.Show("ERROR", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error)


        'End If



    End Sub






    ' Dim dsRowID As DataSet
    ' Dim dsRowID2 As DataSet
    ' Dim dsCSVdetails5 As New DataSet

    '  dsRowID = BusinessClass.GetCSVlogdateRowID(cmbLogD.SelectedItem)
    ' dsRowID2 = BusinessClass.GetCSVlogdateRowID(cmbLogD2.SelectedItem)
    ' dsCSVdetails5 = BusinessClass.GetCSVdata()

    'TextBox1.Text = dsRowID.Tables("dtCSVdetailsRowID").Rows(0)!ID

    '    For i As Integer = dsRowID.Tables("dtCSVdetailsRowID").Rows(0)!ID - 1 To dsRowID2.Tables("dtCSVdetailsRowID").Rows(0)!ID - 1


    '       Me.dgvCSVwrite.DataSource = dsCSVdetails5.Tables("dtCSV").Rows(i)!ID
    '      Me.dgvCSVwrite.DataSource = dsCSVdetails5.Tables("dtCSV").Rows(i)!LogDate
    '     Me.dgvCSVwrite.DataSource = dsCSVdetails5.Tables("dtCSV").Rows(i)!TMP
    'dgvCSVwrite.DataSource = dsCSVdetails5.Tables("dtCSVdetails").Rows()!TMP

    '  Next







    Private Sub ApplyEdit_Click(sender As Object, e As EventArgs) Handles ApplyEdit.Click

        Dim dsRowID As DataSet
        Dim dsRowID2 As DataSet
        Dim dsCSVdetailsFromLD As New DataSet
        Dim dsCSVdetailsToLD As New DataSet
        Dim R_id As Integer
        Dim R_id2 As Integer
        Dim result As String
        Dim PlotFromLD As String
        Dim PlotFromTMP As String
        Dim res As String
       

        Dim i As Integer

        Try

            dsRowID = GetCSVlogdateRowID(TextBox1.Text)
            dsRowID2 = GetCSVlogdateRowID(TextBox2.Text)

            dsCSVdetailsFromLD = GetCSVdata()
            dsCSVdetailsToLD = GetCSVdata()

            '  dsCSVdetails2 = GetCSVlogdate(cmbLogD2.SelectedItem)


            R_id = dsRowID.Tables("dtCSVdetailsRowID").Rows(0)!ID
            R_id2 = dsRowID2.Tables("dtCSVdetailsRowID").Rows(0)!ID


            ' PlotToLD = dsCSVdetailsToLD.Tables("dtCSV").Rows(R_id2)!LogDate


            ' PlotToTMP = dsCSVdetails.Tables("dtCSV").Rows(R_id2)!TMP
            'TextBox3.Text = PlotToTMP
            ' TextBox4.Text = PlotToTMP



            Dim dsDel As New DataSet


            result = GetConnection()



            If (TextBox3.Text <> "") Or (TextBox4.Text <> "") Or (TextBox5.Text <> "") Or (TextBox6.Text <> "") Then


                If result = "true" Then

                    'Dim res As String

                    ' PlotFromLD = dsCSVdetailsFromLD.Tables("dtCSV").Rows(R_id - 1)!LogDate
                    ' PlotFromTMP = dsCSVdetailsToLD.Tables("dtCSV").Rows(R_id - 1)!TMP
                    ' res = AddCSVdata(PlotFromLD, PlotFromTMP)

                    ' res = AddCSVdata(PlotFromLD, PlotFromTMP)

                    For i = R_id - 1 To R_id2 - 1




                        If CDbl(TextBox3.Text) < CDbl(dsCSVdetailsFromLD.Tables("dtCSV").Rows(i)!TMP) Then

                            If CDbl(TextBox4.Text) > CDbl(dsCSVdetailsFromLD.Tables("dtCSV").Rows(i)!TMP) Then




                                If (CDbl(TextBox5.Text) < CDbl(dsCSVdetailsFromLD.Tables("dtCSV").Rows(i)!TMP) / CDbl(dsCSVdetailsFromLD.Tables("dtCSV").Rows(i + 1)!TMP)) Then

                                    If (CDbl(TextBox5.Text) > CDbl(dsCSVdetailsFromLD.Tables("dtCSV").Rows(i)!TMP) / CDbl(dsCSVdetailsFromLD.Tables("dtCSV").Rows(i + 1)!TMP)) Then


                                        PlotFromLD = dsCSVdetailsFromLD.Tables("dtCSV").Rows(i)!LogDate
                                        PlotFromTMP = dsCSVdetailsToLD.Tables("dtCSV").Rows(i)!TMP

                                        res = AddCSVdata(PlotFromLD, PlotFromTMP)
                                        ' res = AddCSVdata(PlotToLD, PlotToTMP)

                                    Else
                                        MessageBox.Show("error", " No ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                Else
                                    MessageBox.Show("error", " No no  ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else

                            End If
                        Else

                        End If
                    Next






                    res = "true"
                    If res = "true" Then
                        MsgBox("Criteria Updated")
                        ' Me.TextBox1.Text = ""
                        'Me.TextBox2.Text = ""


                        TextBox1.Focus()
                    Else
                        MsgBox("Error has occured while updating details")

                    End If

                Else
                    MessageBox.Show("error", "Connection has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else

               


            End If

            MessageBox.Show("Fill in missing parameters")


        Catch ex As Exception
            ex.Message.ToString()
            MessageBox.Show("Check entered parameters and try again")
        End Try





        Dim dsCSV As New DataSet

        result = GetConnection()


        If result = "true" Then

            dsCSV = GetCSVdata2()

            If (dsCSV.Tables("dtCSV2").Rows.Count <> 0) Then
                Me.dgvCSVwrite.DataSource = dsCSV.Tables("dtCSV2")

            Else

                MsgBox("No data found in the database")
                Exit Sub
            End If

        Else
            MessageBox.Show("error", " No connection to database ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Exit Sub

    End Sub


    'Fetch the CSV data from db table 2
    Public Function GetCSVdata() As DataSet
        Dim dsCSV As New DataSet

        Dim sql As String

        Dim daCSV As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sql = "SELECT * FROM CSVTable_2"
        daCSV = New OleDb.OleDbDataAdapter(sql, con)
        daCSV.Fill(dsCSV, "dtCSV")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsCSV

    End Function

    'Fetch the CSV data from db table 3 for display
    Public Function GetCSVdata2() As DataSet

        Dim dsCSV2 As New DataSet

        Dim sql As String

        Dim daCSV2 As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sql = "SELECT * FROM CSVTable_3"
        daCSV2 = New OleDb.OleDbDataAdapter(sql, con)
        daCSV2.Fill(dsCSV2, "dtCSV2")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsCSV2

    End Function



    'Fetch the CSV data from db table 3 for deleting
    Public Function GetCSVdel(ByVal logdate As String) As DataSet

        Dim dsCSVdel As New DataSet

        Dim sql As String

        Dim daCSVdel As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sql = "SELECT * FROM CSVTable_3  WHERE (LogDate='" + logdate + "')"
        daCSVdel = New OleDb.OleDbDataAdapter(sql, con)
        daCSVdel.Fill(dsCSVdel, "dtCSVdel")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsCSVdel

    End Function


    'Load for cmbbox 

    Public Function GetLogDate() As DataSet
        Dim sql As String
        Dim dsLogD As New DataSet
        Dim daLogD As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sql = "SELECT LogDate FROM CSVTable_2 "
        daLogD = New OleDb.OleDbDataAdapter(sql, con)
        daLogD.Fill(dsLogD, "dtLogD")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsLogD
    End Function






    Public Function GetCSVlogdate(ByVal CSVlogdate As String) As DataSet
        Dim dsCSVdetails As New DataSet
        Dim daCSVdetails As OleDb.OleDbDataAdapter
        Dim sql As String
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        sql = "SELECT * FROM CSVTable_2 WHERE (LogDate='" + CSVlogdate + "')"
        daCSVdetails = New OleDb.OleDbDataAdapter(sql, con)
        daCSVdetails.Fill(dsCSVdetails, "dtCSVdetails")
        If con.State = ConnectionState.Open Then

            con.Close()

        End If
        Return dsCSVdetails


    End Function



    ' Getting Row IDs

    Public Function GetCSVlogdateRowID(ByVal CSVlogdateRowID As String) As DataSet
        Dim dsCSVdetailsRowID As New DataSet
        Dim daCSVdetailsRowID As OleDb.OleDbDataAdapter
        Dim sql As String
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        sql = "SELECT ID FROM CSVTable_2 WHERE (LogDate='" + CSVlogdateRowID + "')"
        daCSVdetailsRowID = New OleDb.OleDbDataAdapter(sql, con)
        daCSVdetailsRowID.Fill(dsCSVdetailsRowID, "dtCSVdetailsRowID")
        If con.State = ConnectionState.Open Then

            con.Close()

        End If
        Return dsCSVdetailsRowID


    End Function


    ' Adding Filtered edits


    Public Function AddCSVdata(ByVal Log_date As String, ByVal TMP As String) As String

        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = ""

        Try

            sql = "INSERT INTO CSVTable_3 ( LogDate, TMP) VALUES ('" + Log_date + " ' , '" + TMP + " ')"

            cmd = New OleDb.OleDbCommand(sql, con)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If



        Catch ex As Exception

            result = ex.Message.ToString()

        End Try

        Return result

    End Function



    Public Function GetDeleteRow(ByVal Row As String) As String
        Dim cmd As OleDb.OleDbCommand
        Dim dsDel As New DataSet
        Dim sql As String
        Dim result As String = ""

        Try
            sql = "DELETE * FROM CSVTable_3  WHERE ID = ('" + Row + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function


    Public Function GetDeleteRow2(ByVal LogDate As String) As String
        Dim cmd As OleDb.OleDbCommand
        Dim dsDel As New DataSet
        Dim sql As String
        Dim result As String = ""

        Try
            sql = "DELETE * FROM CSVTable_3  WHERE LogDate = '(" + LogDate + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function






   

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim FL As String

        SaveFileDialog1.ShowDialog()
        FL = SaveFileDialog1.FileName

        ' If FL.Substring(0, 2) = "C:" Then


        ''For Text  file this is ok

        'Dim Qry As String = "Select * From CSVTable_3 Order by ID"
        'Dim Table As New DataTable
        'Dim Adapter As New SqlDataAdapter(Qry, con)
        'Adapter.Fill(Table)

        'Dim txt As String
        'Dim fileloc As String = FL

        '  Dim fileloc As String = "C:\Result.csv"


        '  For Each row As DataRow In Table.Rows
        ' Dim line As String = ""
        ' For Each column As DataColumn In Table.Columns
        ''Add the Data rows.
        'line += "," & row(column.ColumnName).ToString()
        ''line += vbTab & row(column.ColumnName).ToString()
        'Next
        ''Add new line
        'txt += line.Substring(1) & vbCrLf
        'Next

        ' If File.Exists(fileloc) Then

        'Using sw As StreamWriter = New StreamWriter(fileloc)
        ' sw.WriteLine(txt)
        ' End Using
        ''    End If

        'MsgBox("ok")


        'Else
        'End If


    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As String
        Dim dsDel As New DataSet

        result = GetConnection()
        If result = "true" Then
            Dim res As String


            dsDel = GetCSVdel(TextBox1.Text)

            ' If dsDel.Tables("dtCSVdel").Rows.Count <> 0 Then
            Me.dgvCSVwrite.DataSource = dsDel.Tables("dtCSVdel")

            res = GetDeleteRow2(TextBox1.Text)
            If res = "True" Then
                MsgBox("Successfully deleted")

            Else
                MsgBox("Error while deleting a student")

            End If
        Else
            MsgBox("no data found")


        End If

        'End If

    End Sub








    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As String
        Dim dsLogD As New DataSet

        result = GetConnection()

        If result = "true" Then
            dsLogD = GetLogDate()
            If (dsLogD.Tables("dtLogD").Rows.Count = 0) Then
                MessageBox.Show("error", "No data values", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For i As Integer = 0 To dsLogD.Tables("dtLogD").Rows.Count - 1

                    cmbLogD.Items.Add(dsLogD.Tables("dtLogD").Rows(i)!LogDate)

                Next
            End If

        Else
            MessageBox.Show("error", " No connection to database ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dsLogD2 As New DataSet
        Dim result As String

        result = GetConnection()

        If result = "true" Then
            dsLogD2 = GetLogDate()
            If (dsLogD2.Tables("dtLogD").Rows.Count = 0) Then
                MessageBox.Show("error", "No data values", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For i As Integer = 0 To dsLogD2.Tables("dtLogD").Rows.Count - 1

                    cmbLogD2.Items.Add(dsLogD2.Tables("dtLogD").Rows(i)!LogDate)

                Next
            End If

        Else
            MessageBox.Show("error", " No connection to database ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class
