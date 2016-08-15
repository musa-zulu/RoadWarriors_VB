Public Class SearchEvent
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim form = New ManageEvents()
        Me.Close()
        form.Show()
    End Sub
End Class