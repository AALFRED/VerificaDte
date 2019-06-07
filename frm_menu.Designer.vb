<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm



    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Folio_unico_cint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Folio_por_rango_cint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_acuse_recibo_cint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.Folio_por_mes_cint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultaAceptaRechazoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.FolioAñoAnteriores_cint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DctosCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolioCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FolioPorRangoFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.FolioPorMesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RevisionGlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Folio_unico_glo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Folios_por_rango_glo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Folios_por_mes_glo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FolioAñosAnteriores_glo = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.folio_unico_gk = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.Folio_por_mes_gk = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Folio_por_rango_gk = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_cancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Mt_Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Mt_Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Mt_Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.RevisionGlobalToolStripMenuItem, Me.RevisiónToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(38, 46)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ToolStripSeparator1, Me.DctosCompraToolStripMenuItem, Me.ToolStripSeparator2})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ArchivoToolStripMenuItem.Text = "Revisión Cintegral"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Folio_unico_cint, Me.ToolStripSeparator7, Me.Folio_por_rango_cint, Me.ToolStripSeparator8, Me.mnu_acuse_recibo_cint, Me.ToolStripSeparator14, Me.Folio_por_mes_cint, Me.ToolStripSeparator12, Me.ConsultaAceptaRechazoToolStripMenuItem, Me.ToolStripSeparator13, Me.FolioAñoAnteriores_cint})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'Folio_unico_cint
        '
        Me.Folio_unico_cint.Name = "Folio_unico_cint"
        Me.Folio_unico_cint.Size = New System.Drawing.Size(215, 22)
        Me.Folio_unico_cint.Text = "Folio Unico"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(212, 6)
        '
        'Folio_por_rango_cint
        '
        Me.Folio_por_rango_cint.Name = "Folio_por_rango_cint"
        Me.Folio_por_rango_cint.Size = New System.Drawing.Size(215, 22)
        Me.Folio_por_rango_cint.Text = "Folio por Rango Fecha"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(212, 6)
        '
        'mnu_acuse_recibo_cint
        '
        Me.mnu_acuse_recibo_cint.Name = "mnu_acuse_recibo_cint"
        Me.mnu_acuse_recibo_cint.Size = New System.Drawing.Size(215, 22)
        Me.mnu_acuse_recibo_cint.Text = "Acuse Recibo Rango"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(212, 6)
        '
        'Folio_por_mes_cint
        '
        Me.Folio_por_mes_cint.Name = "Folio_por_mes_cint"
        Me.Folio_por_mes_cint.Size = New System.Drawing.Size(215, 22)
        Me.Folio_por_mes_cint.Text = "Folio por Mes"
        Me.Folio_por_mes_cint.Visible = False
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(212, 6)
        Me.ToolStripSeparator12.Visible = False
        '
        'ConsultaAceptaRechazoToolStripMenuItem
        '
        Me.ConsultaAceptaRechazoToolStripMenuItem.Name = "ConsultaAceptaRechazoToolStripMenuItem"
        Me.ConsultaAceptaRechazoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ConsultaAceptaRechazoToolStripMenuItem.Text = "Consulta Acepta -Rechazo"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(212, 6)
        '
        'FolioAñoAnteriores_cint
        '
        Me.FolioAñoAnteriores_cint.Name = "FolioAñoAnteriores_cint"
        Me.FolioAñoAnteriores_cint.Size = New System.Drawing.Size(215, 22)
        Me.FolioAñoAnteriores_cint.Text = "Folio Año Anteriores"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(120, 6)
        '
        'DctosCompraToolStripMenuItem
        '
        Me.DctosCompraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolioCompraToolStripMenuItem, Me.ToolStripSeparator3, Me.FolioPorRangoFechasToolStripMenuItem, Me.ToolStripSeparator9, Me.FolioPorMesToolStripMenuItem1})
        Me.DctosCompraToolStripMenuItem.Name = "DctosCompraToolStripMenuItem"
        Me.DctosCompraToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.DctosCompraToolStripMenuItem.Text = "Compras"
        '
        'FolioCompraToolStripMenuItem
        '
        Me.FolioCompraToolStripMenuItem.Name = "FolioCompraToolStripMenuItem"
        Me.FolioCompraToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.FolioCompraToolStripMenuItem.Text = "Folio Unico"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(199, 6)
        '
        'FolioPorRangoFechasToolStripMenuItem
        '
        Me.FolioPorRangoFechasToolStripMenuItem.Name = "FolioPorRangoFechasToolStripMenuItem"
        Me.FolioPorRangoFechasToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.FolioPorRangoFechasToolStripMenuItem.Text = "Folio por Rango Fechas"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(199, 6)
        '
        'FolioPorMesToolStripMenuItem1
        '
        Me.FolioPorMesToolStripMenuItem1.Name = "FolioPorMesToolStripMenuItem1"
        Me.FolioPorMesToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.FolioPorMesToolStripMenuItem1.Text = "Folio por Mes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(120, 6)
        '
        'RevisionGlobalToolStripMenuItem
        '
        Me.RevisionGlobalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Folio_unico_glo, Me.ToolStripSeparator4, Me.Folios_por_rango_glo, Me.ToolStripSeparator5, Me.Folios_por_mes_glo, Me.ToolStripSeparator6, Me.FolioAñosAnteriores_glo})
        Me.RevisionGlobalToolStripMenuItem.Name = "RevisionGlobalToolStripMenuItem"
        Me.RevisionGlobalToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.RevisionGlobalToolStripMenuItem.Text = "Revision Global"
        '
        'Folio_unico_glo
        '
        Me.Folio_unico_glo.Image = CType(resources.GetObject("Folio_unico_glo.Image"), System.Drawing.Image)
        Me.Folio_unico_glo.Name = "Folio_unico_glo"
        Me.Folio_unico_glo.Size = New System.Drawing.Size(204, 22)
        Me.Folio_unico_glo.Text = "Folio Único"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(201, 6)
        '
        'Folios_por_rango_glo
        '
        Me.Folios_por_rango_glo.Image = CType(resources.GetObject("Folios_por_rango_glo.Image"), System.Drawing.Image)
        Me.Folios_por_rango_glo.Name = "Folios_por_rango_glo"
        Me.Folios_por_rango_glo.Size = New System.Drawing.Size(204, 22)
        Me.Folios_por_rango_glo.Text = "Folios por Rango"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(201, 6)
        '
        'Folios_por_mes_glo
        '
        Me.Folios_por_mes_glo.Image = CType(resources.GetObject("Folios_por_mes_glo.Image"), System.Drawing.Image)
        Me.Folios_por_mes_glo.Name = "Folios_por_mes_glo"
        Me.Folios_por_mes_glo.Size = New System.Drawing.Size(204, 22)
        Me.Folios_por_mes_glo.Text = "Acuse Recibo / Reclamo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(201, 6)
        '
        'FolioAñosAnteriores_glo
        '
        Me.FolioAñosAnteriores_glo.Name = "FolioAñosAnteriores_glo"
        Me.FolioAñosAnteriores_glo.Size = New System.Drawing.Size(204, 22)
        Me.FolioAñosAnteriores_glo.Text = "Folio Años Anteriores"
        '
        'RevisiónToolStripMenuItem
        '
        Me.RevisiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.folio_unico_gk, Me.ToolStripSeparator11, Me.Folio_por_mes_gk, Me.ToolStripSeparator10, Me.Folio_por_rango_gk})
        Me.RevisiónToolStripMenuItem.Name = "RevisiónToolStripMenuItem"
        Me.RevisiónToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.RevisiónToolStripMenuItem.Text = "Revisión Imp. GK"
        '
        'folio_unico_gk
        '
        Me.folio_unico_gk.Image = CType(resources.GetObject("folio_unico_gk.Image"), System.Drawing.Image)
        Me.folio_unico_gk.Name = "folio_unico_gk"
        Me.folio_unico_gk.Size = New System.Drawing.Size(167, 22)
        Me.folio_unico_gk.Text = "Folio Único"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(164, 6)
        '
        'Folio_por_mes_gk
        '
        Me.Folio_por_mes_gk.Image = CType(resources.GetObject("Folio_por_mes_gk.Image"), System.Drawing.Image)
        Me.Folio_por_mes_gk.Name = "Folio_por_mes_gk"
        Me.Folio_por_mes_gk.Size = New System.Drawing.Size(167, 22)
        Me.Folio_por_mes_gk.Text = "Folios por Mes"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(164, 6)
        '
        'Folio_por_rango_gk
        '
        Me.Folio_por_rango_gk.Image = CType(resources.GetObject("Folio_por_rango_gk.Image"), System.Drawing.Image)
        Me.Folio_por_rango_gk.Name = "Folio_por_rango_gk"
        Me.Folio_por_rango_gk.Size = New System.Drawing.Size(167, 22)
        Me.Folio_por_rango_gk.Text = "Folios por Rango"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_cancelar})
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'mnu_cancelar
        '
        Me.mnu_cancelar.Image = CType(resources.GetObject("mnu_cancelar.Image"), System.Drawing.Image)
        Me.mnu_cancelar.Name = "mnu_cancelar"
        Me.mnu_cancelar.Size = New System.Drawing.Size(100, 22)
        Me.mnu_cancelar.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(725, 331)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Mt_Label1
        '
        Me.Mt_Label1.AutoSize = True
        Me.Mt_Label1.Location = New System.Drawing.Point(380, 435)
        Me.Mt_Label1.Name = "Mt_Label1"
        Me.Mt_Label1.Size = New System.Drawing.Size(69, 19)
        Me.Mt_Label1.Style = MetroFramework.MetroColorStyle.Orange
        Me.Mt_Label1.TabIndex = 9
        Me.Mt_Label1.Text = "Mt_Label2"
        Me.Mt_Label1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Mt_Label2
        '
        Me.Mt_Label2.AutoSize = True
        Me.Mt_Label2.Location = New System.Drawing.Point(50, 435)
        Me.Mt_Label2.Name = "Mt_Label2"
        Me.Mt_Label2.Size = New System.Drawing.Size(69, 19)
        Me.Mt_Label2.Style = MetroFramework.MetroColorStyle.Orange
        Me.Mt_Label2.TabIndex = 10
        Me.Mt_Label2.Text = "Mt_Label2"
        Me.Mt_Label2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Mt_Label3
        '
        Me.Mt_Label3.AutoSize = True
        Me.Mt_Label3.Location = New System.Drawing.Point(414, 301)
        Me.Mt_Label3.Name = "Mt_Label3"
        Me.Mt_Label3.Size = New System.Drawing.Size(69, 19)
        Me.Mt_Label3.TabIndex = 11
        Me.Mt_Label3.Text = "Mt_Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(763, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(812, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mt_Label3)
        Me.Controls.Add(Me.Mt_Label2)
        Me.Controls.Add(Me.Mt_Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_menu"
        Me.Padding = New System.Windows.Forms.Padding(23, 69, 23, 23)
        Me.Resizable = False
        Me.TransparencyKey = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RevisionGlobalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevisiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Folio_unico_glo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Folios_por_mes_glo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Folios_por_rango_glo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents folio_unico_gk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Folio_por_mes_gk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Folio_por_rango_gk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_cancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DctosCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolioCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Folio_unico_cint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Folio_por_rango_cint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Folio_por_mes_cint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FolioPorRangoFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FolioPorMesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FolioAñoAnteriores_cint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FolioAñosAnteriores_glo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConsultaAceptaRechazoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_acuse_recibo_cint As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents Mt_Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Mt_Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Mt_Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
