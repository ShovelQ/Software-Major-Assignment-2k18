﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace LampServiceReference
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="LampServiceReference.ILampService")>  _
    Public Interface ILampService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILampService/Authenticate", ReplyAction:="http://tempuri.org/ILampService/AuthenticateResponse")>  _
        Function Authenticate(ByVal username As String, ByVal password As String) As LampCommon.LampUserReturnWrapper
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILampService/Authenticate", ReplyAction:="http://tempuri.org/ILampService/AuthenticateResponse")>  _
        Function AuthenticateAsync(ByVal username As String, ByVal password As String) As System.Threading.Tasks.Task(Of LampCommon.LampUserReturnWrapper)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILampService/Return1", ReplyAction:="http://tempuri.org/ILampService/Return1Response")>  _
        Function Return1() As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILampService/Return1", ReplyAction:="http://tempuri.org/ILampService/Return1Response")>  _
        Function Return1Async() As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILampService/Add", ReplyAction:="http://tempuri.org/ILampService/AddResponse")>  _
        Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILampService/Add", ReplyAction:="http://tempuri.org/ILampService/AddResponse")>  _
        Function AddAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ILampServiceChannel
        Inherits LampServiceReference.ILampService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class LampServiceClient
        Inherits System.ServiceModel.ClientBase(Of LampServiceReference.ILampService)
        Implements LampServiceReference.ILampService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Authenticate(ByVal username As String, ByVal password As String) As LampCommon.LampUserReturnWrapper Implements LampServiceReference.ILampService.Authenticate
            Return MyBase.Channel.Authenticate(username, password)
        End Function
        
        Public Function AuthenticateAsync(ByVal username As String, ByVal password As String) As System.Threading.Tasks.Task(Of LampCommon.LampUserReturnWrapper) Implements LampServiceReference.ILampService.AuthenticateAsync
            Return MyBase.Channel.AuthenticateAsync(username, password)
        End Function
        
        Public Function Return1() As Integer Implements LampServiceReference.ILampService.Return1
            Return MyBase.Channel.Return1
        End Function
        
        Public Function Return1Async() As System.Threading.Tasks.Task(Of Integer) Implements LampServiceReference.ILampService.Return1Async
            Return MyBase.Channel.Return1Async
        End Function
        
        Public Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double Implements LampServiceReference.ILampService.Add
            Return MyBase.Channel.Add(n1, n2)
        End Function
        
        Public Function AddAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements LampServiceReference.ILampService.AddAsync
            Return MyBase.Channel.AddAsync(n1, n2)
        End Function
    End Class
End Namespace
