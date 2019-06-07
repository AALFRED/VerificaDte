Imports System.IO
Imports System.Xml
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Generic
Imports MySql.Data.MySqlClient

Public Class Frm_Inicio
    Public valret As String
    Public miano As Integer
    Public midb As String

    Sub ultimoAcceso()

        miano = Date.Now.Year

        'CONEXION A MYSQL
        ' Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")
        'define variables de conexion
        Dim sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader


        Select Case Label6.Text
            Case "1"
                valret = "cintegral"
            Case "2"
                valret = "global"
            Case "3"
                valret = "impgk"
        End Select

        Dim midb As String = valret & miano

        Try
            'Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")
            Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database='" & midb & "'")
            com.Connection = conn
            If conn.State = 1 Then conn.Close()
            conn.Open()

            sql = "Select max(ingreso) fechafinal FROM CTRL_ACCESO_CAJAS WHERE usuario = '" & TextBox1.Text & "'"
            com = New MySqlCommand(sql, conn)
            rs = com.ExecuteReader()
            rs.Read()
            If IsDBNull(rs("fechafinal")) = True Then
                Label4.Text = ""
            Else
                Label4.Text = rs("fechafinal").ToString()
                rs.Close()
                com.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)

        End Try

    End Sub
    Sub registra_acceso()

        miano = Date.Now.Year

        Select Case Label6.Text
            Case "1"
                valret = "cintegral"
            Case "2"
                valret = "global"
            Case "3"
                valret = "impgk"
        End Select

        midb = valret & miano
        'CONEXION A MYSQL
        'Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")
        Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database='" & midb & "'")
        'define variables de conexion
        Dim sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader
        Dim mifecha As String

        mifecha = Now()

        com.Connection = conn
        If conn.State = 1 Then conn.Close()
        conn.Open()
        sql = "INSERT INTO ctrl_acceso_revdte VALUES('0', '" & TextBox1.Text & "', '" & mifecha & "')"
        com = New MySqlCommand(sql, conn)
        rs = com.ExecuteReader

        'MessageBox.Show("Registro Guardado")
        conn.Close()
        com.Dispose()

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If TextBox1.Text <> "" Then

                'Busca la ultima conexion
                Call ultimoAcceso()

                TextBox2.Select()
            Else
                MsgBox("Debe ingresar datos!", MsgBoxStyle.Exclamation)
                TextBox1.Select()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If TextBox2.Text <> "" Then
                cmd_aceptar.Enabled = True
                cmd_aceptar.Select()
            Else
                MsgBox("Debe ingresar una Password ", MsgBoxStyle.Exclamation)
                TextBox2.Select()

            End If
        End If
    End Sub

    Private Sub Frm_Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        'para mayusculas
        TextBox1.CharacterCasing = CharacterCasing.Upper
        Label4.Text = ""
        Label6.Text = ""
        cbo_empresa.Text = ""
        cbo_empresa.Items.Add("CINTEGRAL")
        cbo_empresa.Items.Add("GLOBAL")
        cbo_empresa.Items.Add("IMPORTADORA GK")


    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        End

    End Sub

    Private Sub cmd_aceptar_Click(sender As Object, e As EventArgs) Handles cmd_aceptar.Click
        Dim sql As String
        Dim com As New MySqlCommand
        Dim mydata As MySqlDataReader
        Dim myadapter As New MySqlDataAdapter

        Try
            'CONEXION A MYSQL
            miano = (Date.Today.Year)

            Select Case Label6.Text
                Case "1"
                    valret = "cintegral"
                Case "2"
                    valret = "global"
                Case "3"
                    valret = "impgk"
            End Select

            midb = valret & miano

            'Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database=cintegral" & miano & "")
            Dim conn As New MySqlConnection("Server=192.168.1.61;user id=cintegral;password=Xtreme749;database='" & midb & "'")
            'define variables de conexion
            com.Connection = conn
            If conn.State = 1 Then conn.Close()
            conn.Open()
            sql = "SELECT * FROM cuentas_dp WHERE usuario = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'"
            com.CommandText = sql
            myadapter.SelectCommand = com
            mydata = com.ExecuteReader()

            If mydata.HasRows = 0 Then
                MsgBox("El usuario o clave errónea", MessageBoxIcon.Error)
                TextBox1.Select()
            Else

                'guarda el acceso
                Call registra_acceso()

                Me.Hide()
                frm_menu.Show()

            End If
            mydata.Close()


        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cbo_empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_empresa.SelectedIndexChanged
        Select Case cbo_empresa.Text
            Case "CINTEGRAL"
                Label6.Text = "1"
            Case "GLOBAL"
                Label6.Text = "2"
            Case "IMPORTADORA GK"
                Label6.Text = "3"
        End Select
    End Sub
End Class