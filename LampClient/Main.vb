﻿Imports System.ServiceModel
Imports LampCommon
Imports LampService

Public Module OwO
    Public Property CurrentUser As LampUser = New LampUser(GetNewGuid, UserPermission.Admin, "none@gmail.comg", "hewwwo", "password", "debugger")

    Public Property CurrentSender As ILampClientService  'LampWcfClient.Local

    Public Property ClientEndpoint As String = "http://localhost:8733/Design_Time_Addresses/LampService.svc"

    Public Sub SetServiceEndpoint(url As String)
        Dim endpoint As New EndpointAddress(ClientEndpoint)
        Dim binding = New BasicHttpBinding()
        binding.MaxReceivedMessageSize = 100000000 ' 100 mb max
        CurrentSender = New LampRemoteWcfClient(binding, New EndpointAddress(url))
    End Sub

    Public Sub SetServiceEndpoint(sender As ILampClientService)
        CurrentSender = sender
    End Sub

    Public Sub Main()
        InitalizeLibraries()
        LampLocalWcfClient.Local = New LampLocalWcfClient(New LampService.LampService)
        SetServiceEndpoint(LampLocalWcfClient.Local)



        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New DebugForm())

    End Sub

    Sub InitalizeLibraries()
        ' extract necessary dll files
        ' put folder in DLL path
    End Sub





End Module