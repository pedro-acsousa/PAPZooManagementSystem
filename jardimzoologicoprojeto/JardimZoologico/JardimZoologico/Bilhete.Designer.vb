<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bilhete
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
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bilhete))
        Me.JardimzoologicoDataSet = New JardimZoologico.jardimzoologicoDataSet()
        Me.BilheteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BilheteTableAdapter = New JardimZoologico.jardimzoologicoDataSetTableAdapters.BilheteTableAdapter()
        Me.TableAdapterManager = New JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager()
        Me.NumbilheteTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValidoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoclienteTextBox = New System.Windows.Forms.TextBox()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.CodbarrasnumTextBox = New System.Windows.Forms.TextBox()
        Me.NomeclienteTextBox = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        NumbilheteLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumbilheteLabel
        '
        NumbilheteLabel.AutoSize = True
        NumbilheteLabel.BackColor = System.Drawing.Color.White
        NumbilheteLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumbilheteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        NumbilheteLabel.Location = New System.Drawing.Point(657, 118)
        NumbilheteLabel.Name = "NumbilheteLabel"
        NumbilheteLabel.Size = New System.Drawing.Size(30, 16)
        NumbilheteLabel.TabIndex = 1
        NumbilheteLabel.Text = "Nº:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.White
        Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label1.Location = New System.Drawing.Point(642, 202)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 16)
        Label1.TabIndex = 14
        Label1.Text = "Cod.Barras:"
        '
        'JardimzoologicoDataSet
        '
        Me.JardimzoologicoDataSet.DataSetName = "jardimzoologicoDataSet"
        Me.JardimzoologicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BilheteBindingSource
        '
        Me.BilheteBindingSource.DataMember = "Bilhete"
        Me.BilheteBindingSource.DataSource = Me.JardimzoologicoDataSet
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
        'NumbilheteTextBox
        '
        Me.NumbilheteTextBox.BackColor = System.Drawing.Color.White
        Me.NumbilheteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumbilheteTextBox.Enabled = False
        Me.NumbilheteTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumbilheteTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NumbilheteTextBox.Location = New System.Drawing.Point(622, 135)
        Me.NumbilheteTextBox.Name = "NumbilheteTextBox"
        Me.NumbilheteTextBox.ReadOnly = True
        Me.NumbilheteTextBox.Size = New System.Drawing.Size(94, 17)
        Me.NumbilheteTextBox.TabIndex = 2
        Me.NumbilheteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.CalendarMonthBackground = System.Drawing.Color.White
        Me.DataDateTimePicker.Enabled = False
        Me.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataDateTimePicker.Location = New System.Drawing.Point(618, 85)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(117, 20)
        Me.DataDateTimePicker.TabIndex = 4
        '
        'ValidoTextBox
        '
        Me.ValidoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidoTextBox.Enabled = False
        Me.ValidoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidoTextBox.Location = New System.Drawing.Point(621, 179)
        Me.ValidoTextBox.Name = "ValidoTextBox"
        Me.ValidoTextBox.Size = New System.Drawing.Size(100, 17)
        Me.ValidoTextBox.TabIndex = 6
        Me.ValidoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TipoclienteTextBox
        '
        Me.TipoclienteTextBox.BackColor = System.Drawing.Color.White
        Me.TipoclienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TipoclienteTextBox.Enabled = False
        Me.TipoclienteTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoclienteTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TipoclienteTextBox.Location = New System.Drawing.Point(616, 258)
        Me.TipoclienteTextBox.Name = "TipoclienteTextBox"
        Me.TipoclienteTextBox.ReadOnly = True
        Me.TipoclienteTextBox.Size = New System.Drawing.Size(100, 17)
        Me.TipoclienteTextBox.TabIndex = 8
        Me.TipoclienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.BackColor = System.Drawing.Color.White
        Me.PrecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PrecoTextBox.Enabled = False
        Me.PrecoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PrecoTextBox.Location = New System.Drawing.Point(720, 258)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.ReadOnly = True
        Me.PrecoTextBox.Size = New System.Drawing.Size(44, 17)
        Me.PrecoTextBox.TabIndex = 10
        Me.PrecoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodbarrasnumTextBox
        '
        Me.CodbarrasnumTextBox.BackColor = System.Drawing.Color.White
        Me.CodbarrasnumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodbarrasnumTextBox.Enabled = False
        Me.CodbarrasnumTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodbarrasnumTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CodbarrasnumTextBox.Location = New System.Drawing.Point(633, 221)
        Me.CodbarrasnumTextBox.Name = "CodbarrasnumTextBox"
        Me.CodbarrasnumTextBox.ReadOnly = True
        Me.CodbarrasnumTextBox.Size = New System.Drawing.Size(100, 17)
        Me.CodbarrasnumTextBox.TabIndex = 12
        Me.CodbarrasnumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NomeclienteTextBox
        '
        Me.NomeclienteTextBox.BackColor = System.Drawing.Color.White
        Me.NomeclienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomeclienteTextBox.Enabled = False
        Me.NomeclienteTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeclienteTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NomeclienteTextBox.Location = New System.Drawing.Point(615, 32)
        Me.NomeclienteTextBox.Multiline = True
        Me.NomeclienteTextBox.Name = "NomeclienteTextBox"
        Me.NomeclienteTextBox.ReadOnly = True
        Me.NomeclienteTextBox.Size = New System.Drawing.Size(150, 47)
        Me.NomeclienteTextBox.TabIndex = 13
        Me.NomeclienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(377, 283)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 49)
        Me.Button4.TabIndex = 17
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Bilhete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(817, 336)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.NomeclienteTextBox)
        Me.Controls.Add(Me.CodbarrasnumTextBox)
        Me.Controls.Add(Me.PrecoTextBox)
        Me.Controls.Add(Me.TipoclienteTextBox)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(NumbilheteLabel)
        Me.Controls.Add(Me.NumbilheteTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ValidoTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bilhete"
        Me.Text = "Bilhete"
        CType(Me.JardimzoologicoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JardimzoologicoDataSet As JardimZoologico.jardimzoologicoDataSet
    Friend WithEvents BilheteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BilheteTableAdapter As JardimZoologico.jardimzoologicoDataSetTableAdapters.BilheteTableAdapter
    Friend WithEvents TableAdapterManager As JardimZoologico.jardimzoologicoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumbilheteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ValidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodbarrasnumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
