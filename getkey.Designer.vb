<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class getkey
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
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.enterb = New System.Windows.Forms.Button()
        Me.titlelabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mainpanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainpanel.Controls.Add(Me.LinkLabel1)
        Me.mainpanel.Controls.Add(Me.Panel1)
        Me.mainpanel.Controls.Add(Me.titlelabel)
        Me.mainpanel.Controls.Add(Me.PictureBox2)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(0, 0)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(282, 196)
        Me.mainpanel.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(88, 178)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(104, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.wrlabstudios.tk"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.enterb)
        Me.Panel1.Location = New System.Drawing.Point(-1, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 147)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Informe a chave de segurança desejada:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(53, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(175, 20)
        Me.TextBox1.TabIndex = 1
        '
        'enterb
        '
        Me.enterb.BackColor = System.Drawing.Color.LightSteelBlue
        Me.enterb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.enterb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.enterb.Location = New System.Drawing.Point(101, 106)
        Me.enterb.Name = "enterb"
        Me.enterb.Size = New System.Drawing.Size(75, 23)
        Me.enterb.TabIndex = 2
        Me.enterb.Text = "Entrar"
        Me.enterb.UseVisualStyleBackColor = False
        '
        'titlelabel
        '
        Me.titlelabel.AutoSize = True
        Me.titlelabel.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlelabel.ForeColor = System.Drawing.SystemColors.Control
        Me.titlelabel.Location = New System.Drawing.Point(6, 5)
        Me.titlelabel.Name = "titlelabel"
        Me.titlelabel.Size = New System.Drawing.Size(212, 19)
        Me.titlelabel.TabIndex = 8
        Me.titlelabel.Text = "My Trust Files - WrLabStudios"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Image = Global.wrlabstudios.mytrustfiles.opensource.My.Resources.Resources.close_pas
        Me.PictureBox2.Location = New System.Drawing.Point(259, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'getkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 196)
        Me.Controls.Add(Me.mainpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "getkey"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "getkey"
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainpanel As System.Windows.Forms.Panel
    Friend WithEvents titlelabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents enterb As System.Windows.Forms.Button
End Class
