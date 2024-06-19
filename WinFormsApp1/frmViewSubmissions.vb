Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class frmViewSubmissions
    Private currentIndex As Integer = 0

    Private Async Sub frmViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await LoadSubmission(currentIndex)
    End Sub

    Private Sub frmViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync($"http://localhost:3000/read?index={index}")
            Dim submission = JsonConvert.DeserializeObject(Of Submission)(response)

            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGithubLink.Text = submission.github_link
            lblStopwatchTime.Text = submission.stopwatch_time
        End Using
    End Function

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = lblStopwatchTime.Text
        }

        Dim json As String = JsonConvert.SerializeObject(New With {
            .index = currentIndex,
            .name = submission.name,
            .email = submission.email,
            .phone = submission.phone,
            .github_link = submission.github_link,
            .stopwatch_time = submission.stopwatch_time
        })
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response = Await client.PutAsync("http://localhost:3000/update", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully!")
            Else
                MessageBox.Show("Update failed!")
            End If
        End Using
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim json As String = JsonConvert.SerializeObject(New With {.index = currentIndex})
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim request As New HttpRequestMessage(HttpMethod.Delete, "http://localhost:3000/delete")
            request.Content = content

            Dim response = Await client.SendAsync(request)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully!")
                If currentIndex > 0 Then
                    currentIndex -= 1
                End If
                Await LoadSubmission(currentIndex)
            Else
                MessageBox.Show("Delete failed!")
            End If
        End Using
    End Sub
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
