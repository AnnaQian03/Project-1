Imports System.IO

Public Class RiskLevelForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBackRisk.Click
        TravelHistoryForm.Show()
        Me.Close()

    End Sub

    Private Sub btnNextMedical_Click(sender As Object, e As EventArgs) Handles btnNextRisk.Click
        HelpAndGuide.Show()
        Me.Close()

    End Sub

    Private Sub tbRiskLevel_Click(sender As Object, e As EventArgs) Handles tbRiskLevel.Click
        If Form1.totalrisk = 0 Then
            tbRiskLevel.Text = "Low"
        ElseIf Form1.totalrisk < 5 Then
            tbRiskLevel.Text = "Medium"
        ElseIf Form1.totalrisk > 4 Then
            tbRiskLevel.Text = "High"
        Else
            tbRiskLevel.Text = "Error"
        End If
    End Sub

    Private Sub tbRiskLevel_TextChanged(sender As Object, e As EventArgs) Handles tbRiskLevel.TextChanged

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