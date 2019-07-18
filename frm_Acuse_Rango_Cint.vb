
Imports System.IO
Imports System.Xml
Imports System.Security.Cryptography
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports System.Object
Imports System.Security.Cryptography.Xml
Imports System.Security.Cryptography.Xml.SignedXml
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ServiceModel.Channels
Imports System.ServiceModel

Public Class frm_Acuse_Rango_Cint

    Private midte As Long
    Private bandera As Boolean
    Private bandera1 As Boolean
    Private bandera2 As Boolean

    Private mifecha As Date
    Private mifecha2 As Date
    Private s, a, b As String
    Private j As Integer
    Private f, g As Integer
    Private contador As Integer = 0
    Public miano As Integer
    Public valor As String
    Dim cadena As String
    Dim agrega As Integer
    Dim valret As String
    Public hora_inicial As String = Now.ToString("HH:mm") 'para log de seguridad
    Public marca As Integer  ' marca que tipo de documento es

    Dim mainStatusBar As New StatusBar()
    Dim statusPanel As New StatusBarPanel()
    Dim datetimePanel As New StatusBarPanel()
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const CS_MAXIMIZE As Integer = &HF030I

    'Dim doc As New XmlTextWriter(System.AppDomain.CurrentDomain.BaseDirectory() + "Token.xml", Encoding.UTF8)
    'Dim docserializado = System.AppDomain.CurrentDomain.BaseDirectory() + "Tokenserial.xml"
    'Dim docxml = System.AppDomain.CurrentDomain.BaseDirectory() + "Token.xml"

    Dim doc As New XmlTextWriter("C:\Proyectos Vb2017\verificadte\TokenCint\Token1.xml", Encoding.UTF8)
    Dim docserializado = ("C:\Proyectos Vb2017\verificadte\TokenCint\Tokenserial1.xml")
    Dim docxml = ("C:\Proyectos Vb2017\verificadte\TokenCint\Token1.xml")

    '///////////////////////////////////////////////////////////////////
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Public Shared Function SeleccionarCertificado() As X509Certificate2
        '        Dim store As New X509Store(StoreLocation.LocalMachine)
        Dim store As New X509Store(StoreLocation.CurrentUser)
        store.Open(OpenFlags.ReadOnly)
        '/////
        'LEE archivo texto
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Proyectos Vb2017\verificadte\cert01.txt") 'certificado cintegral
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        ' & stringReader)

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

    Public Sub creasemilla()
        Try
            Dim jws As New referenciaws.CrSeedService
            Dim resul = jws.getSeed()
            '        MsgBox(resul)
            Dim xmldoc As New XmlDocument
            xmldoc.LoadXml(resul)
            Dim reader = New XmlNodeReader(xmldoc)
            reader.ReadToFollowing("SEMILLA")
            TextBox1.Text = reader.ReadElementContentAsString()
            frm_menu.Hide()
            'MsgBox("semilla creada")
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try
    End Sub
    Public Sub creatoken()
        Dim jws2 As New referenciatoken.GetTokenFromSeedService
        CreaXmlToken(TextBox1.Text)
    End Sub
    Public Sub CreaXmlToken(ByVal seed As String)
        Dim cert As New X509Certificates.X509Certificate2
        Dim Key As New RSACryptoServiceProvider()
        Try
            cert = SeleccionarCertificado()

            If doc.WriteState = WriteState.Closed Then

                'Altero las rutas por sospecha que chochan los archivos xml con las empresas  junio-18
                'original
                'Dim rutaorigen As String = "C:\Proyectos Vb2017\verificadte\bin\Debug\Token.xml"
                'nueva
                Dim rutaorigen As String = "C:\Proyectos Vb2017\verificadte\TokenCint\Token.xml"
                'original
                'Dim RutaDestinoRecibo As String = "C:\Proyectos Vb2017\verificadte\bin\Debug\Token1.xml"
                'nueva
                ' My.Computer.FileSystem.DeleteFile("C:\Proyectos Vb2017\verificadte\TokenCint\Token1.xml")



                Dim ArchivoBorrar As String

                ArchivoBorrar = "C:\Proyectos Vb2017\verificadte\TokenCint\Token1.xml"

                'comprobamos que el archivo existe
                If System.IO.File.Exists(ArchivoBorrar) = True Then
                    System.IO.File.Delete(ArchivoBorrar)
                End If

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

                '  MsgBox(cert)
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
                TextBox2.Text = reader.ReadElementContentAsString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try

    End Sub

    Sub Crea_Log()

        Dim time_ini As String
        'Dim numCols As Integer = grilla.ColumnCount
        'Dim numRows As Integer = grilla.RowCount - 1

        'Horas
        'Inicio
        time_ini = hora_inicial
        'Final
        Dim horafinal As String = Now.ToString("HH:mm")
        Dim DatoHora As String = Now.ToString("HH_mm")

        Dim strDestinationFile As String = "C:\Proyectos Vb2017\verificadte\log\\" & Label4.Text & "-CINT-AR-" & DatoHora & ".txt"
        Dim tw As TextWriter = New StreamWriter(strDestinationFile)

        Try

            tw.Write("VERFIFICACIÓN ACUSE - RECIBO")
            tw.Write(vbCrLf)
            tw.Write("Usuario: " & Label4.Text)
            tw.Write(vbCrLf)
            tw.Write("Documento Inicial: " & Label11.Text)
            tw.Write(vbCrLf)
            tw.Write("Documento Final: " & Label13.Text)
            tw.Write(vbCrLf)
            tw.Write("Nro de Documentos Revisados: " & Label16.Text)
            tw.Write(vbCrLf)
            Select Case marca
                Case 1
                    tw.Write("Tipo de Documento: Factura Electrónica ")
                Case 2
                    tw.Write("Tipo de Documento: Notas de Crédito ")
                Case 3
                    tw.Write("Tipo de Documento: Notas de Débito ")
            End Select

            tw.Write(vbCrLf)
            tw.Write("Hora de Inicio Revision: " & time_ini)
            tw.Write(vbCrLf)
            tw.Write("Hora Final de Revision: " & horafinal)

            tw.Close()
            'MsgBox("Log Registrado Exitosamente", MsgBoxStyle.Information)

        Catch ex As WebException
            MsgBox(ex.ToString())
        End Try

    End Sub

    Sub valida_aceptacion()
        Dim Request As WebRequest
        Dim Response As WebResponse
        Dim DataStream As Stream
        Dim Reader As StreamReader
        Dim SoapByte() As Byte
        Dim SoapStr As String
        Dim pSuccess As Boolean = True

        SoapStr = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://ws.registroreclamodte.diii.sdi.sii.cl"">"
        SoapStr = SoapStr & "<soapenv:Header/>"
        SoapStr = SoapStr & "<soapenv:Body>"
        SoapStr = SoapStr & "<ws:listarEventosHistDoc>"
        SoapStr = SoapStr & "<rutEmisor>96689970</rutEmisor>"
        SoapStr = SoapStr & "<dvEmisor>0</dvEmisor>"
        SoapStr = SoapStr & "<tipoDoc>33</tipoDoc>"
        SoapStr = SoapStr & "<folio>" & midte & "</folio>"
        SoapStr = SoapStr & "</ws:listarEventosHistDoc>"
        SoapStr = SoapStr & "</soapenv:Body>"
        SoapStr = SoapStr & "</soapenv:Envelope>"

        Try
            SoapByte = System.Text.Encoding.UTF8.GetBytes(SoapStr)

            Request = WebRequest.Create("https://ws1.sii.cl/WSREGISTRORECLAMODTE/registroreclamodteservice")
            'Request.Headers.Add("SOAPAction", "listarEventosHistDoc")
            Request.Headers.Add("SOAPAction", "")
            Request.Headers.Add("cookie", "TOKEN=" & TextBox2.Text)
            Request.Method = "POST"
            Request.ContentType = "text/xml; charset=UFT-8"
            Request.ContentLength = SoapByte.Length

            DataStream = Request.GetRequestStream()
            DataStream.Write(SoapByte, 0, SoapByte.Length)
            DataStream.Close()

            'delay
            Threading.Thread.Sleep(3000) 'antes 2500  mayo/2018

            Response = Request.GetResponse()
            DataStream = Response.GetResponseStream()
            Reader = New StreamReader(DataStream)
            Dim SD2Request As String = Reader.ReadToEnd()

            DataStream.Close()
            Reader.Close()

            Dim xmlresultado As New XmlDocument
            xmlresultado.LoadXml(SD2Request)
            Dim leeresul = New XmlNodeReader(xmlresultado)
            leeresul.readtofollowing("codResp")
            s = (leeresul.READELEMENTCONTENTASSTRING())
            'MsgBox(s)  'CODIGO RESPUESTA  estaba comentado

            Select Case s
                Case "16"
                    valret = "SIN ACUSE"

                Case "11"
                    valret = "NCE Involc."

                Case "15"
                    Dim leeresul3 = New XmlNodeReader(xmlresultado)
                    Dim valida As String
                    leeresul3.readtofollowing("codEvento")
                    'MsgBox(leeresul3.READELEMENTCONTENTASSTRING)
                    valida = leeresul3.READELEMENTCONTENTASSTRING 'CODIGO EVENTO
                    valret = valida
                  '  MsgBox(valret)  'estaba comentado
                Case "18"
                    valret = "NO RECIBIDO"
                Case "PAG"
                    valret = "PAG AL CONTADO"
            End Select

        Catch ex As WebException
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation, "Error Detectado")

        End Try
    End Sub


    Sub valida_aceptacion2()
        Dim Request As WebRequest
        Dim Response As WebResponse
        Dim DataStream As Stream
        Dim Reader As StreamReader
        Dim SoapByte() As Byte
        Dim SoapStr As String
        Dim pSuccess As Boolean = True

        SoapStr = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://ws.registroreclamodte.diii.sdi.sii.cl"">"
        SoapStr = SoapStr & "<soapenv:Header/>"
        SoapStr = SoapStr & "<soapenv:Body>"
        SoapStr = SoapStr & "<ws:listarEventosHistDoc>"
        SoapStr = SoapStr & "<rutEmisor>96689970</rutEmisor>"
        SoapStr = SoapStr & "<dvEmisor>0</dvEmisor>"
        SoapStr = SoapStr & "<tipoDoc>33</tipoDoc>"
        SoapStr = SoapStr & "<folio>" & midte & "</folio>"
        SoapStr = SoapStr & "</ws:listarEventosHistDoc>"
        SoapStr = SoapStr & "</soapenv:Body>"
        SoapStr = SoapStr & "</soapenv:Envelope>"

        Try
            SoapByte = System.Text.Encoding.UTF8.GetBytes(SoapStr)

            Request = WebRequest.Create("https://ws1.sii.cl/WSREGISTRORECLAMODTE/registroreclamodteservice")
            Request.Headers.Add("SOAPAction", "listarEventosHistDoc")
            Request.Headers.Add("cookie", "TOKEN=" & TextBox2.Text)
            Request.Method = "POST"
            Request.ContentType = "text/xml; charset=UFT-8"
            Request.ContentLength = SoapByte.Length

            DataStream = Request.GetRequestStream()
            DataStream.Write(SoapByte, 0, SoapByte.Length)
            DataStream.Close()

            'delay
            Threading.Thread.Sleep(3000) 'antes 2500  mayo/2018

            Response = Request.GetResponse()
            DataStream = Response.GetResponseStream()
            Reader = New StreamReader(DataStream)
            Dim SD2Request As String = Reader.ReadToEnd()

            DataStream.Close()
            Reader.Close()

            Dim xmlresultado As New XmlDocument
            xmlresultado.LoadXml(SD2Request)
            Dim leeresul = New XmlNodeReader(xmlresultado)
            leeresul.readtofollowing("codResp")
            s = (leeresul.READELEMENTCONTENTASSTRING())
            ' MsgBox(s)  'CODIGO RESPUESTA  estaba comentado

            Select Case s
                Case "16"
                    valret = "SIN ACUSE"

                Case "11"
                    valret = "NCE Involc."

                Case "15"
                    Dim leeresul3 = New XmlNodeReader(xmlresultado)
                    Dim valida As String
                    leeresul3.readtofollowing("codEvento")
                    'MsgBox(leeresul3.READELEMENTCONTENTASSTRING)
                    valida = leeresul3.READELEMENTCONTENTASSTRING 'CODIGO EVENTO
                    valret = valida
                   ' MsgBox(valret)  'estaba comentado
                Case "18"
                    valret = "NO RECIBIDO"
                Case "PAG"
                    valret = "PAG AL CONTADO"
            End Select

        Catch ex As WebException
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation, "Error Detectado")

        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        creasemilla()

        'BUSCAR FEL
        Dim i As Long
        'CONEXION A MYSQL
        Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")

        'define variables de conexion
        Dim sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader

        Try
            'Dim cadena1 As String
            com.Connection = conn
            midte = Label11.Text
            agrega = 0

            Label20.Visible = True 'REVISANDO...
            Label21.Visible = True 'FEL
            Label24.Text = 0
            j = 0
            agrega = 0

            For i = midte To Label13.Text

                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                If midte <= "99999" Then
                    valor = "FEL00000" & midte
                Else
                    valor = "FEL0000" & midte
                End If
                sql = "Select rutcon, totalcon, fechacon FROM VENTA WHERE tipocon = '" & valor & "'"

                com = New MySqlCommand(sql, conn)
                rs = com.ExecuteReader()
                If rs.HasRows = False Then
                    Call notengodatos()
                Else

                    If rs.Read() = True Then
                        TextBox12.Text = "33"
                        cadena = LTrim(RTrim(CStr(rs("rutcon"))))

                        a = cadena.Substring(1, 9) 'saca el primer caracter
                        s = cadena.Substring(9, 1) 'saca el ultimo caracter
                        a = cadena.Substring(1, 8)
                        TextBox8.Text = a
                        TextBox7.Text = s

                        'TextBox1.Text = a
                        TextBox11.Text = CStr(rs("totalcon"))
                        TextBox10.Text = CStr(rs("fechacon"))

                        TextBox10.Text = Replace(TextBox10.Text, "-", "")
                        TextBox10.Text = TextBox10.Text

                        rs.Close()
                        'MsgBox(midte)
                        frm_menu.Hide()
                        System.Windows.Forms.Application.DoEvents()
                        Cursor.Current = Cursors.WaitCursor

                        '///////////////////////////////////////////
                        'INCREMENTA EL LISTADO
                        bandera = False

                        With grilla
                            If j = 0 Then
                                .Item(0, j).Value = midte
                                '    If b = "DTE No Recibido" Then
                                '        .Item(1, j).Value = b
                                '        agrega = 1
                                '    Else
                                '        .Item(1, j).Value = b
                                '    End If
                                '    ' .Item(2, j).Value = "REGISTRADO"
                                '    If agrega = 1 Then
                                '        'agrega a la grilla2
                                '        Call notengodatos()   'antes notengodatos2
                                '    End If

                                Call valida_aceptacion()
                                Select Case valret
                                    Case "RCD"
                                        .Item(1, j).Value = "Reclamo al contenido del documento"
                                        bandera2 = True
                                        Label24.Text = Label24.Text + 1
                                    Case "RFP"
                                        .Item(1, j).Value = "Reclamo por falta parcial de mercaderías"
                                        bandera2 = True
                                        Label24.Text = Label24.Text + 1
                                    Case "RFT"
                                        .Item(1, j).Value = "Reclamo por falta total de mercaderías"
                                        bandera2 = True
                                        Label24.Text = Label24.Text + 1
                                    Case "SIN ACUSE"
                                        .Item(1, j).Value = "Documento No Presenta eventos de Reclamos o Acuse de Recibo"
                                        bandera2 = False
                                    Case ("ACD")
                                        .Item(1, j).Value = "Acepta contenido del documento"
                                        bandera2 = False
                                    Case "ERM"
                                        .Item(1, j).Value = "Otorga recibo de mercaderías o servicios"
                                        bandera2 = False
                                    Case "NCA"
                                        .Item(1, j).Value = "recepcion de NC de Anulación que Referencian al Documento"
                                        bandera2 = False
                                    Case "ENC"
                                        .Item(1, j).Value = "Recepción de NC distinta de Anulación que Referencian al Documento"
                                        bandera2 = True
                                    Case "PAG"
                                        .Item(1, j).Value = "DTE Pagado al Contado."
                                        bandera2 = False

                                    Case Else
                                        .Item(1, j).Value = "Error de Servicio"
                                        bandera2 = False
                                        'Label24.Text = Label24.Text + 1
                                End Select

                                If bandera2 = True Then
                                    Call notengodatos()   'antes notengodatos2
                                End If

                            Else
                                .Rows.Add()
                                .Item(0, j).Value = midte
                                If b = "DTE No Recibido" Then
                                    .Item(1, j).Value = b
                                    agrega = 1
                                Else
                                    .Item(1, j).Value = b
                                End If

                                ' .Item(2, j).Value = "REGISTRADO" 'si procesa es porque esta en sist vtas

                                'If agrega = 1 Then
                                '    'agrega a la grilla2
                                '    Call notengodatos() 'antes notengodatos2
                                'End If

                                Call valida_aceptacion()
                                Select Case valret
                                    Case "RCD"
                                        .Item(1, j).Value = "Reclamo al contenido del documento."
                                        bandera2 = True
                                        Label24.Text = Label24.Text + 1
                                    Case "RFP"
                                        .Item(1, j).Value = "Reclamo por falta parcial de mercaderías."
                                        bandera2 = True
                                        Label24.Text = Label24.Text + 1
                                    Case "RFT"
                                        .Item(1, j).Value = "Reclamo por falta total de mercaderías."
                                        bandera2 = True
                                        Label24.Text = Label24.Text + 1
                                    Case "SIN ACUSE"
                                        .Item(1, j).Value = "Documento No Presenta eventos de Reclamos o Acuse de Recibo."
                                        bandera2 = False
                                    Case ("ACD")
                                        .Item(1, j).Value = "Acepta contenido del documento."
                                        bandera2 = False
                                    Case "ERM"
                                        .Item(1, j).Value = "Otorga recibo de mercaderías o servicios."
                                        bandera2 = False
                                    Case "NCA"
                                        .Item(1, j).Value = "recepcion de NC de Anulación que Referencian al Documento."
                                        bandera2 = False
                                    Case "ENC"
                                        .Item(1, j).Value = "Recepción de NC distinta de Anulación que Referencian al Documento."
                                        bandera2 = True
                                    Case "PAG"
                                        .Item(1, j).Value = "DTE Pagado al Contado."
                                        bandera2 = False

                                    Case Else
                                        .Item(1, j).Value = "Error de Servicio."
                                        bandera2 = False

                                End Select

                                If bandera2 = True Then
                                    Call notengodatos()  'antes notengodatos2
                                End If
                            End If

                            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft 'alineado a la izquierda

                            .Font = New Font(.Font, FontStyle.Regular)
                            .DefaultCellStyle.Font = New Font("Calibri", 9)

                            j = j + 1
                            agrega = 0
                            .ClearSelection()
                            .CurrentCell = .Rows(.RowCount - 2).Cells(0)
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            midte = midte + 1

                            contador = Val(contador + 1)
                            contador = contador.ToString

                            grilla.Refresh()
                            Label15.Text = contador

                            'pone el foco a la ultima fila
                            grilla.Rows(grilla.RowCount - 1).Selected = True

                            'pone el numero en la columna inicial
                            If grilla.Rows.Count > 0 Then
                                For r As Integer = 0 To grilla.Rows.Count - 1
                                    Me.grilla.Rows(r).HeaderCell.Value = (r + 1).ToString()
                                    .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                                    .RowHeadersWidth = 30
                                    grilla.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
                                Next
                            End If

                        End With
                    End If
                End If
            Next i


            'guarda log y envia por correo
            marca = 1  'FEL
            Call Crea_Log()
            Cursor = Cursors.Default

            Label20.Visible = False 'REVISANDO...
            Label21.Visible = False 'FEL
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Call limpia()
        grilla.Rows.Clear()
        grilla2.Rows.Clear()

        Label20.Visible = False 'REVISANDO...
        Label21.Visible = False 'FEL

        Label15.Text = ""
        Label16.Text = ""

        cmd_buscar.Enabled = False
        Button1.Enabled = False

        Button1.Visible = True

        CheckBox3.Checked = False
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        'BUSCA FEL
        'define la conexion a la base de datos

        If ch_ano_ant.Checked = True Then
            miano = Date.Now.Year - 1
        Else
            miano = frm_menu.Mt_Label3.Text
        End If
        'CONEXION A MYSQL
        Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")
        'define variables de conexion
        Dim sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader
        Try
            com.Connection = conn
            If conn.State = 1 Then conn.Close()
            conn.Open()
            mifecha = fecha1.Text

            sql = "SELECT min(tipocon)as inicio FROM VENTA WHERE fechacon = '" & Format(mifecha, "yyyy-MM-dd") & "' and tipocon like 'FEL%' "
            com = New MySqlCommand(sql, conn)
            rs = com.ExecuteReader()
            rs.Read()
            If IsDBNull(rs("inicio")) = True Then
                MsgBox("La Fecha de Inicio al parecer es Feriado o no hay datos para procesar, Verifique la Fecha de Inicio", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Label11.Text = rs("inicio").ToString()
                rs.Close()
                com.Dispose()

                If Label11.Text <= "FEL0000099999" Then
                    Label11.Text = Replace(Label11.Text, "FEL00000", "")
                Else
                    Label11.Text = Replace(Label11.Text, "FEL0000", "")
                End If
            End If

            com.Connection = conn
            If conn.State = 1 Then conn.Close()
            conn.Open()
            sql = "SELECT max(tipocon)as final FROM VENTA WHERE fechacon = '" & Format(mifecha2, "yyyy-MM-dd") & "' and tipocon like 'FEL%' "
            com = New MySqlCommand(sql, conn)
            rs = com.ExecuteReader()
            rs.Read()
            Label13.Text = CStr(rs("final"))
            rs.Close()

            If Label13.Text <= "FEL0000099999" Then
                Label13.Text = Replace(Label13.Text, "FEL00000", "")
            Else
                Label13.Text = Replace(Label13.Text, "FEL0000", "")
            End If

            'por si pasa el inicio vacio
            If Label11.Text = "" Then Label1.Text = Label13.Text

            'saca el calculo
            Label16.Text = Val(Label13.Text - Label11.Text) + 1
            conn.Close()
            Button1.Enabled = True 'consulta dte
            Button1.Focus()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try
    End Sub

    Sub notengodatos()
        Try
            'Label24.Text = Label24.Text + 1
            '///////////////////////////////////////////
            'CARGA A LA GRILLA2 CUANDO NO EXISTE EL DOCUMENTO Y EL FOLIO NO FUE UTILIZADO
            'INCREMENTA EL LISTADO
            With grilla2
                If g = 0 Then
                    .Item(0, g).Value = midte
                    .Item(1, g).Value = "EL DOCUMENTO PRESENTA UN RECHAZO O PROBLEMA VERIFIQUE"

                    If bandera2 = True Then
                        .Item(1, g).Value = "ERROR VERIFICAR EN PÁGINA DE SII"
                    End If
                Else
                    .Rows.Add()
                    .Item(0, g).Value = midte
                    .Item(1, g).Value = "EL DOCUMENTO PRESENTA UN RECHAZO O PROBLEMA VERIFIQUE."

                    If bandera2 = True Then
                        .Item(1, g).Value = "ERROR VERIFICAR EN PÁGINA DE SII."
                    End If
                End If

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la centro
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft 'Alineado a la izquierda

                .Font = New Font(.Font, FontStyle.Regular)
                .DefaultCellStyle.Font = New Font("Calibri", 9)

                g = g + 1
                .ClearSelection()
                .CurrentCell = .Rows(.RowCount - 2).Cells(0)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Refresh()

            End With
            System.Windows.Forms.Application.DoEvents()
            midte = midte + 1

            contador = Val(contador + 1)
            contador = contador.ToString
            grilla2.Refresh()
            Label15.Text = contador

            'pone el foco a la ultima fila
            Me.grilla2.Rows(Me.grilla2.RowCount - 1).Selected = True

            'pone el numero en la columna inicial
            If grilla2.Rows.Count > 0 Then
                For r As Integer = 0 To grilla2.Rows.Count - 1
                    Me.grilla2.Rows(r).HeaderCell.Value = (r + 1).ToString()
                    grilla2.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    grilla2.RowHeadersWidth = 40
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try
    End Sub

    Sub notengodatos2()
        Try
            'Label24.Text = Label24.Text + 1
            '///////////////////////////////////////////
            'CARGA A LA GRILLA2 CUANDO NO EXISTE EL DOCUMENTO Y EL FOLIO NO FUE UTILIZADO
            'INCREMENTA EL LISTADO
            With grilla2
                If g = 0 Then
                    If bandera2 = True Then
                        .Item(0, g).Value = midte
                        .Item(1, g).Value = "EL DOCUMENTO PRESENTA UN RECHAZO O PROBLEMA VERIFIQUE"
                    End If
                    'If bandera2 = False Then
                    '    .Item(1, g).Value = "ERROR VERIFICAR EN PAGINA DE SII"
                    'End If
                Else
                    If bandera2 = True Then
                        .Rows.Add()
                        .Item(0, g).Value = midte
                        .Item(1, g).Value = "EL DOCUMENTO PRESENTA UN RECHAZO O PROBLEMA VERIFIQUE"

                        'If bandera2 = False Then
                        '    .Item(1, g).Value = "ERROR VERIFICAR EN PAGINA DE SII."
                    End If
                End If

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la centro
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft 'Alineado a la izquierda

                .Font = New Font(.Font, FontStyle.Regular)
                .DefaultCellStyle.Font = New Font("Calibri", 9)

                g = g + 1
                .ClearSelection()
                .CurrentCell = .Rows(.RowCount - 2).Cells(0)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Refresh()

            End With
            System.Windows.Forms.Application.DoEvents()
            midte = midte + 1

            contador = Val(contador + 1)
            contador = contador.ToString
            grilla2.Refresh()
            Label15.Text = contador

            'pone el foco a la ultima fila
            Me.grilla2.Rows(Me.grilla2.RowCount - 1).Selected = True

            'pone el numero en la columna inicial
            If grilla2.Rows.Count > 0 Then
                For r As Integer = 0 To grilla2.Rows.Count - 1
                    Me.grilla2.Rows(r).HeaderCell.Value = (r + 1).ToString()
                    grilla2.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    grilla2.RowHeadersWidth = 40
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
        frm_menu.Show()
    End Sub

    Private Sub fecha1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles fecha1.MaskInputRejected

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox13.Text = DateTime.Now.ToString
        creasemilla()
        creatoken()
    End Sub

    Private Sub fecha2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles fecha2.MaskInputRejected

    End Sub

    Sub limpia()
        'TextBox1.Text = ""
        'TextBox2.Text = ""
        TextBox3.Text = 0
        'TextBox4.Text = ""
        'TextBox5.Text = ""
        'TextBox6.Text = ""
        'TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        'TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        Label11.Text = ""
        Label13.Text = ""
    End Sub

    Private Sub op_calen1_CheckedChanged(sender As Object, e As EventArgs) Handles op_calen1.CheckedChanged
        If op_calen1.Checked = True Then
            Calendar1.Visible = True
            op_calen1.Checked = False
        End If
    End Sub

    Private Sub op_calen2_CheckedChanged(sender As Object, e As EventArgs) Handles op_calen2.CheckedChanged
        If op_calen2.Checked = True Then
            Calendar2.Visible = True
            op_calen2.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'para buscar facturas
        If CheckBox3.Checked = True Then 'check FEL
            'CheckBox2.Checked = False 'check NCR
            'CheckBox1.Checked = False 'check NDB

            Button1.Visible = True 'para FEL
            Button1.Enabled = False 'revisa FEL
            'Button2.Visible = False 'revisa NDB
            'Button3.Visible = False 'revisa NCR

            cmd_buscar.Visible = True 'busca FEL
            cmd_buscar.Enabled = True 'busca FEL
            'cmd_buscar_NCR.Visible = False 'busca NCR
            'cmd_buscar_NDB.Visible = False 'busca NDB
            cmd_buscar.Enabled = True
            cmd_buscar.Focus()
        Else
            'CheckBox1.Checked = False
            'CheckBox2.Checked = False
            CheckBox3.Checked = False
            cmd_buscar.Visible = True
            cmd_buscar.Enabled = False
            Button1.Visible = True
            'Button2.Visible = False
            'Button3.Visible = False
            Button1.Enabled = False
            'cmd_buscar_NCR.Visible = False
            'cmd_buscar_NDB.Visible = False
            fecha1.Focus()
        End If
    End Sub

    Private Sub Calendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendar1.DateChanged

    End Sub

    Private Sub frm_Acuse_Rango_Cint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label5.Text = Now.Date

        Timer1.Start()
        creasemilla()
        creatoken()
        TextBox3.Text = "6706723"
        TextBox4.Text = "1"
        TextBox6.Text = "96689970"
        TextBox5.Text = "0"
        Label11.Text = ""
        Label13.Text = ""
        Calendar1.Visible = False
        Calendar2.Visible = False
        Calendar1.ShowTodayCircle = True
        Calendar2.ShowTodayCircle = True


        Label15.Text = ""
        Label16.Text = ""
        Label24.Text = "0"
        Label3.Text = ""
        miano = frm_menu.Mt_Label3.Text

        Label20.Visible = False 'REVISANDO...
        Label21.Visible = False 'FEL


        Button1.Enabled = False 'consulta dte

        CheckBox3.Enabled = False

        cmd_buscar.Enabled = False

        TextBox3.Visible = False
        TextBox4.Visible = False
        'TextBox5.Visible = False
        'TextBox6.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        'TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        'TextBox12.Visible = False
        grilla.RowCount = 2
        grilla2.RowCount = 2

        CreateDynamicStatusBar()

        'Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.BackColor = System.Drawing.Color.Azure
        'Me.ClientSize = New System.Drawing.Size(999, 700)
        'Me.MaximumSize = New System.Drawing.Size(999, 700)
        'Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Centrar()




    End Sub


    Private Sub fecha1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fecha1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            ' SendKeys.Send("{TAB}")
            If IsDate(fecha1.Text) = True Then
                Date.TryParseExact(fecha1.Text, "dd-MM-yyyy", Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, mifecha)
                'MsgBox(mifecha.ToString("yyyy-MM-dd"))
                fecha2.Focus()
            Else
                fecha1.Focus()
            End If
        End If
    End Sub

    Private Sub ch_VerifCorre_CheckedChanged(sender As Object, e As EventArgs) Handles ch_VerifCorre.CheckedChanged
        Dim valor As Long = Val(Label13.Text)
        Dim i As Integer
        Dim numero As Integer = 0
        Dim row As DataGridViewRow
        Try
            With grilla

                For i = 1 To grilla.Rows.Count - 1
                    If Convert.ToInt32(grilla.Rows(i).Cells(0).Value.ToString()) > numero Then

                        'Guardo el numero, su fila 
                        row = .CurrentRow
                        numero = Convert.ToInt32(grilla.Rows(i).Cells(0).Value.ToString())

                        If numero = valor Then
                            MsgBox("No se detectaron saltos de folio en el listado", MessageBoxIcon.Information, Title:="Verificacion de Correlativo")

                            Exit Sub
                        Else

                            If numero <> valor Then
                                .Rows(.CurrentRow.Index + 1).Selected = True

                            Else
                                MsgBox("Se detectó un salto de folio en docto. nro " & numero & ", verifique!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                .Rows(.CurrentRow.Index + 1).Selected = True
                            End If
                        End If
                    End If
                Next i
            End With
        Catch err As Exception
            MsgBox("Un Error a Ocurrido mientras procesaba." + e.ToString())
        Finally

        End Try
    End Sub

    Private Sub fecha2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fecha2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            ' SendKeys.Send("{TAB}")
            If IsDate(fecha1.Text) = True Then
                Date.TryParseExact(fecha2.Text, "dd-MM-yyyy", Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, mifecha2)
                'MsgBox(mifecha2.ToString("yyyy-MM-dd"))
                cmd_buscar.Enabled = True
                cmd_buscar.Focus()
            Else
                fecha2.Focus()
            End If
        End If
    End Sub

    Private Sub Calendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar1.DateSelected
        fecha1.Text = Calendar1.SelectionRange.Start
        Calendar1.Visible = False

        Date.TryParseExact(fecha1.Text, "dd-MM-yyyy", Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, mifecha)

        fecha2.Focus()
    End Sub

    Private Sub Calendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar2.DateSelected
        fecha2.Text = Calendar2.SelectionRange.Start.Date
        'Date.TryParseExact(fecha2.Text, "dd-MM-yyyy", Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, mifecha2)

        Calendar2.Visible = False
        mifecha2 = fecha2.Text

        CheckBox3.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("LAS SIGLAS CORRESPONDIENTES A ACEPTACIÓN-/-RECLAMO" & vbNewLine & vbNewLine & "SIN ACUSE: Documento No Presenta eventos de Reclamos o Acuse de Recibo" & vbNewLine & vbNewLine & "ERROR: El Documento Presenta Problemas - Revise en la Página del SII" &
              vbNewLine & vbNewLine & "ACEPTA DOC.: Acepta Contenido del Documento" & vbNewLine & vbNewLine & "RECIBO MERC.-R.M.: Otorga Recibo de Mercaderías o Servicios." & vbNewLine & vbNewLine & "RECEP.NC-A: recepcion de NC de Anulación que Referencian al Documento" & vbNewLine & vbNewLine & "RECP.NC-E: Recepción de NC distinta de Anulación que Referencian al Documento" &
              vbNewLine & vbNewLine & "RECL.CONT.: Reclamo al Contenido del Documento" & vbNewLine & vbNewLine & "RECL.FALTA: Reclamo por Falta Parcial de Mercadería" & vbNewLine & vbNewLine & "RECL.TOTAL: Reclamo por Falta Total de Mercaderías.", MsgBoxStyle.Information, "SIGLAS DE INFORMACION")
    End Sub

    Private Sub CreateDynamicStatusBar()

        statusPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken
        statusPanel.Text = "Aplicación Iniciada."
        statusPanel.ToolTipText = "Ultima Actividad"
        statusPanel.AutoSize = StatusBarPanelAutoSize.Spring
        mainStatusBar.Panels.Add(statusPanel)
        datetimePanel.BorderStyle = StatusBarPanelBorderStyle.Raised
        datetimePanel.ToolTipText = "Fecha: " + System.DateTime.Today.ToString()
        datetimePanel.Text = System.DateTime.Today.ToLongDateString()
        datetimePanel.AutoSize = StatusBarPanelAutoSize.Contents
        mainStatusBar.Panels.Add(datetimePanel)
        mainStatusBar.ShowPanels = True
        Controls.Add(mainStatusBar)
    End Sub

    Private Sub cmd_consultar_Click(sender As Object, e As EventArgs) Handles cmd_consultar.Click
        '/////////////////////////////////////////////////////////////////////////
        '//////////////////////// CONSULTA POR FOLIO
        '////////////////////////
        creasemilla()

        'BUSCAR FEL
        Dim i As Long
        'CONEXION A MYSQL
        Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")

        'define variables de conexion
        Dim sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader

        Try
            'Dim cadena1 As String
            com.Connection = conn
            midte = TextBox15.Text
            agrega = 0

            Label20.Visible = True 'REVISANDO...
            Label21.Visible = True 'FEL
            Label24.Text = 0
            j = 0
            agrega = 0

            i = midte

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            If midte <= "99999" Then
                valor = "FEL00000" & midte
            Else
                valor = "FEL0000" & midte
            End If
            sql = "Select rutcon, totalcon, fechacon FROM VENTA WHERE tipocon = '" & valor & "'"

            com = New MySqlCommand(sql, conn)
            rs = com.ExecuteReader()
            If rs.HasRows = False Then
                Call notengodatos2()
            Else

                If rs.Read() = True Then
                    TextBox12.Text = "33"
                    cadena = LTrim(RTrim(CStr(rs("rutcon"))))

                    a = cadena.Substring(1, 9) 'saca el primer caracter
                    s = cadena.Substring(9, 1) 'saca el ultimo caracter
                    a = cadena.Substring(1, 8)
                    TextBox8.Text = a
                    TextBox7.Text = s

                    'TextBox1.Text = a
                    TextBox11.Text = CStr(rs("totalcon"))
                    TextBox10.Text = CStr(rs("fechacon"))

                    TextBox10.Text = Replace(TextBox10.Text, "-", "")
                    TextBox10.Text = TextBox10.Text

                    rs.Close()
                    'MsgBox(midte)
                    frm_menu.Hide()
                    System.Windows.Forms.Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor

                    '///////////////////////////////////////////
                    'INCREMENTA EL LISTADO
                    With grilla
                        If j = 0 Then
                            .Item(0, j).Value = midte
                            If b = "DTE No Recibido" Then
                                .Item(1, j).Value = b
                                agrega = 1
                            Else
                                .Item(1, j).Value = b
                            End If
                            ' .Item(2, j).Value = "REGISTRADO"
                            If agrega = 1 Then
                                'agrega a la grilla2
                                Call notengodatos2()   'antes notengodatos2
                            End If

                            bandera = False

                            Call valida_aceptacion2()
                            Select Case valret
                                Case "RCD"
                                    .Item(1, j).Value = "Reclamo al contenido del documento"
                                    bandera2 = True
                                    Label24.Text = Label24.Text + 1
                                Case "RFP"
                                    .Item(1, j).Value = "Reclamo por falta parcial de mercaderías"
                                    bandera2 = True
                                    Label24.Text = Label24.Text + 1
                                Case "RFT"
                                    .Item(1, j).Value = "Reclamo por falta total de mercaderías"
                                    bandera2 = True
                                    Label24.Text = Label24.Text + 1
                                Case "SIN ACUSE"
                                    .Item(1, j).Value = "Documento No Presenta eventos de Reclamos o Acuse de Recibo"
                                    bandera2 = False
                                Case ("ACD")
                                    .Item(1, j).Value = "Acepta contenido del documento"
                                    bandera2 = False
                                Case "ERM"
                                    .Item(1, j).Value = "Otorga recibo de mercaderías o servicios"
                                    bandera2 = False
                                Case "NCA"
                                    .Item(1, j).Value = "recepcion de NC de Anulación que Referencian al Documento"
                                    bandera2 = False
                                Case "ENC"
                                    .Item(1, j).Value = "Recepción de NC distinta de Anulación que Referencian al Documento"
                                    bandera2 = True
                                Case "PAG"
                                    .Item(1, j).Value = "DTE Pagado al Contado."
                                    bandera2 = False
                                Case Else
                                    .Item(1, j).Value = "Error de Servicio"
                                    bandera2 = True
                                    'Label24.Text = Label24.Text + 1
                            End Select

                            If bandera2 = True Then
                                Call notengodatos2()   'antes notengodatos2
                            End If

                        Else
                            .Rows.Add()
                            .Item(0, j).Value = midte
                            If b = "DTE No Recibido" Then
                                .Item(1, j).Value = b
                                agrega = 1
                            Else
                                .Item(1, j).Value = b
                            End If

                            ' .Item(2, j).Value = "REGISTRADO" 'si procesa es porque esta en sist vtas

                            If agrega = 1 Then
                                'agrega a la grilla2
                                Call notengodatos2() 'antes notengodatos2
                            End If

                            Call valida_aceptacion()
                            Select Case valret
                                Case "RCD"
                                    .Item(1, j).Value = "Reclamo al contenido del documento."
                                    bandera2 = True
                                    Label24.Text = Label24.Text + 1
                                Case "RFP"
                                    .Item(1, j).Value = "Reclamo por falta parcial de mercaderías."
                                    bandera2 = True
                                    Label24.Text = Label24.Text + 1
                                Case "RFT"
                                    .Item(1, j).Value = "Reclamo por falta total de mercaderías."
                                    bandera2 = True
                                    Label24.Text = Label24.Text + 1
                                Case "SIN ACUSE"
                                    .Item(1, j).Value = "Documento No Presenta eventos de Reclamos o Acuse de Recibo."
                                    bandera2 = False
                                Case ("ACD")
                                    .Item(1, j).Value = "Acepta contenido del documento."
                                    bandera2 = False
                                Case "ERM"
                                    .Item(1, j).Value = "Otorga recibo de mercaderías o servicios."
                                    bandera2 = False
                                Case "NCA"
                                    .Item(1, j).Value = "recepcion de NC de Anulación que Referencian al Documento."
                                    bandera2 = False
                                Case "ENC"
                                    .Item(1, j).Value = "Recepción de NC distinta de Anulación que Referencian al Documento."
                                    bandera2 = True
                                Case "PAG"
                                    .Item(1, j).Value = "DTE Pagado al Contado."
                                    bandera2 = False

                                Case Else
                                    .Item(1, j).Value = "Error de Servicio."
                                    bandera2 = True

                            End Select

                            If bandera2 = True Then
                                Call notengodatos2()  'antes notengodatos2
                            End If
                        End If

                        .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft 'alineado a la izquierda

                        .Font = New Font(.Font, FontStyle.Regular)
                        .DefaultCellStyle.Font = New Font("Calibri", 9)

                        j = j + 1
                        agrega = 0
                        .ClearSelection()
                        .CurrentCell = .Rows(.RowCount - 2).Cells(0)
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        midte = midte + 1

                        contador = Val(contador + 1)
                        contador = contador.ToString
                        grilla.Refresh()
                        Label15.Text = contador
                        'pone el foco a la ultima fila
                        grilla.Rows(grilla.RowCount - 1).Selected = True

                        'pone el numero en la columna inicial
                        If grilla.Rows.Count > 0 Then
                            For r As Integer = 0 To grilla.Rows.Count - 1
                                Me.grilla.Rows(r).HeaderCell.Value = (r + 1).ToString()
                                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                                .RowHeadersWidth = 30
                                grilla.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
                            Next
                        End If

                    End With
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        Finally
            Cursor = Cursors.Default
        End Try

        '/////////////////////////////////////////////////////////////////////////
        '//////////////////////// CONSULTA POR FOLIO
        '////////////////////////


    End Sub

    Public Sub Centrar()
        Dim tamaño As Rectangle = My.Computer.Screen.Bounds
        Dim posicionX As Integer = (tamaño.Width - Me.Width) \ 2
        Dim posicionY As Integer = (tamaño.Height - Me.Height) \ 2
        Me.Location = New Point(posicionX, posicionY)
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_SYSCOMMAND Then
            If m.WParam = New IntPtr(CS_MAXIMIZE) Then
                m.Result = IntPtr.Zero
                Me.Size = Me.MaximumSize
                Centrar()
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub frm_Acuse_Rango_Cint_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label4.Text = frm_menu.Label1.Text
    End Sub

    Private Sub frm_Acuse_Rango_Cint_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_menu.Show()

    End Sub
End Class