
Public Class MainForm
    Private Sub ManageAthletes_Btn_Click(sender As Object, e As EventArgs) Handles ManageAthletes_Btn.Click
        Me.Hide()
        Dim manageFrm = New ManageAthletes()
        manageFrm.Show()
    End Sub

    Private Sub ManageEvents_Btn_Click(sender As Object, e As EventArgs) Handles ManageEvents_Btn.Click
        Me.Hide()
        Dim manageEvent = New ManageEvents()
        manageEvent.Show()
    End Sub

    Private Sub AddAthleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAthleteToolStripMenuItem.Click
        Me.Hide()
        Dim addAthlete = New AddAthleteFrm()
        addAthlete.Show()
    End Sub

    Private Sub SearchEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchEditToolStripMenuItem.Click
        Dim serchForm = New SearchForm()
        serchForm.Show()
        Me.Hide()
    End Sub

    Private Sub AddEventToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddEventToolStripMenuItem1.Click
        Dim addEventForm = New AddEventForm()
        Me.Hide()
        addEventForm.Show()
    End Sub

    Private Sub EditEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEventToolStripMenuItem.Click
        Dim searchForm = New SearchEvent()
        Me.Hide()
        searchForm.Show()
    End Sub
End Class