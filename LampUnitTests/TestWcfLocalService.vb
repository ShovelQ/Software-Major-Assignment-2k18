﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LampCommon
Imports Microsoft.VisualStudio.TestTools.UnitTesting.Assert


<TestClass()>
Public Class TestWcfLocalService

    Public Service As LampClient.LampLocalWcfClient = LampClient.LampLocalWcfClient.Local

    ' filled in in Setup()
    Public Admin As LampUser

    Public Elevated1 As LampUser
    Public Elevated2 As LampUser

    Public Standard1 As LampUser
    Public Standard2 As LampUser

    Public ApprovedTemplate As LampTemplate

    ''' <summary>
    ''' Submitted by standard 1
    ''' </summary>
    Public UnApprovedTemplate1 As LampTemplate

    Public Loaded As LampTemplate
    Public Loaded2 As LampTemplate
    <TestInitialize>
    Public Sub Setup()
        Dim channel = Service.Channel
        channel.DeleteDebug()
        Admin = New LampUser("059fa948-fba2-4dd1-837e-6846226f6edf", UserPermission.Admin, "admin@test.com", "admin", "12345", "Admin Admin Admin")
        channel.DebugAddUser(Admin)

        Elevated1 = New LampUser("ffa68d62-ba6d-49aa-aefc-1896240dc4c3", UserPermission.Elevated, "elevated1@test.com", "elevated1", "12345", "Teacher Elevcated not admin")
        channel.DebugAddUser(Elevated1)

        Elevated2 = New LampUser("dda68d62-ba6d-49aa-aefc-1896240dc4c3", UserPermission.Elevated, "elevated2@test.com", "elevated2", "12345", "2  Elevcated not admin")
        channel.DebugAddUser(Elevated2)

        Standard1 = New LampUser("ed44e4e8-cf13-40d7-b110-89f7e5118204", UserPermission.Standard, "standard1@test.com", "standard1", "12345", "1 1 1")
        channel.DebugAddUser(Standard1)

        Standard2 = New LampUser("12345678-cf13-40d7-b110-89f7e5118204", UserPermission.Standard, "standard2@test.com", "standard2", "12345", "2 2 2")
        channel.DebugAddUser(Standard2)

        ApprovedTemplate = LampTemplate.FromFile("../../../templates/spf/1.spf")
        Service.Channel.Database.SetTemplate(ApprovedTemplate, Standard1.UserId, Admin.UserId)

        UnApprovedTemplate1 = LampTemplate.FromFile("../../../templates/spf/2.spf")
        Service.Channel.Database.SetTemplate(UnApprovedTemplate1, Standard1.UserId)

        Loaded = LampTemplate.FromFile("../../../templates/spf/3.spf")
        Loaded2 = LampTemplate.FromFile("../../../templates/spf/4.spf")

    End Sub


    <TestMethod()>
    <TestCategory("WcfService")>
    <TestCategory("WcfTemplate")>
    Public Sub TestGetTemplate()
        Dim response = Service.GetTemplate(Nothing, Nothing)
        Assert.IsTrue(response.Status = LampStatus.InvalidParameters)
        Assert.IsTrue(response.Template Is Nothing)
        response = Service.GetTemplate(Standard1.ToCredentials, Nothing)
        Assert.IsTrue(response.Status = LampStatus.InvalidParameters)
        Assert.IsTrue(response.Template Is Nothing)

        ' anyone should be able to get An approved template
        response = Service.GetTemplate(Standard1.ToCredentials, ApprovedTemplate.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
        response = Service.GetTemplate(Standard2.ToCredentials, ApprovedTemplate.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)

        ' should be able to access own template
        response = Service.GetTemplate(Standard1.ToCredentials, UnApprovedTemplate1.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)

        ' no access to someone else's approved temaplte
        response = Service.GetTemplate(Standard2.ToCredentials, UnApprovedTemplate1.GUID)
        Assert.IsTrue(response.Status = LampStatus.NoAccess)
        Assert.IsTrue(response.Template Is Nothing)

        ' elevated should be able to view any template
        response = Service.GetTemplate(Elevated1.ToCredentials, ApprovedTemplate.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
        response = Service.GetTemplate(Elevated1.ToCredentials, UnApprovedTemplate1.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
        response = Service.GetTemplate(Elevated2.ToCredentials, ApprovedTemplate.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
        response = Service.GetTemplate(Elevated2.ToCredentials, UnApprovedTemplate1.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)


    End Sub

    <TestMethod()>
    <TestCategory("WcfLocalService")>
    <TestCategory("WcfTemplate")>
    Public Async Function TestGetTemplateAsync() As Task
        Dim response = Await Service.GetTemplateAsync(Nothing, Nothing)
        Assert.IsTrue(response.Status = LampStatus.InvalidParameters)
        Assert.IsTrue(response.Template Is Nothing)
        response = Await Service.GetTemplateAsync(Standard1.ToCredentials, Nothing)
        Assert.IsTrue(response.Status = LampStatus.InvalidParameters)
        Assert.IsTrue(response.Template Is Nothing)

        ' anyone should be able to get An approved template
        response = Await Service.GetTemplateAsync(Standard1.ToCredentials, ApprovedTemplate.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
        response = Await Service.GetTemplateAsync(Standard2.ToCredentials, ApprovedTemplate.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)

        ' should be able to access own template
        response = Await Service.GetTemplateAsync(Standard1.ToCredentials, UnApprovedTemplate1.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)

        ' no access to someone else's approved temaplte
        response = Await Service.GetTemplateAsync(Standard2.ToCredentials, UnApprovedTemplate1.GUID)
        Assert.IsTrue(response.Status = LampStatus.NoAccess)
        Assert.IsTrue(response.Template Is Nothing)

        ' elevated should be able to view any template
        response = Await Service.GetTemplateAsync(Elevated1.ToCredentials, ApprovedTemplate.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
        response = Await Service.GetTemplateAsync(Elevated1.ToCredentials, UnApprovedTemplate1.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
        response = Await Service.GetTemplateAsync(Elevated2.ToCredentials, ApprovedTemplate.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
        response = Await Service.GetTemplateAsync(Elevated2.ToCredentials, UnApprovedTemplate1.GUID)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Template IsNot Nothing)
    End Function

    <TestMethod>
    <TestCategory("WcfService")>
    <TestCategory("WcfTemplate")>
    Public Sub TestSetTemplate()
        ' test w/ nothing
        Dim response = Service.AddTemplate(Standard1.ToCredentials, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)
        response = Service.AddTemplate(Nothing, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)

        ' standard should not be able to set templates
        response = Service.AddTemplate(Standard1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.NoAccess)
        response = Service.AddTemplate(Standard2.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.NoAccess)

        ' elevated should be able to set template
        response = Service.AddTemplate(Elevated1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.OK)
        ' test that duplicates give error
        response = Service.AddTemplate(Elevated1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.GuidConflict)
    End Sub

    <TestMethod>
    <TestCategory("WcfLocalService")>
    <TestCategory("WcfTemplate")>
    Public Async Function TestSetTemplateAsync() As Task
        ' test w/ nothing
        Dim response = Await Service.AddTemplateAsync(Standard1.ToCredentials, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)
        response = Await Service.AddTemplateAsync(Nothing, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)

        ' standard should not be able to set templates
        response = Await Service.AddTemplateAsync(Standard1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.NoAccess)
        response = Await Service.AddTemplateAsync(Standard2.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.NoAccess)

        ' elevated should be able to set template
        response = Await Service.AddTemplateAsync(Elevated1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.OK)
        ' test that duplicates give error
        response = Await Service.AddTemplateAsync(Elevated1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.GuidConflict)
    End Function

    <TestMethod>
    <TestCategory("WcfService")>
    <TestCategory("WcfTemplate")>
    Public Sub TestEditTemplate()
        ' test w/ nothing
        Dim response = Service.AddTemplate(Standard1.ToCredentials, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)
        response = Service.AddTemplate(Nothing, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)


        ' check if template doesnt exists
        response = Service.EditTemplate(Standard1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.DoesNotExist)
        response = Service.EditTemplate(Admin.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.DoesNotExist)


        Service.Channel.Database.SetTemplate(Loaded, Admin.UserId, Admin.UserId)
        ' elevated should be able to edit all
        response = Service.EditTemplate(Elevated1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.OK)

        Service.Channel.Database.SetTemplate(Loaded, Admin.UserId, Admin.UserId)
        ' Standard should not be able to edit template that is not their's
        response = Service.EditTemplate(Standard1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.NoAccess)
    End Sub

    <TestMethod>
    <TestCategory("WcfLocalService")>
    <TestCategory("WcfTemplate")>
    Public Async Function TestEditTemplateAsync() As Task
        ' test w/ nothing
        Dim response = Await Service.AddTemplateAsync(Standard1.ToCredentials, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)
        response = Await Service.AddTemplateAsync(Nothing, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)


        ' check if template doesnt exists
        response = Await Service.EditTemplateAsync(Standard1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.DoesNotExist)
        response = Await Service.EditTemplateAsync(Admin.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.DoesNotExist)


        Await Service.Channel.Database.SetTemplateAsync(Loaded, Admin.UserId, Admin.UserId)
        ' elevated should be able to edit all
        response = Await Service.EditTemplateAsync(Elevated1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.OK)

        Await Service.Channel.Database.SetTemplateAsync(Loaded, Admin.UserId, Admin.UserId)
        ' Standard should not be able to edit template that is not their's
        response = Await Service.EditTemplateAsync(Standard1.ToCredentials, Loaded)
        Assert.IsTrue(response = LampStatus.NoAccess)
    End Function

    <TestMethod>
    <TestCategory("WcfService")>
    <TestCategory("WcfTemplate")>
    Public Sub TestRemoveTemplate()
        ' test w/ nothing
        Dim response = Service.RemoveTemplate(Standard1.ToCredentials, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)
        response = Service.RemoveTemplate(Nothing, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)

        Service.Channel.Database.SetTemplate(Loaded, Admin.UserId, Admin.UserId)
        ' elevated should be able to remove standard unapproved, own approved
        response = Service.RemoveTemplate(Elevated1.ToCredentials, Loaded.GUID)
        Assert.IsTrue(response = LampStatus.OK)

        Service.Channel.Database.SetTemplate(Loaded, Admin.UserId, Admin.UserId)
        ' Admin should be able to remove template
        response = Service.RemoveTemplate(Admin.ToCredentials, Loaded.GUID)
        Assert.IsTrue(response = LampStatus.OK)


        Service.Channel.Database.SetTemplate(Loaded, Admin.UserId, Admin.UserId)
        ' standard should not be able to remove template
        response = Service.RemoveTemplate(Standard1.ToCredentials, Loaded.GUID)
        Assert.IsTrue(response = LampStatus.NoAccess)


        Service.Channel.Database.SetTemplate(Loaded, Standard1.UserId, Admin.UserId)
        ' however, the creater should be able to remove it
        response = Service.RemoveTemplate(Standard1.ToCredentials, Loaded.GUID)
        Assert.IsTrue(response = LampStatus.OK)

    End Sub


    <TestMethod>
    <TestCategory("WcfLocalService")>
    <TestCategory("WcfTemplate")>
    Public Async Function TestRemoveTemplateAsync() As Task
        ' test w/ nothing
        Dim response = Await Service.RemoveTemplateAsync(Standard1.ToCredentials, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)
        response = Await Service.RemoveTemplateAsync(Nothing, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)

        Await Service.Channel.Database.SetTemplateAsync(Loaded, Admin.UserId, Admin.UserId)
        ' elevated should be able to remove standard unapproved, own approved
        response = Await Service.RemoveTemplateAsync(Elevated1.ToCredentials, Loaded.GUID)
        Assert.IsTrue(response = LampStatus.OK)

        Await Service.Channel.Database.SetTemplateAsync(Loaded, Admin.UserId, Admin.UserId)
        ' Admin should be able to remove template
        response = Await Service.RemoveTemplateAsync(Admin.ToCredentials, Loaded.GUID)
        Assert.IsTrue(response = LampStatus.OK)


        Await Service.Channel.Database.SetTemplateAsync(Loaded, Admin.UserId, Admin.UserId)
        ' standard should not be able to remove template
        response = Await Service.RemoveTemplateAsync(Standard1.ToCredentials, Loaded.GUID)
        Assert.IsTrue(response = LampStatus.NoAccess)


        Await Service.Channel.Database.SetTemplateAsync(Loaded, Standard1.UserId, Admin.UserId)
        ' however, the creater should be able to remove it
        response = Await Service.RemoveTemplateAsync(Standard1.ToCredentials, Loaded.GUID)
        Assert.IsTrue(response = LampStatus.OK)
    End Function

    <TestMethod>
    <TestCategory("WcfService")>
    <TestCategory("WcfJob")>
    Public Sub TestGetJob()
        ' test w/ invalid parameters
        Dim response = Service.GetJob(Nothing, Nothing)
        Assert.IsTrue(response.Status = LampStatus.InvalidParameters)
        response = Service.GetJob(Admin.ToCredentials, Nothing)
        Assert.IsTrue(response.Status = LampStatus.InvalidParameters)

        Dim job1 = New LampJob(Loaded, Elevated1.ToProfile)
        Service.Channel.Database.SetTemplate(Loaded, Admin.UserId, Admin.UserId)
        Service.Channel.Database.SetJob(job1)

        ' standard cannot see other jobs
        response = Service.GetJob(Standard1.ToCredentials, job1.JobId)
        Assert.IsTrue(response.Status = LampStatus.NoAccess)
        Assert.IsTrue(response.Job Is Nothing)
        ' other elevated (no submitter) shouldnt be able to see the job
        response = Service.GetJob(Elevated2.ToCredentials, job1.JobId)
        Assert.IsTrue(response.Status = LampStatus.NoAccess)
        Assert.IsTrue(response.Job Is Nothing)


        ' admin and submiter should be able to access the job
        response = Service.GetJob(Admin.ToCredentials, job1.JobId)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Job IsNot Nothing)
        response = Service.GetJob(Elevated1.ToCredentials, job1.JobId)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Job IsNot Nothing)
    End Sub


    <TestMethod>
    <TestCategory("WcfLocalService")>
    <TestCategory("WcfJob")>
    Public Async Function TestGetJobAsync() As Task
        ' test w/ invalid parameters
        Dim response = Await Service.GetJobAsync(Nothing, Nothing)
        Assert.IsTrue(response.Status = LampStatus.InvalidParameters)
        response = Await Service.GetJobAsync(Admin.ToCredentials, Nothing)
        Assert.IsTrue(response.Status = LampStatus.InvalidParameters)

        Dim job1 = New LampJob(Loaded, Elevated1.ToProfile)
        Await Service.Channel.Database.SetTemplateAsync(Loaded, Admin.UserId, Admin.UserId)
        Await Service.Channel.Database.SetJobAsync(job1)

        ' standard cannot see other jobs
        response = Await Service.GetJobAsync(Standard1.ToCredentials, job1.JobId)
        Assert.IsTrue(response.Status = LampStatus.NoAccess)
        Assert.IsTrue(response.Job Is Nothing)
        ' other elevated (no submitter) shouldnt be able to see the job
        response = Await Service.GetJobAsync(Elevated2.ToCredentials, job1.JobId)
        Assert.IsTrue(response.Status = LampStatus.NoAccess)
        Assert.IsTrue(response.Job Is Nothing)


        ' admin and submiter should be able to access the job
        response = Await Service.GetJobAsync(Admin.ToCredentials, job1.JobId)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Job IsNot Nothing)
        response = Await Service.GetJobAsync(Elevated1.ToCredentials, job1.JobId)
        Assert.IsTrue(response.Status = LampStatus.OK)
        Assert.IsTrue(response.Job IsNot Nothing)
    End Function


    <TestMethod>
    <TestCategory("WcfService")>
    <TestCategory("WcfJob")>
    Public Sub TestAddJob()
        ' test w/ invalid parameters
        Dim response = Service.AddJob(Nothing, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)
        response = Service.AddJob(Admin.ToCredentials, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)


        Dim job1 = New LampJob(Loaded, Elevated1.ToProfile)

        Service.Channel.Database.SetTemplate(job1.Template)
        Service.Channel.Database.SetJob(job1)
        ' standard cannot submit job
        response = Service.AddJob(Standard1.ToCredentials, job1)
        Assert.IsTrue(response = LampStatus.NoAccess)
        Service.Channel.Database.RemoveTemplate(job1.Template.GUID)
        Service.Channel.Database.RemoveJob(job1.JobId)


        Service.Channel.Database.SetTemplate(Loaded, Admin.UserId, Admin.UserId)
        Service.Channel.Database.SetJob(job1)

        ' cannot add same job twice
        response = Service.AddJob(Elevated1.ToCredentials, job1)
        Assert.IsTrue(response = LampStatus.GuidConflict)

        Service.Channel.Database.RemoveJob(job1.JobId)


        ' elevated should be able to submit jobs
        response = Service.AddJob(Elevated2.ToCredentials, job1)
        Assert.IsTrue(response = LampStatus.OK)

    End Sub

    <TestMethod>
    <TestCategory("WcfLocalService")>
    <TestCategory("WcfJob")>
    Public Async Function TestAddJobAsync() As Task
        ' test w/ invalid parameters
        Dim response = Service.AddJob(Nothing, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)
        response = Service.AddJob(Admin.ToCredentials, Nothing)
        Assert.IsTrue(response = LampStatus.InvalidParameters)


        Dim job1 = New LampJob(Loaded, Elevated1.ToProfile)

        ' standard cannot submit job
        response = Service.AddJob(Standard1.ToCredentials, job1)
        Assert.IsTrue(response = LampStatus.NoAccess)


        Service.Channel.Database.SetTemplate(Loaded, Admin.UserId, Admin.UserId)
        Service.Channel.Database.SetJob(job1)

        ' cannot add same job twice
        response = Service.AddJob(Elevated1.ToCredentials, job1)
        Assert.IsTrue(response = LampStatus.GuidConflict)

        Service.Channel.Database.RemoveJob(job1.JobId)


        ' elevated should be able to submit jobs
        response = Service.AddJob(Elevated2.ToCredentials, job1)
        Assert.IsTrue(response = LampStatus.OK)

    End Function
End Class