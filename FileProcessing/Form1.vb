Imports System.IO

Public Class Form1
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        Try

            Dim filePath As String = "sample.txt" 'comment na random, 'wag mong pansinin


            Using writer As New StreamWriter(filePath, True) 'True to append
                writer.WriteLine("Kunwari pinalitan")
            End Using

            MessageBox.Show("Data written successfully.", "Sucess!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error" & ex.Message, "Error Has Occured!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

        Dim filepath As String = "sample.txt"

        Using reader As New StreamReader(filepath)

            Dim content As String = reader.ReadToEnd()

            MessageBox.Show(content, "File Content:")

        End Using

    End Sub
End Class
