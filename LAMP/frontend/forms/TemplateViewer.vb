﻿Public Class TemplateViewer
    Public Displays(7) As fileDisplay
    Private Sub pbLogo_Click(sender As Object, e As EventArgs)
        frmStart.Show()
        Me.Hide()
        frmStart.lastform = frmStart.curForm
        frmStart.curForm = "view"
    End Sub

    Private Sub fileViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolBar1.lblCurScr.Text = "File Viewer"
        Displays(0) = FileDisplay1
        Displays(1) = FileDisplay2
        Displays(2) = FileDisplay3
        Displays(3) = FileDisplay4
        Displays(4) = FileDisplay5
        Displays(5) = FileDisplay6
        Displays(6) = FileDisplay7
        Displays(7) = FileDisplay8
        LoadFiles()
        Dim template = TemplateDatabase.GetExampleTemplate("one")

        FileDisplay1.DisplayTemplate(template)
    End Sub

    ''' <summary>
    ''' Load Files into the viewing screen
    ''' </summary>
    Public Sub LoadFiles()
        For i = 0 To 7
            Displays(i).lblName.Text = "Name: Standard trophy"
            Displays(i).lblCreator.Text = "Creator: Steve By Birth"
            Displays(i).lblHeight.Text = "Height: 140mm"
            Displays(i).lblWidth.Text = "Width: 70mm"
            Displays(i).lblMaterial.Text = "Material: 3mm Acrylic"
            Displays(i).lblCutTime.Text = "Time to Cut: 12 Min"
        Next
    End Sub

    Private Sub FileDisplay4_Load(sender As Object, e As EventArgs) Handles FileDisplay4.Load

    End Sub

    Private Sub FileDisplay1_Load(sender As Object, e As EventArgs) Handles FileDisplay1.Load

    End Sub

    Private Sub ToolBar1_Load(sender As Object, e As EventArgs) Handles ToolBar1.Load

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim template = TemplateDatabase.GetExampleTemplate("two")

        FileDisplay1.DisplayTemplate(template)
    End Sub
End Class