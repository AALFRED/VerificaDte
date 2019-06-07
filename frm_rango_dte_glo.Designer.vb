<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_rango_dte_glo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rango_dte_glo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.Calendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Calendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmd_expexcel = New System.Windows.Forms.Button()
        Me.op_calen2 = New System.Windows.Forms.RadioButton()
        Me.grilla2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACRCL2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.op_calen1 = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.fecha2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.fecha1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.FolioCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sma_vta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACRCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmd_buscar_NDB = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmd_buscar_NCR = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmd_exp_txt = New System.Windows.Forms.Button()
        Me.ch_ano_ant = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ch_VerifCorre = New System.Windows.Forms.CheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_limpiar.Image = CType(resources.GetObject("cmd_limpiar.Image"), System.Drawing.Image)
        Me.cmd_limpiar.Location = New System.Drawing.Point(665, 37)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(68, 57)
        Me.cmd_limpiar.TabIndex = 145
        Me.cmd_limpiar.Text = "LIMPIAR"
        Me.cmd_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'Calendar1
        '
        Me.Calendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Calendar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.Calendar1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendar1.ForeColor = System.Drawing.Color.Teal
        Me.Calendar1.Location = New System.Drawing.Point(7, 18)
        Me.Calendar1.MaxDate = New Date(2089, 12, 31, 0, 0, 0, 0)
        Me.Calendar1.MaxSelectionCount = 1
        Me.Calendar1.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.TabIndex = 161
        '
        'Calendar2
        '
        Me.Calendar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Calendar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendar2.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.Calendar2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendar2.ForeColor = System.Drawing.Color.Teal
        Me.Calendar2.Location = New System.Drawing.Point(237, 18)
        Me.Calendar2.MaxDate = New Date(2089, 12, 31, 0, 0, 0, 0)
        Me.Calendar2.MaxSelectionCount = 1
        Me.Calendar2.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.Calendar2.Name = "Calendar2"
        Me.Calendar2.TabIndex = 168
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(638, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 15)
        Me.Label14.TabIndex = 170
        Me.Label14.Text = "FOLIOS CON PROBLEMAS"
        '
        'cmd_expexcel
        '
        Me.cmd_expexcel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_expexcel.Image = CType(resources.GetObject("cmd_expexcel.Image"), System.Drawing.Image)
        Me.cmd_expexcel.Location = New System.Drawing.Point(739, 37)
        Me.cmd_expexcel.Name = "cmd_expexcel"
        Me.cmd_expexcel.Size = New System.Drawing.Size(77, 57)
        Me.cmd_expexcel.TabIndex = 167
        Me.cmd_expexcel.Text = "Exp Excel"
        Me.cmd_expexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_expexcel.UseVisualStyleBackColor = True
        '
        'op_calen2
        '
        Me.op_calen2.AutoSize = True
        Me.op_calen2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_calen2.Location = New System.Drawing.Point(366, 13)
        Me.op_calen2.Name = "op_calen2"
        Me.op_calen2.Size = New System.Drawing.Size(77, 17)
        Me.op_calen2.TabIndex = 166
        Me.op_calen2.TabStop = True
        Me.op_calen2.Text = "Calendario"
        Me.op_calen2.UseVisualStyleBackColor = True
        '
        'grilla2
        '
        Me.grilla2.AllowUserToDeleteRows = False
        Me.grilla2.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grilla2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.ACRCL2})
        Me.grilla2.Location = New System.Drawing.Point(584, 127)
        Me.grilla2.Name = "grilla2"
        Me.grilla2.ReadOnly = True
        Me.grilla2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.grilla2.Size = New System.Drawing.Size(490, 463)
        Me.grilla2.TabIndex = 169
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 54
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Estado SII"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 81
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sma. Vta."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 78
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "XML"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 54
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "PDF"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 53
        '
        'ACRCL2
        '
        Me.ACRCL2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ACRCL2.HeaderText = "AC-RCL"
        Me.ACRCL2.Name = "ACRCL2"
        Me.ACRCL2.ReadOnly = True
        Me.ACRCL2.Visible = False
        '
        'op_calen1
        '
        Me.op_calen1.AutoSize = True
        Me.op_calen1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_calen1.Location = New System.Drawing.Point(166, 12)
        Me.op_calen1.Name = "op_calen1"
        Me.op_calen1.Size = New System.Drawing.Size(77, 17)
        Me.op_calen1.TabIndex = 165
        Me.op_calen1.TabStop = True
        Me.op_calen1.Text = "Calendario"
        Me.op_calen1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(220, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 164
        Me.Label19.Text = "Fecha Final:"
        '
        'fecha2
        '
        Me.fecha2.Location = New System.Drawing.Point(291, 32)
        Me.fecha2.Mask = "00/00/0000"
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(81, 20)
        Me.fecha2.TabIndex = 163
        Me.fecha2.ValidatingType = GetType(Date)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 160
        Me.Label18.Text = "Fecha Inicial:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(255, 105)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 13)
        Me.Label17.TabIndex = 159
        Me.Label17.Text = "de"
        '
        'fecha1
        '
        Me.fecha1.Location = New System.Drawing.Point(86, 27)
        Me.fecha1.Mask = "00/00/0000"
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(76, 20)
        Me.fecha1.TabIndex = 162
        Me.fecha1.ValidatingType = GetType(Date)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(205, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 15)
        Me.Label15.TabIndex = 156
        Me.Label15.Text = "Label15"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Revisando Folio"
        '
        'grilla
        '
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioCol, Me.EstadoCol, Me.Sma_vta, Me.XML, Me.PDF, Me.ACRCL})
        Me.grilla.Location = New System.Drawing.Point(13, 125)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(553, 465)
        Me.grilla.TabIndex = 154
        '
        'FolioCol
        '
        Me.FolioCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FolioCol.HeaderText = "Folio"
        Me.FolioCol.MinimumWidth = 10
        Me.FolioCol.Name = "FolioCol"
        Me.FolioCol.ReadOnly = True
        Me.FolioCol.Width = 54
        '
        'EstadoCol
        '
        Me.EstadoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EstadoCol.HeaderText = "Estado SII"
        Me.EstadoCol.Name = "EstadoCol"
        Me.EstadoCol.ReadOnly = True
        Me.EstadoCol.Width = 81
        '
        'Sma_vta
        '
        Me.Sma_vta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Sma_vta.HeaderText = "Sma. Vta."
        Me.Sma_vta.Name = "Sma_vta"
        Me.Sma_vta.ReadOnly = True
        Me.Sma_vta.Width = 78
        '
        'XML
        '
        Me.XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.XML.HeaderText = "XML"
        Me.XML.Name = "XML"
        Me.XML.ReadOnly = True
        Me.XML.Width = 54
        '
        'PDF
        '
        Me.PDF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PDF.HeaderText = "PDF"
        Me.PDF.Name = "PDF"
        Me.PDF.ReadOnly = True
        Me.PDF.Width = 53
        '
        'ACRCL
        '
        Me.ACRCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ACRCL.HeaderText = "AC-RCL"
        Me.ACRCL.Name = "ACRCL"
        Me.ACRCL.ReadOnly = True
        Me.ACRCL.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 100000
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(277, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 15)
        Me.Label16.TabIndex = 157
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Calibri", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(579, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 57)
        Me.Button1.TabIndex = 153
        Me.Button1.Text = "CONSULTA DTE"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancelar.Image = CType(resources.GetObject("cmd_cancelar.Image"), System.Drawing.Image)
        Me.cmd_cancelar.Location = New System.Drawing.Point(910, 37)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(76, 57)
        Me.cmd_cancelar.TabIndex = 158
        Me.cmd_cancelar.Text = "CANCELAR"
        Me.cmd_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(663, 4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(85, 20)
        Me.TextBox9.TabIndex = 152
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmd_buscar.Image = CType(resources.GetObject("cmd_buscar.Image"), System.Drawing.Image)
        Me.cmd_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_buscar.Location = New System.Drawing.Point(487, 38)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(79, 56)
        Me.cmd_buscar.TabIndex = 151
        Me.cmd_buscar.Text = "BUSCAR FEL"
        Me.cmd_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(207, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(150, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Folio Final: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(83, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Folio Inicial:"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(536, 30)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(204, 21)
        Me.TextBox14.TabIndex = 146
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(415, 0)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(111, 20)
        Me.TextBox13.TabIndex = 144
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(532, 73)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(34, 20)
        Me.TextBox12.TabIndex = 143
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(532, 92)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 142
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(625, 76)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 141
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(638, 57)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(19, 20)
        Me.TextBox7.TabIndex = 140
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(532, 57)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 139
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(638, 36)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(19, 20)
        Me.TextBox5.TabIndex = 138
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(532, 34)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 137
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(638, 10)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(19, 20)
        Me.TextBox4.TabIndex = 136
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(532, 7)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 135
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(462, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "Monto Dte"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(572, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Fecha Dte"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(462, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Tipo Dte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(462, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Rut Receptor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(462, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Rut Empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(462, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Rut Repres."
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(816, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 20)
        Me.TextBox2.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(763, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Token"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(564, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Semilla"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(610, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 125
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(348, 98)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 18)
        Me.Label20.TabIndex = 171
        Me.Label20.Text = "REVISANDO...."
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(399, 75)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox2.TabIndex = 174
        Me.CheckBox2.Text = "Verificar NDB"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(399, 41)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(86, 17)
        Me.CheckBox3.TabIndex = 173
        Me.CheckBox3.Text = "Verificar FEL"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(399, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox1.TabIndex = 172
        Me.CheckBox1.Text = "Verificar NCR"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmd_buscar_NDB
        '
        Me.cmd_buscar_NDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_buscar_NDB.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar_NDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmd_buscar_NDB.Image = CType(resources.GetObject("cmd_buscar_NDB.Image"), System.Drawing.Image)
        Me.cmd_buscar_NDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_buscar_NDB.Location = New System.Drawing.Point(487, 38)
        Me.cmd_buscar_NDB.Name = "cmd_buscar_NDB"
        Me.cmd_buscar_NDB.Size = New System.Drawing.Size(79, 58)
        Me.cmd_buscar_NDB.TabIndex = 175
        Me.cmd_buscar_NDB.Text = "BUSCAR NDB"
        Me.cmd_buscar_NDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_buscar_NDB.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(438, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(117, 18)
        Me.Label23.TabIndex = 177
        Me.Label23.Text = "NOTAS DE DÉBITO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(438, 98)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 178
        Me.Label21.Text = "FACTURAS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(441, 98)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(125, 18)
        Me.Label22.TabIndex = 179
        Me.Label22.Text = "NOTAS DE CREDITO"
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Calibri", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(579, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 57)
        Me.Button2.TabIndex = 180
        Me.Button2.Text = "CONSULTA DTE"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Calibri", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(581, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 57)
        Me.Button3.TabIndex = 181
        Me.Button3.Text = "CONSULTA DTE"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmd_buscar_NCR
        '
        Me.cmd_buscar_NCR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_buscar_NCR.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar_NCR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmd_buscar_NCR.Image = CType(resources.GetObject("cmd_buscar_NCR.Image"), System.Drawing.Image)
        Me.cmd_buscar_NCR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_buscar_NCR.Location = New System.Drawing.Point(487, 38)
        Me.cmd_buscar_NCR.Name = "cmd_buscar_NCR"
        Me.cmd_buscar_NCR.Size = New System.Drawing.Size(79, 56)
        Me.cmd_buscar_NCR.TabIndex = 176
        Me.cmd_buscar_NCR.Text = "BUSCAR NCR"
        Me.cmd_buscar_NCR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_buscar_NCR.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(1003, 52)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 26)
        Me.Button4.TabIndex = 182
        Me.Button4.Text = "SIGLA"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'cmd_exp_txt
        '
        Me.cmd_exp_txt.AutoSize = True
        Me.cmd_exp_txt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exp_txt.Image = CType(resources.GetObject("cmd_exp_txt.Image"), System.Drawing.Image)
        Me.cmd_exp_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_exp_txt.Location = New System.Drawing.Point(822, 37)
        Me.cmd_exp_txt.Name = "cmd_exp_txt"
        Me.cmd_exp_txt.Size = New System.Drawing.Size(82, 57)
        Me.cmd_exp_txt.TabIndex = 183
        Me.cmd_exp_txt.Text = "Exp. a TXT"
        Me.cmd_exp_txt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_exp_txt.UseVisualStyleBackColor = True
        '
        'ch_ano_ant
        '
        Me.ch_ano_ant.AutoSize = True
        Me.ch_ano_ant.Location = New System.Drawing.Point(446, 13)
        Me.ch_ano_ant.Name = "ch_ano_ant"
        Me.ch_ano_ant.Size = New System.Drawing.Size(84, 17)
        Me.ch_ano_ant.TabIndex = 184
        Me.ch_ano_ant.Text = "Año Anterior"
        Me.ch_ano_ant.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(779, 105)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 15)
        Me.Label24.TabIndex = 185
        Me.Label24.Text = "Label24"
        '
        'ch_VerifCorre
        '
        Me.ch_VerifCorre.AutoSize = True
        Me.ch_VerifCorre.Location = New System.Drawing.Point(38, 607)
        Me.ch_VerifCorre.Name = "ch_VerifCorre"
        Me.ch_VerifCorre.Size = New System.Drawing.Size(119, 17)
        Me.ch_VerifCorre.TabIndex = 186
        Me.ch_VerifCorre.Text = "Verifica Correlativos"
        Me.ch_VerifCorre.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(859, 611)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 188
        Me.Label26.Text = "Label26"
        Me.Label26.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(756, 611)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 189
        Me.Label25.Text = "Label25"
        Me.Label25.Visible = False
        '
        'frm_rango_dte_glo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 659)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.ch_VerifCorre)
        Me.Controls.Add(Me.Calendar2)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_buscar_NCR)
        Me.Controls.Add(Me.ch_ano_ant)
        Me.Controls.Add(Me.cmd_exp_txt)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.Calendar1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmd_expexcel)
        Me.Controls.Add(Me.op_calen2)
        Me.Controls.Add(Me.op_calen1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.fecha2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.fecha1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_buscar_NDB)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grilla2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_rango_dte_glo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GLOBAL\ CONSULTA DOCUMENTOS ELECTRÓNICOS POR RANGO DE FECHAS"
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents Calendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Calendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmd_expexcel As System.Windows.Forms.Button
    Friend WithEvents op_calen2 As System.Windows.Forms.RadioButton
    Friend WithEvents grilla2 As System.Windows.Forms.DataGridView
    Friend WithEvents op_calen1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents fecha2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents fecha1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_buscar_NDB As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_NCR As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmd_exp_txt As System.Windows.Forms.Button
    Friend WithEvents ch_ano_ant As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ch_VerifCorre As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ACRCL2 As DataGridViewTextBoxColumn
    Friend WithEvents FolioCol As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCol As DataGridViewTextBoxColumn
    Friend WithEvents Sma_vta As DataGridViewTextBoxColumn
    Friend WithEvents XML As DataGridViewTextBoxColumn
    Friend WithEvents PDF As DataGridViewTextBoxColumn
    Friend WithEvents ACRCL As DataGridViewTextBoxColumn
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
