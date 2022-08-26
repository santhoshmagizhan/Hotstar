<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.FormBorder = New System.Windows.Forms.Panel()
        Me.Titlepanel = New System.Windows.Forms.Panel()
        Me.Hotstar_title = New System.Windows.Forms.Label()
        Me.controlBoxP = New System.Windows.Forms.Panel()
        Me.settingsbtn = New System.Windows.Forms.PictureBox()
        Me.miniPanel = New System.Windows.Forms.Panel()
        Me.minBtn = New System.Windows.Forms.PictureBox()
        Me.maxiPanel = New System.Windows.Forms.Panel()
        Me.maxminBtn = New System.Windows.Forms.PictureBox()
        Me.closePanel = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.settingsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PiPSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoWatermarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contentContainer = New System.Windows.Forms.Panel()
        Me.LoaderImg = New System.Windows.Forms.PictureBox()
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormBorder.SuspendLayout()
        Me.Titlepanel.SuspendLayout()
        Me.controlBoxP.SuspendLayout()
        CType(Me.settingsbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.miniPanel.SuspendLayout()
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.maxiPanel.SuspendLayout()
        CType(Me.maxminBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.closePanel.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingsMenu.SuspendLayout()
        Me.contentContainer.SuspendLayout()
        CType(Me.LoaderImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView21.Location = New System.Drawing.Point(0, 0)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(796, 421)
        Me.WebView21.TabIndex = 3
        Me.WebView21.ZoomFactor = 1.0R
        '
        'FormBorder
        '
        Me.FormBorder.BackColor = System.Drawing.Color.Transparent
        Me.FormBorder.BackgroundImage = Global.Hotstar.My.Resources.Resources.header_1
        Me.FormBorder.Controls.Add(Me.Titlepanel)
        Me.FormBorder.Controls.Add(Me.controlBoxP)
        Me.FormBorder.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormBorder.Location = New System.Drawing.Point(0, 0)
        Me.FormBorder.Name = "FormBorder"
        Me.FormBorder.Size = New System.Drawing.Size(800, 26)
        Me.FormBorder.TabIndex = 6
        '
        'Titlepanel
        '
        Me.Titlepanel.Controls.Add(Me.Hotstar_title)
        Me.Titlepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Titlepanel.Location = New System.Drawing.Point(0, 0)
        Me.Titlepanel.Name = "Titlepanel"
        Me.Titlepanel.Size = New System.Drawing.Size(126, 26)
        Me.Titlepanel.TabIndex = 4
        '
        'Hotstar_title
        '
        Me.Hotstar_title.AutoSize = True
        Me.Hotstar_title.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Hotstar_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Hotstar_title.Location = New System.Drawing.Point(12, 7)
        Me.Hotstar_title.Name = "Hotstar_title"
        Me.Hotstar_title.Size = New System.Drawing.Size(110, 17)
        Me.Hotstar_title.TabIndex = 3
        Me.Hotstar_title.Text = "Disnep+ Hotstar"
        '
        'controlBoxP
        '
        Me.controlBoxP.BackColor = System.Drawing.Color.Transparent
        Me.controlBoxP.Controls.Add(Me.settingsbtn)
        Me.controlBoxP.Controls.Add(Me.miniPanel)
        Me.controlBoxP.Controls.Add(Me.maxiPanel)
        Me.controlBoxP.Controls.Add(Me.closePanel)
        Me.controlBoxP.Dock = System.Windows.Forms.DockStyle.Right
        Me.controlBoxP.Location = New System.Drawing.Point(642, 0)
        Me.controlBoxP.Name = "controlBoxP"
        Me.controlBoxP.Size = New System.Drawing.Size(158, 26)
        Me.controlBoxP.TabIndex = 2
        '
        'settingsbtn
        '
        Me.settingsbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settingsbtn.Image = Global.Hotstar.My.Resources.Resources.settings
        Me.settingsbtn.Location = New System.Drawing.Point(0, 0)
        Me.settingsbtn.Name = "settingsbtn"
        Me.settingsbtn.Size = New System.Drawing.Size(41, 26)
        Me.settingsbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.settingsbtn.TabIndex = 4
        Me.settingsbtn.TabStop = False
        Me.tooltip.SetToolTip(Me.settingsbtn, "Settings")
        '
        'miniPanel
        '
        Me.miniPanel.BackColor = System.Drawing.Color.Transparent
        Me.miniPanel.Controls.Add(Me.minBtn)
        Me.miniPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.miniPanel.Location = New System.Drawing.Point(41, 0)
        Me.miniPanel.Name = "miniPanel"
        Me.miniPanel.Size = New System.Drawing.Size(39, 26)
        Me.miniPanel.TabIndex = 3
        '
        'minBtn
        '
        Me.minBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.minBtn.Image = Global.Hotstar.My.Resources.Resources.sm_miniwhite
        Me.minBtn.Location = New System.Drawing.Point(0, 0)
        Me.minBtn.Name = "minBtn"
        Me.minBtn.Size = New System.Drawing.Size(39, 26)
        Me.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minBtn.TabIndex = 2
        Me.minBtn.TabStop = False
        Me.tooltip.SetToolTip(Me.minBtn, "Minimize")
        '
        'maxiPanel
        '
        Me.maxiPanel.BackColor = System.Drawing.Color.Transparent
        Me.maxiPanel.Controls.Add(Me.maxminBtn)
        Me.maxiPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.maxiPanel.Location = New System.Drawing.Point(80, 0)
        Me.maxiPanel.Name = "maxiPanel"
        Me.maxiPanel.Size = New System.Drawing.Size(39, 26)
        Me.maxiPanel.TabIndex = 2
        '
        'maxminBtn
        '
        Me.maxminBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maxminBtn.ErrorImage = Global.Hotstar.My.Resources.Resources.sm_square_white
        Me.maxminBtn.Image = Global.Hotstar.My.Resources.Resources.sm_square_white
        Me.maxminBtn.Location = New System.Drawing.Point(0, 0)
        Me.maxminBtn.Name = "maxminBtn"
        Me.maxminBtn.Size = New System.Drawing.Size(39, 26)
        Me.maxminBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maxminBtn.TabIndex = 2
        Me.maxminBtn.TabStop = False
        Me.tooltip.SetToolTip(Me.maxminBtn, "Normal")
        '
        'closePanel
        '
        Me.closePanel.BackColor = System.Drawing.Color.Transparent
        Me.closePanel.Controls.Add(Me.closeBtn)
        Me.closePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.closePanel.Location = New System.Drawing.Point(119, 0)
        Me.closePanel.Name = "closePanel"
        Me.closePanel.Size = New System.Drawing.Size(39, 26)
        Me.closePanel.TabIndex = 1
        '
        'closeBtn
        '
        Me.closeBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.closeBtn.ErrorImage = Nothing
        Me.closeBtn.Image = Global.Hotstar.My.Resources.Resources.sm_closewhite
        Me.closeBtn.Location = New System.Drawing.Point(0, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(39, 26)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeBtn.TabIndex = 1
        Me.closeBtn.TabStop = False
        Me.tooltip.SetToolTip(Me.closeBtn, "Close")
        '
        'settingsMenu
        '
        Me.settingsMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.settingsMenu.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.settingsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PiPSizeToolStripMenuItem, Me.VideoWatermarkToolStripMenuItem})
        Me.settingsMenu.Name = "settingsMenu"
        Me.settingsMenu.Size = New System.Drawing.Size(201, 74)
        '
        'PiPSizeToolStripMenuItem
        '
        Me.PiPSizeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PiPSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.PiPSizeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PiPSizeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.PiPSizeToolStripMenuItem.Name = "PiPSizeToolStripMenuItem"
        Me.PiPSizeToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.PiPSizeToolStripMenuItem.Text = "PiP Size"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem2.Image = Global.Hotstar.My.Resources.Resources.tick
        Me.ToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem2.Text = "30%"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem3.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem3.Text = "35%"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem4.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem4.Text = "40%"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem5.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem5.Text = "45%"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem6.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem6.Text = "50%"
        '
        'VideoWatermarkToolStripMenuItem
        '
        Me.VideoWatermarkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.VideoWatermarkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem, Me.DisabledToolStripMenuItem})
        Me.VideoWatermarkToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VideoWatermarkToolStripMenuItem.Name = "VideoWatermarkToolStripMenuItem"
        Me.VideoWatermarkToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.VideoWatermarkToolStripMenuItem.Text = "Video Watermark"
        '
        'EnabledToolStripMenuItem
        '
        Me.EnabledToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.EnabledToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EnabledToolStripMenuItem.Image = Global.Hotstar.My.Resources.Resources.tick
        Me.EnabledToolStripMenuItem.Name = "EnabledToolStripMenuItem"
        Me.EnabledToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.EnabledToolStripMenuItem.Text = "Enabled"
        '
        'DisabledToolStripMenuItem
        '
        Me.DisabledToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.DisabledToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DisabledToolStripMenuItem.Name = "DisabledToolStripMenuItem"
        Me.DisabledToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.DisabledToolStripMenuItem.Text = "Disabled"
        '
        'contentContainer
        '
        Me.contentContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contentContainer.Controls.Add(Me.LoaderImg)
        Me.contentContainer.Controls.Add(Me.WebView21)
        Me.contentContainer.Location = New System.Drawing.Point(2, 26)
        Me.contentContainer.Name = "contentContainer"
        Me.contentContainer.Size = New System.Drawing.Size(796, 421)
        Me.contentContainer.TabIndex = 7
        '
        'LoaderImg
        '
        Me.LoaderImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LoaderImg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoaderImg.Image = CType(resources.GetObject("LoaderImg.Image"), System.Drawing.Image)
        Me.LoaderImg.Location = New System.Drawing.Point(0, 0)
        Me.LoaderImg.Name = "LoaderImg"
        Me.LoaderImg.Size = New System.Drawing.Size(796, 421)
        Me.LoaderImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LoaderImg.TabIndex = 6
        Me.LoaderImg.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.contentContainer)
        Me.Controls.Add(Me.FormBorder)
        Me.Font = New System.Drawing.Font("Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(590, 360)
        Me.Name = "Form1"
        Me.Text = "Disney+ Hotstar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormBorder.ResumeLayout(False)
        Me.Titlepanel.ResumeLayout(False)
        Me.Titlepanel.PerformLayout()
        Me.controlBoxP.ResumeLayout(False)
        CType(Me.settingsbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.miniPanel.ResumeLayout(False)
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.maxiPanel.ResumeLayout(False)
        CType(Me.maxminBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.closePanel.ResumeLayout(False)
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingsMenu.ResumeLayout(False)
        Me.contentContainer.ResumeLayout(False)
        CType(Me.LoaderImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents FormBorder As Panel
    Friend WithEvents contentContainer As Panel
    Friend WithEvents LoaderImg As PictureBox
    Friend WithEvents controlBoxP As Panel
    Friend WithEvents miniPanel As Panel
    Friend WithEvents minBtn As PictureBox
    Friend WithEvents maxiPanel As Panel
    Friend WithEvents maxminBtn As PictureBox
    Friend WithEvents closePanel As Panel
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents Titlepanel As Panel
    Friend WithEvents Hotstar_title As Label
    Friend WithEvents settingsbtn As PictureBox
    Friend WithEvents tooltip As ToolTip
    Friend WithEvents settingsMenu As ContextMenuStrip
    Friend WithEvents PiPSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents VideoWatermarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnabledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisabledToolStripMenuItem As ToolStripMenuItem
End Class
