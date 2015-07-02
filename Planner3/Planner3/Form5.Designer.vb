<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.btnRegressD = New System.Windows.Forms.Button()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.txtbLog = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnRegressD
        '
        Me.btnRegressD.BackColor = System.Drawing.Color.Black
        Me.btnRegressD.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnRegressD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegressD.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegressD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegressD.Location = New System.Drawing.Point(-2, -4)
        Me.btnRegressD.Name = "btnRegressD"
        Me.btnRegressD.Size = New System.Drawing.Size(82, 31)
        Me.btnRegressD.TabIndex = 15
        Me.btnRegressD.Text = "regress"
        Me.btnRegressD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegressD.UseVisualStyleBackColor = False
        '
        'lblLog
        '
        Me.lblLog.BackColor = System.Drawing.Color.Black
        Me.lblLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.ForeColor = System.Drawing.Color.White
        Me.lblLog.Location = New System.Drawing.Point(518, 9)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(99, 37)
        Me.lblLog.TabIndex = 16
        Me.lblLog.Text = "LOG"
        Me.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbLog
        '
        Me.txtbLog.BackColor = System.Drawing.Color.Black
        Me.txtbLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtbLog.Location = New System.Drawing.Point(13, 57)
        Me.txtbLog.Name = "txtbLog"
        Me.txtbLog.Size = New System.Drawing.Size(604, 247)
        Me.txtbLog.TabIndex = 17
        Me.txtbLog.Text = ""
        '
        'Form5
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(647, 329)
        Me.Controls.Add(Me.txtbLog)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.btnRegressD)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(800, 100)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegressD As System.Windows.Forms.Button
    Friend WithEvents lblLog As System.Windows.Forms.Label
    Friend WithEvents txtbLog As System.Windows.Forms.RichTextBox
End Class
