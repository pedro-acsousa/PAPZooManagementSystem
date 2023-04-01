<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class funcionarios
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
        Dim Num_funcionarioLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim GeneroLabel1 As System.Windows.Forms.Label
        Dim CodigopostalLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim NifLabel As System.Windows.Forms.Label
        Dim DatanascLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(funcionarios))
        Dim PermissõesLabel As System.Windows.Forms.Label
        Me.JardimzoologicoDataSet = New JardimZoologico.jardimzoologicoDataSet()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.FuncionariosTableAdapter()
        Me.TableAdapterManager = New JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager()
        Me.FuncionariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4x = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.FuncionariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datanasc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_funcionarioTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox()
        Me.CodigopostalTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadesTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.LocalidadesTableAdapter()
        Me.b_gravar = New System.Windows.Forms.Button()
        Me.FuncionariosTableAdapter1 = New JardimZoologico.jardimzoologicoDataSetTableAdapters.FuncionariosTableAdapter()
        Me.b_cancelar = New System.Windows.Forms.Button()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.NifTextBox = New System.Windows.Forms.TextBox()
        Me.fotobox = New System.Windows.Forms.PictureBox()
        Me.b_carregar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.DatanascDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.b_adicionar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_alterar = New System.Windows.Forms.Button()
        Me.b_eliminar = New System.Windows.Forms.Button()
        Me.PermissõesComboBox = New System.Windows.Forms.ComboBox()
        Num_funcionarioLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        GeneroLabel1 = New System.Windows.Forms.Label()
        CodigopostalLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        NifLabel = New System.Windows.Forms.Label()
        DatanascLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PermissõesLabel = New System.Windows.Forms.Label()
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuncionariosBindingNavigator.SuspendLayout()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotobox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Num_funcionarioLabel
        '
        Num_funcionarioLabel.AutoSize = True
        Num_funcionarioLabel.BackColor = System.Drawing.Color.Transparent
        Num_funcionarioLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Num_funcionarioLabel.Location = New System.Drawing.Point(6, 20)
        Num_funcionarioLabel.Name = "Num_funcionarioLabel"
        Num_funcionarioLabel.Size = New System.Drawing.Size(94, 16)
        Num_funcionarioLabel.TabIndex = 2
        Num_funcionarioLabel.Text = "Nº Funcionário:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        NomeLabel.Location = New System.Drawing.Point(51, 62)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(43, 16)
        NomeLabel.TabIndex = 4
        NomeLabel.Text = "Nome:"
        '
        'GeneroLabel1
        '
        GeneroLabel1.AutoSize = True
        GeneroLabel1.BackColor = System.Drawing.Color.Transparent
        GeneroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        GeneroLabel1.Location = New System.Drawing.Point(197, 20)
        GeneroLabel1.Name = "GeneroLabel1"
        GeneroLabel1.Size = New System.Drawing.Size(49, 16)
        GeneroLabel1.TabIndex = 7
        GeneroLabel1.Text = "Género:"
        '
        'CodigopostalLabel
        '
        CodigopostalLabel.AutoSize = True
        CodigopostalLabel.BackColor = System.Drawing.Color.Transparent
        CodigopostalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        CodigopostalLabel.Location = New System.Drawing.Point(20, 100)
        CodigopostalLabel.Name = "CodigopostalLabel"
        CodigopostalLabel.Size = New System.Drawing.Size(73, 16)
        CodigopostalLabel.TabIndex = 8
        CodigopostalLabel.Text = "Cód. Postal:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.BackColor = System.Drawing.Color.Transparent
        TelefoneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        TelefoneLabel.Location = New System.Drawing.Point(341, 59)
        TelefoneLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(60, 16)
        TelefoneLabel.TabIndex = 13
        TelefoneLabel.Text = "Telefone:"
        '
        'NifLabel
        '
        NifLabel.AutoSize = True
        NifLabel.BackColor = System.Drawing.Color.Transparent
        NifLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        NifLabel.Location = New System.Drawing.Point(62, 134)
        NifLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NifLabel.Name = "NifLabel"
        NifLabel.Size = New System.Drawing.Size(35, 16)
        NifLabel.TabIndex = 15
        NifLabel.Text = "NIF:"
        '
        'DatanascLabel
        '
        DatanascLabel.AutoSize = True
        DatanascLabel.BackColor = System.Drawing.Color.Transparent
        DatanascLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DatanascLabel.Location = New System.Drawing.Point(1, 177)
        DatanascLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DatanascLabel.Name = "DatanascLabel"
        DatanascLabel.Size = New System.Drawing.Size(91, 16)
        DatanascLabel.TabIndex = 18
        DatanascLabel.Text = "Data de Nasc.:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(562, 161)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(62, 16)
        UsernameLabel.TabIndex = 19
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(564, 192)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(60, 16)
        PasswordLabel.TabIndex = 20
        PasswordLabel.Text = "password:"
        '
        'JardimzoologicoDataSet
        '
        Me.JardimzoologicoDataSet.DataSetName = "jardimzoologicoDataSet"
        Me.JardimzoologicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FuncionariosBindingSource
        '
        Me.FuncionariosBindingSource.DataMember = "Funcionarios"
        Me.FuncionariosBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'FuncionariosTableAdapter
        '
        Me.FuncionariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnimaisTableAdapter = Nothing
        Me.TableAdapterManager.ArtigosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BilheteiraTableAdapter = Nothing
        Me.TableAdapterManager.BilheteTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.Detalhe_comprasTableAdapter = Nothing
        Me.TableAdapterManager.FuncionariosTableAdapter = Me.FuncionariosTableAdapter
        Me.TableAdapterManager.LocalidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FuncionariosBindingNavigator
        '
        Me.FuncionariosBindingNavigator.AddNewItem = Nothing
        Me.FuncionariosBindingNavigator.BackColor = System.Drawing.Color.White
        Me.FuncionariosBindingNavigator.BindingSource = Me.FuncionariosBindingSource
        Me.FuncionariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FuncionariosBindingNavigator.DeleteItem = Nothing
        Me.FuncionariosBindingNavigator.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncionariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton4x, Me.ToolStripLabel1})
        Me.FuncionariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FuncionariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FuncionariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FuncionariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FuncionariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FuncionariosBindingNavigator.Name = "FuncionariosBindingNavigator"
        Me.FuncionariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FuncionariosBindingNavigator.Size = New System.Drawing.Size(778, 25)
        Me.FuncionariosBindingNavigator.TabIndex = 0
        Me.FuncionariosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(40, 22)
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
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.White
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
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
        'ToolStripButton4x
        '
        Me.ToolStripButton4x.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4x.BackgroundImage = Global.JardimZoologico.My.Resources.Resources.delete_button
        Me.ToolStripButton4x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton4x.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripButton4x.Image = CType(resources.GetObject("ToolStripButton4x.Image"), System.Drawing.Image)
        Me.ToolStripButton4x.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4x.Name = "ToolStripButton4x"
        Me.ToolStripButton4x.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4x.Text = "Sair"
        Me.ToolStripButton4x.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'FuncionariosDataGridView
        '
        Me.FuncionariosDataGridView.AutoGenerateColumns = False
        Me.FuncionariosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FuncionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FuncionariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.datanasc, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.username, Me.password})
        Me.FuncionariosDataGridView.DataSource = Me.FuncionariosBindingSource
        Me.FuncionariosDataGridView.Location = New System.Drawing.Point(19, 282)
        Me.FuncionariosDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FuncionariosDataGridView.Name = "FuncionariosDataGridView"
        Me.FuncionariosDataGridView.Size = New System.Drawing.Size(670, 299)
        Me.FuncionariosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'datanasc
        '
        Me.datanasc.DataPropertyName = "datanasc"
        Me.datanasc.HeaderText = "Data. Nasc"
        Me.datanasc.Name = "datanasc"
        Me.datanasc.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "genero"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Género"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "codigopostal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cod. Postal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Telefone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nif"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NIF"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "num_funcionario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nº Funcionário"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.HeaderText = "username"
        Me.username.Name = "username"
        '
        'password
        '
        Me.password.DataPropertyName = "password"
        Me.password.HeaderText = "password"
        Me.password.Name = "password"
        Me.password.Visible = False
        '
        'Num_funcionarioTextBox
        '
        Me.Num_funcionarioTextBox.BackColor = System.Drawing.Color.White
        Me.Num_funcionarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "num_funcionario", True))
        Me.Num_funcionarioTextBox.ForeColor = System.Drawing.Color.Black
        Me.Num_funcionarioTextBox.Location = New System.Drawing.Point(100, 16)
        Me.Num_funcionarioTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Num_funcionarioTextBox.Name = "Num_funcionarioTextBox"
        Me.Num_funcionarioTextBox.ReadOnly = True
        Me.Num_funcionarioTextBox.Size = New System.Drawing.Size(53, 23)
        Me.Num_funcionarioTextBox.TabIndex = 3
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.White
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "nome", True))
        Me.NomeTextBox.ForeColor = System.Drawing.Color.Black
        Me.NomeTextBox.Location = New System.Drawing.Point(100, 58)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(189, 23)
        Me.NomeTextBox.TabIndex = 5
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.BackColor = System.Drawing.Color.White
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "genero", True))
        Me.GeneroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GeneroComboBox.ForeColor = System.Drawing.Color.Black
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.GeneroComboBox.Location = New System.Drawing.Point(256, 16)
        Me.GeneroComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(140, 24)
        Me.GeneroComboBox.TabIndex = 8
        '
        'CodigopostalTextBox
        '
        Me.CodigopostalTextBox.BackColor = System.Drawing.Color.White
        Me.CodigopostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "codigopostal", True))
        Me.CodigopostalTextBox.ForeColor = System.Drawing.Color.Black
        Me.CodigopostalTextBox.Location = New System.Drawing.Point(102, 96)
        Me.CodigopostalTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodigopostalTextBox.Name = "CodigopostalTextBox"
        Me.CodigopostalTextBox.Size = New System.Drawing.Size(103, 23)
        Me.CodigopostalTextBox.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FuncionariosBindingSource, "codigopostal", True))
        Me.ComboBox1.DataSource = Me.LocalidadesBindingSource
        Me.ComboBox1.DisplayMember = "nomelocalidade"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(213, 96)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 24)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.ValueMember = "cod_postal"
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "Localidades"
        Me.LocalidadesBindingSource.DataSource = Me.JardimzoologicoDataSet
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'b_gravar
        '
        Me.b_gravar.BackColor = System.Drawing.Color.Transparent
        Me.b_gravar.BackgroundImage = CType(resources.GetObject("b_gravar.BackgroundImage"), System.Drawing.Image)
        Me.b_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_gravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_gravar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.b_gravar.FlatAppearance.BorderSize = 0
        Me.b_gravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_gravar.ForeColor = System.Drawing.Color.Transparent
        Me.b_gravar.Location = New System.Drawing.Point(190, 4)
        Me.b_gravar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.b_gravar.Name = "b_gravar"
        Me.b_gravar.Size = New System.Drawing.Size(48, 52)
        Me.b_gravar.TabIndex = 12
        Me.b_gravar.UseVisualStyleBackColor = False
        '
        'FuncionariosTableAdapter1
        '
        Me.FuncionariosTableAdapter1.ClearBeforeFill = True
        '
        'b_cancelar
        '
        Me.b_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.b_cancelar.BackgroundImage = CType(resources.GetObject("b_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.b_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.b_cancelar.FlatAppearance.BorderSize = 0
        Me.b_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_cancelar.ForeColor = System.Drawing.Color.White
        Me.b_cancelar.Location = New System.Drawing.Point(248, 4)
        Me.b_cancelar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.b_cancelar.Name = "b_cancelar"
        Me.b_cancelar.Size = New System.Drawing.Size(47, 51)
        Me.b_cancelar.TabIndex = 13
        Me.b_cancelar.UseVisualStyleBackColor = False
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.BackColor = System.Drawing.Color.White
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "telefone", True))
        Me.TelefoneTextBox.ForeColor = System.Drawing.Color.Black
        Me.TelefoneTextBox.Location = New System.Drawing.Point(403, 56)
        Me.TelefoneTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(108, 23)
        Me.TelefoneTextBox.TabIndex = 14
        '
        'NifTextBox
        '
        Me.NifTextBox.BackColor = System.Drawing.Color.White
        Me.NifTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "nif", True))
        Me.NifTextBox.ForeColor = System.Drawing.Color.Black
        Me.NifTextBox.Location = New System.Drawing.Point(94, 131)
        Me.NifTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.NifTextBox.Name = "NifTextBox"
        Me.NifTextBox.Size = New System.Drawing.Size(71, 23)
        Me.NifTextBox.TabIndex = 16
        '
        'fotobox
        '
        Me.fotobox.BackColor = System.Drawing.Color.White
        Me.fotobox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.FuncionariosBindingSource, "foto", True))
        Me.fotobox.Location = New System.Drawing.Point(387, 86)
        Me.fotobox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.fotobox.Name = "fotobox"
        Me.fotobox.Size = New System.Drawing.Size(78, 79)
        Me.fotobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotobox.TabIndex = 17
        Me.fotobox.TabStop = False
        '
        'b_carregar
        '
        Me.b_carregar.BackColor = System.Drawing.Color.White
        Me.b_carregar.BackgroundImage = CType(resources.GetObject("b_carregar.BackgroundImage"), System.Drawing.Image)
        Me.b_carregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_carregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_carregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_carregar.ForeColor = System.Drawing.Color.Black
        Me.b_carregar.Location = New System.Drawing.Point(407, 169)
        Me.b_carregar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.b_carregar.Name = "b_carregar"
        Me.b_carregar.Size = New System.Drawing.Size(43, 36)
        Me.b_carregar.TabIndex = 18
        Me.b_carregar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(PermissõesLabel)
        Me.GroupBox1.Controls.Add(Me.PermissõesComboBox)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(DatanascLabel)
        Me.GroupBox1.Controls.Add(Me.DatanascDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.NifTextBox)
        Me.GroupBox1.Controls.Add(Me.b_carregar)
        Me.GroupBox1.Controls.Add(Me.Num_funcionarioTextBox)
        Me.GroupBox1.Controls.Add(Me.fotobox)
        Me.GroupBox1.Controls.Add(Num_funcionarioLabel)
        Me.GroupBox1.Controls.Add(NifLabel)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Controls.Add(TelefoneLabel)
        Me.GroupBox1.Controls.Add(Me.GeneroComboBox)
        Me.GroupBox1.Controls.Add(Me.TelefoneTextBox)
        Me.GroupBox1.Controls.Add(GeneroLabel1)
        Me.GroupBox1.Controls.Add(Me.CodigopostalTextBox)
        Me.GroupBox1.Controls.Add(CodigopostalLabel)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(752, 225)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(630, 189)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PasswordTextBox.TabIndex = 21
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(630, 158)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.UsernameTextBox.TabIndex = 20
        '
        'DatanascDateTimePicker
        '
        Me.DatanascDateTimePicker.CalendarForeColor = System.Drawing.Color.White
        Me.DatanascDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DatanascDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DatanascDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DatanascDateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.DatanascDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FuncionariosBindingSource, "datanasc", True))
        Me.DatanascDateTimePicker.Location = New System.Drawing.Point(94, 172)
        Me.DatanascDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DatanascDateTimePicker.Name = "DatanascDateTimePicker"
        Me.DatanascDateTimePicker.Size = New System.Drawing.Size(264, 23)
        Me.DatanascDateTimePicker.TabIndex = 19
        '
        'b_adicionar
        '
        Me.b_adicionar.BackColor = System.Drawing.Color.Transparent
        Me.b_adicionar.BackgroundImage = CType(resources.GetObject("b_adicionar.BackgroundImage"), System.Drawing.Image)
        Me.b_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_adicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.b_adicionar.FlatAppearance.BorderSize = 0
        Me.b_adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_adicionar.ForeColor = System.Drawing.Color.Transparent
        Me.b_adicionar.Location = New System.Drawing.Point(125, 2)
        Me.b_adicionar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.b_adicionar.Name = "b_adicionar"
        Me.b_adicionar.Size = New System.Drawing.Size(61, 55)
        Me.b_adicionar.TabIndex = 21
        Me.b_adicionar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.b_alterar)
        Me.Panel1.Controls.Add(Me.b_gravar)
        Me.Panel1.Controls.Add(Me.b_adicionar)
        Me.Panel1.Controls.Add(Me.b_eliminar)
        Me.Panel1.Controls.Add(Me.b_cancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 607)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 62)
        Me.Panel1.TabIndex = 22
        '
        'b_alterar
        '
        Me.b_alterar.BackColor = System.Drawing.Color.Transparent
        Me.b_alterar.BackgroundImage = CType(resources.GetObject("b_alterar.BackgroundImage"), System.Drawing.Image)
        Me.b_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_alterar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.b_alterar.FlatAppearance.BorderSize = 0
        Me.b_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_alterar.ForeColor = System.Drawing.Color.Transparent
        Me.b_alterar.Location = New System.Drawing.Point(363, 7)
        Me.b_alterar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.b_alterar.Name = "b_alterar"
        Me.b_alterar.Size = New System.Drawing.Size(52, 49)
        Me.b_alterar.TabIndex = 24
        Me.b_alterar.UseVisualStyleBackColor = False
        '
        'b_eliminar
        '
        Me.b_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.b_eliminar.BackgroundImage = CType(resources.GetObject("b_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.b_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.b_eliminar.FlatAppearance.BorderSize = 0
        Me.b_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_eliminar.ForeColor = System.Drawing.Color.Transparent
        Me.b_eliminar.Location = New System.Drawing.Point(305, 5)
        Me.b_eliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.b_eliminar.Name = "b_eliminar"
        Me.b_eliminar.Size = New System.Drawing.Size(48, 49)
        Me.b_eliminar.TabIndex = 23
        Me.b_eliminar.UseVisualStyleBackColor = False
        '
        'PermissõesLabel
        '
        PermissõesLabel.AutoSize = True
        PermissõesLabel.Location = New System.Drawing.Point(568, 16)
        PermissõesLabel.Name = "PermissõesLabel"
        PermissõesLabel.Size = New System.Drawing.Size(142, 16)
        PermissõesLabel.TabIndex = 22
        PermissõesLabel.Text = "Permissões de Utilizador:"
        '
        'PermissõesComboBox
        '
        Me.PermissõesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "permissões", True))
        Me.PermissõesComboBox.FormattingEnabled = True
        Me.PermissõesComboBox.Items.AddRange(New Object() {"administrador", "funcionário"})
        Me.PermissõesComboBox.Location = New System.Drawing.Point(577, 47)
        Me.PermissõesComboBox.Name = "PermissõesComboBox"
        Me.PermissõesComboBox.Size = New System.Drawing.Size(121, 24)
        Me.PermissõesComboBox.TabIndex = 23
        '
        'funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 669)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FuncionariosDataGridView)
        Me.Controls.Add(Me.FuncionariosBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário Funcionários"
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuncionariosBindingNavigator.ResumeLayout(False)
        Me.FuncionariosBindingNavigator.PerformLayout()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotobox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JardimzoologicoDataSet As JardimZoologico.jardimzoologicoDataSet
    Friend WithEvents FuncionariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionariosTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents TableAdapterManager As JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FuncionariosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FuncionariosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Num_funcionarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GeneroComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodigopostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LocalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadesTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.LocalidadesTableAdapter
    Friend WithEvents b_gravar As System.Windows.Forms.Button
    Friend WithEvents FuncionariosTableAdapter1 As JardimZoologico.jardimzoologicoDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents b_cancelar As System.Windows.Forms.Button
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NifTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fotobox As System.Windows.Forms.PictureBox
    Friend WithEvents b_carregar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripButton4x As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DatanascDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents b_adicionar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents b_eliminar As System.Windows.Forms.Button
    Friend WithEvents b_alterar As System.Windows.Forms.Button
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datanasc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PermissõesComboBox As System.Windows.Forms.ComboBox
End Class
