<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class animais
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Nome_animalLabel As System.Windows.Forms.Label
        Dim Datanas_animalLabel As System.Windows.Forms.Label
        Dim Especie_animalLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(animais))
        Me.AnimaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AnimaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JardimzoologicoDataSet = New JardimZoologico.jardimzoologicoDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnimaisDataGridView = New System.Windows.Forms.DataGridView()
        Me.cod_animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datanas_animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.especie_animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Nome_animalTextBox = New System.Windows.Forms.TextBox()
        Me.Datanas_animalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Especie_animalTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AnimaisTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.AnimaisTableAdapter()
        Me.TableAdapterManager = New JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Nome_animalLabel = New System.Windows.Forms.Label()
        Datanas_animalLabel = New System.Windows.Forms.Label()
        Especie_animalLabel = New System.Windows.Forms.Label()
        CType(Me.AnimaisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnimaisBindingNavigator.SuspendLayout()
        CType(Me.AnimaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimaisDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_animalLabel
        '
        Nome_animalLabel.AutoSize = True
        Nome_animalLabel.Location = New System.Drawing.Point(325, 423)
        Nome_animalLabel.Name = "Nome_animalLabel"
        Nome_animalLabel.Size = New System.Drawing.Size(100, 16)
        Nome_animalLabel.TabIndex = 9
        Nome_animalLabel.Text = "Nome do Animal:"
        '
        'Datanas_animalLabel
        '
        Datanas_animalLabel.AutoSize = True
        Datanas_animalLabel.Location = New System.Drawing.Point(351, 467)
        Datanas_animalLabel.Name = "Datanas_animalLabel"
        Datanas_animalLabel.Size = New System.Drawing.Size(74, 16)
        Datanas_animalLabel.TabIndex = 11
        Datanas_animalLabel.Text = "Data Nasc.:"
        '
        'Especie_animalLabel
        '
        Especie_animalLabel.AutoSize = True
        Especie_animalLabel.Location = New System.Drawing.Point(367, 507)
        Especie_animalLabel.Name = "Especie_animalLabel"
        Especie_animalLabel.Size = New System.Drawing.Size(52, 16)
        Especie_animalLabel.TabIndex = 13
        Especie_animalLabel.Text = "Espécie:"
        '
        'AnimaisBindingNavigator
        '
        Me.AnimaisBindingNavigator.AddNewItem = Nothing
        Me.AnimaisBindingNavigator.BackColor = System.Drawing.Color.White
        Me.AnimaisBindingNavigator.BindingSource = Me.AnimaisBindingSource
        Me.AnimaisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnimaisBindingNavigator.DeleteItem = Nothing
        Me.AnimaisBindingNavigator.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnimaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1})
        Me.AnimaisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnimaisBindingNavigator.MoveFirstItem = Nothing
        Me.AnimaisBindingNavigator.MoveLastItem = Nothing
        Me.AnimaisBindingNavigator.MoveNextItem = Nothing
        Me.AnimaisBindingNavigator.MovePreviousItem = Nothing
        Me.AnimaisBindingNavigator.Name = "AnimaisBindingNavigator"
        Me.AnimaisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnimaisBindingNavigator.Size = New System.Drawing.Size(583, 25)
        Me.AnimaisBindingNavigator.TabIndex = 0
        Me.AnimaisBindingNavigator.Text = "BindingNavigator1"
        '
        'AnimaisBindingSource
        '
        Me.AnimaisBindingSource.DataMember = "Animais"
        Me.AnimaisBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'JardimzoologicoDataSet
        '
        Me.JardimzoologicoDataSet.DataSetName = "jardimzoologicoDataSet"
        Me.JardimzoologicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(40, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.White
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AnimaisDataGridView
        '
        Me.AnimaisDataGridView.AutoGenerateColumns = False
        Me.AnimaisDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AnimaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnimaisDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_animal, Me.nome_animal, Me.datanas_animal, Me.especie_animal})
        Me.AnimaisDataGridView.DataSource = Me.AnimaisBindingSource
        Me.AnimaisDataGridView.Location = New System.Drawing.Point(63, 64)
        Me.AnimaisDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AnimaisDataGridView.Name = "AnimaisDataGridView"
        Me.AnimaisDataGridView.ReadOnly = True
        Me.AnimaisDataGridView.Size = New System.Drawing.Size(446, 271)
        Me.AnimaisDataGridView.TabIndex = 1
        '
        'cod_animal
        '
        Me.cod_animal.DataPropertyName = "cod_animal"
        Me.cod_animal.HeaderText = "Cód. Animal"
        Me.cod_animal.Name = "cod_animal"
        Me.cod_animal.ReadOnly = True
        '
        'nome_animal
        '
        Me.nome_animal.DataPropertyName = "nome_animal"
        Me.nome_animal.HeaderText = "Nome Animal"
        Me.nome_animal.Name = "nome_animal"
        Me.nome_animal.ReadOnly = True
        '
        'datanas_animal
        '
        Me.datanas_animal.DataPropertyName = "datanas_animal"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.datanas_animal.DefaultCellStyle = DataGridViewCellStyle1
        Me.datanas_animal.HeaderText = "Data Nasc. Animal"
        Me.datanas_animal.Name = "datanas_animal"
        Me.datanas_animal.ReadOnly = True
        '
        'especie_animal
        '
        Me.especie_animal.DataPropertyName = "especie_animal"
        Me.especie_animal.HeaderText = "Espécie"
        Me.especie_animal.Name = "especie_animal"
        Me.especie_animal.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.AnimaisBindingSource, "especie_foto", True))
        Me.PictureBox1.Location = New System.Drawing.Point(57, 358)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(141, 539)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 55)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(83, 688)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 60)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(240, 688)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 60)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(324, 688)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 60)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(408, 688)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 60)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(161, 688)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 60)
        Me.Button6.TabIndex = 8
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Nome_animalTextBox
        '
        Me.Nome_animalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimaisBindingSource, "nome_animal", True))
        Me.Nome_animalTextBox.Location = New System.Drawing.Point(430, 419)
        Me.Nome_animalTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_animalTextBox.Name = "Nome_animalTextBox"
        Me.Nome_animalTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Nome_animalTextBox.TabIndex = 10
        '
        'Datanas_animalDateTimePicker
        '
        Me.Datanas_animalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimaisBindingSource, "datanas_animal", True))
        Me.Datanas_animalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datanas_animalDateTimePicker.Location = New System.Drawing.Point(433, 460)
        Me.Datanas_animalDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Datanas_animalDateTimePicker.Name = "Datanas_animalDateTimePicker"
        Me.Datanas_animalDateTimePicker.Size = New System.Drawing.Size(116, 23)
        Me.Datanas_animalDateTimePicker.TabIndex = 12
        '
        'Especie_animalTextBox
        '
        Me.Especie_animalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimaisBindingSource, "especie_animal", True))
        Me.Especie_animalTextBox.Location = New System.Drawing.Point(432, 501)
        Me.Especie_animalTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Especie_animalTextBox.Name = "Especie_animalTextBox"
        Me.Especie_animalTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Especie_animalTextBox.TabIndex = 14
        '
        'Button7
        '
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(157, 621)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(123, 28)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Filtrar por espécie"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(297, 621)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(128, 28)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "Filtrar por Nome"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(170, 656)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 23)
        Me.TextBox1.TabIndex = 18
        '
        'AnimaisTableAdapter
        '
        Me.AnimaisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnimaisTableAdapter = Me.AnimaisTableAdapter
        Me.TableAdapterManager.ArtigosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BilheteiraTableAdapter = Nothing
        Me.TableAdapterManager.BilheteTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.Detalhe_comprasTableAdapter = Nothing
        Me.TableAdapterManager.FuncionariosTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(231, 34)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(29, 23)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "|<"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(266, 34)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(29, 23)
        Me.Button10.TabIndex = 20
        Me.Button10.Text = "<"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(301, 34)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(29, 23)
        Me.Button11.TabIndex = 21
        Me.Button11.Text = ">"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(336, 34)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(29, 23)
        Me.Button12.TabIndex = 22
        Me.Button12.Text = ">|"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'animais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(583, 750)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Especie_animalLabel)
        Me.Controls.Add(Me.Especie_animalTextBox)
        Me.Controls.Add(Datanas_animalLabel)
        Me.Controls.Add(Me.Datanas_animalDateTimePicker)
        Me.Controls.Add(Nome_animalLabel)
        Me.Controls.Add(Me.Nome_animalTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AnimaisDataGridView)
        Me.Controls.Add(Me.AnimaisBindingNavigator)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "animais"
        Me.Text = "Animais"
        CType(Me.AnimaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnimaisBindingNavigator.ResumeLayout(False)
        Me.AnimaisBindingNavigator.PerformLayout()
        CType(Me.AnimaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimaisDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JardimzoologicoDataSet As JardimZoologico.jardimzoologicoDataSet
    Friend WithEvents AnimaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnimaisTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.AnimaisTableAdapter
    Friend WithEvents TableAdapterManager As JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnimaisBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnimaisDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cod_animal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_animal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datanas_animal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents especie_animal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome_animalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datanas_animalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Especie_animalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
