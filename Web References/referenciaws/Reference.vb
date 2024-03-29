﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace referenciaws
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="CrSeedSoapBinding", [Namespace]:="http://DefaultNamespace")>  _
    Partial Public Class CrSeedService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private getStateOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getSeedOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getVersionMayorOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getVersionMenorOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getVersionPatchOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.WindowsApplication1.My.MySettings.Default.WindowsApplication1_referenciaws_CrSeedService
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event getStateCompleted As getStateCompletedEventHandler
        
        '''<remarks/>
        Public Event getSeedCompleted As getSeedCompletedEventHandler
        
        '''<remarks/>
        Public Event getVersionMayorCompleted As getVersionMayorCompletedEventHandler
        
        '''<remarks/>
        Public Event getVersionMenorCompleted As getVersionMenorCompletedEventHandler
        
        '''<remarks/>
        Public Event getVersionPatchCompleted As getVersionPatchCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function getState() As <System.Xml.Serialization.SoapElementAttribute("getStateReturn")> String
            Dim results() As Object = Me.Invoke("getState", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getStateAsync()
            Me.getStateAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getStateAsync(ByVal userState As Object)
            If (Me.getStateOperationCompleted Is Nothing) Then
                Me.getStateOperationCompleted = AddressOf Me.OngetStateOperationCompleted
            End If
            Me.InvokeAsync("getState", New Object(-1) {}, Me.getStateOperationCompleted, userState)
        End Sub
        
        Private Sub OngetStateOperationCompleted(ByVal arg As Object)
            If (Not (Me.getStateCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getStateCompleted(Me, New getStateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function getSeed() As <System.Xml.Serialization.SoapElementAttribute("getSeedReturn")> String
            Dim results() As Object = Me.Invoke("getSeed", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getSeedAsync()
            Me.getSeedAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getSeedAsync(ByVal userState As Object)
            If (Me.getSeedOperationCompleted Is Nothing) Then
                Me.getSeedOperationCompleted = AddressOf Me.OngetSeedOperationCompleted
            End If
            Me.InvokeAsync("getSeed", New Object(-1) {}, Me.getSeedOperationCompleted, userState)
        End Sub
        
        Private Sub OngetSeedOperationCompleted(ByVal arg As Object)
            If (Not (Me.getSeedCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getSeedCompleted(Me, New getSeedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function getVersionMayor() As <System.Xml.Serialization.SoapElementAttribute("getVersionMayorReturn")> String
            Dim results() As Object = Me.Invoke("getVersionMayor", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getVersionMayorAsync()
            Me.getVersionMayorAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getVersionMayorAsync(ByVal userState As Object)
            If (Me.getVersionMayorOperationCompleted Is Nothing) Then
                Me.getVersionMayorOperationCompleted = AddressOf Me.OngetVersionMayorOperationCompleted
            End If
            Me.InvokeAsync("getVersionMayor", New Object(-1) {}, Me.getVersionMayorOperationCompleted, userState)
        End Sub
        
        Private Sub OngetVersionMayorOperationCompleted(ByVal arg As Object)
            If (Not (Me.getVersionMayorCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getVersionMayorCompleted(Me, New getVersionMayorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function getVersionMenor() As <System.Xml.Serialization.SoapElementAttribute("getVersionMenorReturn")> String
            Dim results() As Object = Me.Invoke("getVersionMenor", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getVersionMenorAsync()
            Me.getVersionMenorAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getVersionMenorAsync(ByVal userState As Object)
            If (Me.getVersionMenorOperationCompleted Is Nothing) Then
                Me.getVersionMenorOperationCompleted = AddressOf Me.OngetVersionMenorOperationCompleted
            End If
            Me.InvokeAsync("getVersionMenor", New Object(-1) {}, Me.getVersionMenorOperationCompleted, userState)
        End Sub
        
        Private Sub OngetVersionMenorOperationCompleted(ByVal arg As Object)
            If (Not (Me.getVersionMenorCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getVersionMenorCompleted(Me, New getVersionMenorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function getVersionPatch() As <System.Xml.Serialization.SoapElementAttribute("getVersionPatchReturn")> String
            Dim results() As Object = Me.Invoke("getVersionPatch", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getVersionPatchAsync()
            Me.getVersionPatchAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getVersionPatchAsync(ByVal userState As Object)
            If (Me.getVersionPatchOperationCompleted Is Nothing) Then
                Me.getVersionPatchOperationCompleted = AddressOf Me.OngetVersionPatchOperationCompleted
            End If
            Me.InvokeAsync("getVersionPatch", New Object(-1) {}, Me.getVersionPatchOperationCompleted, userState)
        End Sub
        
        Private Sub OngetVersionPatchOperationCompleted(ByVal arg As Object)
            If (Not (Me.getVersionPatchCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getVersionPatchCompleted(Me, New getVersionPatchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub getStateCompletedEventHandler(ByVal sender As Object, ByVal e As getStateCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getStateCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub getSeedCompletedEventHandler(ByVal sender As Object, ByVal e As getSeedCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getSeedCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub getVersionMayorCompletedEventHandler(ByVal sender As Object, ByVal e As getVersionMayorCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getVersionMayorCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub getVersionMenorCompletedEventHandler(ByVal sender As Object, ByVal e As getVersionMenorCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getVersionMenorCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub getVersionPatchCompletedEventHandler(ByVal sender As Object, ByVal e As getVersionPatchCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getVersionPatchCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
