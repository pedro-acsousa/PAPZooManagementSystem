<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim Num_compraLabel As System.Windows.Forms.Label
        Dim Data_compraLabel As System.Windows.Forms.Label
        Dim FuncionarioencomendaLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim EstadocompraLabel As System.Windows.Forms.Label
        Dim AnimaldestinoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.JardimzoologicoDataSet = New JardimZoologico.jardimzoologicoDataSet()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.ComprasTableAdapter()
        Me.TableAdapterManager = New JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager()
        Me.Detalhe_comprasTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.Detalhe_comprasTableAdapter()
        Me.ComprasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.primeiro = New System.Windows.Forms.ToolStripButton()
        Me.anterior = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.seguinte = New System.Windows.Forms.ToolStripButton()
        Me.ultimo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ComprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.num_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.funcionarioencomenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadocompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.animaldestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalhe_comprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalhe_comprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_compra1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.artigo_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade_encomendada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalpreco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_compraTextBox = New System.Windows.Forms.TextBox()
        Me.Data_compraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.EstadocompraComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.AnimaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FuncionariosTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.FuncionariosTableAdapter()
        Me.AnimaisTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.AnimaisTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Num_compraLabel = New System.Windows.Forms.Label()
        Data_compraLabel = New System.Windows.Forms.Label()
        FuncionarioencomendaLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        EstadocompraLabel = New System.Windows.Forms.Label()
        AnimaldestinoLabel = New System.Windows.Forms.Label()
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComprasBindingNavigator.SuspendLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalhe_comprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalhe_comprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AnimaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Num_compraLabel
        '
        Num_compraLabel.AutoSize = True
        Num_compraLabel.Location = New System.Drawing.Point(6, 16)
        Num_compraLabel.Name = "Num_compraLabel"
        Num_compraLabel.Size = New System.Drawing.Size(61, 13)
        Num_compraLabel.TabIndex = 3
        Num_compraLabel.Text = "Nº Compra:"
        '
        'Data_compraLabel
        '
        Data_compraLabel.AutoSize = True
        Data_compraLabel.Location = New System.Drawing.Point(1, 44)
        Data_compraLabel.Name = "Data_compraLabel"
        Data_compraLabel.Size = New System.Drawing.Size(66, 13)
        Data_compraLabel.TabIndex = 5
        Data_compraLabel.Text = "Data Fatura:"
        '
        'FuncionarioencomendaLabel
        '
        FuncionarioencomendaLabel.AutoSize = True
        FuncionarioencomendaLabel.Location = New System.Drawing.Point(13, 71)
        FuncionarioencomendaLabel.Name = "FuncionarioencomendaLabel"
        FuncionarioencomendaLabel.Size = New System.Drawing.Size(52, 13)
        FuncionarioencomendaLabel.TabIndex = 7
        FuncionarioencomendaLabel.Text = "Nº Func.:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(270, 102)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 9
        ValorLabel.Text = "Valor:"
        '
        'EstadocompraLabel
        '
        EstadocompraLabel.AutoSize = True
        EstadocompraLabel.Location = New System.Drawing.Point(354, 16)
        EstadocompraLabel.Name = "EstadocompraLabel"
        EstadocompraLabel.Size = New System.Drawing.Size(43, 13)
        EstadocompraLabel.TabIndex = 11
        EstadocompraLabel.Text = "Estado:"
        '
        'AnimaldestinoLabel
        '
        AnimaldestinoLabel.AutoSize = True
        AnimaldestinoLabel.Location = New System.Drawing.Point(317, 47)
        AnimaldestinoLabel.Name = "AnimaldestinoLabel"
        AnimaldestinoLabel.Size = New System.Drawing.Size(80, 13)
        AnimaldestinoLabel.TabIndex = 13
        AnimaldestinoLabel.Text = "Animal Destino:"
        '
        'JardimzoologicoDataSet
        '
        Me.JardimzoologicoDataSet.DataSetName = "jardimzoologicoDataSet"
        Me.JardimzoologicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnimaisTableAdapter = Nothing
        Me.TableAdapterManager.ArtigosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BilheteiraTableAdapter = Nothing
        Me.TableAdapterManager.BilheteTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.Detalhe_comprasTableAdapter = Me.Detalhe_comprasTableAdapter
        Me.TableAdapterManager.FuncionariosTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Detalhe_comprasTableAdapter
        '
        Me.Detalhe_comprasTableAdapter.ClearBeforeFill = True
        '
        'ComprasBindingNavigator
        '
        Me.ComprasBindingNavigator.AddNewItem = Nothing
        Me.ComprasBindingNavigator.BindingSource = Me.ComprasBindingSource
        Me.ComprasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ComprasBindingNavigator.DeleteItem = Nothing
        Me.ComprasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.primeiro, Me.anterior, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.seguinte, Me.ultimo, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ComprasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComprasBindingNavigator.MoveFirstItem = Me.primeiro
        Me.ComprasBindingNavigator.MoveLastItem = Me.ultimo
        Me.ComprasBindingNavigator.MoveNextItem = Me.seguinte
        Me.ComprasBindingNavigator.MovePreviousItem = Me.anterior
        Me.ComprasBindingNavigator.Name = "ComprasBindingNavigator"
        Me.ComprasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ComprasBindingNavigator.Size = New System.Drawing.Size(644, 25)
        Me.ComprasBindingNavigator.TabIndex = 0
        Me.ComprasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'primeiro
        '
        Me.primeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.primeiro.Image = CType(resources.GetObject("primeiro.Image"), System.Drawing.Image)
        Me.primeiro.Name = "primeiro"
        Me.primeiro.RightToLeftAutoMirrorImage = True
        Me.primeiro.Size = New System.Drawing.Size(23, 22)
        Me.primeiro.Text = "Move first"
        '
        'anterior
        '
        Me.anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.anterior.Image = CType(resources.GetObject("anterior.Image"), System.Drawing.Image)
        Me.anterior.Name = "anterior"
        Me.anterior.RightToLeftAutoMirrorImage = True
        Me.anterior.Size = New System.Drawing.Size(23, 22)
        Me.anterior.Text = "Move previous"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.ReadOnly = True
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'seguinte
        '
        Me.seguinte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.seguinte.Image = CType(resources.GetObject("seguinte.Image"), System.Drawing.Image)
        Me.seguinte.Name = "seguinte"
        Me.seguinte.RightToLeftAutoMirrorImage = True
        Me.seguinte.Size = New System.Drawing.Size(23, 22)
        Me.seguinte.Text = "Move next"
        '
        'ultimo
        '
        Me.ultimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ultimo.Image = CType(resources.GetObject("ultimo.Image"), System.Drawing.Image)
        Me.ultimo.Name = "ultimo"
        Me.ultimo.RightToLeftAutoMirrorImage = True
        Me.ultimo.Size = New System.Drawing.Size(23, 22)
        Me.ultimo.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripButton1.Text = "Criar Compra"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripButton2.Text = "Gravar Compra"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton3.Text = "Cancelar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripButton4.Text = "Editar Compra"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButton5.Text = "Apagar Compra"
        '
        'ComprasDataGridView
        '
        Me.ComprasDataGridView.AutoGenerateColumns = False
        Me.ComprasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_compra, Me.data_compra, Me.funcionarioencomenda, Me.valor, Me.estadocompra, Me.animaldestino})
        Me.ComprasDataGridView.DataSource = Me.ComprasBindingSource
        Me.ComprasDataGridView.Location = New System.Drawing.Point(10, 32)
        Me.ComprasDataGridView.Name = "ComprasDataGridView"
        Me.ComprasDataGridView.ReadOnly = True
        Me.ComprasDataGridView.Size = New System.Drawing.Size(543, 177)
        Me.ComprasDataGridView.TabIndex = 1
        '
        'num_compra
        '
        Me.num_compra.DataPropertyName = "num_compra"
        Me.num_compra.HeaderText = "Nº"
        Me.num_compra.Name = "num_compra"
        Me.num_compra.ReadOnly = True
        Me.num_compra.Width = 50
        '
        'data_compra
        '
        Me.data_compra.DataPropertyName = "data_compra"
        Me.data_compra.HeaderText = "Data Compra"
        Me.data_compra.Name = "data_compra"
        Me.data_compra.ReadOnly = True
        '
        'funcionarioencomenda
        '
        Me.funcionarioencomenda.DataPropertyName = "funcionarioencomenda"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.funcionarioencomenda.DefaultCellStyle = DataGridViewCellStyle1
        Me.funcionarioencomenda.HeaderText = "Funcionário que encomendou"
        Me.funcionarioencomenda.Name = "funcionarioencomenda"
        Me.funcionarioencomenda.ReadOnly = True
        '
        'valor
        '
        Me.valor.DataPropertyName = "valor"
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Width = 75
        '
        'estadocompra
        '
        Me.estadocompra.DataPropertyName = "estadocompra"
        Me.estadocompra.HeaderText = "Estado"
        Me.estadocompra.Name = "estadocompra"
        Me.estadocompra.ReadOnly = True
        '
        'animaldestino
        '
        Me.animaldestino.DataPropertyName = "animaldestino"
        Me.animaldestino.HeaderText = "NºAnimal"
        Me.animaldestino.Name = "animaldestino"
        Me.animaldestino.ReadOnly = True
        Me.animaldestino.Width = 75
        '
        'Detalhe_comprasBindingSource
        '
        Me.Detalhe_comprasBindingSource.DataMember = "ComprasDetalhe_compras"
        Me.Detalhe_comprasBindingSource.DataSource = Me.ComprasBindingSource
        '
        'Detalhe_comprasDataGridView
        '
        Me.Detalhe_comprasDataGridView.AutoGenerateColumns = False
        Me.Detalhe_comprasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Detalhe_comprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalhe_comprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.num_compra1, Me.artigo_num, Me.preco, Me.quantidade_encomendada, Me.totalpreco})
        Me.Detalhe_comprasDataGridView.DataSource = Me.Detalhe_comprasBindingSource
        Me.Detalhe_comprasDataGridView.Location = New System.Drawing.Point(59, 364)
        Me.Detalhe_comprasDataGridView.Name = "Detalhe_comprasDataGridView"
        Me.Detalhe_comprasDataGridView.ReadOnly = True
        Me.Detalhe_comprasDataGridView.Size = New System.Drawing.Size(458, 163)
        Me.Detalhe_comprasDataGridView.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'num_compra1
        '
        Me.num_compra1.DataPropertyName = "num_compra"
        Me.num_compra1.HeaderText = "NºCompra"
        Me.num_compra1.Name = "num_compra1"
        Me.num_compra1.ReadOnly = True
        Me.num_compra1.Width = 65
        '
        'artigo_num
        '
        Me.artigo_num.DataPropertyName = "artigo_num"
        Me.artigo_num.HeaderText = "Art. Nº"
        Me.artigo_num.Name = "artigo_num"
        Me.artigo_num.ReadOnly = True
        Me.artigo_num.Width = 75
        '
        'preco
        '
        Me.preco.DataPropertyName = "preco"
        Me.preco.HeaderText = "Preço"
        Me.preco.Name = "preco"
        Me.preco.ReadOnly = True
        Me.preco.Width = 75
        '
        'quantidade_encomendada
        '
        Me.quantidade_encomendada.DataPropertyName = "quantidade_encomendada"
        Me.quantidade_encomendada.HeaderText = "Quant."
        Me.quantidade_encomendada.Name = "quantidade_encomendada"
        Me.quantidade_encomendada.ReadOnly = True
        Me.quantidade_encomendada.Width = 50
        '
        'totalpreco
        '
        Me.totalpreco.DataPropertyName = "totalpreco"
        Me.totalpreco.HeaderText = "Total"
        Me.totalpreco.Name = "totalpreco"
        Me.totalpreco.ReadOnly = True
        Me.totalpreco.Width = 50
        '
        'Num_compraTextBox
        '
        Me.Num_compraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "num_compra", True))
        Me.Num_compraTextBox.Location = New System.Drawing.Point(70, 13)
        Me.Num_compraTextBox.Name = "Num_compraTextBox"
        Me.Num_compraTextBox.ReadOnly = True
        Me.Num_compraTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Num_compraTextBox.TabIndex = 4
        '
        'Data_compraDateTimePicker
        '
        Me.Data_compraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource, "data_compra", True))
        Me.Data_compraDateTimePicker.Enabled = False
        Me.Data_compraDateTimePicker.Location = New System.Drawing.Point(70, 38)
        Me.Data_compraDateTimePicker.Name = "Data_compraDateTimePicker"
        Me.Data_compraDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Data_compraDateTimePicker.TabIndex = 6
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(309, 98)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.ReadOnly = True
        Me.ValorTextBox.Size = New System.Drawing.Size(64, 20)
        Me.ValorTextBox.TabIndex = 10
        '
        'EstadocompraComboBox
        '
        Me.EstadocompraComboBox.AutoCompleteCustomSource.AddRange(New String() {"Aguarda pagamento", "Paga", "Entregue", "Cancelada"})
        Me.EstadocompraComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EstadocompraComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadocompraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "estadocompra", True))
        Me.EstadocompraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadocompraComboBox.FormattingEnabled = True
        Me.EstadocompraComboBox.Items.AddRange(New Object() {"Aguarda pagamento", "Paga", "Entregue", "Cancelada"})
        Me.EstadocompraComboBox.Location = New System.Drawing.Point(403, 13)
        Me.EstadocompraComboBox.Name = "EstadocompraComboBox"
        Me.EstadocompraComboBox.Size = New System.Drawing.Size(120, 21)
        Me.EstadocompraComboBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Detalhe:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Num_compraLabel)
        Me.GroupBox1.Controls.Add(Me.Num_compraTextBox)
        Me.GroupBox1.Controls.Add(AnimaldestinoLabel)
        Me.GroupBox1.Controls.Add(Me.Data_compraDateTimePicker)
        Me.GroupBox1.Controls.Add(Data_compraLabel)
        Me.GroupBox1.Controls.Add(EstadocompraLabel)
        Me.GroupBox1.Controls.Add(Me.EstadocompraComboBox)
        Me.GroupBox1.Controls.Add(FuncionarioencomendaLabel)
        Me.GroupBox1.Controls.Add(ValorLabel)
        Me.GroupBox1.Controls.Add(Me.ValorTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 123)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(403, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 37)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Modificar Produtos na fatura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "animaldestino", True))
        Me.ComboBox4.DataSource = Me.AnimaisBindingSource
        Me.ComboBox4.DisplayMember = "nome_animal"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(451, 41)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox4.TabIndex = 22
        Me.ComboBox4.ValueMember = "cod_animal"
        '
        'AnimaisBindingSource
        '
        Me.AnimaisBindingSource.DataMember = "Animais"
        Me.AnimaisBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "animaldestino", True))
        Me.ComboBox3.DataSource = Me.AnimaisBindingSource
        Me.ComboBox3.DisplayMember = "cod_animal"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(403, 41)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(44, 21)
        Me.ComboBox3.TabIndex = 21
        Me.ComboBox3.ValueMember = "cod_animal"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "funcionarioencomenda", True))
        Me.ComboBox2.DataSource = Me.FuncionariosBindingSource
        Me.ComboBox2.DisplayMember = "num_funcionario"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(70, 68)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox2.TabIndex = 20
        Me.ComboBox2.ValueMember = "num_funcionario"
        '
        'FuncionariosBindingSource
        '
        Me.FuncionariosBindingSource.DataMember = "Funcionarios"
        Me.FuncionariosBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "funcionarioencomenda", True))
        Me.ComboBox1.DataSource = Me.FuncionariosBindingSource
        Me.ComboBox1.DisplayMember = "nome"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(150, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "num_funcionario"
        '
        'FuncionariosTableAdapter
        '
        Me.FuncionariosTableAdapter.ClearBeforeFill = True
        '
        'AnimaisTableAdapter
        '
        Me.AnimaisTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(644, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(128, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(644, 561)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Detalhe_comprasDataGridView)
        Me.Controls.Add(Me.ComprasDataGridView)
        Me.Controls.Add(Me.ComprasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Compras"
        Me.Text = "                                                                                 " & _
    "                                                                                " & _
    "                          "
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComprasBindingNavigator.ResumeLayout(False)
        Me.ComprasBindingNavigator.PerformLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalhe_comprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalhe_comprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AnimaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JardimzoologicoDataSet As JardimZoologico.jardimzoologicoDataSet
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents TableAdapterManager As JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents primeiro As System.Windows.Forms.ToolStripButton
    Friend WithEvents anterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents seguinte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ultimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ComprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Detalhe_comprasTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.Detalhe_comprasTableAdapter
    Friend WithEvents num_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents funcionarioencomenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estadocompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents animaldestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalhe_comprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Detalhe_comprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_compra1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents artigo_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantidade_encomendada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalpreco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Num_compraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_compraDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadocompraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FuncionariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionariosTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents AnimaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnimaisTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.AnimaisTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
