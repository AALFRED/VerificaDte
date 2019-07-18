'Imports consumiendo.referenciaws
Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Security.Cryptography
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.Drawing



Public Class frm_anos_dte_mes

    Private midte As Long
    Private bandera As Boolean
    Private bandera1 As Boolean
    Private mifecha As Date
    Private mifecha2 As Date
    Private s, a, b As String
    Private j As Integer
    Private f, g As Integer
    Private contador As Integer = 0
    Public mireten As String
    Public mireten2 As String
    Public mireten3 As String
    Public valor As String
    Dim valret As String


    Dim mainStatusBar As New StatusBar()
    Dim statusPanel As New StatusBarPanel()
    Dim datetimePanel As New StatusBarPanel()
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const CS_MAXIMIZE As Integer = &HF030I
    Public miano As Integer

    Dim doc As New XmlTextWriter(System.AppDomain.CurrentDomain.BaseDirectory() + "Token.xml", Encoding.UTF8)
    Dim docserializado = System.AppDomain.CurrentDomain.BaseDirectory() + "Tokenserial.xml"
    Dim docxml = System.AppDomain.CurrentDomain.BaseDirectory() + "Token.xml"
    '///////////////////////////////////////////////////////////////////
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnSring As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    Public Shared Function SeleccionarCertificado() As X509Certificate2
        '        Dim store As New X509Store(StoreLocation.LocalMachine)
        Dim store As New X509Store(StoreLocation.CurrentUser)
        store.Open(OpenFlags.ReadOnly)

        '/////
        'LEE archivo texto
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\validacion\verificadte\cert01.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        ' & stringReader)
        Try
            Dim certSeleccionado As X509Certificate2 = Nothing
            For Each cert As X509Certificate2 In store.Certificates
                If cert.HasPrivateKey Then
                    'If certSeleccionado = Nothing Then
                    'tomaremos el primero de ellos para este ejemplo
                    'If Trim(cert.FriendlyName) = "FRANKLIN" Then
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
    Sub limpia()
        'TextBox1.Text = ""
        'TextBox2.Text = ""
        TextBox3.Text = 0
        'TextBox4.Text = ""
        'TextBox5.Text = ""
        'TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        'TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        Label11.Text = ""
        Label13.Text = ""
        Label26.Text = "0"
        Button2.Visible = False
        Button3.Visible = False
        cmd_buscar_NCR.Visible = False
        cmd_buscar_NDB.Visible = False


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
            Request.Headers.Add("SOAPAction", "listarEventosHistDoc")
            Request.Headers.Add("cookie", "TOKEN=" & TextBox2.Text)

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

            Dim xmlresultado As New XmlDocument
            xmlresultado.LoadXml(SD2Request)
            Dim leeresul = New XmlNodeReader(xmlresultado)
            leeresul.readtofollowing("codResp")
            s = (leeresul.READELEMENTCONTENTASSTRING())
            'MsgBox(s)  'CODIGO RESPUESTA

            Select Case s
                Case "16"
                    valret = "SIN ACUSE"

                Case "15"
                    Dim leeresul3 = New XmlNodeReader(xmlresultado)
                    Dim valida As String
                    leeresul3.readtofollowing("codEvento")
                    'MsgBox(leeresul3.READELEMENTCONTENTASSTRING)
                    valida = leeresul3.READELEMENTCONTENTASSTRING 'CODIGO EVENTO
                    valret = valida
                    ' MsgBox(valret)

            End Select

        Catch ex As WebException
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub busca_xml()
        Dim stArch As String
        Dim defecto As String
        Dim ruta As String = ""
        'MsgBox(midte)
        defecto = TextBox12.Text & "_"
        'defecto = "DOC_INT_T33_N"
        stArch = ("\\192.168.1.250\SistemaERP\FAE_BSOFT02\02\dte_respaldo\")


        defecto = defecto & midte & ".xml"
        ruta = stArch & defecto
        If File.Exists(ruta) Then
            'MsgBox("existe archivo XML")
            bandera = True

        Else
            'MsgBox("no existe XML")
            bandera = False
        End If

    End Sub
    Sub busca_pdf()
        Dim stArch As String
        Dim defecto As String
        Dim ruta As String = ""
        'MsgBox(midte)
        defecto = TextBox12.Text & "-"
        'stArch = ("\\192.168.1.250\SistemaERP\FAE_BSOFT02\02\pdf\")
        'stArch = ("\\192.168.1.250\SistemaERP\FAE_BSOFT02\02\pdf\")
        stArch = ("\\192.168.1.250\EmpDte\CINTEGRAL\PDF\")
        defecto = defecto & midte & ".pdf"
        ruta = stArch & defecto
        If File.Exists(ruta) Then
            'MsgBox("existe archivo XML")
            bandera1 = True

        Else
            'MsgBox("no existe XML")
            bandera1 = False
        End If
    End Sub
    Function consulta_estado()
        '//////////////////////////////////////////////////////////
        'CONSULTA EL ESTADO
        Dim rut1 As Integer = TextBox3.Text
        Dim dv1 As String = TextBox4.Text
        Dim rut2 As Integer = TextBox6.Text
        Dim dv2 As String = TextBox5.Text
        Dim rut3 As Integer = TextBox8.Text
        Dim dv3 As String = TextBox7.Text
        Dim tipodte As Integer = TextBox12.Text
        Dim nrodte As Integer = midte
        Dim fechadte As String = TextBox10.Text
        Dim montodte As Integer = TextBox11.Text
        Dim token As String = TextBox2.Text
        Dim jws As New estadoDTE.QueryEstDteService
        Dim lugar As Boolean

        Try
            lugar = False
            Dim resul = jws.getEstDte(rut1, dv1, rut2, dv2, rut3, dv3, tipodte, nrodte, fechadte, montodte, token)

            TextBox14.Text = resul
            'MsgBox(resul)
            'prueba
            Dim xmlresultado As New XmlDocument
            xmlresultado.LoadXml(resul)
            Dim leeresul = New XmlNodeReader(xmlresultado)
            leeresul.readtofollowing("GLOSA_ESTADO")
            'MsgBox(leeresul.READELEMENTCONTENTASSTRING())
            b = leeresul.READELEMENTCONTENTASSTRING()
            'MsgBox(b)

            'DELAY
            System.Threading.Thread.Sleep(1000) '1 segundo
            'fin prueba


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en respuesta del Servicio")
            lugar = True
        Finally
        End Try
        Return lugar
    End Function

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
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

                Dim rutaorigen As String = "C:\validacion\verificadte\bin\Debug\Token.xml"
                Dim RutaDestinoRecibo As String = "C:\validacion\verificadte\bin\Debug\Token1.xml"
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
        End Try

    End Sub

    Private Sub frm_anos_dte_mes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'cbo_mes.Text = Date.Now.Month.ToString
        ' cbo_mes.Text = Format(Now, "MMMM")
    End Sub

    Private Sub frm_anos_dte_mes_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_menu.Show()
    End Sub

    Private Sub frm_anos_dte_mes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        theScreenBounds = Screen.GetBounds(Screen.PrimaryScreen.Bounds)

        x = theScreenBounds.Width
        y = theScreenBounds.Height
        classResize.ResizeForm(Me, x, y)

        Timer1.Start()
        creasemilla()
        creatoken()
        TextBox3.Text = "67067231"
        TextBox4.Text = "1"
        TextBox6.Text = "96689970"
        TextBox5.Text = "0"
        Label24.Visible = False
        Label26.Text = "0" 'contador de documentos erroneos

        Label11.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label3.Visible = False
        Label4.Visible = False
        Label14.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label15.Text = ""
        Label16.Text = ""

        Label19.Visible = False 'REVISANDO...
        Label20.Visible = False 'NCR
        Label21.Visible = False 'FEL
        Label22.Visible = False 'NDB

        cmd_buscar.Enabled = False
        cmd_buscar_NCR.Visible = False
        cmd_buscar_NDB.Visible = False
        Button2.Visible = False 'NCR
        Button3.Visible = False 'NDB
        Button1.Enabled = False 'consulta dte

        cbo_mes.Text = ""
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False

        cbo_ano.Text = Date.Now.Year
        cbo_ano.Items.Add("2014")
        cbo_ano.Items.Add("2015")
        cbo_ano.Items.Add("2016")
        cbo_ano.Items.Add("2017")
        cbo_ano.Items.Add("2018")
        cbo_ano.Items.Add("2019")
        cbo_ano.Items.Add("2020")
        cbo_ano.Items.Add("2021")
        cbo_ano.Items.Add("2022")
        cbo_ano.Items.Add("2023")


        cbo_mes.Items.Add("ENERO")
        cbo_mes.Items.Add("FEBRERO")
        cbo_mes.Items.Add("MARZO")
        cbo_mes.Items.Add("ABRIL")
        cbo_mes.Items.Add("MAYO")
        cbo_mes.Items.Add("JUNIO")
        cbo_mes.Items.Add("JULIO")
        cbo_mes.Items.Add("AGOSTO")
        cbo_mes.Items.Add("SEPTIEMBRE")
        cbo_mes.Items.Add("OCTUBRE")
        cbo_mes.Items.Add("NOVIEMBRE")
        cbo_mes.Items.Add("DICIEMBRE")

        grilla.RowCount = 2

        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label15.Text = ""
        Label16.Text = ""
        miano = CInt(cbo_ano.SelectedIndex.ToString)

        grilla.RowCount = 2
        grilla2.RowCount = 2
        cmd_expexcel.Enabled = False

        CreateDynamicStatusBar()
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(999, 700)
        Me.MaximumSize = New System.Drawing.Size(999, 700)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Centrar()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox13.Text = DateTime.Now.ToString
        creasemilla()
        creatoken()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        creasemilla()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        creatoken()
    End Sub

    Private Sub cmd_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_limpiar.Click
        Call limpia()
        grilla.Rows.Clear()
        grilla2.Rows.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False

        Label19.Visible = False 'REVISANDO...
        Label20.Visible = False 'NCR
        Label21.Visible = False 'FEL
        Label22.Visible = False 'NDB
        Label26.Text = "0"

        cmd_buscar.Enabled = False
        cmd_buscar.Visible = True
        cmd_buscar_NCR.Visible = False
        cmd_buscar_NDB.Visible = False

        Button2.Visible = False 'NCR
        Button3.Visible = False 'NDB
        Button1.Enabled = False 'consulta dte
        Button1.Visible = True
        cbo_mes.Focus()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        'BUSCA FACTURAS
        'define la conexion a la base de datos
        'Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database= '" & Label24.Text & "';User Id=sa;Password=Xtreme_1720")
        'define variables de conexion
        'Dim sql As String
        'Dim com As New SqlCommand
        'Dim rs As SqlDataReader

        miano = cbo_ano.Text

        'CONEXION A MYSQL
        Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=global" & miano & "")
        'define variables de conexion
        Dim sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader
        Try
            com.Connection = conn
            If conn.State = 1 Then conn.Close()
            conn.Open()
            valor = Label14.Text

            sql = "SELECT min(substr(tipocon,4,13))as inicio FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'FEL%'"
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
                Label11.Text = Replace(Label11.Text, "00000", "")
            End If

            com.Connection = conn
            If conn.State = 1 Then conn.Close()
            conn.Open()

            sql = "SELECT max(substr(tipocon,4,13))as final FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'FEL%'"
            com = New MySqlCommand(sql, conn)
            rs = com.ExecuteReader()
            rs.Read()
            Label13.Text = CStr(rs("final"))
            rs.Close()
            Label13.Text = Replace(Label13.Text, "00000", "")
            'por si pasa el inicio vacio
            If Label11.Text = "" Then Label1.Text = Label13.Text

            'saca el calculo
            Label16.Text = Val(Label13.Text - Label11.Text) + 1
            conn.Close()
            Button1.Enabled = True 'consulta dte
            Button1.Focus()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cbo_mes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_mes.SelectedIndexChanged
        Select Case cbo_mes.Text
            Case "ENERO"
                Label14.Text = "1"
            Case "FEBRERO"
                Label14.Text = "2"
            Case "MARZO"
                Label14.Text = "3"
            Case "ABRIL"
                Label14.Text = "4"
            Case "MAYO"
                Label14.Text = "5"
            Case "JUNIO"
                Label14.Text = "6"
            Case "JULIO"
                Label14.Text = "7"
            Case "AGOSTO"
                Label14.Text = "8"
            Case "SEPTIEMBRE"
                Label14.Text = "9"
            Case "OCTUBRE"
                Label14.Text = "10"
            Case "NOVIEMBRE"
                Label14.Text = "11"
            Case "DICIEMBRE"
                Label14.Text = "12"
        End Select
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'BUSCA FACTURAS
        Dim i As Long
        'Dim midte As Long = Label11.Text
        'define la conexion a la base de datos
        'Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database= '" & Label24.Text & "';User Id=sa;Password=Xtreme_1720")

        'CONEXION A MYSQL
        Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")
        'define variables de conexion
        Dim sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader
        Dim cadena As String
        Dim agrega As Integer

        Try
            'Dim cadena1 As String
            com.Connection = conn
            midte = Label11.Text
            agrega = 0
            Label19.Visible = True 'REVISANDO....
            Label21.Visible = True 'FEL

            For i = midte To Label13.Text

                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                If midte >= 1000 And midte < 9999 Then
                    mireten = "FEL000000"
                Else
                    If midte >= 10000 And midte < 99999 Then
                        mireten = "FEL00000"
                    Else
                        If midte >= 100000 And midte < 999999 Then
                            mireten = "FEL0000"
                        Else
                            If midte >= 1000000 And midte < 9999999 Then
                                mireten = "FEL000"
                            End If
                        End If
                    End If
                End If

                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                valor = mireten & midte
                sql = "SELECT rutcon, totalcon, fechacon FROM VENTA WHERE tipocon = '" & valor & "'"
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

                        Call consulta_estado()
                        rs.Close()
                        'MsgBox(midte)
                        frm_menu.Hide()
                        System.Windows.Forms.Application.DoEvents()

                        'Cursor = Cursors.waitCursor
                        Cursor = Cursors.WaitCursor

                        '///////////////////////////////////////////
                        'INCREMENTA EL LISTADO
                        With grilla
                            If j = 0 Then
                                .Item(0, j).Value = midte
                                If b = "DTE No Recibido" Then
                                    .Item(1, j).Value = b
                                    agrega = 1
                                    Label26.Text = CInt(Label26.Text) + 1
                                Else
                                    .Item(1, j).Value = b
                                End If

                                .Item(2, j).Value = "REGISTRADO"

                                Call busca_xml()
                                If bandera = True Then
                                    .Item(3, j).Value = "EXISTE"
                                Else
                                    .Item(3, j).Value = "NO EXISTE"
                                    .Item(3, j).Value = "NO REVISADO"
                                    agrega = 1
                                    '      Call notengodatos2()
                                End If

                                Call busca_pdf()
                                If bandera1 = True Then
                                    .Item(4, j).Value = "EXISTE"
                                Else
                                    .Item(4, j).Value = "NO EXISTE"
                                    .Item(4, j).Value = "NO REVISADO"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If
                                If agrega = 1 Then
                                    'agrega a la grilla2
                                    ' Call notengodatos2()
                                End If
                            Else
                                .Rows.Add()
                                .Item(0, j).Value = midte
                                If b = "DTE No Recibido" Then
                                    .Item(1, j).Value = b
                                    agrega = 1
                                    Label26.Text = CInt(Label26.Text) + 1
                                Else
                                    .Item(1, j).Value = b
                                End If

                                .Item(2, j).Value = "REGISTRADO" 'si procesa es porque esta en sist vtas

                                Call busca_xml()
                                If bandera = True Then
                                    .Item(3, j).Value = "EXISTE"
                                Else
                                    .Item(3, j).Value = "NO-EXISTE"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If

                                Call busca_pdf()
                                If bandera1 = True Then
                                    .Item(4, j).Value = "EXISTE"
                                Else
                                    .Item(4, j).Value = "NO-EXISTE"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If
                                If agrega = 1 Then
                                    'agrega a la grilla2
                                    Call notengodatos2()
                                End If
                            End If
                            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
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

                            'pone el numero en la columna inicial
                            If grilla.Rows.Count > 0 Then
                                For r As Integer = 0 To grilla.Rows.Count - 1
                                    Me.grilla.Rows(r).HeaderCell.Value = (r + 1).ToString()
                                    .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet
                                    .RowHeadersWidth = 60
                                Next
                            End If
                        End With
                    End If
                End If
                If midte >= 1000 And midte < 9999 Then
                    mireten = "FEL000000"
                Else
                    If midte >= 10000 And midte < 99999 Then
                        mireten = "FEL00000"
                    Else
                        If midte >= 100000 And midte < 999999 Then
                            mireten = "FEL0000"
                        Else
                            If midte >= 1000000 And midte < 9999999 Then
                                mireten = "FEL000"
                            End If
                        End If
                    End If
                End If
            Next i
            'Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor
            Label19.Visible = False 'REVISANDO....
            Label21.Visible = False 'FEL
            cmd_expexcel.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub
    Sub notengodatos()
        Try
            '///////////////////////////////////////////
            'CARGA A LA GRILLA2 CUANDO NO EXISTE EL DOCUMENTO Y EL FOLIO NO FUE UTILIZADO
            'INCREMENTA EL LISTADO
            With grilla2
                If g = 0 Then
                    .Item(0, g).Value = midte
                    .Item(1, g).Value = "NO RECIBIDO"
                    Label26.Text = CInt(Label26.Text) + 1

                    .Item(2, g).Value = "NO REGISTRADO"

                    ' Call busca_xml()
                    If bandera = True Then
                        ' .Item(3, g).Value = "EXISTE"
                    Else
                        .Item(3, g).Value = "NO EXISTE"

                    End If
                    'Call busca_pdf()
                    If bandera1 = True Then
                        '  .Item(4, g).Value = "EXISTE"
                    Else
                        .Item(4, g).Value = "NO EXISTE"

                    End If
                Else
                    .Rows.Add()
                    .Item(0, g).Value = midte
                    .Item(1, g).Value = "NO RECIBIDO"
                    Label26.Text = CInt(Label26.Text) + 1

                    .Item(2, g).Value = "NO-REGISTRADO"

                    'Call busca_xml()
                    If bandera = True Then
                        ' .Item(3, g).Value = "EXISTE"
                    Else
                        .Item(3, g).Value = "NO-EXISTE"

                    End If
                    'Call busca_pdf()
                    If bandera1 = True Then
                        '  .Item(4, g).Value = "EXISTE"
                    Else
                        .Item(4, g).Value = "NO-EXISTE"

                    End If
                End If

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
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
            'pone el numero en la columna inicial
            If grilla2.Rows.Count > 0 Then
                For r As Integer = 0 To grilla.Rows.Count - 1
                    Me.grilla.Rows(r).HeaderCell.Value = (r + 1).ToString()
                    grilla2.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet
                    grilla2.RowHeadersWidth = 60
                Next
            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub notengodatos2()
        Try
            '///////////////////////////////////////////
            'CARGA EL DOCUMENTO A LA GRILLA2 CUANDO TIENE UN PROBLEMA
            'INCREMENTA EL LISTADO

            With grilla2
                If f = 0 Then
                    .Item(0, f).Value = grilla.Item(0, j).Value 'dte
                    .Item(1, f).Value = grilla.Item(1, j).Value 'recibido sii
                    .Item(2, f).Value = grilla.Item(2, j).Value 'sta vtas
                    .Item(3, f).Value = grilla.Item(3, j).Value 'xml
                    .Item(4, f).Value = grilla.Item(4, j).Value 'pdf

                Else
                    .Rows.Add()
                    .Item(0, f).Value = grilla.Item(0, j).Value 'dte
                    .Item(1, f).Value = grilla.Item(1, j).Value 'recibido sii
                    .Item(2, f).Value = grilla.Item(2, j).Value 'sta vtas
                    .Item(3, f).Value = grilla.Item(3, j).Value 'xml
                    .Item(4, f).Value = grilla.Item(4, j).Value 'pdf

                End If

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                .Font = New Font(.Font, FontStyle.Regular)
                .DefaultCellStyle.Font = New Font("Calibri", 9)

                .ClearSelection()
                .CurrentCell = .Rows(.RowCount - 2).Cells(0)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Refresh()
                f = f + 1
            End With
            System.Windows.Forms.Application.DoEvents()

            If grilla2.Rows.Count > 0 Then
                For r As Integer = 0 To grilla2.Rows.Count - 1
                    Me.grilla2.Rows(r).HeaderCell.Value = (r + 1).ToString()
                    grilla2.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet
                    grilla2.RowHeadersWidth = 60
                Next
            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.Close()
        frm_menu.Show()
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

    Private Sub cmd_expexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_expexcel.Click
        Call GridAExcel(grilla2)
    End Sub
    Private Sub grilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grilla.CellFormatting
        Dim row As DataGridViewRow = grilla.Rows(e.RowIndex)
        Dim cell As DataGridViewCell
        If grilla.Columns(e.ColumnIndex).Name <> "ESTADOCOL" Then
            cell = grilla.Rows(e.RowIndex).Cells("ESTADOCOL")

            If CStr(cell.Value) = "DTE No Recibido" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.Yellow
            End If

        End If
        If grilla.Columns(e.ColumnIndex).Name <> "Sma_vta" Then
            cell = grilla.Rows(e.RowIndex).Cells("Sma_vta")

            If CStr(cell.Value) = "NO REGISTRADO" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.Yellow
            End If

        End If
        If grilla.Columns(e.ColumnIndex).Name <> "XML" Then
            cell = (grilla.Rows(e.RowIndex).Cells("XML"))

            If CStr(cell.Value) = "NO EXISTE" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.Yellow
            End If

        End If
        If grilla.Columns(e.ColumnIndex).Name <> "PDF" Then
            cell = grilla.Rows(e.RowIndex).Cells("PDF")

            If CStr(cell.Value) = "NO EXISTE" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.Yellow
            End If

        End If
    End Sub

    Private Sub grilla2_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grilla2.CellFormatting
        Dim row As DataGridViewRow = grilla2.Rows(e.RowIndex)
        Dim cell As DataGridViewCell
        If grilla2.Columns(e.ColumnIndex).Name <> "estadocol_2" Then
            cell = grilla2.Rows(e.RowIndex).Cells("estadocol_2")

            If CStr(cell.Value) = "DTE No Recibido" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.Yellow
            End If

        End If
        If grilla2.Columns(e.ColumnIndex).Name <> "Smavta_2" Then
            cell = grilla2.Rows(e.RowIndex).Cells("Smavta_2")

            If CStr(cell.Value) = "NO REGISTRADO" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.Yellow
            End If

        End If
        If grilla2.Columns(e.ColumnIndex).Name <> "colxml_2" Then
            cell = (grilla2.Rows(e.RowIndex).Cells("colxml_2"))

            If CStr(cell.Value) = "NO EXISTE" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.Yellow
            End If

        End If
        If grilla2.Columns(e.ColumnIndex).Name <> "colpdf_2" Then
            cell = grilla2.Rows(e.RowIndex).Cells("colpdf_2")

            If CStr(cell.Value) = "NO EXISTE" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.Yellow
            End If

        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        'para buscar facturas
        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            cmd_buscar.Visible = True 'busca FEL
            cmd_buscar.Enabled = True
            cmd_buscar_NCR.Visible = False
            cmd_buscar_NDB.Visible = False
            Button1.Visible = True 'para FEL
            Button2.Visible = False 'para NCR
            Button3.Visible = False 'para NDB
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            cmd_buscar.Visible = True
            cmd_buscar.Enabled = False
            Button1.Visible = True
            Button2.Visible = False
            Button3.Visible = False
            Button1.Enabled = False
            cmd_buscar_NCR.Visible = False
            cmd_buscar_NDB.Visible = False
            cbo_mes.Focus()


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'para buscar NCR
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            cmd_buscar.Visible = False 'busca FEL
            cmd_buscar.Enabled = False
            cmd_buscar_NCR.Visible = True
            cmd_buscar_NCR.Enabled = True
            cmd_buscar_NDB.Visible = False
            Button1.Visible = False 'para FEL
            Button2.Visible = True 'para NCR
            Button2.Enabled = False
            Button3.Visible = False 'para NDB
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            cmd_buscar.Visible = True
            cmd_buscar.Enabled = False
            Button1.Visible = True
            Button2.Visible = False
            Button3.Visible = False
            Button1.Enabled = False
            cmd_buscar_NCR.Visible = False
            cmd_buscar_NDB.Visible = False
            cbo_mes.Focus()


        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        'para buscar NDB
        If CheckBox2.Checked = True Then
            CheckBox3.Checked = False
            CheckBox1.Checked = False
            cmd_buscar.Visible = False 'busca FEL
            cmd_buscar_NCR.Visible = False
            cmd_buscar_NDB.Visible = True
            cmd_buscar_NDB.Enabled = True
            Button1.Visible = False 'para FEL
            Button2.Visible = False 'para NCR
            Button3.Visible = True 'para NDB
            Button3.Enabled = False
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            cmd_buscar.Visible = True
            cmd_buscar.Enabled = False
            Button1.Visible = True
            Button2.Visible = False
            Button3.Visible = False
            Button1.Enabled = False
            cmd_buscar_NCR.Visible = False
            cmd_buscar_NDB.Visible = False
            cbo_mes.Focus()


        End If
    End Sub
    Private Sub cmd_buscar_NCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar_NCR.Click
        'BUSCA NCR
        'define la conexion a la base de datos
        Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database= '" & Label24.Text & "';User Id=sa;Password=Xtreme_1720")

        'define variables de conexion
        Dim sql As String
        Dim com As New SqlCommand
        Dim rs As SqlDataReader
        Dim valor As String
        Try
            com.Connection = conn
            conn.Open()

            valor = Label14.Text

            'sql = "SELECT min(tipocon)as inicio FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'NCE%' "
            sql = "SELECT min(dbo.val(dbo.substr(tipocon,4,13)))as inicio FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'NCE%'"
            com = New SqlCommand(sql, conn)
            rs = com.ExecuteReader()
            rs.Read()
            Label11.Text = CStr(rs("inicio"))
            rs = Nothing
            com.Dispose()

            'Dim s As String
            's = Label11.Text
            's = Mid(s, 4, 13)
            'Label11.Text = CInt(s)

            com.Connection = conn
            If conn.State = 1 Then conn.Close()
            conn.Open()
            'sql = "SELECT max(tipocon)as final FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'NCE%' "
            sql = "SELECT max(dbo.val(dbo.substr(tipocon,4,13)))as final FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'NCE%'"
            com = New SqlCommand(sql, conn)
            rs = com.ExecuteReader()
            rs.Read()
            Label13.Text = CStr(rs("final"))
            rs.Close()

            's = Label13.Text
            's = Mid(s, 4, 13)
            'Label13.Text = CInt(s)


            Label16.Text = Val(Label13.Text - Label11.Text)
            conn.Close()
            Button2.Enabled = True
            Button2.Focus()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            MsgBox("No se Encontraron Registros para el Criterio de Búsqueda", MsgBoxStyle.Exclamation)
            Button2.Enabled = False
        End Try
    End Sub

    Private Sub cmd_buscar_NDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar_NDB.Click
        'BUSCA NDB
        'define la conexion a la base de datos
        Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database= '" & Label24.Text & "';User Id=sa;Password=Xtreme_1720")

        'define variables de conexion
        Dim sql As String
        Dim com As New SqlCommand
        Dim rs As SqlDataReader
        Dim valor As String
        Try
            com.Connection = conn
            conn.Open()
            valor = Label14.Text
            'sql = "SELECT min(tipocon)as inicio FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'NDE%' "
            sql = "SELECT min(dbo.val(dbo.substr(tipocon,4,13)))as inicio FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'NDE%'"
            com = New SqlCommand(sql, conn)
            rs = com.ExecuteReader()
            rs.Read()
            Label11.Text = CStr(rs("inicio"))
            rs = Nothing
            com.Dispose()

            'Dim s As String
            's = Label11.Text
            's = Mid(s, 4, 13)
            'Label11.Text = CInt(s)

            com.Connection = conn
            If conn.State = 1 Then conn.Close()
            conn.Open()
            'sql = "SELECT max(tipocon)as final FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'NDE%' "
            sql = "SELECT max(dbo.val(dbo.substr(tipocon,4,13)))as final FROM VENTA WHERE month(fechacon) = '" & valor & "' and tipocon like 'NDE%'"
            com = New SqlCommand(sql, conn)
            rs = com.ExecuteReader()
            rs.Read()
            Label13.Text = CStr(rs("final"))
            rs.Close()

            's = Label11.Text
            's = Mid(s, 4, 13)
            'Label13.Text = CInt(s)

            Label16.Text = Val(Label13.Text - Label11.Text)
            conn.Close()
            Button3.Enabled = True
            Button3.Focus()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            MsgBox("No se Encontraron Registros para el Criterio de Búsqueda", MsgBoxStyle.Exclamation)
            Button3.Enabled = False
        End Try
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'BUSCA NCR
        Dim i As Long
        'Dim midte As Long = Label11.Text
        'define la conexion a la base de datos
        Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database= '" & Label24.Text & "';User Id=sa;Password=Xtreme_1720")

        'define variables de conexion
        Dim sql As String
        Dim com As New SqlCommand
        Dim rs As SqlDataReader
        Dim valor As String
        Dim cadena As String
        Dim agrega As Integer

        Try
            'Dim cadena1 As String
            com.Connection = conn
            midte = Label11.Text
            agrega = 0
            Label19.Visible = True 'REVISANDO....
            Label20.Visible = True 'NCR
            For i = midte To Label13.Text

                If midte >= 1000 And midte < 9999 Then
                    mireten = "NCE000000"
                Else
                    If midte >= 10000 And midte < 99999 Then
                        mireten = "NCE00000"
                    Else
                        If midte >= 100000 And midte < 999999 Then
                            mireten = "NCE0000"
                        Else
                            If midte >= 1000000 And midte < 9999999 Then
                                mireten = "NCE000"
                            End If
                        End If
                    End If
                End If


                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                valor = mireten2 & midte
                sql = "SELECT rutcon, totalcon, fechacon FROM VENTA WHERE tipocon = '" & valor & "'"
                com = New SqlCommand(sql, conn)
                rs = com.ExecuteReader()
                If rs.HasRows = False Then
                    Call notengodatos()
                Else
                    If rs.Read() = True Then
                        TextBox12.Text = "61"

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

                        Call consulta_estado()
                        rs.Close()
                        'MsgBox(midte)
                        frm_menu.Hide()
                        System.Windows.Forms.Application.DoEvents()
                        'Cursor.Current = Cursors.WaitCursor
                        Cursor = Cursors.WaitCursor

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

                                .Item(2, j).Value = "REGISTRADO"

                                'Call busca_xml()
                                If bandera = True Then
                                    .Item(3, j).Value = "EXISTE"
                                Else
                                    .Item(3, j).Value = "NO EXISTE"
                                    agrega = 1
                                    '      Call notengodatos2()
                                End If

                                ' Call busca_pdf()
                                If bandera1 = True Then
                                    .Item(4, j).Value = "EXISTE"
                                Else
                                    .Item(4, j).Value = "NO EXISTE"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If
                                If agrega = 1 Then
                                    'agrega a la grilla2
                                    Call notengodatos2()
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

                                .Item(2, j).Value = "REGISTRADO" 'si procesa es porque esta en sist vtas

                                ' Call busca_xml()
                                If bandera = True Then
                                    ' .Item(3, j).Value = "EXISTE"
                                Else
                                    .Item(3, j).Value = "NO EXISTE"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If

                                '  Call busca_pdf()
                                If bandera1 = True Then
                                    ' .Item(4, j).Value = "EXISTE"
                                Else
                                    .Item(4, j).Value = "NO EXISTE"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If
                                If agrega = 1 Then
                                    'agrega a la grilla2
                                    Call notengodatos2()
                                End If
                            End If
                            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
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

                            'pone el numero en la columna inicial
                            If grilla.Rows.Count > 0 Then
                                For r As Integer = 0 To grilla.Rows.Count - 1
                                    Me.grilla.Rows(r).HeaderCell.Value = (r + 1).ToString()
                                    .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    .RowHeadersWidth = 60
                                Next
                            End If
                        End With
                    End If
                End If
                If midte >= 1000 And midte < 9999 Then
                    mireten = "NCE000000"
                Else
                    If midte >= 10000 And midte < 99999 Then
                        mireten = "NCE00000"
                    Else
                        If midte >= 100000 And midte < 999999 Then
                            mireten = "NCE0000"
                        Else
                            If midte >= 1000000 And midte < 9999999 Then
                                mireten = "NCE000"
                            End If
                        End If
                    End If
                End If
            Next i
            'Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor
            Label19.Visible = False 'REVISANDO....
            Label20.Visible = False 'NCR
            cmd_expexcel.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'BUSCA NDE
        Dim i As Long
        'Dim midte As Long = Label11.Text
        'define la conexion a la base de datos
        Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database= '" & Label24.Text & "';User Id=sa;Password=Xtreme_1720")

        'define variables de conexion
        Dim sql As String
        Dim com As New SqlCommand
        Dim rs As SqlDataReader
        Dim valor As String
        Dim cadena As String
        Dim agrega As Integer

        Try
            'Dim cadena1 As String
            com.Connection = conn
            midte = Label11.Text
            agrega = 0
            Label19.Visible = True 'REVISANDO....
            Label22.Visible = True 'NDB

            For i = midte To Label13.Text

                If midte >= 1000 And midte < 9999 Then
                    mireten = "NDE000000"
                Else
                    If midte >= 10000 And midte < 99999 Then
                        mireten = "NDE00000"
                    Else
                        If midte >= 100000 And midte < 999999 Then
                            mireten = "NDE0000"
                        Else
                            If midte >= 1000000 And midte < 9999999 Then
                                mireten = "NDE000"
                            End If
                        End If
                    End If
                End If

                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                valor = mireten3 & midte
                sql = "SELECT rutcon, totalcon, fechacon FROM VENTA WHERE tipocon = '" & valor & "'"
                com = New SqlCommand(sql, conn)
                rs = com.ExecuteReader()
                If rs.HasRows = False Then
                    Call notengodatos()
                Else

                    If rs.Read() = True Then

                        TextBox12.Text = "56"

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

                        Call consulta_estado()
                        rs.Close()
                        'MsgBox(midte)
                        frm_menu.Hide()
                        System.Windows.Forms.Application.DoEvents()
                        'Cursor.Current = Cursors.WaitCursor
                        Cursor = Cursors.WaitCursor

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

                                .Item(2, j).Value = "REGISTRADO"

                                ' Call busca_xml()
                                If bandera = True Then
                                    ' .Item(3, j).Value = "EXISTE"
                                Else
                                    .Item(3, j).Value = "NO EXISTE"
                                    agrega = 1
                                    '      Call notengodatos2()
                                End If

                                '  Call busca_pdf()
                                If bandera1 = True Then
                                    ' .Item(4, j).Value = "EXISTE"
                                Else
                                    .Item(4, j).Value = "NO EXISTE"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If
                                If agrega = 1 Then
                                    'agrega a la grilla2
                                    Call notengodatos2()
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

                                .Item(2, j).Value = "REGISTRADO" 'si procesa es porque esta en sist vtas

                                '   Call busca_xml()
                                If bandera = True Then
                                    ' .Item(3, j).Value = "EXISTE"
                                Else
                                    .Item(3, j).Value = "NO EXISTE"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If

                                '    Call busca_pdf()
                                If bandera1 = True Then
                                    ' .Item(4, j).Value = "EXISTE"
                                Else
                                    .Item(4, j).Value = "NO EXISTE"
                                    agrega = 1
                                    'Call notengodatos2()
                                End If
                                If agrega = 1 Then
                                    'agrega a la grilla2
                                    Call notengodatos2()
                                End If
                            End If
                            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
                            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alineado a la derecha
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

                            'pone el numero en la columna inicial
                            If grilla.Rows.Count > 0 Then
                                For r As Integer = 0 To grilla.Rows.Count - 1
                                    Me.grilla.Rows(r).HeaderCell.Value = (r + 1).ToString()
                                    .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    .RowHeadersWidth = 60
                                Next
                            End If
                        End With
                    End If
                End If
                If midte >= 1000 And midte < 9999 Then
                    mireten = "NDE000000"
                Else
                    If midte >= 10000 And midte < 99999 Then
                        mireten = "NDE00000"
                    Else
                        If midte >= 100000 And midte < 999999 Then
                            mireten = "NDE0000"
                        Else
                            If midte >= 1000000 And midte < 9999999 Then
                                mireten = "NDE000"
                            End If
                        End If
                    End If
                End If
            Next i
            'Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor
            Label19.Visible = False 'REVISANDO....
            Label22.Visible = False 'NDB
            cmd_expexcel.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub cbo_ano_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_ano.SelectedIndexChanged
        Select Case cbo_ano.Text
            Case "2014"
                Label24.Text = "Cintegral2014"
                'mireten = "FEL000000"
                'mireten2 = "NCE000000"
                'mireten3 = "NDE00000000"
            Case "2015"
                Label24.Text = "Cintegral2015"
                'mireten = "FEL000000"
                ' mireten2 = "NCE000000"
                ' mireten3 = "NDE00000000"
            Case "2016"
                Label24.Text = "Cintegral2016"
                'mireten = "FEL00000"
                'mireten2 = "NCE000000"
                'mireten3 = "NDE00000000"
            Case "2017"
                Label24.Text = "Cintegral2017"
                'mireten = "FEL00000"
                'mireten2 = "NCE000000"
                'mireten3 = "NDE00000000"
            Case "2018"
                Label24.Text = "Cintegral2018"
                'mireten = "FEL0000"
            Case "2019"
                Label24.Text = "Cintegral2019"
                'mireten = "FEL0000"
            Case "2020"
                Label24.Text = "Cintegral2020"
                'mireten = "FEL000"
            Case "2021"
                Label24.Text = "Cintegral2021"
                'mireten = "FEL000"
            Case "2022"
                Label24.Text = "Cintegral2022"
                'mireten = "FEL00"
            Case "2023"
                Label24.Text = "Cintegral2023"
                'mireten = "FEL00"
        End Select
    End Sub

End Class