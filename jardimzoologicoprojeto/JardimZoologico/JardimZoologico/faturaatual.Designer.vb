<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class faturaatual
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
        Dim Nome_aLabel As System.Windows.Forms.Label
        Dim Preco_aLabel As System.Windows.Forms.Label
        Dim Stock_aLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(faturaatual))
        Me.JardimzoologicoDataSet = New JardimZoologico.jardimzoologicoDataSet()
        Me.Detalhe_comprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalhe_comprasTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.Detalhe_comprasTableAdapter()
        Me.TableAdapterManager = New JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager()
        Me.ArtigosTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.ArtigosTableAdapter()
        Me.Detalhe_comprasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Detalhe_comprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.artigo_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade_encomendada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalpreco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalhe_comprasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ArtigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nome_aComboBox = New System.Windows.Forms.ComboBox()
        Me.Preco_aTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_aTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComprasTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.ComprasTableAdapter()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Nome_aLabel = New System.Windows.Forms.Label()
        Preco_aLabel = New System.Windows.Forms.Label()
        Stock_aLabel = New System.Windows.Forms.Label()
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalhe_comprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalhe_comprasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Detalhe_comprasBindingNavigator.SuspendLayout()
        CType(Me.Detalhe_comprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalhe_comprasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nome_aLabel
        '
        Nome_aLabel.AutoSize = True
        Nome_aLabel.Location = New System.Drawing.Point(15, 21)
        Nome_aLabel.Name = "Nome_aLabel"
        Nome_aLabel.Size = New System.Drawing.Size(130, 16)
        Nome_aLabel.TabIndex = 4
        Nome_aLabel.Text = "Nome Artigo a inserir:"
        '
        'Preco_aLabel
        '
        Preco_aLabel.AutoSize = True
        Preco_aLabel.Location = New System.Drawing.Point(65, 70)
        Preco_aLabel.Name = "Preco_aLabel"
        Preco_aLabel.Size = New System.Drawing.Size(80, 16)
        Preco_aLabel.TabIndex = 6
        Preco_aLabel.Text = "Preço Artigo:"
        '
        'Stock_aLabel
        '
        Stock_aLabel.AutoSize = True
        Stock_aLabel.Location = New System.Drawing.Point(376, 26)
        Stock_aLabel.Name = "Stock_aLabel"
        Stock_aLabel.Size = New System.Drawing.Size(82, 16)
        Stock_aLabel.TabIndex = 8
        Stock_aLabel.Text = "Stock Artigo:"
        '
        'JardimzoologicoDataSet
        '
        Me.JardimzoologicoDataSet.DataSetName = "jardimzoologicoDataSet"
        Me.JardimzoologicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalhe_comprasBindingSource
        '
        Me.Detalhe_comprasBindingSource.DataMember = "Detalhe_compras"
        Me.Detalhe_comprasBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'Detalhe_comprasTableAdapter
        '
        Me.Detalhe_comprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnimaisTableAdapter = Nothing
        Me.TableAdapterManager.ArtigosTableAdapter = Me.ArtigosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.Detalhe_comprasTableAdapter = Me.Detalhe_comprasTableAdapter
        Me.TableAdapterManager.FuncionariosTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtigosTableAdapter
        '
        Me.ArtigosTableAdapter.ClearBeforeFill = True
        '
        'Detalhe_comprasBindingNavigator
        '
        Me.Detalhe_comprasBindingNavigator.AddNewItem = Nothing
        Me.Detalhe_comprasBindingNavigator.BindingSource = Me.Detalhe_comprasBindingSource
        Me.Detalhe_comprasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Detalhe_comprasBindingNavigator.DeleteItem = Nothing
        Me.Detalhe_comprasBindingNavigator.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detalhe_comprasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorSeparator2, Me.ToolStripLabel2, Me.ToolStripLabel1})
        Me.Detalhe_comprasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Detalhe_comprasBindingNavigator.MoveFirstItem = Nothing
        Me.Detalhe_comprasBindingNavigator.MoveLastItem = Nothing
        Me.Detalhe_comprasBindingNavigator.MoveNextItem = Nothing
        Me.Detalhe_comprasBindingNavigator.MovePreviousItem = Nothing
        Me.Detalhe_comprasBindingNavigator.Name = "Detalhe_comprasBindingNavigator"
        Me.Detalhe_comprasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Detalhe_comprasBindingNavigator.Size = New System.Drawing.Size(527, 25)
        Me.Detalhe_comprasBindingNavigator.TabIndex = 0
        Me.Detalhe_comprasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BindingNavigatorPositionItem.ReadOnly = True
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripLabel2.Text = "Encomenda para o animal.  "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'Detalhe_comprasDataGridView
        '
        Me.Detalhe_comprasDataGridView.AutoGenerateColumns = False
        Me.Detalhe_comprasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Detalhe_comprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalhe_comprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.num_compra, Me.artigo_num, Me.preco, Me.quantidade_encomendada, Me.totalpreco})
        Me.Detalhe_comprasDataGridView.DataSource = Me.Detalhe_comprasBindingSource1
        Me.Detalhe_comprasDataGridView.Location = New System.Drawing.Point(43, 155)
        Me.Detalhe_comprasDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Detalhe_comprasDataGridView.Name = "Detalhe_comprasDataGridView"
        Me.Detalhe_comprasDataGridView.Size = New System.Drawing.Size(428, 233)
        Me.Detalhe_comprasDataGridView.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 50
        '
        'num_compra
        '
        Me.num_compra.DataPropertyName = "num_compra"
        Me.num_compra.HeaderText = "NºFatura"
        Me.num_compra.Name = "num_compra"
        Me.num_compra.Width = 75
        '
        'artigo_num
        '
        Me.artigo_num.DataPropertyName = "artigo_num"
        Me.artigo_num.HeaderText = "NºArtigo"
        Me.artigo_num.Name = "artigo_num"
        Me.artigo_num.Width = 75
        '
        'preco
        '
        Me.preco.DataPropertyName = "preco"
        Me.preco.HeaderText = "Preço"
        Me.preco.Name = "preco"
        Me.preco.Width = 50
        '
        'quantidade_encomendada
        '
        Me.quantidade_encomendada.DataPropertyName = "quantidade_encomendada"
        Me.quantidade_encomendada.HeaderText = "Quant. Encomendada"
        Me.quantidade_encomendada.Name = "quantidade_encomendada"
        Me.quantidade_encomendada.Width = 85
        '
        'totalpreco
        '
        Me.totalpreco.DataPropertyName = "totalpreco"
        Me.totalpreco.HeaderText = "Preço total"
        Me.totalpreco.Name = "totalpreco"
        Me.totalpreco.Width = 50
        '
        'Detalhe_comprasBindingSource1
        '
        Me.Detalhe_comprasBindingSource1.DataMember = "ComprasDetalhe_compras"
        Me.Detalhe_comprasBindingSource1.DataSource = Me.ComprasBindingSource
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalhe_comprasBindingSource, "quantidade_encomendada", True))
        Me.TextBox1.Location = New System.Drawing.Point(105, 126)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 23)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inserir Quantidade"
        '
        'ArtigosBindingSource
        '
        Me.ArtigosBindingSource.DataMember = "Artigos"
        Me.ArtigosBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'Nome_aComboBox
        '
        Me.Nome_aComboBox.BackColor = System.Drawing.Color.White
        Me.Nome_aComboBox.DataSource = Me.ArtigosBindingSource
        Me.Nome_aComboBox.DisplayMember = "nome_a"
        Me.Nome_aComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nome_aComboBox.FormattingEnabled = True
        Me.Nome_aComboBox.Location = New System.Drawing.Point(152, 18)
        Me.Nome_aComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_aComboBox.Name = "Nome_aComboBox"
        Me.Nome_aComboBox.Size = New System.Drawing.Size(112, 24)
        Me.Nome_aComboBox.TabIndex = 5
        Me.Nome_aComboBox.ValueMember = "cod_a"
        '
        'Preco_aTextBox
        '
        Me.Preco_aTextBox.BackColor = System.Drawing.Color.White
        Me.Preco_aTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "preco_a", True))
        Me.Preco_aTextBox.Location = New System.Drawing.Point(152, 66)
        Me.Preco_aTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Preco_aTextBox.Name = "Preco_aTextBox"
        Me.Preco_aTextBox.ReadOnly = True
        Me.Preco_aTextBox.Size = New System.Drawing.Size(112, 23)
        Me.Preco_aTextBox.TabIndex = 7
        '
        'Stock_aTextBox
        '
        Me.Stock_aTextBox.BackColor = System.Drawing.Color.White
        Me.Stock_aTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "stock_a", True))
        Me.Stock_aTextBox.Location = New System.Drawing.Point(359, 50)
        Me.Stock_aTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Stock_aTextBox.Name = "Stock_aTextBox"
        Me.Stock_aTextBox.ReadOnly = True
        Me.Stock_aTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Stock_aTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(392, 89)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 55)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(68, 396)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 52)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(151, 395)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 54)
        Me.Button3.TabIndex = 12
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DataSource = Me.ArtigosBindingSource
        Me.ComboBox1.DisplayMember = "cod_a"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(271, 18)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(53, 24)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "cod_a"
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "valor", True))
        Me.TextBox2.Location = New System.Drawing.Point(378, 406)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(116, 23)
        Me.TextBox2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Total"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(141, 508)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 49)
        Me.Button4.TabIndex = 16
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(374, 503)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(140, 81)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenar Produtos por"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(20, 52)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 20)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Preço"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(20, 23)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 20)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "NºArtigo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Detalhe_comprasDataGridView)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Nome_aComboBox)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Nome_aLabel)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Preco_aTextBox)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Preco_aLabel)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Stock_aTextBox)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Stock_aLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 34)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(506, 458)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(307, 89)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 55)
        Me.Button5.TabIndex = 16
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'faturaatual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(527, 591)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Detalhe_comprasBindingNavigator)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "faturaatual"
        Me.Text = "faturaatual"
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalhe_comprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalhe_comprasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Detalhe_comprasBindingNavigator.ResumeLayout(False)
        Me.Detalhe_comprasBindingNavigator.PerformLayout()
        CType(Me.Detalhe_comprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalhe_comprasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JardimzoologicoDataSet As JardimZoologico.jardimzoologicoDataSet
    Friend WithEvents Detalhe_comprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Detalhe_comprasTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.Detalhe_comprasTableAdapter
    Friend WithEvents TableAdapterManager As JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Detalhe_comprasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Detalhe_comprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ArtigosTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.ArtigosTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ArtigosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nome_aComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Preco_aTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_aTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents Detalhe_comprasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents artigo_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantidade_encomendada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalpreco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
