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
Namespace eventos_acepta
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="RegistroReclamoDteServicePortBinding", [Namespace]:="http://ws.registroreclamodte.diii.sdi.sii.cl")>  _
    Partial Public Class RegistroReclamoDteServiceEndpointService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private consultarDocDteCedibleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private consultarFechaRecepcionSiiOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getVersionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ingresarAceptacionReclamoDocOperationCompleted As System.Threading.SendOrPostCallback
        
        Private listarEventosHistDocOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.WindowsApplication1.My.MySettings.Default.verificadte_eventos_acepta_RegistroReclamoDteServiceEndpointService
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
        Public Event consultarDocDteCedibleCompleted As consultarDocDteCedibleCompletedEventHandler
        
        '''<remarks/>
        Public Event consultarFechaRecepcionSiiCompleted As consultarFechaRecepcionSiiCompletedEventHandler
        
        '''<remarks/>
        Public Event getVersionCompleted As getVersionCompletedEventHandler
        
        '''<remarks/>
        Public Event ingresarAceptacionReclamoDocCompleted As ingresarAceptacionReclamoDocCompletedEventHandler
        
        '''<remarks/>
        Public Event listarEventosHistDocCompleted As listarEventosHistDocCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", ResponseNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", Use:=System.Web.Services.Description.SoapBindingUse.Literal)>  _
        Public Function consultarDocDteCedible(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String) As <System.Xml.Serialization.XmlElementAttribute("return")> respuestaTo
            Dim results() As Object = Me.Invoke("consultarDocDteCedible", New Object() {rutEmisor, dvEmisor, tipoDoc, folio})
            Return CType(results(0),respuestaTo)
        End Function
        
        '''<remarks/>
        Public Overloads Sub consultarDocDteCedibleAsync(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String)
            Me.consultarDocDteCedibleAsync(rutEmisor, dvEmisor, tipoDoc, folio, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub consultarDocDteCedibleAsync(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String, ByVal userState As Object)
            If (Me.consultarDocDteCedibleOperationCompleted Is Nothing) Then
                Me.consultarDocDteCedibleOperationCompleted = AddressOf Me.OnconsultarDocDteCedibleOperationCompleted
            End If
            Me.InvokeAsync("consultarDocDteCedible", New Object() {rutEmisor, dvEmisor, tipoDoc, folio}, Me.consultarDocDteCedibleOperationCompleted, userState)
        End Sub
        
        Private Sub OnconsultarDocDteCedibleOperationCompleted(ByVal arg As Object)
            If (Not (Me.consultarDocDteCedibleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent consultarDocDteCedibleCompleted(Me, New consultarDocDteCedibleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", ResponseNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", Use:=System.Web.Services.Description.SoapBindingUse.Literal)>  _
        Public Function consultarFechaRecepcionSii(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String) As <System.Xml.Serialization.XmlElementAttribute("return")> String
            Dim results() As Object = Me.Invoke("consultarFechaRecepcionSii", New Object() {rutEmisor, dvEmisor, tipoDoc, folio})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub consultarFechaRecepcionSiiAsync(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String)
            Me.consultarFechaRecepcionSiiAsync(rutEmisor, dvEmisor, tipoDoc, folio, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub consultarFechaRecepcionSiiAsync(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String, ByVal userState As Object)
            If (Me.consultarFechaRecepcionSiiOperationCompleted Is Nothing) Then
                Me.consultarFechaRecepcionSiiOperationCompleted = AddressOf Me.OnconsultarFechaRecepcionSiiOperationCompleted
            End If
            Me.InvokeAsync("consultarFechaRecepcionSii", New Object() {rutEmisor, dvEmisor, tipoDoc, folio}, Me.consultarFechaRecepcionSiiOperationCompleted, userState)
        End Sub
        
        Private Sub OnconsultarFechaRecepcionSiiOperationCompleted(ByVal arg As Object)
            If (Not (Me.consultarFechaRecepcionSiiCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent consultarFechaRecepcionSiiCompleted(Me, New consultarFechaRecepcionSiiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", ResponseNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", Use:=System.Web.Services.Description.SoapBindingUse.Literal)>  _
        Public Function getVersion() As <System.Xml.Serialization.XmlElementAttribute("return")> String
            Dim results() As Object = Me.Invoke("getVersion", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getVersionAsync()
            Me.getVersionAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getVersionAsync(ByVal userState As Object)
            If (Me.getVersionOperationCompleted Is Nothing) Then
                Me.getVersionOperationCompleted = AddressOf Me.OngetVersionOperationCompleted
            End If
            Me.InvokeAsync("getVersion", New Object(-1) {}, Me.getVersionOperationCompleted, userState)
        End Sub
        
        Private Sub OngetVersionOperationCompleted(ByVal arg As Object)
            If (Not (Me.getVersionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getVersionCompleted(Me, New getVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", ResponseNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", Use:=System.Web.Services.Description.SoapBindingUse.Literal)>  _
        Public Function ingresarAceptacionReclamoDoc(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String, ByVal accionDoc As String) As <System.Xml.Serialization.XmlElementAttribute("return")> respuestaTo
            Dim results() As Object = Me.Invoke("ingresarAceptacionReclamoDoc", New Object() {rutEmisor, dvEmisor, tipoDoc, folio, accionDoc})
            Return CType(results(0),respuestaTo)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ingresarAceptacionReclamoDocAsync(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String, ByVal accionDoc As String)
            Me.ingresarAceptacionReclamoDocAsync(rutEmisor, dvEmisor, tipoDoc, folio, accionDoc, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ingresarAceptacionReclamoDocAsync(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String, ByVal accionDoc As String, ByVal userState As Object)
            If (Me.ingresarAceptacionReclamoDocOperationCompleted Is Nothing) Then
                Me.ingresarAceptacionReclamoDocOperationCompleted = AddressOf Me.OningresarAceptacionReclamoDocOperationCompleted
            End If
            Me.InvokeAsync("ingresarAceptacionReclamoDoc", New Object() {rutEmisor, dvEmisor, tipoDoc, folio, accionDoc}, Me.ingresarAceptacionReclamoDocOperationCompleted, userState)
        End Sub
        
        Private Sub OningresarAceptacionReclamoDocOperationCompleted(ByVal arg As Object)
            If (Not (Me.ingresarAceptacionReclamoDocCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ingresarAceptacionReclamoDocCompleted(Me, New ingresarAceptacionReclamoDocCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", ResponseNamespace:="http://ws.registroreclamodte.diii.sdi.sii.cl", Use:=System.Web.Services.Description.SoapBindingUse.Literal)>  _
        Public Function listarEventosHistDoc(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String) As <System.Xml.Serialization.XmlElementAttribute("return")> respuestaTo
            Dim results() As Object = Me.Invoke("listarEventosHistDoc", New Object() {rutEmisor, dvEmisor, tipoDoc, folio})
            Return CType(results(0),respuestaTo)
        End Function
        
        '''<remarks/>
        Public Overloads Sub listarEventosHistDocAsync(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String)
            Me.listarEventosHistDocAsync(rutEmisor, dvEmisor, tipoDoc, folio, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub listarEventosHistDocAsync(ByVal rutEmisor As String, ByVal dvEmisor As String, ByVal tipoDoc As String, ByVal folio As String, ByVal userState As Object)
            If (Me.listarEventosHistDocOperationCompleted Is Nothing) Then
                Me.listarEventosHistDocOperationCompleted = AddressOf Me.OnlistarEventosHistDocOperationCompleted
            End If
            Me.InvokeAsync("listarEventosHistDoc", New Object() {rutEmisor, dvEmisor, tipoDoc, folio}, Me.listarEventosHistDocOperationCompleted, userState)
        End Sub
        
        Private Sub OnlistarEventosHistDocOperationCompleted(ByVal arg As Object)
            If (Not (Me.listarEventosHistDocCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent listarEventosHistDocCompleted(Me, New listarEventosHistDocCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ws.registroreclamodte.diii.sdi.sii.cl")>  _
    Partial Public Class respuestaTo
        
        Private codRespField As Integer
        
        Private codRespFieldSpecified As Boolean
        
        Private descRespField As String
        
        Private listaEventosDocField() As DteEventoDocTo
        
        Private rutTokenField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property codResp() As Integer
            Get
                Return Me.codRespField
            End Get
            Set
                Me.codRespField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property codRespSpecified() As Boolean
            Get
                Return Me.codRespFieldSpecified
            End Get
            Set
                Me.codRespFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property descResp() As String
            Get
                Return Me.descRespField
            End Get
            Set
                Me.descRespField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("listaEventosDoc", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property listaEventosDoc() As DteEventoDocTo()
            Get
                Return Me.listaEventosDocField
            End Get
            Set
                Me.listaEventosDocField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property rutToken() As String
            Get
                Return Me.rutTokenField
            End Get
            Set
                Me.rutTokenField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ws.registroreclamodte.diii.sdi.sii.cl")>  _
    Partial Public Class DteEventoDocTo
        
        Private codEventoField As String
        
        Private descEventoField As String
        
        Private rutResponsableField As String
        
        Private dvResponsableField As String
        
        Private fechaEventoField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property codEvento() As String
            Get
                Return Me.codEventoField
            End Get
            Set
                Me.codEventoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property descEvento() As String
            Get
                Return Me.descEventoField
            End Get
            Set
                Me.descEventoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property rutResponsable() As String
            Get
                Return Me.rutResponsableField
            End Get
            Set
                Me.rutResponsableField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property dvResponsable() As String
            Get
                Return Me.dvResponsableField
            End Get
            Set
                Me.dvResponsableField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property fechaEvento() As String
            Get
                Return Me.fechaEventoField
            End Get
            Set
                Me.fechaEventoField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")>  _
    Public Delegate Sub consultarDocDteCedibleCompletedEventHandler(ByVal sender As Object, ByVal e As consultarDocDteCedibleCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class consultarDocDteCedibleCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As respuestaTo
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),respuestaTo)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")>  _
    Public Delegate Sub consultarFechaRecepcionSiiCompletedEventHandler(ByVal sender As Object, ByVal e As consultarFechaRecepcionSiiCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class consultarFechaRecepcionSiiCompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")>  _
    Public Delegate Sub getVersionCompletedEventHandler(ByVal sender As Object, ByVal e As getVersionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getVersionCompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")>  _
    Public Delegate Sub ingresarAceptacionReclamoDocCompletedEventHandler(ByVal sender As Object, ByVal e As ingresarAceptacionReclamoDocCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ingresarAceptacionReclamoDocCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As respuestaTo
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),respuestaTo)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")>  _
    Public Delegate Sub listarEventosHistDocCompletedEventHandler(ByVal sender As Object, ByVal e As listarEventosHistDocCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class listarEventosHistDocCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As respuestaTo
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),respuestaTo)
            End Get
        End Property
    End Class
End Namespace
