Imports System.IO

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Dim SW As StreamWriter
        SW = New StreamWriter("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\btnClassNameA.txt")
        SW.WriteLine(btnClassNameA.Text)
        SW.Close()
        SW = New StreamWriter("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\btnClassNameB.txt")
        SW.WriteLine(btnClassNameB.Text)
        SW.Close()
        SW = New StreamWriter("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\btnClassNameC.txt")
        SW.WriteLine(btnClassNameC.Text)
        SW.Close()
        SW = New StreamWriter("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\txtbLog.txt")
        SW.WriteLine(My.Forms.Form5.txtbLog.Text)
        SW.Close()
        SW = New StreamWriter("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\txtbClassPageA.txt")
        SW.WriteLine(My.Forms.Form2.txtbClassPageA.Text)
        SW.Close()
        SW = New StreamWriter("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\txtbClassPageB.txt")
        SW.WriteLine(My.Forms.Form3.txtbClassPageB.Text)
        SW.Close()
        SW = New StreamWriter("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\txtbClassPageC.txt")
        SW.WriteLine(My.Forms.Form4.txtbClassPageC.Text)
        SW.Close()



        Dim sbDA As New System.Text.StringBuilder
        For Index As Integer = 0 To My.Forms.Form2.clbDiscA.Items.Count - 1
            sbDA.AppendLine(String.Format("{0},{1}",
                    If(My.Forms.Form2.clbDiscA.GetItemChecked(Index), True, False), My.Forms.Form2.clbDiscA.Items(Index)))
        Next
        IO.File.WriteAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscA.txt", sbDA.ToString)

        Dim sbDB As New System.Text.StringBuilder
        For Index As Integer = 0 To My.Forms.Form3.clbDiscB.Items.Count - 1
            sbDB.AppendLine(String.Format("{0},{1}",
                    If(My.Forms.Form3.clbDiscB.GetItemChecked(Index), True, False), My.Forms.Form3.clbDiscB.Items(Index)))
        Next
        IO.File.WriteAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscB.txt", sbDB.ToString)

        Dim sbDC As New System.Text.StringBuilder
        For Index As Integer = 0 To My.Forms.Form4.clbDiscC.Items.Count - 1
            sbDC.AppendLine(String.Format("{0},{1}",
                    If(My.Forms.Form4.clbDiscC.GetItemChecked(Index), True, False), My.Forms.Form4.clbDiscC.Items(Index)))
        Next
        IO.File.WriteAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscC.txt", sbDC.ToString)

        Dim sbAA As New System.Text.StringBuilder
        For Index As Integer = 0 To My.Forms.Form2.clbAssA.Items.Count - 1
            sbAA.AppendLine(String.Format("{0},{1}",
                    If(My.Forms.Form2.clbAssA.GetItemChecked(Index), True, False), My.Forms.Form2.clbAssA.Items(Index)))
        Next
        IO.File.WriteAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssA.txt", sbAA.ToString)

        Dim sbAB As New System.Text.StringBuilder
        For Index As Integer = 0 To My.Forms.Form3.clbAssB.Items.Count - 1
            sbAB.AppendLine(String.Format("{0},{1}",
                    If(My.Forms.Form3.clbAssB.GetItemChecked(Index), True, False), My.Forms.Form3.clbAssB.Items(Index)))
        Next
        IO.File.WriteAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssB.txt", sbAB.ToString)

        Dim sbAC As New System.Text.StringBuilder
        For Index As Integer = 0 To My.Forms.Form4.clbAssC.Items.Count - 1
            sbAC.AppendLine(String.Format("{0},{1}",
                    If(My.Forms.Form4.clbAssC.GetItemChecked(Index), True, False), My.Forms.Form4.clbAssC.Items(Index)))
        Next
        IO.File.WriteAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssC.txt", sbAC.ToString)
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim fileRCNA As String
        fileRCNA = My.Computer.FileSystem.ReadAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\btnClassNameA.txt")
        btnClassNameA.Text = fileRCNA
        txtbClassNameA.Visible = False
        btnEngageA.Visible = True


        Dim fileRCNB As String
        fileRCNB = My.Computer.FileSystem.ReadAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\btnClassNameB.txt")
        btnClassNameB.Text = fileRCNB
        txtbClassNameB.Visible = False
        btnEngageB.Visible = True


        Dim fileRCNC As String
        fileRCNC = My.Computer.FileSystem.ReadAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\btnClassNameC.txt")
        btnClassNameC.Text = fileRCNC
        txtbClassNameC.Visible = False
        btnEngageC.Visible = True


        Dim fileRCPA As String
        fileRCPA = My.Computer.FileSystem.ReadAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\txtbClassPageA.txt")
        My.Forms.Form2.txtbClassPageA.Text = fileRCPA

        Dim fileRCPB As String
        fileRCPB = My.Computer.FileSystem.ReadAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\txtbClassPageB.txt")
        My.Forms.Form3.txtbClassPageB.Text = fileRCPB

        Dim fileRCPC As String
        fileRCPC = My.Computer.FileSystem.ReadAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\txtbClassPageC.txt")
        My.Forms.Form4.txtbClassPageC.Text = fileRCPC

        Dim fileRLog As String
        fileRLog = My.Computer.FileSystem.ReadAllText("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\txtbLog.txt")
        My.Forms.Form5.txtbLog.Text = fileRLog

        If IO.File.Exists("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscA.txt") Then
            Using Reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscA.txt")
                Dim bTest As Boolean = False
                Reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                Reader.Delimiters = New String() {","}
                Dim Row As String()
                While Not Reader.EndOfData
                    Row = Reader.ReadFields()
                    My.Forms.Form2.clbDiscA.Items.Add(Row(1))
                    If Boolean.TryParse(Row(0), bTest) Then
                        My.Forms.Form2.clbDiscA.SetItemChecked(My.Forms.Form2.clbDiscA.Items.Count - 1, bTest)
                    End If
                End While
            End Using
        End If

        If IO.File.Exists("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscB.txt") Then
            Using Reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscB.txt")
                Dim bTest As Boolean = False
                Reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                Reader.Delimiters = New String() {","}
                Dim Row As String()
                While Not Reader.EndOfData
                    Row = Reader.ReadFields()
                    My.Forms.Form3.clbDiscB.Items.Add(Row(1))
                    If Boolean.TryParse(Row(0), bTest) Then
                        My.Forms.Form3.clbDiscB.SetItemChecked(My.Forms.Form3.clbDiscB.Items.Count - 1, bTest)
                    End If
                End While
            End Using
        End If

        If IO.File.Exists("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscC.txt") Then
            Using Reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbDiscC.txt")
                Dim bTest As Boolean = False
                Reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                Reader.Delimiters = New String() {","}
                Dim Row As String()
                While Not Reader.EndOfData
                    Row = Reader.ReadFields()
                    My.Forms.Form4.clbDiscC.Items.Add(Row(1))
                    If Boolean.TryParse(Row(0), bTest) Then
                        My.Forms.Form4.clbDiscC.SetItemChecked(My.Forms.Form4.clbDiscC.Items.Count - 1, bTest)
                    End If
                End While
            End Using
        End If

        If IO.File.Exists("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssA.txt") Then
            Using Reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssA.txt")
                Dim bTest As Boolean = False
                Reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                Reader.Delimiters = New String() {","}
                Dim Row As String()
                While Not Reader.EndOfData
                    Row = Reader.ReadFields()
                    My.Forms.Form2.clbAssA.Items.Add(Row(1))
                    If Boolean.TryParse(Row(0), bTest) Then
                        My.Forms.Form2.clbAssA.SetItemChecked(My.Forms.Form2.clbAssA.Items.Count - 1, bTest)
                    End If
                End While
            End Using
        End If

        If IO.File.Exists("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssB.txt") Then
            Using Reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssB.txt")
                Dim bTest As Boolean = False
                Reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                Reader.Delimiters = New String() {","}
                Dim Row As String()
                While Not Reader.EndOfData
                    Row = Reader.ReadFields()
                    My.Forms.Form3.clbAssB.Items.Add(Row(1))
                    If Boolean.TryParse(Row(0), bTest) Then
                        My.Forms.Form3.clbAssB.SetItemChecked(My.Forms.Form3.clbAssB.Items.Count - 1, bTest)
                    End If
                End While
            End Using
        End If

        If IO.File.Exists("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssC.txt") Then
            Using Reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Pikey10\Documents\Visual Studio 2013\Projects\Planner3\Read Write\clbAssC.txt")
                Dim bTest As Boolean = False
                Reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                Reader.Delimiters = New String() {","}
                Dim Row As String()
                While Not Reader.EndOfData
                    Row = Reader.ReadFields()
                    My.Forms.Form4.clbAssC.Items.Add(Row(1))
                    If Boolean.TryParse(Row(0), bTest) Then
                        My.Forms.Form4.clbAssC.SetItemChecked(My.Forms.Form4.clbAssC.Items.Count - 1, bTest)
                    End If
                End While
            End Using
        End If
    End Sub

    Private Sub btnClassNameA_Click(sender As Object, e As EventArgs) Handles btnClassNameA.Click
        txtbClassNameA.Visible = True
        txtbClassNameA.Focus()

    End Sub

    Private Sub txtbClassNameA_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbClassNameA.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnClassNameA.Text = txtbClassNameA.Text
            txtbClassNameA.Visible = False
            btnEngageA.Visible = True

        End If

    End Sub

    Private Sub btnEngageA_Click(sender As Object, e As EventArgs) Handles btnEngageA.Click
        Me.Hide()
        Form2.Show()
        My.Forms.Form2.txtbClassPageA.Text = btnClassNameA.Text
    End Sub

    Private Sub btnClassNameB_Click(sender As Object, e As EventArgs) Handles btnClassNameB.Click
        txtbClassNameB.Visible = True
        txtbClassNameB.Focus()

    End Sub

    Private Sub txtbClassNameB_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbClassNameB.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnClassNameB.Text = txtbClassNameB.Text
            txtbClassNameB.Visible = False
            btnEngageB.Visible = True
        End If

    End Sub

    Private Sub btnEngageB_Click(sender As Object, e As EventArgs) Handles btnEngageB.Click
        Me.Hide()
        Form3.Show()
        My.Forms.Form3.txtbClassPageB.Text = btnClassNameB.Text
    End Sub

    Private Sub btnClassNameC_Click(sender As Object, e As EventArgs) Handles btnClassNameC.Click
        txtbClassNameC.Visible = True
        txtbClassNameC.Focus()

    End Sub

    Private Sub txtbClassNameC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbClassNameC.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnClassNameC.Text = txtbClassNameC.Text
            txtbClassNameC.Visible = False
            btnEngageC.Visible = True
        End If

    End Sub

    Private Sub btnEngageC_Click(sender As Object, e As EventArgs) Handles btnEngageC.Click
        Me.Hide()
        Form4.Show()
        My.Forms.Form4.txtbClassPageC.Text = btnClassNameC.Text
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Me.Hide()
        Form5.Show()
    End Sub


End Class

