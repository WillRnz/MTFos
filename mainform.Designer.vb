<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.openfile_txts = New System.Windows.Forms.OpenFileDialog()
        Me.savefile_txts = New System.Windows.Forms.SaveFileDialog()
        Me.openfile_image = New System.Windows.Forms.OpenFileDialog()
        Me.savefile_image = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cryptbox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.criptedimage = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.saveb = New System.Windows.Forms.Button()
        Me.openb = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbt = New System.Windows.Forms.Button()
        Me.salvar_se = New System.Windows.Forms.Button()
        Me.minimize_btn = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.PictureBox()
        Me.titlelabel = New System.Windows.Forms.Label()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.criptedimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.minimize_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'openfile_txts
        '
        Me.openfile_txts.Filter = "WSecurity File|*.wrlab"
        '
        'savefile_txts
        '
        Me.savefile_txts.Filter = "WSecurity File|*.wrlab"
        '
        'openfile_image
        '
        Me.openfile_image.Filter = "WSecurity Image File|*.gif;*.jpg;*.jpeg;*.wmf;*.bmp;*.png;*.tiff"
        '
        'savefile_image
        '
        Me.savefile_image.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Im" &
    "age (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(533, 392)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.cryptbox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(525, 366)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Textos"
        '
        'cryptbox
        '
        Me.cryptbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cryptbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cryptbox.Location = New System.Drawing.Point(0, 0)
        Me.cryptbox.Multiline = True
        Me.cryptbox.Name = "cryptbox"
        Me.cryptbox.Size = New System.Drawing.Size(525, 366)
        Me.cryptbox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.criptedimage)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(525, 366)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Imagem"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'criptedimage
        '
        Me.criptedimage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.criptedimage.Location = New System.Drawing.Point(0, 0)
        Me.criptedimage.Margin = New System.Windows.Forms.Padding(0)
        Me.criptedimage.Name = "criptedimage"
        Me.criptedimage.Size = New System.Drawing.Size(525, 366)
        Me.criptedimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.criptedimage.TabIndex = 3
        Me.criptedimage.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.LinkLabel2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(525, 366)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sobre"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(185, 129)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(122, 20)
        Me.LinkLabel2.TabIndex = 16
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "WrLAB Studios"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Visite:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(44, 173)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(449, 164)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "~~ WrLab Studios ~~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ver: OS Rev1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Algoritimo: Rijndael 256" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Modo: ECB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hash: SHA" &
    "256" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Atualizações recebidas via GitHub"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(185, 101)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(107, 20)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "William Aniz"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Desenvolvedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(68, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 79)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "My Trust Files"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.saveb)
        Me.Panel2.Controls.Add(Me.openb)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cbt)
        Me.Panel2.Controls.Add(Me.salvar_se)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(533, 43)
        Me.Panel2.TabIndex = 1
        '
        'saveb
        '
        Me.saveb.BackColor = System.Drawing.Color.LightSteelBlue
        Me.saveb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.saveb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveb.Location = New System.Drawing.Point(340, 15)
        Me.saveb.Name = "saveb"
        Me.saveb.Size = New System.Drawing.Size(75, 23)
        Me.saveb.TabIndex = 11
        Me.saveb.Text = "Salvar"
        Me.saveb.UseVisualStyleBackColor = False
        '
        'openb
        '
        Me.openb.BackColor = System.Drawing.Color.LightSteelBlue
        Me.openb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.openb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.openb.Location = New System.Drawing.Point(258, 15)
        Me.openb.Name = "openb"
        Me.openb.Size = New System.Drawing.Size(75, 23)
        Me.openb.TabIndex = 10
        Me.openb.Text = "Abrir"
        Me.openb.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.Location = New System.Drawing.Point(7, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "My Trust Files"
        '
        'cbt
        '
        Me.cbt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cbt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.cbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbt.Location = New System.Drawing.Point(421, 15)
        Me.cbt.Name = "cbt"
        Me.cbt.Size = New System.Drawing.Size(75, 23)
        Me.cbt.TabIndex = 2
        Me.cbt.Text = "Cript. Texto"
        Me.cbt.UseVisualStyleBackColor = False
        '
        'salvar_se
        '
        Me.salvar_se.BackColor = System.Drawing.Color.LightSteelBlue
        Me.salvar_se.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.salvar_se.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.salvar_se.Location = New System.Drawing.Point(421, 15)
        Me.salvar_se.Name = "salvar_se"
        Me.salvar_se.Size = New System.Drawing.Size(75, 23)
        Me.salvar_se.TabIndex = 12
        Me.salvar_se.Text = "Salvar SE."
        Me.salvar_se.UseVisualStyleBackColor = False
        '
        'minimize_btn
        '
        Me.minimize_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.minimize_btn.Image = Global.wrlabstudios.mytrustfiles.opensource.My.Resources.Resources.min_pas
        Me.minimize_btn.Location = New System.Drawing.Point(496, 3)
        Me.minimize_btn.Name = "minimize_btn"
        Me.minimize_btn.Size = New System.Drawing.Size(16, 16)
        Me.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimize_btn.TabIndex = 6
        Me.minimize_btn.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.close_btn.Image = Global.wrlabstudios.mytrustfiles.opensource.My.Resources.Resources.close_pas
        Me.close_btn.Location = New System.Drawing.Point(513, 3)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(16, 16)
        Me.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_btn.TabIndex = 7
        Me.close_btn.TabStop = False
        '
        'titlelabel
        '
        Me.titlelabel.AutoSize = True
        Me.titlelabel.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlelabel.ForeColor = System.Drawing.SystemColors.Control
        Me.titlelabel.Location = New System.Drawing.Point(169, 0)
        Me.titlelabel.Name = "titlelabel"
        Me.titlelabel.Size = New System.Drawing.Size(236, 19)
        Me.titlelabel.TabIndex = 8
        Me.titlelabel.Text = "My Trust Files - WrabStudios 2017"
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainpanel.Controls.Add(Me.titlelabel)
        Me.mainpanel.Controls.Add(Me.close_btn)
        Me.mainpanel.Controls.Add(Me.minimize_btn)
        Me.mainpanel.Controls.Add(Me.Panel2)
        Me.mainpanel.Controls.Add(Me.TabControl1)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(0, 0)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(535, 440)
        Me.mainpanel.TabIndex = 0
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 440)
        Me.Controls.Add(Me.mainpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainform"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Trust Files - WrabStudios 2017"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.criptedimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.minimize_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openfile_txts As System.Windows.Forms.OpenFileDialog
    Friend WithEvents savefile_txts As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openfile_image As OpenFileDialog
    Friend WithEvents savefile_image As SaveFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cryptbox As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents criptedimage As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label3 As Label
    Protected WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents saveb As Button
    Friend WithEvents openb As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbt As Button
    Friend WithEvents salvar_se As Button
    Friend WithEvents minimize_btn As PictureBox
    Friend WithEvents close_btn As PictureBox
    Friend WithEvents titlelabel As Label
    Friend WithEvents mainpanel As Panel
End Class
