<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFind))
        Me.lblFindWhat = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpDirection = New System.Windows.Forms.GroupBox()
        Me.radDown = New System.Windows.Forms.RadioButton()
        Me.radUp = New System.Windows.Forms.RadioButton()
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.grpDirection.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFindWhat
        '
        Me.lblFindWhat.AutoSize = True
        Me.lblFindWhat.Location = New System.Drawing.Point(2, 13)
        Me.lblFindWhat.Name = "lblFindWhat"
        Me.lblFindWhat.Size = New System.Drawing.Size(56, 13)
        Me.lblFindWhat.TabIndex = 0
        Me.lblFindWhat.Text = "Find what:"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(64, 10)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(181, 20)
        Me.txtFind.TabIndex = 1
        '
        'btnFindNext
        '
        Me.btnFindNext.Location = New System.Drawing.Point(260, 6)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(75, 23)
        Me.btnFindNext.TabIndex = 2
        Me.btnFindNext.Text = "&Find Next"
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(260, 35)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpDirection
        '
        Me.grpDirection.Controls.Add(Me.radDown)
        Me.grpDirection.Controls.Add(Me.radUp)
        Me.grpDirection.Location = New System.Drawing.Point(147, 46)
        Me.grpDirection.Name = "grpDirection"
        Me.grpDirection.Size = New System.Drawing.Size(107, 38)
        Me.grpDirection.TabIndex = 4
        Me.grpDirection.TabStop = False
        Me.grpDirection.Text = "Direction"
        '
        'radDown
        '
        Me.radDown.AutoSize = True
        Me.radDown.Checked = True
        Me.radDown.Location = New System.Drawing.Point(52, 15)
        Me.radDown.Name = "radDown"
        Me.radDown.Size = New System.Drawing.Size(53, 17)
        Me.radDown.TabIndex = 1
        Me.radDown.TabStop = True
        Me.radDown.Text = "&Down"
        Me.radDown.UseVisualStyleBackColor = True
        '
        'radUp
        '
        Me.radUp.AutoSize = True
        Me.radUp.Location = New System.Drawing.Point(7, 15)
        Me.radUp.Name = "radUp"
        Me.radUp.Size = New System.Drawing.Size(39, 17)
        Me.radUp.TabIndex = 0
        Me.radUp.Text = "&Up"
        Me.radUp.UseVisualStyleBackColor = True
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Location = New System.Drawing.Point(12, 65)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(82, 17)
        Me.chkMatchCase.TabIndex = 5
        Me.chkMatchCase.Text = "Match &case"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(339, 96)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.grpDirection)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFindNext)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.lblFindWhat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.Text = "Find"
        Me.grpDirection.ResumeLayout(False)
        Me.grpDirection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFindWhat As Label
    Friend WithEvents txtFind As TextBox
    Friend WithEvents btnFindNext As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents grpDirection As GroupBox
    Friend WithEvents radDown As RadioButton
    Friend WithEvents radUp As RadioButton
    Friend WithEvents chkMatchCase As CheckBox
End Class
