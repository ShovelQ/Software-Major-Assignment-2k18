﻿Imports LampCommon

Public Class JobDisplay

    Private dynamicTextViewer As New DynamicTextCreationForm

    Private _job As LampJob

    ''' <summary>
    ''' Change template to change the text on the display
    ''' </summary>
    ''' <returns></returns>
    Public Property Job As LampJob
        Get
            Return _job
        End Get
        Set(value As LampJob)
            _job = value
            DisplayJob()
        End Set
    End Property

    Private Sub DisplayJob()
        If Job IsNot Nothing Then
            SubmitProfileDisplay.Profile = Job.Submitter
            ApproveProfileDisplay.Profile = Job.Approver
            dynamicTextViewer.Source = Job.Template
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDynamicText.Click
        dynamicTextViewer.ShowDialog()
    End Sub
End Class