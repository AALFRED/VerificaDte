'Imports consumiendo.referenciaws
Imports System.Data
Imports System.IO
Imports System.Xml
Imports System.Security.Cryptography
Imports System.Text
Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Diagnostics
Imports System.Object
Imports System.Security.Cryptography.Xml
Imports System.Security.Cryptography.Xml.SignedXml
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Web.Security
Imports System.net
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ServiceModel.Channels
Imports System.ServiceModel


Public Class frm_consulta_eventos
    Private s, a, b, c, d, e, f, g, h, i, j, k As String
    Dim fila As Integer
    'Dim doc As New XmlTextWriter(System.AppDomain.CurrentDomain.BaseDirectory() + "Token.xml", Encoding.UTF8)
    'Dim docserializado = System.AppDomain.CurrentDomain.BaseDirectory() + "Tokenserial.xml"
    'Dim docxml = System.AppDomain.CurrentDomain.BaseDirectory() + "Token.xml"
    Dim doc As New XmlTextWriter("C:\Proyectos Vb2017\verificadte\TokenCint\Token1.xml", Encoding.UTF8)
    Dim docserializado = ("C:\Proyectos Vb2017\verificadte\TokenCint\Tokenserial1.xml")
    Dim docxml = ("C:\Proyectos Vb2017\verificadte\TokenCint\Token1.xml")

    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Public Function SaveIncomingFile(ByVal cBody As String) As String
        Try
            Dim pdfByte As Byte() = Convert.FromBase64String(cBody)
            Dim oFileStream As FileStream = New FileStream("c:\" + "new.pdf", FileMode.CreateNew)
            oFileStream.Write(pdfByte, 0, pdfByte.Length)
            oFileStream.Close()
            Return "awsome"
        Catch ex As Exception
            Return "ErrorMessage: " & ex.Message
        End Try
    End Function


    Public Shared Function SeleccionarCertificado() As X509Certificate2
        '        Dim store As New X509Store(StoreLocation.LocalMachine)
        Dim store As New X509Store(StoreLocation.CurrentUser)
        '/////
        'LEE archivo texto
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Proyectos Vb2017\verificadte\cert01.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        ' & stringReader)

        store.Open(OpenFlags.ReadOnly)
        Try
            Dim certSeleccionado As X509Certificate2 = Nothing
            For Each cert As X509Certificate2 In store.Certificates
                If cert.HasPrivateKey Then
                    'If certSeleccionado = Nothing Then
                    'tomaremos el primero de ellos para este ejemplo
                    If Trim(cert.FriendlyName) = stringReader Then
                        certSeleccionado = cert
                    End If
                    'End If
                End If
            Next
            'MsgBox(certSeleccionado.FriendlyName)
            Return certSeleccionado
        Finally
            store.Close()
        End Try
    End Function
    Public Sub CreaXmlToken(ByVal seed As String)
        Dim cert As New X509Certificates.X509Certificate2
        Dim Key As New RSACryptoServiceProvider()
        Try
            cert = SeleccionarCertificado()

            If doc.WriteState = WriteState.Closed Then

                'Dim rutaorigen As String = "C:\validacion\verificadte\bin\Debug\Token.xml"
                'Dim RutaDestinoRecibo As String = "C:\validacion\verificadte\bin\Debug\Token1.xml"
                'Altero las rutas por sospecha que chochan los archivos xml con las empresas  junio-18
                'original
                'Dim rutaorigen As String = "C:\Proyectos Vb2017\verificadte\bin\Debug\Token.xml"
                'nueva
                Dim rutaorigen As String = "C:\Proyectos Vb2017\verificadte\TokenCint\Token.xml"
                'original
                'Dim RutaDestinoRecibo As String = "C:\Proyectos Vb2017\verificadte\bin\Debug\Token1.xml"
                'nueva
                Dim RutaDestinoRecibo As String = "C:\Proyectos Vb2017\verificadte\TokenCint\Token1.xml"
                Dim archivonombre = Path.GetFileName(rutaorigen)
                Dim destino As String = Path.Combine(RutaDestinoRecibo, archivonombre)

                File.Copy(rutaorigen, RutaDestinoRecibo, True)

            Else

                doc.WriteStartDocument()
                doc.WriteStartElement("getToken")
                doc.WriteStartElement("Item")
                doc.WriteStartElement("Semilla")
                doc.WriteValue(seed)
                doc.WriteEndElement() 'fin Semilla
                doc.WriteEndElement() 'Fin Item
                doc.WriteEndElement() 'Fin getToken
                doc.WriteEndDocument() ' fin documento
                doc.Flush()
                doc.Close()

                'MsgBox(cert)
                Key = cert.PrivateKey

                '  SignXmlFile(docxml, docserializado, Key)
                'inicio serializacion
                Dim filename As String = docxml
                Dim signedfilename As String = docserializado

                ' Create a new XML document.
                Dim doc2 As New XmlDocument()

                ' Load the passed XML file using its name.
                doc2.Load(New XmlTextReader(filename))

                ' Create a SignedXml object.
                Dim signedXml As New SignedXml(doc2)

                ' Add the key to the SignedXml document. 
                signedXml.SigningKey = Key

                ' Create a reference to be signed.
                Dim reference As New Reference()
                reference.Uri = ""

                ' Add an enveloped transformation to the reference.
                Dim env As New XmlDsigEnvelopedSignatureTransform()
                reference.AddTransform(env)

                ' Add the reference to the SignedXml object.
                signedXml.AddReference(reference)

                'crea keyinfo

                Dim keyInfo As New KeyInfo()
                keyInfo.AddClause(New RSAKeyValue(CType(Key, RSA)))
                keyInfo.AddClause(New KeyInfoX509Data(cert))
                signedXml.KeyInfo = keyInfo


                ' Compute the signature.
                signedXml.ComputeSignature()

                ' Get the XML representation of the signature and save
                ' it to an XmlElement object.
                Dim xmlDigitalSignature As XmlElement = signedXml.GetXml()

                ' Append the element to the XML document.
                doc2.DocumentElement.AppendChild(doc2.ImportNode(xmlDigitalSignature, True))

                If TypeOf doc2.FirstChild Is XmlDeclaration Then
                    doc2.RemoveChild(doc2.FirstChild)
                End If

                ' Save the signed XML document to a file specified
                ' using the passed string.
                Dim xmltw As New XmlTextWriter(signedfilename, New UTF8Encoding(False))
                doc2.WriteTo(xmltw)
                xmltw.Close()
                Dim jws As New referenciatoken.GetTokenFromSeedService
                Dim resul = jws.getToken(doc2.InnerXml)
                'MsgBox(resul)

                Dim xmldoc As New XmlDocument
                xmldoc.LoadXml(resul)
                Dim reader = New XmlNodeReader(xmldoc)
                reader.ReadToFollowing("TOKEN")
                TextBox3.Text = reader.ReadElementContentAsString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try

    End Sub

    Public Sub creasemilla()
        Try
            Dim jws As New referenciaws.CrSeedService
            Dim resul = jws.getSeed()
            '        MsgBox(resul)
            Dim xmldoc As New XmlDocument
            xmldoc.LoadXml(resul)
            Dim reader = New XmlNodeReader(xmldoc)
            reader.ReadToFollowing("SEMILLA")
            TextBox4.Text = reader.ReadElementContentAsString()
            frm_menu.Hide()
            'MsgBox("semilla creada")
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try
    End Sub
    Public Sub creatoken()
        Dim jws2 As New referenciatoken.GetTokenFromSeedService
        CreaXmlToken(TextBox4.Text)
    End Sub

    Private Sub frm_consulta_eventos_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_menu.Show()

    End Sub
    Private Sub frm_consulta_eventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox6.Text = "96689970"
        TextBox5.Text = "0"
        TextBox2.Text = "33"
        creasemilla()
        creatoken()

        Label10.Text = "" 'cod resp
        Label11.Text = "" 'desc resp

        Label17.Text = "" 'cod evento
        Label18.Text = "" 'desc evento
        Label19.Text = "" 'rut
        Label20.Text = "" 'fecha
        Label25.Text = "" 'dv

        Label21.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        Label24.Text = ""
        Label26.Text = "" 'dv

        cmd_enviar.Enabled = False

    End Sub

    Private Sub cmd_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_enviar.Click
        Dim Request As WebRequest
        Dim Response As WebResponse
        Dim DataStream As Stream
        Dim Reader As StreamReader
        Dim SoapByte() As Byte
        Dim SoapStr As String
        Dim pSuccess As Boolean = True
        'Dim objNodelist As XmlNodeList
        'Dim objNode As XmlNode

        Label10.Text = ""
        Label11.Text = ""

        TextBox7.Clear()

        SoapStr = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://ws.registroreclamodte.diii.sdi.sii.cl"">"
        SoapStr = SoapStr & "<soapenv:Header/>"
        SoapStr = SoapStr & "<soapenv:Body>"
        SoapStr = SoapStr & "<ws:listarEventosHistDoc>"
        SoapStr = SoapStr & "<rutEmisor>96689970</rutEmisor>"
        SoapStr = SoapStr & "<dvEmisor>0</dvEmisor>"
        SoapStr = SoapStr & "<tipoDoc>33</tipoDoc>"
        SoapStr = SoapStr & "<folio>" & TextBox1.Text & "</folio>"
        SoapStr = SoapStr & "</ws:listarEventosHistDoc>"
        SoapStr = SoapStr & "</soapenv:Body>"
        SoapStr = SoapStr & "</soapenv:Envelope>"

        Try

            SoapByte = System.Text.Encoding.UTF8.GetBytes(SoapStr)

            Request = WebRequest.Create("https://ws1.sii.cl/WSREGISTRORECLAMODTE/registroreclamodteservice")
            Request.Headers.Add("SOAPAction", "listarEventosHistDoc")
            Request.Headers.Add("cookie", "TOKEN=" & TextBox3.Text)

            Request.ContentType = "text/xml; charset=utf-8"
            Request.ContentLength = SoapByte.Length
            Request.Method = "POST"

            DataStream = Request.GetRequestStream()
            DataStream.Write(SoapByte, 0, SoapByte.Length)
            DataStream.Close()

            Response = Request.GetResponse()
            DataStream = Response.GetResponseStream()
            Reader = New StreamReader(DataStream)
            Dim SD2Request As String = Reader.ReadToEnd()

            DataStream.Close()
            Reader.Close()
            ' MsgBox(SD2Request)
            TextBox7.Text = SD2Request
            TextBox7.Visible = False

            Dim xmlresultado As New XmlDocument
            xmlresultado.LoadXml(SD2Request)
            Dim leeresul = New XmlNodeReader(xmlresultado)
            leeresul.readtofollowing("codResp")
            s = (leeresul.READELEMENTCONTENTASSTRING())
            Label10.Text = s  'CODIGO RESPUESTA

            Select Case Label10.Text
                Case "16"

                    Dim leeresul2 = New XmlNodeReader(xmlresultado)
                    leeresul2.readtofollowing("descResp")
                    a = leeresul2.READELEMENTCONTENTASSTRING()
                    Label11.Text = a 'DESCRIPCION RESPUESTA
                    Exit Sub

                Case "15"

                    Dim leeresul2 = New XmlNodeReader(xmlresultado)
                    leeresul2.readtofollowing("descResp")
                    a = leeresul2.READELEMENTCONTENTASSTRING()
                    Label11.Text = a 'DESCRIPCION RESPUESTA

                    'primera lista de eventos doc
                    Dim leeresul3 = New XmlNodeReader(xmlresultado)
                    leeresul3.readtofollowing("codEvento")
                    'MsgBox(leeresul3.READELEMENTCONTENTASSTRING)
                    b = leeresul3.READELEMENTCONTENTASSTRING
                    Label17.Text = b 'CODIGO EVENTO

                    Dim leeresul4 = New XmlNodeReader(xmlresultado)
                    leeresul4.readtofollowing("descEvento")
                    c = leeresul4.READELEMENTCONTENTASSTRING()
                    Label18.Text = c 'DESCRIPCION EVENTO

                    Dim leeresul5 = New XmlNodeReader(xmlresultado)
                    leeresul5.readtofollowing("rutResponsable")
                    d = leeresul5.READELEMENTCONTENTASSTRING()
                    Label19.Text = d 'RUT RESPONSABLE

                    Dim leeresul6 = New XmlNodeReader(xmlresultado)
                    Dim valor As String
                    leeresul6.readtofollowing("dvResponsable")
                    'e = leeresul6.READELEMENTCONTENTASSTRING() 'falta e
                    valor = (leeresul6.READELEMENTCONTENTASSTRING())
                    Label25.Text = valor  'DV RESPONSABLE

                    Dim leeresul7 = New XmlNodeReader(xmlresultado)
                    leeresul7.readtofollowing("fechaEvento")
                    f = leeresul7.READELEMENTCONTENTASSTRING()
                    Label20.Text = f 'FECHA EVENTO
                    'fin primera lista

                    '///////////////////////////////////////////////////////////////////////////////////////
                    'segunda lista de eventos doc
                    Dim leeresul8 = New XmlNodeReader(xmlresultado)
                    leeresul8.readtofollowing("codEvento")
                    'MsgBox(leeresul3.READELEMENTCONTENTASSTRING)
                    b = leeresul8.READELEMENTCONTENTASSTRING
                    Label21.Text = g 'CODIGO EVENTO

                    Dim leeresul9 = New XmlNodeReader(xmlresultado)
                    leeresul9.readtofollowing("descEvento")
                    c = leeresul9.READELEMENTCONTENTASSTRING()
                    Label22.Text = h 'DESCRIPCION EVENTO

                    Dim leeresul10 = New XmlNodeReader(xmlresultado)
                    leeresul10.readtofollowing("rutResponsable")
                    d = leeresul10.READELEMENTCONTENTASSTRING()
                    Label23.Text = i 'RUT RESPONSABLE

                    Dim leeresul11 = New XmlNodeReader(xmlresultado)
                    Dim valor2 As String
                    leeresul11.readtofollowing("dvResponsable")
                    'e = leeresul6.READELEMENTCONTENTASSTRING() 'falta e
                    valor2 = (leeresul11.READELEMENTCONTENTASSTRING())
                    Label25.Text = valor2  'DV RESPONSABLE

                    Dim leeresul12 = New XmlNodeReader(xmlresultado)
                    leeresul12.readtofollowing("fechaEvento")
                    f = leeresul12.READELEMENTCONTENTASSTRING()
                    Label24.Text = f 'FECHA EVENTO
                    'fin segunda lista


                    'Const fic As String = "C:\validacion\Prueba.txt"
                    'Dim texto As String = SD2Request.ToString

                    'Dim sw As New System.IO.StreamWriter(fic)
                    'sw.WriteLine(texto)
                    'sw.Close()
                    Response.Close()
            End Select

        Catch ex As WebException
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub cmd_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_limpiar.Click
        TextBox1.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label25.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        Label26.Text = ""
        Label24.Text = ""

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If GetAsyncKeyState(13) Then
            If TextBox1.Text <> "" Then
                cmd_enviar.Enabled = True
                cmd_enviar.Select()
            Else
                TextBox1.Select()
            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class