Imports System.IO
Imports System.Xml.Schema

'Jarreth Fleischer Anak Majang (20DDT21F1017)
'Boon Sze Qian (20DDT21F1004)

Public Class Form1
    Public i As Integer
    Public totalrisk As Integer
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNextSymptoms.Click
        Dim risk0 As Integer = 0
        Dim risk1 As Integer = 0
        Dim risk2 As Integer = 0
        Dim risk3 As Integer = 0
        Dim risk4 As Integer = 0
        Dim risk5 As Integer = 0
        Dim risk6 As Integer = 0


        MedicalHistoryForm.Show()
        Me.Hide()
        If tbCough.Text = "yes" Then
            i = 1
            risk0 = risk0 + i
        Else
            i = 0
            risk0 = risk0 + i
        End If

        If tbFever.Text = "yes" Then
            i = 1
            risk1 = risk0 + i
        Else
            i = 0
            risk1 = risk0 + i
        End If

        Dim shortbreath As String = ComboShortness.SelectedItem
        i = 1
        risk2 = risk1 + i
        If CboxChest.Checked = True Then
            i = 1
            risk3 = risk2 + i
        Else
            i = 0
            risk3 = risk2 + i
        End If

        If CboxDiarrhea.Checked = True Then
            i = 1
            risk4 = risk3 + i
        Else
            i = 0
            risk4 = risk3 + i
        End If

        If CboxHeadache.Checked = True Then
            i = 1
            risk5 = risk4 + i
        Else
            i = 0
            risk5 = risk4 + i
        End If

        If CboxIrritated.Checked = True Then
            i = 1
            risk6 = risk5 + i
        Else
            i = 0
            risk6 = risk5 + i
        End If

        totalrisk = risk6

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNReset.Click
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFolder As String = folderBrowserDialog.SelectedPath
            ' Do something with the selected folder path
        End If
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog.FileName
            Using writer As New StreamWriter(fileName)
                writer.Write("Some text to save to the file")
            End Using
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Close()
    End Sub
End Class
