﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Acuse_Rango_Glo
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Acuse_Rango_Glo))
        Me.ch_ano_ant = New System.Windows.Forms.CheckBox()
        Me.op_calen2 = New System.Windows.Forms.RadioButton()
        Me.op_calen1 = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.fecha2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.fecha1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.FolioCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACRCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grilla2 = New System.Windows.Forms.DataGridView()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACRCL2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Calendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ch_VerifCorre = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_consultar = New System.Windows.Forms.Button()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ch_ano_ant
        '
        Me.ch_ano_ant.AutoSize = True
        Me.ch_ano_ant.Location = New System.Drawing.Point(443, 21)
        Me.ch_ano_ant.Name = "ch_ano_ant"
        Me.ch_ano_ant.Size = New System.Drawing.Size(84, 17)
        Me.ch_ano_ant.TabIndex = 191
        Me.ch_ano_ant.Text = "Año Anterior"
        Me.ch_ano_ant.UseVisualStyleBackColor = True
        '
        'op_calen2
        '
        Me.op_calen2.AutoSize = True
        Me.op_calen2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_calen2.Location = New System.Drawing.Point(363, 21)
        Me.op_calen2.Name = "op_calen2"
        Me.op_calen2.Size = New System.Drawing.Size(77, 17)
        Me.op_calen2.TabIndex = 190
        Me.op_calen2.TabStop = True
        Me.op_calen2.Text = "Calendario"
        Me.op_calen2.UseVisualStyleBackColor = True
        '
        'op_calen1
        '
        Me.op_calen1.AutoSize = True
        Me.op_calen1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_calen1.Location = New System.Drawing.Point(163, 20)
        Me.op_calen1.Name = "op_calen1"
        Me.op_calen1.Size = New System.Drawing.Size(77, 17)
        Me.op_calen1.TabIndex = 189
        Me.op_calen1.TabStop = True
        Me.op_calen1.Text = "Calendario"
        Me.op_calen1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(217, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "Fecha Final:"
        '
        'fecha2
        '
        Me.fecha2.Location = New System.Drawing.Point(288, 40)
        Me.fecha2.Mask = "00/00/0000"
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(81, 20)
        Me.fecha2.TabIndex = 187
        Me.fecha2.ValidatingType = GetType(Date)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 185
        Me.Label18.Text = "Fecha Inicial:"
        '
        'fecha1
        '
        Me.fecha1.Location = New System.Drawing.Point(83, 35)
        Me.fecha1.Mask = "00/00/0000"
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(76, 20)
        Me.fecha1.TabIndex = 186
        Me.fecha1.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(312, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 13)
        Me.Label17.TabIndex = 199
        Me.Label17.Text = "de"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(262, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 15)
        Me.Label15.TabIndex = 197
        Me.Label15.Text = "Label15"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 196
        Me.Label7.Text = "Revisando Folio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(334, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 15)
        Me.Label16.TabIndex = 198
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(264, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 195
        Me.Label13.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(207, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 194
        Me.Label12.Text = "Folio Final: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(140, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 193
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(80, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "Folio Inicial:"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(398, 61)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(86, 17)
        Me.CheckBox3.TabIndex = 200
        Me.CheckBox3.Text = "Verificar FEL"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(360, 81)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 18)
        Me.Label20.TabIndex = 201
        Me.Label20.Text = "REVISANDO...."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(455, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 202
        Me.Label21.Text = "FACTURAS"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmd_buscar.Image = CType(resources.GetObject("cmd_buscar.Image"), System.Drawing.Image)
        Me.cmd_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_buscar.Location = New System.Drawing.Point(542, 49)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(79, 56)
        Me.cmd_buscar.TabIndex = 203
        Me.cmd_buscar.Text = "BUSCAR FEL"
        Me.cmd_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Calibri", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(636, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 57)
        Me.Button1.TabIndex = 204
        Me.Button1.Text = "CONSULTA DTE"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioCol, Me.ACRCL})
        Me.grilla.Location = New System.Drawing.Point(49, 135)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(548, 405)
        Me.grilla.TabIndex = 205
        '
        'FolioCol
        '
        Me.FolioCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FolioCol.HeaderText = "Folio"
        Me.FolioCol.Name = "FolioCol"
        Me.FolioCol.ReadOnly = True
        Me.FolioCol.Width = 54
        '
        'ACRCL
        '
        Me.ACRCL.HeaderText = "ACUSE RECIBO / RECLAMO DTE"
        Me.ACRCL.Name = "ACRCL"
        Me.ACRCL.ReadOnly = True
        Me.ACRCL.Width = 401
        '
        'grilla2
        '
        Me.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Folio, Me.ACRCL2})
        Me.grilla2.Location = New System.Drawing.Point(612, 135)
        Me.grilla2.Name = "grilla2"
        Me.grilla2.Size = New System.Drawing.Size(380, 405)
        Me.grilla2.TabIndex = 206
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio2"
        Me.Folio.Name = "Folio"
        '
        'ACRCL2
        '
        Me.ACRCL2.HeaderText = "CONDICION DE ERROR"
        Me.ACRCL2.Name = "ACRCL2"
        Me.ACRCL2.ReadOnly = True
        Me.ACRCL2.Width = 300
        '
        'Calendar2
        '
        Me.Calendar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Calendar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendar2.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.Calendar2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendar2.ForeColor = System.Drawing.Color.Teal
        Me.Calendar2.Location = New System.Drawing.Point(279, 35)
        Me.Calendar2.MaxDate = New Date(2089, 12, 31, 0, 0, 0, 0)
        Me.Calendar2.MaxSelectionCount = 1
        Me.Calendar2.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.Calendar2.Name = "Calendar2"
        Me.Calendar2.TabIndex = 208
        '
        'Calendar1
        '
        Me.Calendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Calendar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.Calendar1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendar1.ForeColor = System.Drawing.Color.Teal
        Me.Calendar1.Location = New System.Drawing.Point(49, 35)
        Me.Calendar1.MaxDate = New Date(2089, 12, 31, 0, 0, 0, 0)
        Me.Calendar1.MaxSelectionCount = 1
        Me.Calendar1.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.TabIndex = 207
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(680, 113)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 15)
        Me.Label24.TabIndex = 210
        Me.Label24.Text = "Label24"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(539, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 15)
        Me.Label14.TabIndex = 209
        Me.Label14.Text = "FOLIOS CON PROBLEMAS"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancelar.Image = CType(resources.GetObject("cmd_cancelar.Image"), System.Drawing.Image)
        Me.cmd_cancelar.Location = New System.Drawing.Point(816, 48)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(76, 57)
        Me.cmd_cancelar.TabIndex = 211
        Me.cmd_cancelar.Text = "CANCELAR"
        Me.cmd_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(539, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "Semilla"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(585, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 212
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(791, 17)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 20)
        Me.TextBox2.TabIndex = 215
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(738, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "Token"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(807, 295)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(85, 20)
        Me.TextBox9.TabIndex = 222
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(559, 291)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(111, 20)
        Me.TextBox13.TabIndex = 220
        Me.TextBox13.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(676, 383)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 219
        Me.TextBox11.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(782, 301)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(19, 20)
        Me.TextBox4.TabIndex = 217
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(676, 298)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 216
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(676, 348)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 218
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(680, 321)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(204, 21)
        Me.TextBox14.TabIndex = 221
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(570, 321)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 223
        Me.TextBox10.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(570, 348)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 224
        Me.TextBox6.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(789, 348)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(19, 20)
        Me.TextBox5.TabIndex = 225
        Me.TextBox5.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 100000
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_limpiar.Image = CType(resources.GetObject("cmd_limpiar.Image"), System.Drawing.Image)
        Me.cmd_limpiar.Location = New System.Drawing.Point(733, 48)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(68, 57)
        Me.cmd_limpiar.TabIndex = 226
        Me.cmd_limpiar.Text = "LIMPIAR"
        Me.cmd_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(493, 40)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(34, 20)
        Me.TextBox12.TabIndex = 227
        Me.TextBox12.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(913, 48)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(19, 20)
        Me.TextBox7.TabIndex = 228
        Me.TextBox7.Visible = False
        '
        'ch_VerifCorre
        '
        Me.ch_VerifCorre.AutoSize = True
        Me.ch_VerifCorre.Location = New System.Drawing.Point(40, 570)
        Me.ch_VerifCorre.Name = "ch_VerifCorre"
        Me.ch_VerifCorre.Size = New System.Drawing.Size(119, 17)
        Me.ch_VerifCorre.TabIndex = 229
        Me.ch_VerifCorre.Text = "Verifica Correlativos"
        Me.ch_VerifCorre.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 574)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "Label3"
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(922, 81)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 26)
        Me.Button4.TabIndex = 278
        Me.Button4.Text = "SIGLA"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(684, 565)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 279
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(803, 565)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 280
        Me.Label5.Text = "Label5"
        '
        'cmd_consultar
        '
        Me.cmd_consultar.Location = New System.Drawing.Point(493, 565)
        Me.cmd_consultar.Name = "cmd_consultar"
        Me.cmd_consultar.Size = New System.Drawing.Size(64, 23)
        Me.cmd_consultar.TabIndex = 285
        Me.cmd_consultar.Text = "Consultar"
        Me.cmd_consultar.UseVisualStyleBackColor = True
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(391, 568)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(80, 20)
        Me.TextBox15.TabIndex = 284
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 553)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 283
        Me.Label6.Text = "Consultar Folio"
        '
        'frm_Acuse_Rango_Glo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 618)
        Me.Controls.Add(Me.cmd_consultar)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ch_VerifCorre)
        Me.Controls.Add(Me.Calendar1)
        Me.Controls.Add(Me.Calendar2)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.grilla2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ch_ano_ant)
        Me.Controls.Add(Me.op_calen2)
        Me.Controls.Add(Me.op_calen1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.fecha2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.fecha1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Acuse_Rango_Glo"
        Me.Text = "Revision Acuse de Recibo  DTE - GLOBAL"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ch_ano_ant As System.Windows.Forms.CheckBox
    Friend WithEvents op_calen2 As RadioButton
    Friend WithEvents op_calen1 As RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents fecha2 As MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents fecha1 As MaskedTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grilla As DataGridView
    Friend WithEvents grilla2 As DataGridView
    Friend WithEvents Calendar2 As MonthCalendar
    Friend WithEvents Calendar1 As MonthCalendar
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents FolioCol As DataGridViewTextBoxColumn
    Friend WithEvents ACRCL As DataGridViewTextBoxColumn
    Friend WithEvents Folio As DataGridViewTextBoxColumn
    Friend WithEvents ACRCL2 As DataGridViewTextBoxColumn
    Friend WithEvents ch_VerifCorre As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmd_consultar As System.Windows.Forms.Button
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
