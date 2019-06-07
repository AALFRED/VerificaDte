Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Collections
Imports System.Drawing
Imports System
Imports MetroFramework


Public Class frm_menu
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const CS_MAXIMIZE As Integer = &HF030I
    Dim mainStatusBar As New StatusBar()
    Dim statusPanel As New StatusBarPanel()
    Dim datetimePanel As New StatusBarPanel()

    Public ElUser As String


    Public Sub Centrar()
        Dim tamaño As Rectangle = My.Computer.Screen.Bounds
        Dim posicionX As Integer = (tamaño.Width - Me.Width) \ 2
        Dim posicionY As Integer = (tamaño.Height - Me.Height) \ 2
        Me.Location = New Point(posicionX, posicionY)
    End Sub
    Private Sub frm_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CreateDynamicStatusBar()
        Mt_Label1.Text = "Autorizado su Uso a Cintegral, Global, Imp.GK V.2.0"

        theScreenBounds = Screen.GetBounds(Screen.PrimaryScreen.Bounds)

        x = theScreenBounds.Width
        y = theScreenBounds.Height
        Mt_Label2.Text = "La resolucion de tu pantalla es  " & x & " x " & y
        Me.Mt_Label3.Text = Year(Now)

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(272, 438)
        Me.Centrar()
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

    Private Sub FolioÚnicoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folio_unico_glo.Click
        Me.Hide()
        frm_folio_dte_glo.Show()
    End Sub

    Private Sub FoliosPorMesToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folios_por_mes_glo.Click
        Me.Hide()
        frm_Acuse_Rango_Glo.Show()
        'MsgBox("Módulo Desactivado")
        'Me.Show()
    End Sub

    Private Sub FoliosPorRangoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folios_por_rango_glo.Click
        Me.Hide()
        frm_rango_dte_glo.Show()
    End Sub

    Private Sub mnu_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_cancelar.Click
        End
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles folio_unico_gk.Click
        Me.Hide()
        frm_folio_dte_gk.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folio_por_mes_gk.Click
        Me.Hide()
        'frm_folio_mes_gk.Show()
        MsgBox("Módulo Desactivado")
        Me.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folio_por_rango_gk.Click
        Me.Hide()
        frm_rango_dte_gk.Show()
    End Sub

    Private Sub FolioCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolioCompraToolStripMenuItem.Click
        Me.Hide()
        frm_folio_compras_cint.Show()
        'MsgBox("módulo en revisión")
    End Sub

    Private Sub FolioUnicoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folio_unico_cint.Click
        Me.Hide()
        frm_folio_dte.Show()
    End Sub

    Private Sub FolioPorRangoFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folio_por_rango_cint.Click
        Me.Hide()
        frm_rango_dte.Show()
    End Sub

    Private Sub FolioPorMesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folio_por_mes_cint.Click
        Me.Hide()
        'frm_folio_mes.Show()
        MsgBox("Módulo Desactivado")
        Me.Show()

    End Sub

    Private Sub FolioPorMesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolioPorMesToolStripMenuItem1.Click
        Me.Hide()
        frm_mes_cint_compras.Show()
        'MsgBox("módulo en revisión")
    End Sub

    Private Sub FolioAñoAnterioresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolioAñoAnteriores_cint.Click
        Me.Hide()
        'frm_anos_dte_mes.Show()
        MsgBox("En Revision")
    End Sub

    Private Sub FolioPorRangoFechasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolioPorRangoFechasToolStripMenuItem.Click
        Me.Hide()
        frm_folio_compras_cint.Show()
        'MsgBox("módulo en revisión")
    End Sub

    Private Sub FolioAñosAnterioresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolioAñosAnteriores_glo.Click
        Me.Hide()
        'frm_anos_dte_mes_glo.show()
        MsgBox("En revision")
        Me.Show()


    End Sub

    Private Sub ConsultaAceptaRechazoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaAceptaRechazoToolStripMenuItem.Click
        frm_consulta_eventos.Show()
    End Sub

    Private Sub frm_menu_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub mnu_acuse_recibo_cint_Click(sender As Object, e As EventArgs) Handles mnu_acuse_recibo_cint.Click
        Me.Hide()

        frm_Acuse_Rango_Cint.Show()

    End Sub

    Private Sub frm_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim x As Integer

        x = MetroFramework.MetroMessageBox.Show(Me, "Estimado Usuario(a): ¿Esta seguro de Cerrar el Sistema de Verificación?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If x = 2 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_menu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ElUser = Frm_Inicio.TextBox1.Text
        Frm_Inicio.Hide()
        Label1.Text = ElUser


    End Sub
End Class