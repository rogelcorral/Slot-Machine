<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lbSlot1 = New System.Windows.Forms.Label()
        Me.lbSlot2 = New System.Windows.Forms.Label()
        Me.lbSlot3 = New System.Windows.Forms.Label()
        Me.lbResultText = New System.Windows.Forms.Label()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lbWinningLabel = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lbCreditsLeft = New System.Windows.Forms.Label()
        Me.lbCredits = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbSlot1
        '
        Me.lbSlot1.BackColor = System.Drawing.Color.Transparent
        Me.lbSlot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSlot1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbSlot1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSlot1.Location = New System.Drawing.Point(35, 16)
        Me.lbSlot1.Name = "lbSlot1"
        Me.lbSlot1.Size = New System.Drawing.Size(65, 95)
        Me.lbSlot1.TabIndex = 3
        Me.lbSlot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSlot2
        '
        Me.lbSlot2.BackColor = System.Drawing.Color.Transparent
        Me.lbSlot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSlot2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbSlot2.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSlot2.Location = New System.Drawing.Point(135, 16)
        Me.lbSlot2.Name = "lbSlot2"
        Me.lbSlot2.Size = New System.Drawing.Size(65, 95)
        Me.lbSlot2.TabIndex = 4
        Me.lbSlot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSlot3
        '
        Me.lbSlot3.BackColor = System.Drawing.Color.Transparent
        Me.lbSlot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSlot3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbSlot3.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSlot3.Location = New System.Drawing.Point(235, 16)
        Me.lbSlot3.Name = "lbSlot3"
        Me.lbSlot3.Size = New System.Drawing.Size(65, 95)
        Me.lbSlot3.TabIndex = 5
        Me.lbSlot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbResultText
        '
        Me.lbResultText.BackColor = System.Drawing.Color.Lavender
        Me.lbResultText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResultText.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbResultText.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResultText.Location = New System.Drawing.Point(173, 124)
        Me.lbResultText.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbResultText.Name = "lbResultText"
        Me.lbResultText.Size = New System.Drawing.Size(127, 60)
        Me.lbResultText.TabIndex = 7
        Me.lbResultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPull
        '
        Me.btnPull.BackColor = System.Drawing.SystemColors.Control
        Me.btnPull.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPull.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPull.Location = New System.Drawing.Point(35, 278)
        Me.btnPull.MaximumSize = New System.Drawing.Size(75, 70)
        Me.btnPull.MinimumSize = New System.Drawing.Size(75, 70)
        Me.btnPull.Name = "btnPull"
        Me.btnPull.Size = New System.Drawing.Size(75, 70)
        Me.btnPull.TabIndex = 0
        Me.btnPull.Text = "&Pull"
        Me.btnPull.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuit.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(225, 278)
        Me.btnQuit.MaximumSize = New System.Drawing.Size(75, 70)
        Me.btnQuit.MinimumSize = New System.Drawing.Size(75, 70)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 70)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lbWinningLabel
        '
        Me.lbWinningLabel.BackColor = System.Drawing.Color.Transparent
        Me.lbWinningLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWinningLabel.Location = New System.Drawing.Point(35, 124)
        Me.lbWinningLabel.Name = "lbWinningLabel"
        Me.lbWinningLabel.Size = New System.Drawing.Size(127, 60)
        Me.lbWinningLabel.TabIndex = 6
        Me.lbWinningLabel.Text = "Total Winnings:"
        Me.lbWinningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(130, 278)
        Me.btnReset.MaximumSize = New System.Drawing.Size(75, 70)
        Me.btnReset.MinimumSize = New System.Drawing.Size(75, 70)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 70)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&New"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lbCreditsLeft
        '
        Me.lbCreditsLeft.BackColor = System.Drawing.Color.Transparent
        Me.lbCreditsLeft.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCreditsLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbCreditsLeft.Location = New System.Drawing.Point(35, 197)
        Me.lbCreditsLeft.Name = "lbCreditsLeft"
        Me.lbCreditsLeft.Size = New System.Drawing.Size(127, 60)
        Me.lbCreditsLeft.TabIndex = 8
        Me.lbCreditsLeft.Text = "Credits Left:"
        Me.lbCreditsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCredits
        '
        Me.lbCredits.BackColor = System.Drawing.Color.Lavender
        Me.lbCredits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbCredits.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCredits.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCredits.Location = New System.Drawing.Point(173, 197)
        Me.lbCredits.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbCredits.Name = "lbCredits"
        Me.lbCredits.Size = New System.Drawing.Size(127, 60)
        Me.lbCredits.TabIndex = 9
        Me.lbCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.SimpleSlotMachine.My.Resources.Resources.picgifs_powerpuff_girls_4260734
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(340, 88)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(260, 260)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(260, 260)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 260)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Powerpuff", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(340, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 69)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Power Slot Machine"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnPull
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Thistle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(634, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbCreditsLeft)
        Me.Controls.Add(Me.lbCredits)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lbWinningLabel)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPull)
        Me.Controls.Add(Me.lbResultText)
        Me.Controls.Add(Me.lbSlot3)
        Me.Controls.Add(Me.lbSlot2)
        Me.Controls.Add(Me.lbSlot1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 400)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbSlot1 As Label
    Friend WithEvents lbSlot2 As Label
    Friend WithEvents lbSlot3 As Label
    Friend WithEvents lbResultText As Label
    Friend WithEvents btnPull As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lbWinningLabel As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lbCreditsLeft As Label
    Friend WithEvents lbCredits As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
