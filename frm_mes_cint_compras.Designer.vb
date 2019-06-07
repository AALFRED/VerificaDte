<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mes_cint_compras
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mes_cint_compras))
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grilla2 = New System.Windows.Forms.DataGridView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label
        Me.grilla = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbo_mes = New System.Windows.Forms.ComboBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_expexcel = New System.Windows.Forms.Button
        Me.cmd_cancelar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmd_buscar = New System.Windows.Forms.Button
        Me.cmd_limpiar = New System.Windows.Forms.Button
        Me.cmd_buscar_NDB = New System.Windows.Forms.Button
        Me.cmd_buscar_NCR = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.EstadoSII = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Glosa_Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cod_Error = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GlosaError = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nro_Fact = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(341, 102)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(150, 18)
        Me.Label21.TabIndex = 187
        Me.Label21.Text = "FACTURAS DE COMPRA"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(248, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 18)
        Me.Label19.TabIndex = 185
        Me.Label19.Text = "REVISANDO...."
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(431, 16)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox2.TabIndex = 182
        Me.CheckBox2.Text = "Verificar NDB"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(216, 8)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(86, 17)
        Me.CheckBox3.TabIndex = 181
        Me.CheckBox3.Text = "Verificar FEL"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(399, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox1.TabIndex = 180
        Me.CheckBox1.Text = "Verificar NCR"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(733, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 20)
        Me.TextBox2.TabIndex = 141
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(527, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 138
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(624, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 15)
        Me.Label18.TabIndex = 177
        Me.Label18.Text = "FOLIOS CON PROBLEMAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(990, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Rut Repres."
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
        Me.grilla2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EstadoSII, Me.Glosa_Estado, Me.Cod_Error, Me.GlosaError, Me.Nro_Fact})
        Me.grilla2.Location = New System.Drawing.Point(562, 123)
        Me.grilla2.Name = "grilla2"
        Me.grilla2.ReadOnly = True
        Me.grilla2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.grilla2.Size = New System.Drawing.Size(652, 487)
        Me.grilla2.TabIndex = 175
        '
        'Timer1
        '
        Me.Timer1.Interval = 100000
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(113, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 171
        Me.Label15.Text = "Label15"
        '
        'grilla
        '
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(12, 123)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grilla.Size = New System.Drawing.Size(534, 487)
        Me.grilla.TabIndex = 169
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Revisando Folio:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(956, 9)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(85, 20)
        Me.TextBox9.TabIndex = 167
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(71, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 166
        Me.Label14.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(30, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "Label13"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(30, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 162
        Me.Label11.Text = "Label11"
        '
        'cbo_mes
        '
        Me.cbo_mes.FormattingEnabled = True
        Me.cbo_mes.Location = New System.Drawing.Point(39, 27)
        Me.cbo_mes.Name = "cbo_mes"
        Me.cbo_mes.Size = New System.Drawing.Size(160, 21)
        Me.cbo_mes.TabIndex = 160
        Me.cbo_mes.Text = "cbo_mes"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(216, 31)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(260, 19)
        Me.TextBox14.TabIndex = 159
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(921, 8)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(200, 20)
        Me.TextBox13.TabIndex = 157
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(534, 78)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(34, 20)
        Me.TextBox12.TabIndex = 156
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(534, 97)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 155
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(627, 81)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 154
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(1094, 82)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(19, 20)
        Me.TextBox7.TabIndex = 153
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(988, 82)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 152
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(1094, 61)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(19, 20)
        Me.TextBox5.TabIndex = 151
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(988, 59)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 150
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(640, 15)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(19, 20)
        Me.TextBox4.TabIndex = 149
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(534, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(464, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Monto Dte"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(574, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Fecha Dte"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(464, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Tipo Dte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(918, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Rut Receptor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(918, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Rut Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(680, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Token"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Semilla"
        '
        'cmd_expexcel
        '
        Me.cmd_expexcel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_expexcel.Image = CType(resources.GetObject("cmd_expexcel.Image"), System.Drawing.Image)
        Me.cmd_expexcel.Location = New System.Drawing.Point(693, 39)
        Me.cmd_expexcel.Name = "cmd_expexcel"
        Me.cmd_expexcel.Size = New System.Drawing.Size(100, 53)
        Me.cmd_expexcel.TabIndex = 176
        Me.cmd_expexcel.Text = "Exp Excel"
        Me.cmd_expexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_expexcel.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancelar.Image = CType(resources.GetObject("cmd_cancelar.Image"), System.Drawing.Image)
        Me.cmd_cancelar.Location = New System.Drawing.Point(812, 38)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(100, 51)
        Me.cmd_cancelar.TabIndex = 173
        Me.cmd_cancelar.Text = "CANCELAR"
        Me.cmd_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(468, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 55)
        Me.Button1.TabIndex = 168
        Me.Button1.Text = "CONSULTA DTE"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.Image = CType(resources.GetObject("cmd_buscar.Image"), System.Drawing.Image)
        Me.cmd_buscar.Location = New System.Drawing.Point(358, 38)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(100, 54)
        Me.cmd_buscar.TabIndex = 165
        Me.cmd_buscar.Text = "BUSCAR"
        Me.cmd_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_limpiar.Image = CType(resources.GetObject("cmd_limpiar.Image"), System.Drawing.Image)
        Me.cmd_limpiar.Location = New System.Drawing.Point(577, 38)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(100, 54)
        Me.cmd_limpiar.TabIndex = 158
        Me.cmd_limpiar.Text = "LIMPIAR"
        Me.cmd_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_buscar_NDB
        '
        Me.cmd_buscar_NDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_buscar_NDB.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar_NDB.Image = CType(resources.GetObject("cmd_buscar_NDB.Image"), System.Drawing.Image)
        Me.cmd_buscar_NDB.Location = New System.Drawing.Point(358, 38)
        Me.cmd_buscar_NDB.Name = "cmd_buscar_NDB"
        Me.cmd_buscar_NDB.Size = New System.Drawing.Size(100, 54)
        Me.cmd_buscar_NDB.TabIndex = 179
        Me.cmd_buscar_NDB.Text = "BUSCAR"
        Me.cmd_buscar_NDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_buscar_NDB.UseVisualStyleBackColor = False
        '
        'cmd_buscar_NCR
        '
        Me.cmd_buscar_NCR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_buscar_NCR.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar_NCR.Image = CType(resources.GetObject("cmd_buscar_NCR.Image"), System.Drawing.Image)
        Me.cmd_buscar_NCR.Location = New System.Drawing.Point(358, 38)
        Me.cmd_buscar_NCR.Name = "cmd_buscar_NCR"
        Me.cmd_buscar_NCR.Size = New System.Drawing.Size(100, 54)
        Me.cmd_buscar_NCR.TabIndex = 178
        Me.cmd_buscar_NCR.Text = "BUSCAR"
        Me.cmd_buscar_NCR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_buscar_NCR.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(467, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 55)
        Me.Button3.TabIndex = 184
        Me.Button3.Text = "CONSULTA DTE"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(468, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 55)
        Me.Button2.TabIndex = 183
        Me.Button2.Text = "CONSULTA DTE"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'EstadoSII
        '
        Me.EstadoSII.HeaderText = "Estado SII"
        Me.EstadoSII.Name = "EstadoSII"
        Me.EstadoSII.ReadOnly = True
        Me.EstadoSII.Width = 81
        '
        'Glosa_Estado
        '
        Me.Glosa_Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Glosa_Estado.HeaderText = "Glosa Estado"
        Me.Glosa_Estado.Name = "Glosa_Estado"
        Me.Glosa_Estado.ReadOnly = True
        Me.Glosa_Estado.Width = 95
        '
        'Cod_Error
        '
        Me.Cod_Error.HeaderText = "Cod.Error"
        Me.Cod_Error.Name = "Cod_Error"
        Me.Cod_Error.ReadOnly = True
        Me.Cod_Error.Width = 76
        '
        'GlosaError
        '
        Me.GlosaError.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GlosaError.HeaderText = "Glosa Error"
        Me.GlosaError.Name = "GlosaError"
        Me.GlosaError.ReadOnly = True
        Me.GlosaError.Width = 84
        '
        'Nro_Fact
        '
        Me.Nro_Fact.HeaderText = "Nro Fact"
        Me.Nro_Fact.Name = "Nro_Fact"
        Me.Nro_Fact.ReadOnly = True
        Me.Nro_Fact.Width = 73
        '
        'frm_mes_cint_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 668)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cmd_expexcel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grilla2)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbo_mes)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_buscar_NDB)
        Me.Controls.Add(Me.cmd_buscar_NCR)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_mes_cint_compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE DOCUMENTOS ELECTRONICOS DE COMPRAS\FOLIOS DEL MES"
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_expexcel As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grilla2 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbo_mes As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_NDB As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_NCR As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents EstadoSII As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Glosa_Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod_Error As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GlosaError As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro_Fact As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
