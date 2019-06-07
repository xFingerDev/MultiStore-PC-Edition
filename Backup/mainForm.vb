Imports System.Net
Public Class mainForm

    Dim whereToSave As String 'Where the program save the file

    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)

    Public Sub DownloadComplete(ByVal cancelled As Boolean)
        Me.txtFileName.Enabled = True
        Me.btnDownload.Enabled = True
        Me.btnCancel.Enabled = False

        If cancelled Then

            Me.Label4.Text = "Cancelled"

            MessageBox.Show("Download aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            Me.Label4.Text = "Successfully downloaded"

            MessageBox.Show("Successfully downloaded!", "All OK", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

        Me.ProgressBar1.Value = 0
        Me.Label5.Text = "Downloading: "
        Me.Label6.Text = "Save to: "
        Me.Label3.Text = "File size: "
        Me.Label2.Text = "Download speed: "
        Me.Label4.Text = ""

    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)

        Me.Label3.Text = "File Size: " & Math.Round((length / 1024), 2) & " KB"

        Me.Label5.Text = "Downloading: " & Me.txtFileName.Text

        Me.Label4.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((length / 1024), 2) & "KB (" & Me.ProgressBar1.Value & "%)"

        If speed = -1 Then
            Me.Label2.Text = "Speed: calculating..."
        Else
            Me.Label2.Text = "Speed: " & Math.Round((speed / 1024), 2) & " KB/s"
        End If

        Me.ProgressBar1.Value = percent


    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        If Me.txtFileName.Text <> "" AndAlso Me.txtFileName.Text.StartsWith("http://") Then


            Me.SaveFileDialog1.FileName = Me.txtFileName.Text.Split("/"c)(Me.txtFileName.Text.Split("/"c).Length - 1)

            If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                Me.whereToSave = Me.SaveFileDialog1.FileName

                Me.SaveFileDialog1.FileName = ""

                Me.Label6.Text = "Save to: " & Me.whereToSave

                Me.txtFileName.Enabled = False
                Me.btnDownload.Enabled = False
                Me.btnCancel.Enabled = True

                Me.BackgroundWorker1.RunWorkerAsync() 'Start download

            End If

        Else

            MessageBox.Show("Please insert valid URL for download", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'Creating the request and getting the response
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try 'Checks if the file exist

            theRequest = WebRequest.Create(Me.txtFileName.Text)
            theResponse = theRequest.GetResponse
        Catch ex As Exception

            MessageBox.Show("An error occurred while downloading file. Possibe causes:" & ControlChars.CrLf & _
                            "1) File doesn't exist" & ControlChars.CrLf & _
                            "2) Remote server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub
        End Try
        Dim length As Long = theResponse.ContentLength 'Size of the response (in bytes)

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0) 'Invoke the TreadsafeDelegate

        Dim writeStream As New IO.FileStream(Me.whereToSave, IO.FileMode.Create)

        'Replacement for Stream.Position (webResponse stream doesn't support seek)
        Dim nRead As Integer

        'To calculate the download speed
        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0

        Do

            If BackgroundWorker1.CancellationPending Then 'If user abort download
                Exit Do
            End If

            speedtimer.Start()

            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)

            nRead += bytesread
            Dim percent As Short = (nRead * 100) / length

            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)

            If bytesread = 0 Then Exit Do

            writeStream.Write(readBytes, 0, bytesread)

            speedtimer.Stop()

            readings += 1
            If readings >= 5 Then 'For increase precision, the speed it's calculated only every five cicles
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        'Close the streams
        theResponse.GetResponseStream.Close()
        writeStream.Close()

        If Me.BackgroundWorker1.CancellationPending Then

            IO.File.Delete(Me.whereToSave)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub

        End If

        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

        Me.Invoke(completeDelegate, False)

    End Sub

    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label4.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BackgroundWorker1.CancelAsync() 'Send cancel request
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Created by Carmine_XX (www.thetotalsite.it)" & ControlChars.CrLf & "To report bugs/suggestions/comments please contact me by email: pikachu31@gmail.com or in the project page on CodeProject.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
