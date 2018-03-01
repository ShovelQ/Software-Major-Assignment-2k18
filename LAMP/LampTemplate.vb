﻿Imports System.IO
Imports System.Reflection
Imports LAMP
Imports netDxf
Imports Newtonsoft.Json


Public Class LampTemplate
    ''' <summary>
    ''' The actual template : contains just 1 of drawing
    ''' </summary>
    <JsonProperty("template", Order:=1000)>
    Private _template As LampDxfDocument

    ''' <summary>
    ''' Where the dynamic text will be stored:
    ''' 
    ''' </summary>
    ''' <returns></returns>
    <JsonProperty("dynamicTextList")>
    Public Property DynamicTextList As New List(Of DynamicText)


    ''' <summary>
    ''' The completed drawing, w/ all the templates laid out appropriately
    ''' Not serialized, as it can be generated using _template when deserialized
    ''' </summary>
    Private _completedDrawing As LampDxfDocument

    ''' <summary>
    ''' Where each individual trophy will be inserted (in cartesian form) on the competedDrawing
    ''' Contains rotation data, dynamic text data, everything required to rebuild the
    ''' completeddrawing
    ''' </summary>
    ''' <returns></returns>
    <JsonProperty("insertionLocations")>
    Public Property InsertionLocations As New List(Of LampDxfInsertLocation)

    ''' <summary>
    ''' where or not the file is in a complete state - if complete, should disable editing
    ''' </summary>
    ''' <returns></returns>
    <JsonProperty("isComplete")>
    Public Property IsComplete As Boolean

    <JsonProperty("creatorName")>
    Public Property CreatorName As String = ""

    <JsonProperty("creatorId")>
    Public Property CreatorId As Integer = -1

    <JsonProperty("approverName")>
    Public Property ApproverName As String = ""

    Friend Shared Function Load(fileName As String) As LampTemplate
        Using file As New StreamReader(fileName)
            Return Deserialize(file.ReadToEnd())
        End Using
    End Function

    Private Shared Function Deserialize(json As String) As LampTemplate
        Return JsonConvert.DeserializeObject(Of LampTemplate)(json)
    End Function

    <JsonProperty("approverId")>
    Public Property ApproverId As Integer = -1

    ''' <summary>
    ''' Gets whether or not it has text that is filled in by the user
    ''' during creation
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property HasDynamicText As Boolean
        Get
            Return DynamicTextList.Count() = 0
        End Get
    End Property

    ''' <summary>
    ''' Converts -> json format to be saved as a .spiff
    ''' </summary>
    ''' <returns></returns>
    Public Function Serialize(Optional formatting As Formatting = Formatting.None) As String
        Return JsonConvert.SerializeObject(Me, formatting)
    End Function

    Public Shared Function Serialize(item As LampTemplate) As String
        Return JsonConvert.SerializeObject(item)
    End Function

    Public Sub Save(path As String, Optional formatting As Formatting = Formatting.None)
        Using fileStream As New StreamWriter(path)
            fileStream.Write(Serialize(formatting))
        End Using
    End Sub

    Public Sub New(Optional start As LampDxfDocument = Nothing)
        If start IsNot Nothing Then
            Me._template = start
        Else
            Me._template = New LampDxfDocument
        End If

        InsertionLocations.Add(New LampDxfInsertLocation())
        RefreshCompleteDrawing()
    End Sub

    Public Shared Function CreateFromDxf(drawing As LampDxfDocument)
        Return New LampTemplate(drawing)
    End Function

    ''' <summary>
    ''' Refreshes the _completeDrawing based on the InsertionLocations
    ''' Expensive, dont call too many times 
    ''' </summary>
    Public Sub RefreshCompleteDrawing()
        ' TODO!
        _completedDrawing = New LampDxfDocument()
        For Each point As LampDxfInsertLocation In InsertionLocations
            _template.InsertInto(_completedDrawing, point)
        Next
    End Sub

    Public Sub AddInsertionPoint(point As LampDxfInsertLocation, Optional refresh As Boolean = True)
        InsertionLocations.Add(point)
        If refresh Then
            RefreshCompleteDrawing()
        End If
    End Sub
End Class














Public Class OwO
    Sub Main()
        InitalizeLibraries()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub

    Sub InitalizeLibraries()
        ' extract necessary dll files
        ' put folder in DLL path
    End Sub




End Class


Public Class LampDxfInsertLocation
    <JsonProperty("insertPoint")>
    Public Property InsertPoint As New Vector3
    <JsonProperty("rotation")>
    Public Property Rotation As Double
    <JsonProperty("dynamicTextData")>
    Public Property DynamicTextData As New Dictionary(Of DynamicText, String)
End Class