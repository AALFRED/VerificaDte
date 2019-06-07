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
Imports System.Data.SqlClient
Imports System.Drawing
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frm_mes_cint_compras
    Private midte As Long
    Private bandera As Boolean
    Private bandera1 As Boolean
    Private mifecha As Date
    Private mifecha2 As Date

    Private s, a, b, c As String
    Private j As Integer
    Private f, g As Integer
    Private contador As Integer = 0
    Public miano As Integer
    Public valor As String
    Public agrega As Integer

    Dim mainStatusBar As New StatusBar()
    Dim statusPanel As New StatusBarPanel()
    Dim datetimePanel As New StatusBarPanel()
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const CS_MAXIMIZE As Integer = &HF030I

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
        Button2.Visible = False
        Button3.Visible = False
        cmd_buscar_NCR.Visible = False
        cmd_buscar_NDB.Visible = False


    End Sub

    Function consulta_estado()
        'consulta FEL COMPRA

        Dim rut1 As Integer = TextBox3.Text 'rut consultante
        Dim dv1 As String = TextBox4.Text 'dv consultante
        Dim rut2 As Integer = TextBox6.Text 'rut receptor
        Dim dv2 As String = TextBox5.Text 'dv receptor
        Dim rut3 As Integer = TextBox8.Text 'rut cia
        Dim dv3 As String = TextBox7.Text 'dv cia
        Dim tipodte As Integer = TextBox12.Text 'tipo dte
        Dim token As String = TextBox2.Text 'token

        Dim nrodte As Integer = TextBox9.Text 'nro dte
        Dim fechadte As String = TextBox10.Text 'fecha emision dte
        Dim montodte As Integer = TextBox11.Text 'monto dte

        Dim lugar As Boolean
        Dim jws As New estadoDTE.QueryEstDteService
        Dim resul = jws.getEstDte(rut1, dv1, rut3, dv3, rut2, dv2, tipodte, nrodte, fechadte, montodte, token)

        '//////////////////////////////////////////////////////////
        'CONSULTA EL ESTADO
        Try
            lugar = False

            'MsgBox(resul)
            'prueba
            Dim xmlresultado As New XmlDocument
            xmlresultado.LoadXml(resul)
            Dim leeresul = New XmlNodeReader(xmlresultado)
            leeresul.readtofollowing("GLOSA_ESTADO")
            'MsgBox(leeresul.READELEMENTCONTENTASSTRING())
            'fin prueba
            TextBox14.Text = resul

            Dim leeresul2 = New XmlNodeReader(xmlresultado)
            leeresul2.readtofollowing("ESTADO")
            s = leeresul2.READELEMENTCONTENTASSTRING()

            Dim leeresul1 = New XmlNodeReader(xmlresultado)
            leeresul1.readtofollowing("GLOSA_ESTADO")
            b = leeresul1.READELEMENTCONTENTASSTRING

            Dim leeresul3 = New XmlNodeReader(xmlresultado)
            leeresul3.readtofollowing("ERR_CODE")
            a = leeresul3.READELEMENTCONTENTASSTRING()

            Dim leeresul4 = New XmlNodeReader(xmlresultado)
            leeresul4.readtofollowing("GLOSA_ERR")
            c = leeresul4.READELEMENTCONTENTASSTRING()

            'Label11.Text = s 'codigo estado
            'Label13.Text = b 'glosa estado
            'Label15.Text = a 'cod error
            'Label17.Text = c 'glosa error

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

    Private Sub frm_mes_cint_compras_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cbo_mes.Text = Date.Now.Month.ToString
        cbo_mes.Text = Format(Now, "MMMM")
    End Sub

    Private Sub frm_mes_cint_compras_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_menu.Show()
    End Sub
    Private Sub frm_mes_cint_compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'theScreenBounds = Screen.GetBounds(Screen.PrimaryScreen.Bounds)

        ' x = theScreenBounds.Width
        ' y = theScreenBounds.Height
        ' classResize.ResizeForm(Me, x, y)

        Timer1.Start()
        creasemilla()
        creatoken()
        TextBox3.Text = "67067231" 'rut consultante
        TextBox4.Text = "1" 'dv consultante
        TextBox6.Text = "96689970" 'rut receptor
        TextBox5.Text = "0" 'dv receptor

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

        CheckBox1.Visible = False
        CheckBox2.Visible = False
        Label19.Visible = False 'REVISANDO...
        Label21.Visible = False 'FEL


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
        CreateDynamicStatusBar()

        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label15.Text = ""

        TextBox12.Text = "33"

        grilla.RowCount = 2
        grilla2.RowCount = 2
        cmd_expexcel.Enabled = False

        CreateDynamicStatusBar()
        'Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.BackColor = System.Drawing.Color.Azure
        ' Me.ClientSize = New System.Drawing.Size(999, 700)
        ' Me.MaximumSize = New System.Drawing.Size(999, 700)
        ' Me.MinimumSize = New System.Drawing.Size(800, 500)
        ' Me.Centrar()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        '//////////////////////////////////////////////
        'BUSCA FACTURAS de COMPRA
        miano = Year(Now)
        'CONEXION A MYSQL
        Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")
        'define variables de conexion
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader
        Dim midata As New DataTable
   
        Try
            System.Windows.Forms.Application.DoEvents()
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Label21.Visible = True
            Label21.Text = "ESPERE...CARGANDO DATOS"
            com.Connection = conn
            conn.Open()
            valor = Label14.Text
            'INICIO
            Dim cmd = New MySqlDataAdapter("SELECT asoc3,provparte, MAEPROV.nomprov,totalparte,fechafacp,nroparte,fechparte FROM PARTES INNER JOIN MAEPROV ON Ltrim(rtrim(PARTES.provparte)) = Ltrim(rtrim(MAEPROV.rutprov)) WHERE month(fechafacp) = '" & Label14.Text & "' group by nroparte,fechparte,provparte,totalparte, fechafacp, asoc3, nomprov order by asoc3 ASC", conn)
            Dim ds As New Data.DataSet
            cmd.Fill(ds)
            grilla.DataSource = ds.Tables(0)
            cmd.dispose()
            rs = Nothing
            conn.Close()

            grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            grilla.Font = New Font(grilla.Font, FontStyle.Regular)
            grilla.DefaultCellStyle.Font = New Font("Calibri", 9)
            '/////////////////////////////////////////////////
            'FINAL
            Cursor = System.Windows.Forms.Cursors.Default
            Label21.Visible = False
            Label21.Text = ""
            Button1.Enabled = True
            Button1.Focus()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
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


    Private Sub grilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grilla.CellFormatting
        'Dim row As DataGridViewRow = grilla.Rows(e.RowIndex)
        'Dim cell As DataGridViewCell

        'If grilla2.Columns(0).Name = "EstadoSII" Then
        'cell = grilla.Rows(0).Cells("Estado SII")

        'If CStr(cell.Value) = "DOK" Then
        ' row.DefaultCellStyle.BackColor = Color.White
        ' row.DefaultCellStyle.ForeColor = Color.Green
        ' End If

        'End If

    End Sub

    Private Sub cmd_expexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_expexcel.Click
        Call GridAExcel(grilla2)
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

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.Close()
        frm_menu.Show()
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

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'REVISA FACTURAS

        Dim cadena As String
        agrega = 0
        Try
            Label19.Visible = True 'REVISANDO....
            Label21.Visible = True 'FEL
            Label21.Text = "FACTURAS DE COMPRA"

            'For i = midte To DataGridViewRow In grilla.Rows
            'declaramos las variables que queremos que contengan los valores de la columna

            For Each row As DataGridViewRow In Me.grilla.Rows
                'obtenemos el valor de la columna en la variable declarada
                valor = row.Cells(1).Value 'donde (0) es la columna a recorrer
                'MsgBox(valor) 'se mostrara un mensaje con el valor de cada una de las columnas

                cadena = LTrim(RTrim(CStr(row.Cells(2).Value)))

                a = cadena.Substring(0, 8) 'saca el primer caracter
                s = cadena.Substring(9, 1) 'saca el ultimo caracter
                TextBox8.Text = a
                TextBox7.Text = s
                TextBox11.Text = CStr(row.Cells(4).Value) 'total parte
                TextBox10.Text = CStr(row.Cells(5).Value) 'fecha fact
                TextBox10.Text = Replace(TextBox10.Text, "-", "")
                TextBox10.Text = TextBox10.Text
                TextBox9.Text = CStr(row.Cells(1).Value) 'nro de dte

                Call consulta_estado()

                System.Windows.Forms.Application.DoEvents()
                Cursor = Cursors.waitCursor

                '///////////////////////////////////////////
                'INCREMENTA EL LISTADO
                With grilla2
                    If j = 0 Then
                        .Rows.Add()
                        .Item(0, j).Value = s 'codigo estado
                        .Item(1, j).Value = b 'glosa estado
                        .Item(2, j).Value = a 'cod error
                        .Item(3, j).Value = c 'glosa error
                        .Item(4, j).Value = valor

                    Else
                        .Rows.Add()
                        .Item(0, j).Value = s 'codigo estado
                        .Item(1, j).Value = b 'glosa estado
                        .Item(2, j).Value = a 'cod error
                        .Item(3, j).Value = c 'glosa error
                        .Item(4, j).Value = valor

                    End If
                    .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Font = New Font(.Font, FontStyle.Regular)
                    .DefaultCellStyle.Font = New Font("Calibri", 9)

                    j = j + 1
                    agrega = 0
                    .ClearSelection()
                    .CurrentCell = .Rows(.RowCount - 2).Cells(0)
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    contador = Val(contador + 1)
                    contador = contador.ToString

                    grilla2.Refresh()
                    Label15.Text = contador

                    'pone el numero en la columna inicial
                    If grilla2.Rows.Count > 0 Then
                        For r As Integer = 0 To grilla2.Rows.Count - 1
                            Me.grilla.Rows(r).HeaderCell.Value = (r + 1).ToString()
                            .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            .RowHeadersWidth = 60
                        Next
                    End If
                End With
                'End If
                'End If

            Next
            Cursor = Cursors.Default
            Label19.Visible = False 'REVISANDO....
            Label21.Visible = False 'FEL
            cmd_expexcel.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class