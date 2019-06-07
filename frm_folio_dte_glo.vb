'Imports System.Data
Imports System.IO
Imports System.Xml
Imports System.Security.Cryptography
Imports System.Text
'Imports System
Imports System.Security.Cryptography.X509Certificates
'Imports System.Diagnostics
'Imports System.Object
Imports System.Security.Cryptography.Xml
'Imports System.Security.Cryptography.Xml.SignedXml
'Imports System.Windows.Forms
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frm_folio_dte_glo
    Private s, a, b, c As String
    Private midte As Long
    Dim ano As String
    Public miano As Integer

    Dim doc As New XmlTextWriter(System.AppDomain.CurrentDomain.BaseDirectory() + "Token.xml", Encoding.UTF8)
    Dim docserializado = System.AppDomain.CurrentDomain.BaseDirectory() + "Tokenserial.xml"
    Dim docxml = System.AppDomain.CurrentDomain.BaseDirectory() + "Token.xml"
    '///////////////////////////////////////////////////////////////////
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Public Shared Function SeleccionarCertificado() As X509Certificate2
        '        Dim store As New X509Store(StoreLocation.LocalMachine)
        Dim store As New X509Store(StoreLocation.CurrentUser)
        store.Open(OpenFlags.ReadOnly)

        '/////
        'LEE archivo texto
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Proyectos Vb2017\verificadte\cert02.txt")
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
        'TextBox3.Text = ""
        'TextBox4.Text = ""
        'TextBox5.Text = ""
        'TextBox6.Text = ""
        TextBox7.Text = "" 'dv
        TextBox8.Text = "" 'rut
        TextBox9.Text = "" 'nro dte
        TextBox10.Text = "" 'fecha
        TextBox11.Text = ""
        'TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        Label11.Text = ""
        Label13.Text = ""
        Label15.Text = ""
        Label17.Text = ""

    End Sub
    Public Sub creasemilla()
        Dim jws As New referenciaws.CrSeedService
        Dim resul = jws.getSeed()
        '        MsgBox(resul)
        Dim xmldoc As New XmlDocument
        xmldoc.LoadXml(resul)
        Dim reader = New XmlNodeReader(xmldoc)
        reader.ReadToFollowing("SEMILLA")
        TextBox1.Text = reader.ReadElementContentAsString()
        'MsgBox("semilla creada")
        frm_menu.Hide()

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

                Dim rutaorigen As String = "C:\validacion\verificadte\bin\Debug\Tokenglo.xml"
                Dim RutaDestinoRecibo As String = "C:\validacion\verificadte\bin\Debug\Token1glo.xml"
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
                frm_menu.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Frm_folio_dte_glo_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_menu.Show()

    End Sub

    Private Sub Frm_folio_dte_glo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        theScreenBounds = Screen.GetBounds(Screen.PrimaryScreen.Bounds)

        x = theScreenBounds.Width
        y = theScreenBounds.Height
        classResize.ResizeForm(Me, x, y)

        Timer1.Start()
        creasemilla()
        creatoken()
        TextBox3.Text = "7734036"
        TextBox4.Text = "K"
        TextBox6.Text = "96661420"
        TextBox5.Text = "K"
        Label11.Text = ""
        Label13.Text = ""
        Label15.Text = ""
        Label17.Text = ""
        miano = frm_menu.Mt_Label3.Text

        TextBox15.Visible = False
        TextBox16.Visible = False
        Button1.Visible = False 'NCR
        Button2.Visible = False 'NDB
        Button3.Enabled = False 'FEL
        TextBox9.Enabled = False 'FEL
        TextBox15.Enabled = False 'NCR
        TextBox16.Enabled = False 'NDB

        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox6.Visible = False
        TextBox5.Visible = False
        TextBox13.Visible = False
        Label4.Visible = False
        Label3.Visible = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox14.Visible = False

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim rut1 As Integer = TextBox3.Text
            Dim dv1 As String = TextBox4.Text
            Dim rut2 As Integer = TextBox6.Text
            Dim dv2 As String = TextBox5.Text
            Dim rut3 As Integer = TextBox8.Text
            Dim dv3 As String = TextBox7.Text
            Dim tipodte As Integer = TextBox12.Text
            Dim nrodte As Integer = TextBox9.Text
            Dim fechadte As String = TextBox10.Text
            Dim montodte As Integer = TextBox11.Text
            Dim token As String = TextBox2.Text
            Dim jws As New estadoDTE.QueryEstDteService
            Dim resul = jws.getEstDte(rut1, dv1, rut2, dv2, rut3, dv3, tipodte, nrodte, fechadte, montodte, token)

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

            Dim leeresul3 = New XmlNodeReader(xmlresultado)
            leeresul3.readtofollowing("ERR_CODE")
            a = leeresul3.READELEMENTCONTENTASSTRING()

            Dim leeresul4 = New XmlNodeReader(xmlresultado)
            leeresul4.readtofollowing("GLOSA_ERR")
            c = leeresul4.READELEMENTCONTENTASSTRING()

            'MsgBox(b)
            'MsgBox(s)
            'MsgBox(a)
            'MsgBox(c)
            Label11.Text = s 'codigo estado
            Label13.Text = b 'glosa estado
            Label15.Text = a 'cod error
            Label17.Text = c 'glosa error

            'DELAY
            System.Threading.Thread.Sleep(1000) '1 segundo
            'fin prueba

            'Call consulta_estado()
            frm_menu.Hide()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox13.Text = DateTime.Now.ToString
        creasemilla()
        creatoken()
    End Sub

    Private Sub TextBox9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyDown
        If GetAsyncKeyState(13) Then
            'BUSCA FEL
            'define la conexion a la base de datos
            'Dim conn As New SqlConnection("Server=190.151.5.59\SQL2008;Database=GLOBAL2016;User Id=sa;Password=Rs1399")
            'Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database=GLOBAL" & miano & ";User Id=sa;Password=Xtreme_1720")

            'CONEXION A MYSQL
            Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=global" & miano & "")
            'define variables de conexion
            Dim sql As String
            Dim com As New MySqlCommand
            Dim rs As MySqlDataReader
            Dim valor As String
            Try
                com.Connection = conn
                conn.Open()
                valor = "FEL0000" & TextBox9.Text
                sql = "SELECT rutcon, totalcon, fechacon FROM VENTA WHERE tipocon = '" & valor & "'"
                com = New MySqlCommand(sql, conn)
                com.CommandTimeout = 1500
                rs = com.ExecuteReader()
                rs.Read()
                TextBox12.Text = "33"

                Dim s, a, b As String
                Dim cadena As String = CStr(rs("rutcon"))
                Dim cadena1 As String

                a = cadena.Substring(1, 9) 'saca el primer caracter
                s = cadena.Substring(9, 1) 'saca el ultimo caracter
                a = cadena.Substring(1, 8)
                TextBox8.Text = a
                TextBox7.Text = s

                TextBox1.Text = a
                TextBox11.Text = CStr(rs("totalcon"))
                TextBox10.Text = CStr(rs("fechacon"))

                TextBox10.Text = Replace(TextBox10.Text, "-", "")
                TextBox10.Text = TextBox10.Text


                cadena1 = TextBox9.Text
                b = cadena1.Substring(1, 5)
                TextBox9.Text = b
                rs.Close()
                Button3.Visible = True
                Button3.Enabled = True
                Button3.Select()

            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
                frm_menu.Hide()
            End Try
        End If


    End Sub


    Private Sub cmd_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_limpiar.Click
        Call limpia()

    End Sub

    Private Sub Frm_folio_dte_glo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        frm_menu.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'esto es verifica NCR
        Try
            Dim rut1 As Integer = TextBox3.Text
            Dim dv1 As String = TextBox4.Text
            Dim rut2 As Integer = TextBox6.Text
            Dim dv2 As String = TextBox5.Text
            Dim rut3 As Integer = TextBox8.Text
            Dim dv3 As String = TextBox7.Text
            Dim tipodte As Integer = TextBox12.Text
            Dim nrodte As Integer = TextBox15.Text
            Dim fechadte As String = TextBox10.Text
            Dim montodte As Integer = TextBox11.Text
            Dim token As String = TextBox2.Text
            Dim jws As New estadoDTE.QueryEstDteService
            Dim resul = jws.getEstDte(rut1, dv1, rut2, dv2, rut3, dv3, tipodte, nrodte, fechadte, montodte, token)

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

            Dim leeresul3 = New XmlNodeReader(xmlresultado)
            leeresul3.readtofollowing("ERR_CODE")
            a = leeresul3.READELEMENTCONTENTASSTRING()

            Dim leeresul4 = New XmlNodeReader(xmlresultado)
            leeresul4.readtofollowing("GLOSA_ERR")
            c = leeresul4.READELEMENTCONTENTASSTRING()

            'MsgBox(b)
            'MsgBox(s)
            'MsgBox(a)
            'MsgBox(c)
            Label11.Text = s 'codigo estado
            Label13.Text = b 'glosa estado
            Label15.Text = a 'cod error
            Label17.Text = c 'glosa error

            'DELAY
            System.Threading.Thread.Sleep(1000) '1 segundo
            'fin prueba

            'Call consulta_estado()
            frm_menu.Hide()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'esto es verifica NDE
        Try
            Dim rut1 As Integer = TextBox3.Text
            Dim dv1 As String = TextBox4.Text
            Dim rut2 As Integer = TextBox6.Text
            Dim dv2 As String = TextBox5.Text
            Dim rut3 As Integer = TextBox8.Text
            Dim dv3 As String = TextBox7.Text
            Dim tipodte As Integer = TextBox12.Text
            Dim nrodte As Integer = TextBox16.Text
            Dim fechadte As String = TextBox10.Text
            Dim montodte As Integer = TextBox11.Text
            Dim token As String = TextBox2.Text
            Dim jws As New estadoDTE.QueryEstDteService
            Dim resul = jws.getEstDte(rut1, dv1, rut2, dv2, rut3, dv3, tipodte, nrodte, fechadte, montodte, token)

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

            Dim leeresul3 = New XmlNodeReader(xmlresultado)
            leeresul3.readtofollowing("ERR_CODE")
            a = leeresul3.READELEMENTCONTENTASSTRING()

            Dim leeresul4 = New XmlNodeReader(xmlresultado)
            leeresul4.readtofollowing("GLOSA_ERR")
            c = leeresul4.READELEMENTCONTENTASSTRING()

            'MsgBox(b)
            'MsgBox(s)
            'MsgBox(a)
            'MsgBox(c)
            Label11.Text = s 'codigo estado
            Label13.Text = b 'glosa estado
            Label15.Text = a 'cod error
            Label17.Text = c 'glosa error

            'DELAY
            System.Threading.Thread.Sleep(1000) '1 segundo
            'fin prueba
            frm_menu.Hide()
            'Call consulta_estado()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            frm_menu.Hide()
        End Try
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        'FEL
        If CheckBox3.Checked = True Then
            CheckBox1.Checked = False 'NCR
            CheckBox2.Checked = False 'NDB

            TextBox16.Visible = False
            TextBox15.Visible = False
            Button3.Visible = True  'fel
            Button1.Visible = False  'ncr
            Button2.Visible = False  'ndb
            Button3.Enabled = False
            TextBox12.Text = "33"
            TextBox9.Visible = True
            TextBox9.Enabled = True
            TextBox9.Select()
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False

            Button3.Visible = True
            Button2.Visible = False
            Button1.Visible = False
            Button3.Enabled = False
            TextBox12.Text = ""
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox9.Visible = True
            TextBox9.Enabled = False


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'NCR
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False 'ndb
            CheckBox3.Checked = False 'fel
            TextBox9.Visible = False 'fel
            TextBox16.Visible = False 'ndb
            TextBox15.Visible = True 'ncr
            Button3.Visible = False  'fel
            Button1.Visible = True 'ncr
            Button2.Visible = False  'ndb
            Button1.Enabled = False

            TextBox12.Text = "61"
            TextBox15.Enabled = True
            TextBox15.Select()
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False

            Button3.Visible = True
            Button2.Visible = False
            Button1.Visible = False
            Button3.Enabled = False
            TextBox12.Text = ""
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox9.Visible = True
            TextBox9.Enabled = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        'NBD
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False 'ncr
            CheckBox3.Checked = False 'fel
            TextBox9.Visible = False 'fel
            TextBox16.Visible = True 'ndb
            TextBox15.Visible = False 'ncr
            Button3.Visible = False  'fel
            Button1.Visible = False  'ncr
            Button2.Visible = True 'ndb
            Button2.Enabled = False
            TextBox12.Text = "56"
            TextBox16.Enabled = True
            TextBox16.Select()
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False

            Button3.Visible = True
            Button2.Visible = False
            Button1.Visible = False
            Button3.Enabled = False
            TextBox12.Text = ""
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox9.Visible = True
            TextBox9.Enabled = False

        End If
    End Sub

    Private Sub TextBox15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        'BUSCA LAS NOTAS DE CREDITO
        If GetAsyncKeyState(13) Then
            'define la conexion a la base de datos
            'Dim conn As New SqlConnection("Server=190.151.5.59\SQL2008;Database=GLOBAL2016;User Id=sa;Password=Rs1399")
            'Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database=GLOBAL" & miano & ";User Id=sa;Password=Xtreme_1720")

            'CONEXION A MYSQL
            Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=global" & miano & "")
            'define variables de conexion
            Dim sql As String
            Dim com As New MySqlCommand
            Dim rs As MySqlDataReader
            Dim valor As String
            Try
                com.Connection = conn
                conn.Open()
                valor = "NCE000000" & TextBox15.Text
                sql = "SELECT rutcon, totalcon, fechacon FROM VENTA WHERE tipocon = '" & valor & "'"
                com = New MySqlCommand(sql, conn)
                com.CommandTimeout = 1500
                rs = com.ExecuteReader()
                rs.Read()
                TextBox12.Text = "61"

                Dim s, a As String
                'dim b as string
                Dim cadena As String = CStr(rs("rutcon"))
                'Dim cadena1 As String

                a = cadena.Substring(1, 9) 'saca el primer caracter
                s = cadena.Substring(9, 1) 'saca el ultimo caracter
                a = cadena.Substring(1, 8)
                TextBox8.Text = a
                TextBox7.Text = s

                TextBox1.Text = a
                TextBox11.Text = CStr(rs("totalcon"))
                TextBox10.Text = CStr(rs("fechacon"))

                TextBox10.Text = Replace(TextBox10.Text, "-", "")
                TextBox10.Text = TextBox10.Text


                ' cadena1 = TextBox15.Text
                ' b = cadena1.Substring(1, 5)
                ' TextBox15.Text = b
                rs.Close()
                frm_menu.Hide()
                Button1.Visible = True
                Button1.Enabled = True
                Button1.Select()

            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
                frm_menu.Hide()
            End Try
        End If
    End Sub

    Private Sub TextBox16_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox16.KeyPress
        If GetAsyncKeyState(13) Then
            'BUSCA LAS NOTAS DE DEBITO
            'define la conexion a la base de datos
            'Dim conn As New SqlConnection("Server=190.151.5.59\SQL2008;Database=GLOBAL2016;User Id=sa;Password=Rs1399")
            'Dim conn As New SqlConnection("Server=192.168.1.28\SQL2008;Database=GLOBAL" & miano & ";User Id=sa;Password=Xtreme_1720")

            'CONEXION A MYSQL
            Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=global" & miano & "")
            'define variables de conexion
            Dim sql As String
            Dim com As New MySqlCommand
            Dim rs As MySqlDataReader
            Dim valor As String
            Try
                com.Connection = conn
                If conn.State = 1 Then conn.Close()
                conn.Open()
                valor = "NDE000000" & TextBox16.Text
                sql = "SELECT rutcon, totalcon, fechacon FROM VENTA WHERE tipocon = '" & valor & "'"
                com = New MySqlCommand(sql, conn)
                com.CommandTimeout = 1500
                rs = com.ExecuteReader()
                rs.Read()
                TextBox12.Text = "56"

                Dim s, a As String
                'Dim b As String
                Dim cadena As String = CStr(rs("rutcon"))
                'Dim cadena2 As String

                a = cadena.Substring(1, 9) 'saca el primer caracter
                s = cadena.Substring(9, 1) 'saca el ultimo caracter
                a = cadena.Substring(1, 8)
                TextBox8.Text = a
                TextBox7.Text = s

                TextBox1.Text = a
                TextBox11.Text = CStr(rs("totalcon"))
                TextBox10.Text = CStr(rs("fechacon"))

                TextBox10.Text = Replace(TextBox10.Text, "-", "")
                TextBox10.Text = TextBox10.Text


                'cadena2 = TextBox16.Text
                'b = cadena2.Substring(2, 4)
                'TextBox16.Text = b
                rs.Close()
                frm_menu.Hide()
                Button2.Visible = True
                Button2.Enabled = True
                Button2.Select()

            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
                frm_menu.Hide()
            End Try
        End If
    End Sub

    Private Sub TextBox15_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.LostFocus
        frm_menu.Hide()

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class