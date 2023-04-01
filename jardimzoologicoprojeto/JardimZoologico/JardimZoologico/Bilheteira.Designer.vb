<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bilheteira
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
        Dim NumbilheteLabel As System.Windows.Forms.Label
        Dim PrecoLabel As System.Windows.Forms.Label
        Dim BilhetesdisponiveisLabel As System.Windows.Forms.Label
        Dim NomeclienteLabel As System.Windows.Forms.Label
        Dim IdadeLabel As System.Windows.Forms.Label
        Dim TipoclienteLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim ValidoLabel As System.Windows.Forms.Label
        Dim OperadorcaixaLabel As System.Windows.Forms.Label
        Dim CodbarrasnumLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bilheteira))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GerarBilheteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarGerarBilheteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarBilheteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarBilheteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirBilheteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilhetesDeHojeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilheteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BilheteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JardimzoologicoDataSet = New JardimZoologico.jardimzoologicoDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NumbilheteTextBox = New System.Windows.Forms.TextBox()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.BilhetesdisponiveisTextBox = New System.Windows.Forms.TextBox()
        Me.BilheteiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomeclienteTextBox = New System.Windows.Forms.TextBox()
        Me.IdadeTextBox = New System.Windows.Forms.TextBox()
        Me.TipoclienteComboBox = New System.Windows.Forms.ComboBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValidoTextBox = New System.Windows.Forms.TextBox()
        Me.OperadorcaixaTextBox = New System.Windows.Forms.TextBox()
        Me.BilheteDataGridView = New System.Windows.Forms.DataGridView()
        Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codbarrasnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomecliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipocliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operadorcaixa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numbilhete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilheteiraDataGridView = New System.Windows.Forms.DataGridView()
        Me.data1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataTextBox = New System.Windows.Forms.DateTimePicker()
        Me.CodbarrasnumTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BilheteTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.BilheteTableAdapter()
        Me.TableAdapterManager = New JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager()
        Me.BilheteiraTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.BilheteiraTableAdapter()
        NumbilheteLabel = New System.Windows.Forms.Label()
        PrecoLabel = New System.Windows.Forms.Label()
        BilhetesdisponiveisLabel = New System.Windows.Forms.Label()
        NomeclienteLabel = New System.Windows.Forms.Label()
        IdadeLabel = New System.Windows.Forms.Label()
        TipoclienteLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        ValidoLabel = New System.Windows.Forms.Label()
        OperadorcaixaLabel = New System.Windows.Forms.Label()
        CodbarrasnumLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BilheteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BilheteBindingNavigator.SuspendLayout()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteiraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumbilheteLabel
        '
        NumbilheteLabel.AutoSize = True
        NumbilheteLabel.Location = New System.Drawing.Point(51, 27)
        NumbilheteLabel.Name = "NumbilheteLabel"
        NumbilheteLabel.Size = New System.Drawing.Size(112, 16)
        NumbilheteLabel.TabIndex = 2
        NumbilheteLabel.Text = "Número do Bilhete:"
        '
        'PrecoLabel
        '
        PrecoLabel.AutoSize = True
        PrecoLabel.Location = New System.Drawing.Point(483, 484)
        PrecoLabel.Name = "PrecoLabel"
        PrecoLabel.Size = New System.Drawing.Size(42, 16)
        PrecoLabel.TabIndex = 4
        PrecoLabel.Text = "Preço:"
        '
        'BilhetesdisponiveisLabel
        '
        BilhetesdisponiveisLabel.AutoSize = True
        BilhetesdisponiveisLabel.Location = New System.Drawing.Point(294, 32)
        BilhetesdisponiveisLabel.Name = "BilhetesdisponiveisLabel"
        BilhetesdisponiveisLabel.Size = New System.Drawing.Size(168, 16)
        BilhetesdisponiveisLabel.TabIndex = 6
        BilhetesdisponiveisLabel.Text = "Bilhetes disponíveis para hoje:"
        '
        'NomeclienteLabel
        '
        NomeclienteLabel.AutoSize = True
        NomeclienteLabel.Location = New System.Drawing.Point(51, 79)
        NomeclienteLabel.Name = "NomeclienteLabel"
        NomeclienteLabel.Size = New System.Drawing.Size(101, 16)
        NomeclienteLabel.TabIndex = 8
        NomeclienteLabel.Text = "Nome do Cliente:"
        '
        'IdadeLabel
        '
        IdadeLabel.AutoSize = True
        IdadeLabel.Location = New System.Drawing.Point(112, 134)
        IdadeLabel.Name = "IdadeLabel"
        IdadeLabel.Size = New System.Drawing.Size(43, 16)
        IdadeLabel.TabIndex = 10
        IdadeLabel.Text = "Idade:"
        '
        'TipoclienteLabel
        '
        TipoclienteLabel.AutoSize = True
        TipoclienteLabel.Location = New System.Drawing.Point(59, 187)
        TipoclienteLabel.Name = "TipoclienteLabel"
        TipoclienteLabel.Size = New System.Drawing.Size(94, 16)
        TipoclienteLabel.TabIndex = 12
        TipoclienteLabel.Text = "Tipo de Bilhete:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(119, 238)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(38, 16)
        DataLabel.TabIndex = 14
        DataLabel.Text = "Data:"
        '
        'ValidoLabel
        '
        ValidoLabel.AutoSize = True
        ValidoLabel.Location = New System.Drawing.Point(117, 284)
        ValidoLabel.Name = "ValidoLabel"
        ValidoLabel.Size = New System.Drawing.Size(44, 16)
        ValidoLabel.TabIndex = 16
        ValidoLabel.Text = "Válido:"
        '
        'OperadorcaixaLabel
        '
        OperadorcaixaLabel.AutoSize = True
        OperadorcaixaLabel.Location = New System.Drawing.Point(98, 332)
        OperadorcaixaLabel.Name = "OperadorcaixaLabel"
        OperadorcaixaLabel.Size = New System.Drawing.Size(62, 16)
        OperadorcaixaLabel.TabIndex = 18
        OperadorcaixaLabel.Text = "Operador:"
        '
        'CodbarrasnumLabel
        '
        CodbarrasnumLabel.AutoSize = True
        CodbarrasnumLabel.Location = New System.Drawing.Point(84, 379)
        CodbarrasnumLabel.Name = "CodbarrasnumLabel"
        CodbarrasnumLabel.Size = New System.Drawing.Size(76, 16)
        CodbarrasnumLabel.TabIndex = 23
        CodbarrasnumLabel.Text = "Cód. Barras:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerarBilheteToolStripMenuItem, Me.CancelarGerarBilheteToolStripMenuItem, Me.GuardarBilheteToolStripMenuItem, Me.CancelarBilheteToolStripMenuItem, Me.ImprimirBilheteToolStripMenuItem, Me.BilhetesDeHojeToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GerarBilheteToolStripMenuItem
        '
        Me.GerarBilheteToolStripMenuItem.Image = CType(resources.GetObject("GerarBilheteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerarBilheteToolStripMenuItem.Name = "GerarBilheteToolStripMenuItem"
        Me.GerarBilheteToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.GerarBilheteToolStripMenuItem.Text = "Gerar Bilhete  |"
        '
        'CancelarGerarBilheteToolStripMenuItem
        '
        Me.CancelarGerarBilheteToolStripMenuItem.Image = CType(resources.GetObject("CancelarGerarBilheteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelarGerarBilheteToolStripMenuItem.Name = "CancelarGerarBilheteToolStripMenuItem"
        Me.CancelarGerarBilheteToolStripMenuItem.Size = New System.Drawing.Size(166, 20)
        Me.CancelarGerarBilheteToolStripMenuItem.Text = "Cancelar Gerar Bilhete    |"
        '
        'GuardarBilheteToolStripMenuItem
        '
        Me.GuardarBilheteToolStripMenuItem.Image = CType(resources.GetObject("GuardarBilheteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarBilheteToolStripMenuItem.Name = "GuardarBilheteToolStripMenuItem"
        Me.GuardarBilheteToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.GuardarBilheteToolStripMenuItem.Text = "  Guardar Bilhete  |"
        '
        'CancelarBilheteToolStripMenuItem
        '
        Me.CancelarBilheteToolStripMenuItem.Image = CType(resources.GetObject("CancelarBilheteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelarBilheteToolStripMenuItem.Name = "CancelarBilheteToolStripMenuItem"
        Me.CancelarBilheteToolStripMenuItem.Size = New System.Drawing.Size(134, 20)
        Me.CancelarBilheteToolStripMenuItem.Text = "  Invalidar Bilhete  |"
        '
        'ImprimirBilheteToolStripMenuItem
        '
        Me.ImprimirBilheteToolStripMenuItem.Image = CType(resources.GetObject("ImprimirBilheteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirBilheteToolStripMenuItem.Name = "ImprimirBilheteToolStripMenuItem"
        Me.ImprimirBilheteToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.ImprimirBilheteToolStripMenuItem.Text = "  Imprimir Bilhete  |"
        '
        'BilhetesDeHojeToolStripMenuItem
        '
        Me.BilhetesDeHojeToolStripMenuItem.Image = CType(resources.GetObject("BilhetesDeHojeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BilhetesDeHojeToolStripMenuItem.Name = "BilhetesDeHojeToolStripMenuItem"
        Me.BilhetesDeHojeToolStripMenuItem.Size = New System.Drawing.Size(160, 20)
        Me.BilhetesDeHojeToolStripMenuItem.Text = "Consulta de Bilhetes     |"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 20)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(12, 20)
        '
        'BilheteBindingNavigator
        '
        Me.BilheteBindingNavigator.AddNewItem = Nothing
        Me.BilheteBindingNavigator.BindingSource = Me.BilheteBindingSource
        Me.BilheteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BilheteBindingNavigator.DeleteItem = Nothing
        Me.BilheteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BilheteBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.BilheteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BilheteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BilheteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BilheteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BilheteBindingNavigator.Name = "BilheteBindingNavigator"
        Me.BilheteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BilheteBindingNavigator.Size = New System.Drawing.Size(844, 25)
        Me.BilheteBindingNavigator.TabIndex = 1
        Me.BilheteBindingNavigator.Text = "BindingNavigator1"
        '
        'BilheteBindingSource
        '
        Me.BilheteBindingSource.DataMember = "Bilhete"
        Me.BilheteBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'JardimzoologicoDataSet
        '
        Me.JardimzoologicoDataSet.DataSetName = "jardimzoologicoDataSet"
        Me.JardimzoologicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NumbilheteTextBox
        '
        Me.NumbilheteTextBox.BackColor = System.Drawing.Color.White
        Me.NumbilheteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "numbilhete", True))
        Me.NumbilheteTextBox.Location = New System.Drawing.Point(171, 23)
        Me.NumbilheteTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumbilheteTextBox.Name = "NumbilheteTextBox"
        Me.NumbilheteTextBox.ReadOnly = True
        Me.NumbilheteTextBox.Size = New System.Drawing.Size(116, 23)
        Me.NumbilheteTextBox.TabIndex = 3
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.BackColor = System.Drawing.Color.White
        Me.PrecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "preco", True))
        Me.PrecoTextBox.Location = New System.Drawing.Point(533, 480)
        Me.PrecoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.ReadOnly = True
        Me.PrecoTextBox.Size = New System.Drawing.Size(116, 23)
        Me.PrecoTextBox.TabIndex = 5
        '
        'BilhetesdisponiveisTextBox
        '
        Me.BilhetesdisponiveisTextBox.BackColor = System.Drawing.Color.White
        Me.BilhetesdisponiveisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteiraBindingSource, "bilhetesdisponiveis", True))
        Me.BilhetesdisponiveisTextBox.Location = New System.Drawing.Point(475, 28)
        Me.BilhetesdisponiveisTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BilhetesdisponiveisTextBox.Name = "BilhetesdisponiveisTextBox"
        Me.BilhetesdisponiveisTextBox.ReadOnly = True
        Me.BilhetesdisponiveisTextBox.Size = New System.Drawing.Size(116, 23)
        Me.BilhetesdisponiveisTextBox.TabIndex = 7
        '
        'BilheteiraBindingSource
        '
        Me.BilheteiraBindingSource.DataMember = "Bilheteira"
        Me.BilheteiraBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'NomeclienteTextBox
        '
        Me.NomeclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "nomecliente", True))
        Me.NomeclienteTextBox.Location = New System.Drawing.Point(174, 75)
        Me.NomeclienteTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomeclienteTextBox.Name = "NomeclienteTextBox"
        Me.NomeclienteTextBox.Size = New System.Drawing.Size(361, 23)
        Me.NomeclienteTextBox.TabIndex = 9
        '
        'IdadeTextBox
        '
        Me.IdadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "idade", True))
        Me.IdadeTextBox.Location = New System.Drawing.Point(174, 130)
        Me.IdadeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IdadeTextBox.Name = "IdadeTextBox"
        Me.IdadeTextBox.Size = New System.Drawing.Size(116, 23)
        Me.IdadeTextBox.TabIndex = 11
        '
        'TipoclienteComboBox
        '
        Me.TipoclienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "tipocliente", True))
        Me.TipoclienteComboBox.Enabled = False
        Me.TipoclienteComboBox.FormattingEnabled = True
        Me.TipoclienteComboBox.Location = New System.Drawing.Point(174, 183)
        Me.TipoclienteComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TipoclienteComboBox.Name = "TipoclienteComboBox"
        Me.TipoclienteComboBox.Size = New System.Drawing.Size(140, 24)
        Me.TipoclienteComboBox.TabIndex = 14
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "data", True))
        Me.DataDateTimePicker.Enabled = False
        Me.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataDateTimePicker.Location = New System.Drawing.Point(174, 233)
        Me.DataDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(140, 23)
        Me.DataDateTimePicker.TabIndex = 15
        '
        'ValidoTextBox
        '
        Me.ValidoTextBox.BackColor = System.Drawing.Color.White
        Me.ValidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "valido", True))
        Me.ValidoTextBox.Location = New System.Drawing.Point(171, 281)
        Me.ValidoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValidoTextBox.Name = "ValidoTextBox"
        Me.ValidoTextBox.ReadOnly = True
        Me.ValidoTextBox.Size = New System.Drawing.Size(116, 23)
        Me.ValidoTextBox.TabIndex = 17
        '
        'OperadorcaixaTextBox
        '
        Me.OperadorcaixaTextBox.BackColor = System.Drawing.Color.White
        Me.OperadorcaixaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "operadorcaixa", True))
        Me.OperadorcaixaTextBox.Location = New System.Drawing.Point(171, 329)
        Me.OperadorcaixaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OperadorcaixaTextBox.Name = "OperadorcaixaTextBox"
        Me.OperadorcaixaTextBox.ReadOnly = True
        Me.OperadorcaixaTextBox.Size = New System.Drawing.Size(116, 23)
        Me.OperadorcaixaTextBox.TabIndex = 19
        '
        'BilheteDataGridView
        '
        Me.BilheteDataGridView.AutoGenerateColumns = False
        Me.BilheteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BilheteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.preco, Me.codbarrasnum, Me.nomecliente, Me.idade, Me.tipocliente, Me.DataGridViewTextBoxColumn7, Me.operadorcaixa, Me.numbilhete, Me.valido})
        Me.BilheteDataGridView.DataSource = Me.BilheteBindingSource
        Me.BilheteDataGridView.Location = New System.Drawing.Point(377, 135)
        Me.BilheteDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BilheteDataGridView.Name = "BilheteDataGridView"
        Me.BilheteDataGridView.Size = New System.Drawing.Size(273, 159)
        Me.BilheteDataGridView.TabIndex = 20
        Me.BilheteDataGridView.Visible = False
        '
        'preco
        '
        Me.preco.DataPropertyName = "preco"
        Me.preco.HeaderText = "preco"
        Me.preco.Name = "preco"
        '
        'codbarrasnum
        '
        Me.codbarrasnum.DataPropertyName = "codbarrasnum"
        Me.codbarrasnum.HeaderText = "codbarrasnum"
        Me.codbarrasnum.Name = "codbarrasnum"
        '
        'nomecliente
        '
        Me.nomecliente.DataPropertyName = "nomecliente"
        Me.nomecliente.HeaderText = "nomecliente"
        Me.nomecliente.Name = "nomecliente"
        '
        'idade
        '
        Me.idade.DataPropertyName = "idade"
        Me.idade.HeaderText = "idade"
        Me.idade.Name = "idade"
        '
        'tipocliente
        '
        Me.tipocliente.DataPropertyName = "tipocliente"
        Me.tipocliente.HeaderText = "tipocliente"
        Me.tipocliente.Name = "tipocliente"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn7.HeaderText = "data"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'operadorcaixa
        '
        Me.operadorcaixa.DataPropertyName = "operadorcaixa"
        Me.operadorcaixa.HeaderText = "operadorcaixa"
        Me.operadorcaixa.Name = "operadorcaixa"
        '
        'numbilhete
        '
        Me.numbilhete.DataPropertyName = "numbilhete"
        Me.numbilhete.HeaderText = "numbilhete"
        Me.numbilhete.Name = "numbilhete"
        '
        'valido
        '
        Me.valido.DataPropertyName = "valido"
        Me.valido.HeaderText = "valido"
        Me.valido.Name = "valido"
        '
        'BilheteiraDataGridView
        '
        Me.BilheteiraDataGridView.AutoGenerateColumns = False
        Me.BilheteiraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BilheteiraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.data1, Me.DataGridViewTextBoxColumn10})
        Me.BilheteiraDataGridView.DataSource = Me.BilheteiraBindingSource
        Me.BilheteiraDataGridView.Location = New System.Drawing.Point(486, 32)
        Me.BilheteiraDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BilheteiraDataGridView.Name = "BilheteiraDataGridView"
        Me.BilheteiraDataGridView.Size = New System.Drawing.Size(225, 96)
        Me.BilheteiraDataGridView.TabIndex = 22
        Me.BilheteiraDataGridView.Visible = False
        '
        'data1
        '
        Me.data1.DataPropertyName = "data"
        Me.data1.HeaderText = "data"
        Me.data1.Name = "data1"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "bilhetesdisponiveis"
        Me.DataGridViewTextBoxColumn10.HeaderText = "bilhetesdisponiveis"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.DataTextBox)
        Me.GroupBox1.Controls.Add(CodbarrasnumLabel)
        Me.GroupBox1.Controls.Add(Me.CodbarrasnumTextBox)
        Me.GroupBox1.Controls.Add(Me.NumbilheteTextBox)
        Me.GroupBox1.Controls.Add(Me.BilheteiraDataGridView)
        Me.GroupBox1.Controls.Add(NumbilheteLabel)
        Me.GroupBox1.Controls.Add(Me.BilheteDataGridView)
        Me.GroupBox1.Controls.Add(Me.NomeclienteTextBox)
        Me.GroupBox1.Controls.Add(NomeclienteLabel)
        Me.GroupBox1.Controls.Add(OperadorcaixaLabel)
        Me.GroupBox1.Controls.Add(PrecoLabel)
        Me.GroupBox1.Controls.Add(Me.IdadeTextBox)
        Me.GroupBox1.Controls.Add(Me.PrecoTextBox)
        Me.GroupBox1.Controls.Add(Me.OperadorcaixaTextBox)
        Me.GroupBox1.Controls.Add(IdadeLabel)
        Me.GroupBox1.Controls.Add(ValidoLabel)
        Me.GroupBox1.Controls.Add(TipoclienteLabel)
        Me.GroupBox1.Controls.Add(Me.ValidoTextBox)
        Me.GroupBox1.Controls.Add(Me.TipoclienteComboBox)
        Me.GroupBox1.Controls.Add(DataLabel)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 64)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(797, 507)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editar Bilhete:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(395, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'DataTextBox
        '
        Me.DataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteiraBindingSource, "data", True))
        Me.DataTextBox.Location = New System.Drawing.Point(398, 0)
        Me.DataTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(233, 23)
        Me.DataTextBox.TabIndex = 25
        Me.DataTextBox.Visible = False
        '
        'CodbarrasnumTextBox
        '
        Me.CodbarrasnumTextBox.BackColor = System.Drawing.Color.White
        Me.CodbarrasnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "codbarrasnum", True))
        Me.CodbarrasnumTextBox.Location = New System.Drawing.Point(171, 376)
        Me.CodbarrasnumTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodbarrasnumTextBox.Name = "CodbarrasnumTextBox"
        Me.CodbarrasnumTextBox.ReadOnly = True
        Me.CodbarrasnumTextBox.Size = New System.Drawing.Size(116, 23)
        Me.CodbarrasnumTextBox.TabIndex = 24
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 576)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(844, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(128, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'BilheteTableAdapter
        '
        Me.BilheteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnimaisTableAdapter = Nothing
        Me.TableAdapterManager.ArtigosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BilheteiraTableAdapter = Nothing
        Me.TableAdapterManager.BilheteTableAdapter = Me.BilheteTableAdapter
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.Detalhe_comprasTableAdapter = Nothing
        Me.TableAdapterManager.FuncionariosTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BilheteiraTableAdapter
        '
        Me.BilheteiraTableAdapter.ClearBeforeFill = True
        '
        'Bilheteira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(844, 598)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(BilhetesdisponiveisLabel)
        Me.Controls.Add(Me.BilhetesdisponiveisTextBox)
        Me.Controls.Add(Me.BilheteBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Bilheteira"
        Me.Text = "Bilheteira"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BilheteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BilheteBindingNavigator.ResumeLayout(False)
        Me.BilheteBindingNavigator.PerformLayout()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteiraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GerarBilheteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarBilheteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JardimzoologicoDataSet As JardimZoologico.jardimzoologicoDataSet
    Friend WithEvents BilheteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BilheteTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.BilheteTableAdapter
    Friend WithEvents TableAdapterManager As JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BilheteBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NumbilheteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BilheteiraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BilheteiraTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.BilheteiraTableAdapter
    Friend WithEvents BilhetesdisponiveisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoclienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ValidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OperadorcaixaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BilheteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BilheteiraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CancelarBilheteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirBilheteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodbarrasnumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents preco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codbarrasnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomecliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipocliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operadorcaixa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numbilhete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTextBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents data1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BilhetesDeHojeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarGerarBilheteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
