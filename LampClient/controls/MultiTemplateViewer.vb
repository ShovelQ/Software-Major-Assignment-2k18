﻿Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports LampCommon

Public Class MultiTemplateViewer
    Public ReadOnly Property Templates As ObservableCollection(Of LampTemplate)

    Public Overrides Property AutoScroll As Boolean
        Get
            Return GridPanel.AutoScroll
        End Get
        Set(value As Boolean)
            GridPanel.AutoScroll = value
        End Set
    End Property



    Public Const Columns = 4


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Templates = New ObservableCollection(Of LampTemplate)
        AddHandler Templates.CollectionChanged, AddressOf UpdateViewers
        Me.GridPanel.Padding = New Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0)
    End Sub

    Private Sub UpdateViewers(sender As Object, e As NotifyCollectionChangedEventArgs)
        If _suspend Then
            Return
        End If
        SuspendLayout()
        GridPanel.Controls.Clear()

        GridPanel.RowCount = 0
        GridPanel.RowStyles.Clear()

        Dim totalRows As Integer = Math.Ceiling(Templates.Count / Columns)

        For i = 1 To totalRows
            GridPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 1 / totalRows))
        Next
        GridPanel.RowCount = totalRows


        Dim count = 0

        For Each template In Templates

            GridPanel.Controls.Add(New FileDisplay() With {.Template = template, .Dock = DockStyle.Fill})

            count += 1
        Next

        ResumeLayout()
    End Sub

    Friend Sub StopLoading()
        LoadingPictureBox.Visible = False
    End Sub

    Friend Sub ShowLoading()
        LoadingPictureBox.Visible = True
    End Sub

    Private _suspend As Boolean = False
    Public Sub Suspend()
        _suspend = True
    End Sub

    Public Sub EndSuspend(Optional doUpdate As Boolean = True)
        _suspend = False
        If doUpdate Then
            UpdateViewers(Nothing, Nothing)
        End If
    End Sub


    ' enable double buffering
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get

            Dim baseParams = MyBase.CreateParams
            baseParams.ExStyle = baseParams.ExStyle Or &H2000000 ' magic number that enables double buffering
            Return baseParams
        End Get
    End Property




End Class
