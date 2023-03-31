Imports System.IO

Public Class MedicalHistoryForm
    Private Sub btnNextMedical_Click(sender As Object, e As EventArgs) Handles btnNextMedical.Click
        TravelHistoryForm.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBackMedical.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub MedicalHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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