Imports System.IO

Public Class Form1
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        Try

            Dim filePath As String = "sample.txt" 'comment na random, 'wag mong pansinin


            Using writer As New StreamWriter(filePath, True) 'True to append
                writer.WriteLine("Hello, this is a test file")
                writer.WriteLine("Second Line of Text")
            End Using

            MessageBox.Show("Data written successfully.", "Sucess!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error" & ex.Message, "Error Has Occured!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        End Try

    End Sub
End Class
