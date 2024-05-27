<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page_Entrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page_Entrada))
        Me.txt_jbc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_caixa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_caixa = New System.Windows.Forms.CheckBox()
        Me.btn_entrada = New System.Windows.Forms.Button()
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
        Me.txt_jbc.Size = New System.Drawing.Size(65, 36)
        Me.txt_jbc.TabIndex = 9
        Me.txt_jbc.Text = "JBC"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(86, 318)
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
        Me.Label3.Location = New System.Drawing.Point(211, 318)
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
        Me.Label5.Location = New System.Drawing.Point(109, 318)
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
        'txt_caixa
        '
        Me.txt_caixa.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_caixa.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txt_caixa.Location = New System.Drawing.Point(44, 90)
        Me.txt_caixa.Name = "txt_caixa"
        Me.txt_caixa.Size = New System.Drawing.Size(154, 29)
        Me.txt_caixa.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(40, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 23)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Código da caixa"
        '
        'txt_cv
        '
        Me.txt_cv.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_cv.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txt_cv.Location = New System.Drawing.Point(45, 157)
        Me.txt_cv.Name = "txt_cv"
        Me.txt_cv.Size = New System.Drawing.Size(250, 29)
        Me.txt_cv.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Código do cartão vermelho"
        '
        'txt_pn
        '
        Me.txt_pn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_pn.Enabled = False
        Me.txt_pn.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txt_pn.Location = New System.Drawing.Point(46, 222)
        Me.txt_pn.Name = "txt_pn"
        Me.txt_pn.Size = New System.Drawing.Size(152, 29)
        Me.txt_pn.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(42, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "PartNumber"
        '
        'txt_qtd
        '
        Me.txt_qtd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_qtd.Enabled = False
        Me.txt_qtd.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txt_qtd.Location = New System.Drawing.Point(204, 222)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(90, 29)
        Me.txt_qtd.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(200, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 23)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Quantidade"
        '
        'cb_caixa
        '
        Me.cb_caixa.AutoSize = True
        Me.cb_caixa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_caixa.ForeColor = System.Drawing.Color.White
        Me.cb_caixa.Location = New System.Drawing.Point(204, 93)
        Me.cb_caixa.Name = "cb_caixa"
        Me.cb_caixa.Size = New System.Drawing.Size(91, 24)
        Me.cb_caixa.TabIndex = 49
        Me.cb_caixa.Text = "Sem caixa"
        Me.cb_caixa.UseVisualStyleBackColor = True
        '
        'btn_entrada
        '
        Me.btn_entrada.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_entrada.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_entrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_entrada.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btn_entrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_entrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_entrada.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.btn_entrada.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_entrada.Image = Global.Contencao.My.Resources.Resources.fluent__box_arrow_left_20_regular
        Me.btn_entrada.Location = New System.Drawing.Point(44, 265)
        Me.btn_entrada.Name = "btn_entrada"
        Me.btn_entrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_entrada.Size = New System.Drawing.Size(250, 40)
        Me.btn_entrada.TabIndex = 29
        Me.btn_entrada.Text = "Entrada"
        Me.btn_entrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_entrada.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_entrada.UseVisualStyleBackColor = False
        '
        'Page_Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(329, 371)
        Me.Controls.Add(Me.cb_caixa)
        Me.Controls.Add(Me.txt_qtd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_pn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_entrada)
        Me.Controls.Add(Me.txt_caixa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Page_Entrada"
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
    Friend WithEvents btn_entrada As Button
    Friend WithEvents txt_caixa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_caixa As CheckBox
End Class
