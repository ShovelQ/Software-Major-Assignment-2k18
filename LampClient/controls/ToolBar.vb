﻿Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports LampClient
Imports LampCommon

Public Module ToolbarUtilities
    Public ReadOnly Property PreviousForms As New List(Of LampForm)

    <Extension>
    Public Sub AddPreviousForm(this As IToolbar, form As Form)
        Select Case form.GetType()
            Case GetType(HomeForm)
                PreviousForms.Add(LampForm.HomeForm)
            Case GetType(MyOrdersForm)
                PreviousForms.Add(LampForm.MyOrdersForm)
            Case GetType(MyTemplatesForm)
                PreviousForms.Add(LampForm.MyTemplatesForm)
            Case GetType(NewOrderForm)
                PreviousForms.Add(LampForm.NewOrderForm)
            Case GetType(TemplateSelectBox)
                PreviousForms.Add(LampForm.TemplateSelectForm)
            Case GetType(AdminForm)
                PreviousForms.Add(LampForm.AdminForm)



            Case Else
                Throw New ArgumentOutOfRangeException(NameOf(form))
        End Select
    End Sub

    ''' <summary>
    ''' Pops and shows the last saved form
    ''' assumes that at least 1 saved form exists
    ''' </summary>
    ''' <param name="this"></param>
    <Extension>
    Private Sub PopPreviousForm(this As IToolbar)
        Dim last = PreviousForms(PreviousForms.Count - 1)
        PreviousForms.RemoveAt(PreviousForms.Count - 1)
        Select Case last
            Case LampForm.HomeForm
                HomeForm.Show()
            Case LampForm.MyOrdersForm
                MyOrdersForm.Show()
            Case LampForm.MyTemplatesForm
                MyTemplatesForm.Show()
            Case LampForm.NewOrderForm
                NewOrderForm.Show()
            Case LampForm.TemplateSelectForm
                TemplateSelectBox.Show()
        End Select
    End Sub

    ''' <summary>
    ''' Adds the previous form storage and opens the new form, then closes the previous form
    ''' </summary>
    ''' <param name="this"></param>
    ''' <param name="previousForm"></param>
    ''' <param name="newForm"></param>
    <Extension>
    Public Sub ShowNewForm(this As IToolbar, previousForm As Form, newForm As Form)
        this.AddPreviousForm(previousForm)
        newForm.Show()
        previousForm.Close()
    End Sub

    ''' <summary>
    ''' Closes the current form, then opens last closed form
    ''' </summary>
    ''' <param name="this"></param>
    ''' <param name="currentForm"></param>
    <Extension>
    Public Sub ShowPreviousForm(this As IToolbar, currentForm As Form)
        If Not this.HasSavedForms() Then
            Throw New InvalidOperationException("No previous forms")
        End If
        this.PopPreviousForm()
        currentForm.Close()
    End Sub

    <Extension>
    Public Function HasSavedForms(this As IToolbar) As Boolean
        Return PreviousForms.Count > 0
    End Function

    <Extension>
    Public Function Logout(this As IToolbar, parentForm As Form) As Boolean
        If LogoutBox.ShowDialog() = DialogResult.OK Then
            PreviousForms.Clear()
            LoginForm.Show()

            parentForm.Close()
            Return True
        End If
        Return False
    End Function
End Module

Public Interface IToolbar
    Sub SetUsername(username As String)

End Interface

Public Class ToolBar
    Implements IToolbar

#Region "DesignerProperties"
    <Category("DisableButtons")>
    Public Property NewOrderEnabled As Boolean
        Get
            Return btnNewOrder.Enabled
        End Get
        Set(value As Boolean)
            btnNewOrder.Enabled = value
        End Set
    End Property

    <Category("DisableButtons")>
    Public Property HomeEnabled As Boolean
        Get
            Return btnHome.Enabled
        End Get
        Set(value As Boolean)
            btnHome.Enabled = value
        End Set
    End Property

    <Category("DisableButtons")>
    Public Property MyTrophyEnabled As Boolean
        Get
            Return btnDesigns.Enabled
        End Get
        Set(value As Boolean)
            btnDesigns.Enabled = value
        End Set
    End Property

    <Category("DisableButtons")>
    Public Property MyOrdersEnabled As Boolean
        Get
            Return btnOrders.Enabled
        End Get
        Set(value As Boolean)
            btnOrders.Enabled = value
        End Set
    End Property


#End Region

    Public Sub SetUsername(username As String) Implements IToolbar.SetUsername
        Me.Username.Text = String.Format("Welcome {0}", username)
    End Sub


    ''' <summary>
    ''' Closes the first form that is a parent of control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnQY_Click(sender As Object, e As EventArgs)
        Me.ParentForm.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(ParentForm)
    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowNewForm(ParentForm, HomeForm)
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        ShowNewForm(ParentForm, NewOrderForm)
    End Sub

    Private Sub btnDesigns_Click(sender As Object, e As EventArgs) Handles btnDesigns.Click
        ShowNewForm(ParentForm, MyTemplatesForm)
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        ShowNewForm(ParentForm, MyOrdersForm)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        HelpBox.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutBox.ShowDialog()
    End Sub



    ''' <summary>
    ''' Checks if previousform is set to disable/enable it
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PreviousForms.Count() = 0 Then
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If
        SetUsername(CurrentUser.Username)
        ' dont have permission to 
        If CurrentUser.PermissionLevel <= UserPermission.Standard Then
            MyOrdersEnabled = False
            NewOrderEnabled = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If PreviousForms.Count = 0 Then
            btnBack.Enabled = False
            MessageBox.Show("ProgramException: PreviousForm not found")
            ' note: this shouldnt be possilbe unless you twiddle w/ the values of PreviousForm urself
            Return
        End If

        ShowPreviousForm(ParentForm)
    End Sub



    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        If CloseBox.ShowDialog() = DialogResult.OK Then
            End
        End If
    End Sub

End Class


Public Enum LampForm
    HomeForm
    MyOrdersForm
    MyTemplatesForm
    NewOrderForm
    TemplateSelectForm
    AdminForm
End Enum