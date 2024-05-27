<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page_Jbc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page_Jbc))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.txt_jbc = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.txt_proc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TreinamentosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreinamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodigosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Menu.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TreinamentosToolStripMenuItem, Me.CodigosToolStripMenuItem, Me.ConfiguracaoToolStripMenuItem})
        Me.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Padding = New System.Windows.Forms.Padding(8)
        Me.Menu.ShowItemToolTips = True
        Me.Menu.Size = New System.Drawing.Size(966, 44)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        Me.DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridView.Location = New System.Drawing.Point(12, 163)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
        Me.DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(942, 350)
        Me.DataGridView.TabIndex = 2
        '
        'txt_jbc
        '
        Me.txt_jbc.AutoSize = True
        Me.txt_jbc.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jbc.ForeColor = System.Drawing.Color.White
        Me.txt_jbc.Location = New System.Drawing.Point(12, 60)
        Me.txt_jbc.Name = "txt_jbc"
        Me.txt_jbc.Size = New System.Drawing.Size(112, 43)
        Me.txt_jbc.TabIndex = 8
        Me.txt_jbc.Text = "JBC's "
        '
        'Timer
        '
        Me.Timer.Interval = 120000
        '
        'txt_proc
        '
        Me.txt_proc.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_proc.Location = New System.Drawing.Point(12, 131)
        Me.txt_proc.Name = "txt_proc"
        Me.txt_proc.Size = New System.Drawing.Size(228, 26)
        Me.txt_proc.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(431, 521)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 43)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "APTIV"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(533, 521)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 43)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "•"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(408, 521)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 43)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "•"
        '
        'TreinamentosMenuItem
        '
        Me.TreinamentosMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TreinamentosMenuItem.ForeColor = System.Drawing.Color.White
        Me.TreinamentosMenuItem.Name = "TreinamentosMenuItem"
        Me.TreinamentosMenuItem.Size = New System.Drawing.Size(148, 28)
        Me.TreinamentosMenuItem.Text = "Treinamentos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Pesquisar"
        '
        'TreinamentosToolStripMenuItem
        '
        Me.TreinamentosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TreinamentosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TreinamentosToolStripMenuItem.Image = Global.Contencao.My.Resources.Resources.oui__training
        Me.TreinamentosToolStripMenuItem.Name = "TreinamentosToolStripMenuItem"
        Me.TreinamentosToolStripMenuItem.Size = New System.Drawing.Size(166, 28)
        Me.TreinamentosToolStripMenuItem.Text = "Treinamentos"
        '
        'CodigosToolStripMenuItem
        '
        Me.CodigosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CodigosToolStripMenuItem.Image = Global.Contencao.My.Resources.Resources.ph__list_numbers_light__1_
        Me.CodigosToolStripMenuItem.Name = "CodigosToolStripMenuItem"
        Me.CodigosToolStripMenuItem.Size = New System.Drawing.Size(117, 28)
        Me.CodigosToolStripMenuItem.Text = "Códigos"
        '
        'ConfiguracaoToolStripMenuItem
        '
        Me.ConfiguracaoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConfiguracaoToolStripMenuItem.Image = Global.Contencao.My.Resources.Resources.uil__setting
        Me.ConfiguracaoToolStripMenuItem.Name = "ConfiguracaoToolStripMenuItem"
        Me.ConfiguracaoToolStripMenuItem.Size = New System.Drawing.Size(165, 28)
        Me.ConfiguracaoToolStripMenuItem.Text = "Configuração"
        '
        'Page_Jbc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(966, 573)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_proc)
        Me.Controls.Add(Me.txt_jbc)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Menu)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "Page_Jbc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents txt_jbc As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents txt_proc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TreinamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreinamentosMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents CodigosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracaoToolStripMenuItem As ToolStripMenuItem
End Class
