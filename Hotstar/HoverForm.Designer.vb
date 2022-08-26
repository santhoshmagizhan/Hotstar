<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HoverForm
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.hoverpanel = New System.Windows.Forms.Panel()
        Me.titlepanel = New System.Windows.Forms.Panel()
        Me.pausenplay = New System.Windows.Forms.PictureBox()
        Me.closePIP = New System.Windows.Forms.PictureBox()
        Me.maxiPIP = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.hoverpanel.SuspendLayout()
        Me.titlepanel.SuspendLayout()
        CType(Me.pausenplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closePIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxiPIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'hoverpanel
        '
        Me.hoverpanel.BackColor = System.Drawing.Color.Transparent
        Me.hoverpanel.Controls.Add(Me.titlepanel)
        Me.hoverpanel.Controls.Add(Me.maxiPIP)
        Me.hoverpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hoverpanel.Location = New System.Drawing.Point(0, 0)
        Me.hoverpanel.Name = "hoverpanel"
        Me.hoverpanel.Size = New System.Drawing.Size(800, 450)
        Me.hoverpanel.TabIndex = 0
        '
        'titlepanel
        '
        Me.titlepanel.Controls.Add(Me.pausenplay)
        Me.titlepanel.Controls.Add(Me.closePIP)
        Me.titlepanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlepanel.Location = New System.Drawing.Point(0, 0)
        Me.titlepanel.Name = "titlepanel"
        Me.titlepanel.Size = New System.Drawing.Size(800, 28)
        Me.titlepanel.TabIndex = 1
        '
        'pausenplay
        '
        Me.pausenplay.Dock = System.Windows.Forms.DockStyle.Left
        Me.pausenplay.Image = Global.Hotstar.My.Resources.Resources.pause
        Me.pausenplay.Location = New System.Drawing.Point(0, 0)
        Me.pausenplay.Name = "pausenplay"
        Me.pausenplay.Size = New System.Drawing.Size(39, 28)
        Me.pausenplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pausenplay.TabIndex = 1
        Me.pausenplay.TabStop = False
        '
        'closePIP
        '
        Me.closePIP.Dock = System.Windows.Forms.DockStyle.Right
        Me.closePIP.Image = Global.Hotstar.My.Resources.Resources.sm_closewhite
        Me.closePIP.Location = New System.Drawing.Point(761, 0)
        Me.closePIP.Name = "closePIP"
        Me.closePIP.Size = New System.Drawing.Size(39, 28)
        Me.closePIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closePIP.TabIndex = 0
        Me.closePIP.TabStop = False
        '
        'maxiPIP
        '
        Me.maxiPIP.BackColor = System.Drawing.Color.Transparent
        Me.maxiPIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maxiPIP.Image = Global.Hotstar.My.Resources.Resources.maxi
        Me.maxiPIP.Location = New System.Drawing.Point(0, 0)
        Me.maxiPIP.Name = "maxiPIP"
        Me.maxiPIP.Size = New System.Drawing.Size(800, 450)
        Me.maxiPIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maxiPIP.TabIndex = 0
        Me.maxiPIP.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'HoverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.hoverpanel)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HoverForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "HoverForm"
        Me.hoverpanel.ResumeLayout(False)
        Me.titlepanel.ResumeLayout(False)
        CType(Me.pausenplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closePIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxiPIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents hoverpanel As Panel
    Friend WithEvents maxiPIP As PictureBox
    Friend WithEvents closePIP As PictureBox
    Friend WithEvents titlepanel As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents pausenplay As PictureBox
End Class
