<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page_Config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page_Config))
        Me.txt_jbc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbo_area = New System.Windows.Forms.ComboBox()
        Me.btn_entrada = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_jbc
        '
        Me.txt_jbc.AutoSize = True
        Me.txt_jbc.Font = New System.Drawing.Font("Arial Narrow", 23.0!, System.Drawing.FontStyle.Bold)
        Me.txt_jbc.ForeColor = System.Drawing.Color.White
        Me.txt_jbc.Location = New System.Drawing.Point(5, 7)
        Me.txt_jbc.Name = "txt_jbc"
        Me.txt_jbc.Size = New System.Drawing.Size(194, 36)
        Me.txt_jbc.TabIndex = 9
        Me.txt_jbc.Text = "Configurações"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(86, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 43)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "•"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(211, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 43)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "•"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(109, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 43)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "APTIV"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txt_jbc)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 47)
        Me.Panel1.TabIndex = 38
        '
        'cbo_area
        '
        Me.cbo_area.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.cbo_area.FormattingEnabled = True
        Me.cbo_area.Location = New System.Drawing.Point(39, 106)
        Me.cbo_area.Name = "cbo_area"
        Me.cbo_area.Size = New System.Drawing.Size(250, 30)
        Me.cbo_area.TabIndex = 51
        '
        'btn_entrada
        '
        Me.btn_entrada.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_entrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_entrada.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btn_entrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_entrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_entrada.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.btn_entrada.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_entrada.Location = New System.Drawing.Point(39, 148)
        Me.btn_entrada.Name = "btn_entrada"
        Me.btn_entrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_entrada.Size = New System.Drawing.Size(250, 35)
        Me.btn_entrada.TabIndex = 49
        Me.btn_entrada.Text = "Salvar"
        Me.btn_entrada.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_entrada.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 23)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Área"
        '
        'Page_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(329, 271)
        Me.Controls.Add(Me.cbo_area)
        Me.Controls.Add(Me.btn_entrada)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Page_Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_jbc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents TreinamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InspeçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents cbo_area As ComboBox
    Friend WithEvents btn_entrada As Button
    Friend WithEvents Label6 As Label
End Class
