<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNotepad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotepad))
        Me.txtNotepad = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lblNewFile = New System.Windows.Forms.Label()
        Me.lblOpenFile = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.pnlFile = New System.Windows.Forms.Panel()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblSaveAs = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnNewFile = New System.Windows.Forms.Button()
        Me.pnlClipboard = New System.Windows.Forms.Panel()
        Me.lblClipboard = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCut = New System.Windows.Forms.Label()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.pnlText = New System.Windows.Forms.Panel()
        Me.lblFind = New System.Windows.Forms.Label()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.pnlHelp = New System.Windows.Forms.Panel()
        Me.lblSupport = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.pnlEmpty = New System.Windows.Forms.Panel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.pnlFile.SuspendLayout()
        Me.pnlClipboard.SuspendLayout()
        Me.pnlText.SuspendLayout()
        Me.pnlHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNotepad
        '
        Me.txtNotepad.AcceptsReturn = True
        Me.txtNotepad.AcceptsTab = True
        Me.txtNotepad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotepad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotepad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNotepad.Location = New System.Drawing.Point(5, 77)
        Me.txtNotepad.Margin = New System.Windows.Forms.Padding(20)
        Me.txtNotepad.Multiline = True
        Me.txtNotepad.Name = "txtNotepad"
        Me.txtNotepad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotepad.Size = New System.Drawing.Size(779, 363)
        Me.txtNotepad.TabIndex = 0
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Text Documents (*.txt)|*.txt"
        Me.OpenFileDialog.Title = "Open Text File"
        '
        'lblNewFile
        '
        Me.lblNewFile.AutoSize = True
        Me.lblNewFile.Location = New System.Drawing.Point(12, 42)
        Me.lblNewFile.Name = "lblNewFile"
        Me.lblNewFile.Size = New System.Drawing.Size(29, 13)
        Me.lblNewFile.TabIndex = 5
        Me.lblNewFile.Text = "New"
        '
        'lblOpenFile
        '
        Me.lblOpenFile.AutoSize = True
        Me.lblOpenFile.Location = New System.Drawing.Point(57, 42)
        Me.lblOpenFile.Name = "lblOpenFile"
        Me.lblOpenFile.Size = New System.Drawing.Size(33, 13)
        Me.lblOpenFile.TabIndex = 6
        Me.lblOpenFile.Text = "Open"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Location = New System.Drawing.Point(100, 42)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(32, 13)
        Me.lblSave.TabIndex = 7
        Me.lblSave.Text = "Save"
        '
        'lblPrint
        '
        Me.lblPrint.AutoSize = True
        Me.lblPrint.Location = New System.Drawing.Point(192, 42)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(28, 13)
        Me.lblPrint.TabIndex = 8
        Me.lblPrint.Text = "Print"
        '
        'pnlFile
        '
        Me.pnlFile.BackColor = System.Drawing.SystemColors.Control
        Me.pnlFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFile.Controls.Add(Me.lblFile)
        Me.pnlFile.Controls.Add(Me.lblPrint)
        Me.pnlFile.Controls.Add(Me.lblSaveAs)
        Me.pnlFile.Controls.Add(Me.lblSave)
        Me.pnlFile.Controls.Add(Me.lblOpenFile)
        Me.pnlFile.Controls.Add(Me.lblNewFile)
        Me.pnlFile.Controls.Add(Me.btnPrint)
        Me.pnlFile.Controls.Add(Me.btnSaveAs)
        Me.pnlFile.Controls.Add(Me.btnSave)
        Me.pnlFile.Controls.Add(Me.btnOpenFile)
        Me.pnlFile.Controls.Add(Me.btnNewFile)
        Me.pnlFile.Location = New System.Drawing.Point(0, 0)
        Me.pnlFile.Name = "pnlFile"
        Me.pnlFile.Size = New System.Drawing.Size(240, 75)
        Me.pnlFile.TabIndex = 4
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(108, 60)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(23, 13)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Text = "File"
        '
        'lblSaveAs
        '
        Me.lblSaveAs.AutoSize = True
        Me.lblSaveAs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSaveAs.Location = New System.Drawing.Point(142, 42)
        Me.lblSaveAs.Name = "lblSaveAs"
        Me.lblSaveAs.Size = New System.Drawing.Size(44, 13)
        Me.lblSaveAs.TabIndex = 8
        Me.lblSaveAs.Text = "SaveAs"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.Print_32x
        Me.btnPrint.Location = New System.Drawing.Point(184, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(40, 40)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSaveAs.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnSaveAs.FlatAppearance.BorderSize = 0
        Me.btnSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAs.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.Save_As_32
        Me.btnSaveAs.Location = New System.Drawing.Point(140, 5)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(40, 40)
        Me.btnSaveAs.TabIndex = 3
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.Save_32x
        Me.btnSave.Location = New System.Drawing.Point(95, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(40, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnOpenFile.FlatAppearance.BorderSize = 0
        Me.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFile.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.FolderOpen_32x
        Me.btnOpenFile.Location = New System.Drawing.Point(50, 5)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(40, 40)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'btnNewFile
        '
        Me.btnNewFile.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnNewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNewFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnNewFile.FlatAppearance.BorderSize = 0
        Me.btnNewFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewFile.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.Document_32x
        Me.btnNewFile.Location = New System.Drawing.Point(5, 5)
        Me.btnNewFile.Name = "btnNewFile"
        Me.btnNewFile.Size = New System.Drawing.Size(40, 40)
        Me.btnNewFile.TabIndex = 1
        Me.btnNewFile.UseVisualStyleBackColor = False
        '
        'pnlClipboard
        '
        Me.pnlClipboard.BackColor = System.Drawing.SystemColors.MenuBar
        Me.pnlClipboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlClipboard.Controls.Add(Me.lblClipboard)
        Me.pnlClipboard.Controls.Add(Me.Label2)
        Me.pnlClipboard.Controls.Add(Me.Label1)
        Me.pnlClipboard.Controls.Add(Me.lblCut)
        Me.pnlClipboard.Controls.Add(Me.btnCut)
        Me.pnlClipboard.Controls.Add(Me.btnCopy)
        Me.pnlClipboard.Controls.Add(Me.btnPaste)
        Me.pnlClipboard.Location = New System.Drawing.Point(245, 0)
        Me.pnlClipboard.Name = "pnlClipboard"
        Me.pnlClipboard.Size = New System.Drawing.Size(170, 75)
        Me.pnlClipboard.TabIndex = 5
        '
        'lblClipboard
        '
        Me.lblClipboard.AutoSize = True
        Me.lblClipboard.Location = New System.Drawing.Point(59, 58)
        Me.lblClipboard.Name = "lblClipboard"
        Me.lblClipboard.Size = New System.Drawing.Size(51, 13)
        Me.lblClipboard.TabIndex = 10
        Me.lblClipboard.Text = "Clipboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Paste"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Copy"
        '
        'lblCut
        '
        Me.lblCut.AutoSize = True
        Me.lblCut.Location = New System.Drawing.Point(32, 42)
        Me.lblCut.Name = "lblCut"
        Me.lblCut.Size = New System.Drawing.Size(23, 13)
        Me.lblCut.TabIndex = 5
        Me.lblCut.Text = "Cut"
        '
        'btnCut
        '
        Me.btnCut.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCut.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnCut.FlatAppearance.BorderSize = 0
        Me.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCut.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.Cut_32
        Me.btnCut.Location = New System.Drawing.Point(20, 5)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(40, 40)
        Me.btnCut.TabIndex = 4
        Me.btnCut.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCopy.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.Copy_32x
        Me.btnCopy.Location = New System.Drawing.Point(65, 5)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(40, 40)
        Me.btnCopy.TabIndex = 3
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPaste.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnPaste.FlatAppearance.BorderSize = 0
        Me.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaste.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.Paste_32
        Me.btnPaste.Location = New System.Drawing.Point(110, 5)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(40, 40)
        Me.btnPaste.TabIndex = 2
        Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.Filter = "Text Documents (*.txt)|*.txt"
        Me.SaveFileDialog.Title = "SuperNotepad Save As"
        '
        'pnlText
        '
        Me.pnlText.BackColor = System.Drawing.SystemColors.MenuBar
        Me.pnlText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlText.Controls.Add(Me.lblFind)
        Me.pnlText.Controls.Add(Me.lblFont)
        Me.pnlText.Controls.Add(Me.btnFont)
        Me.pnlText.Controls.Add(Me.btnFind)
        Me.pnlText.Controls.Add(Me.lblText)
        Me.pnlText.Location = New System.Drawing.Point(420, 0)
        Me.pnlText.Name = "pnlText"
        Me.pnlText.Size = New System.Drawing.Size(125, 75)
        Me.pnlText.TabIndex = 7
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.Location = New System.Drawing.Point(75, 42)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(27, 13)
        Me.lblFind.TabIndex = 14
        Me.lblFind.Text = "Find"
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(28, 42)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(28, 13)
        Me.lblFont.TabIndex = 13
        Me.lblFont.Text = "Font"
        '
        'btnFont
        '
        Me.btnFont.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFont.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnFont.FlatAppearance.BorderSize = 0
        Me.btnFont.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFont.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.Font_32x
        Me.btnFont.Location = New System.Drawing.Point(20, 5)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(40, 40)
        Me.btnFont.TabIndex = 12
        Me.btnFont.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFind.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.if_magnifying_glass_search_1891418
        Me.btnFind.Location = New System.Drawing.Point(65, 5)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(40, 40)
        Me.btnFind.TabIndex = 11
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(48, 60)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(28, 13)
        Me.lblText.TabIndex = 10
        Me.lblText.Text = "Text"
        '
        'pnlHelp
        '
        Me.pnlHelp.BackColor = System.Drawing.SystemColors.MenuBar
        Me.pnlHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHelp.Controls.Add(Me.lblSupport)
        Me.pnlHelp.Controls.Add(Me.lblHelp)
        Me.pnlHelp.Controls.Add(Me.btnHelp)
        Me.pnlHelp.Location = New System.Drawing.Point(550, 0)
        Me.pnlHelp.Name = "pnlHelp"
        Me.pnlHelp.Size = New System.Drawing.Size(80, 75)
        Me.pnlHelp.TabIndex = 8
        '
        'lblSupport
        '
        Me.lblSupport.AutoSize = True
        Me.lblSupport.Location = New System.Drawing.Point(18, 58)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(44, 13)
        Me.lblSupport.TabIndex = 16
        Me.lblSupport.Text = "Support"
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Location = New System.Drawing.Point(25, 42)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(29, 13)
        Me.lblHelp.TabIndex = 15
        Me.lblHelp.Text = "Help"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Image = Global.SuperNotepad_Joseph_Virtu.My.Resources.Resources.HelpApplication_32x
        Me.btnHelp.Location = New System.Drawing.Point(17, 5)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 12
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'FontDialog
        '
        Me.FontDialog.ShowColor = True
        '
        'pnlEmpty
        '
        Me.pnlEmpty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEmpty.BackColor = System.Drawing.SystemColors.MenuBar
        Me.pnlEmpty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEmpty.Location = New System.Drawing.Point(635, 0)
        Me.pnlEmpty.Name = "pnlEmpty"
        Me.pnlEmpty.Size = New System.Drawing.Size(147, 75)
        Me.pnlEmpty.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip"
        '
        'PrintDialog
        '
        Me.PrintDialog.AllowPrintToFile = False
        Me.PrintDialog.UseEXDialog = True
        '
        'FrmNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlEmpty)
        Me.Controls.Add(Me.pnlHelp)
        Me.Controls.Add(Me.pnlText)
        Me.Controls.Add(Me.pnlClipboard)
        Me.Controls.Add(Me.pnlFile)
        Me.Controls.Add(Me.txtNotepad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNotepad"
        Me.Text = "Untitled - SuperNotepad"
        Me.pnlFile.ResumeLayout(False)
        Me.pnlFile.PerformLayout()
        Me.pnlClipboard.ResumeLayout(False)
        Me.pnlClipboard.PerformLayout()
        Me.pnlText.ResumeLayout(False)
        Me.pnlText.PerformLayout()
        Me.pnlHelp.ResumeLayout(False)
        Me.pnlHelp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNotepad As TextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSaveAs As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNewFile As Button
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents lblNewFile As Label
    Friend WithEvents lblOpenFile As Label
    Friend WithEvents lblSave As Label
    Friend WithEvents lblPrint As Label
    Friend WithEvents pnlFile As Panel
    Friend WithEvents lblSaveAs As Label
    Friend WithEvents lblFile As Label
    Friend WithEvents pnlClipboard As Panel
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents btnCut As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnPaste As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCut As Label
    Friend WithEvents lblClipboard As Label
    Friend WithEvents pnlText As Panel
    Friend WithEvents lblText As Label
    Friend WithEvents btnFont As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents lblFind As Label
    Friend WithEvents lblFont As Label
    Friend WithEvents pnlHelp As Panel
    Friend WithEvents lblHelp As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents lblSupport As Label
    Friend WithEvents FontDialog As FontDialog
    Friend WithEvents pnlEmpty As Panel
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PrintDialog As PrintDialog
End Class
