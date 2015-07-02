<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnRegressB = New System.Windows.Forms.Button()
        Me.clbAssB = New System.Windows.Forms.CheckedListBox()
        Me.lblAssignments = New System.Windows.Forms.Label()
        Me.txtbClassPageB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clbDiscB = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'btnRegressB
        '
        Me.btnRegressB.BackColor = System.Drawing.Color.Black
        Me.btnRegressB.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnRegressB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegressB.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegressB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegressB.Location = New System.Drawing.Point(-2, -4)
        Me.btnRegressB.Name = "btnRegressB"
        Me.btnRegressB.Size = New System.Drawing.Size(82, 31)
        Me.btnRegressB.TabIndex = 8
        Me.btnRegressB.Text = "regress"
        Me.btnRegressB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegressB.UseVisualStyleBackColor = False
        '
        'clbAssB
        '
        Me.clbAssB.BackColor = System.Drawing.Color.Black
        Me.clbAssB.ColumnWidth = 118
        Me.clbAssB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbAssB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clbAssB.FormattingEnabled = True
        Me.clbAssB.Location = New System.Drawing.Point(158, 48)
        Me.clbAssB.MultiColumn = True
        Me.clbAssB.Name = "clbAssB"
        Me.clbAssB.Size = New System.Drawing.Size(477, 92)
        Me.clbAssB.TabIndex = 3
        '
        'lblAssignments
        '
        Me.lblAssignments.Location = New System.Drawing.Point(69, 48)
        Me.lblAssignments.Name = "lblAssignments"
        Me.lblAssignments.Size = New System.Drawing.Size(88, 17)
        Me.lblAssignments.TabIndex = 6
        Me.lblAssignments.Text = "Assignments"
        Me.lblAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbClassPageB
        '
        Me.txtbClassPageB.BackColor = System.Drawing.Color.Black
        Me.txtbClassPageB.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbClassPageB.ForeColor = System.Drawing.Color.White
        Me.txtbClassPageB.Location = New System.Drawing.Point(12, 86)
        Me.txtbClassPageB.Name = "txtbClassPageB"
        Me.txtbClassPageB.Size = New System.Drawing.Size(146, 39)
        Me.txtbClassPageB.TabIndex = 7
        Me.txtbClassPageB.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Discussion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clbDiscB
        '
        Me.clbDiscB.BackColor = System.Drawing.Color.Black
        Me.clbDiscB.ColumnWidth = 150
        Me.clbDiscB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbDiscB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clbDiscB.FormattingEnabled = True
        Me.clbDiscB.Location = New System.Drawing.Point(16, 165)
        Me.clbDiscB.MultiColumn = True
        Me.clbDiscB.Name = "clbDiscB"
        Me.clbDiscB.Size = New System.Drawing.Size(619, 136)
        Me.clbDiscB.TabIndex = 2
        '
        'Form3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(647, 329)
        Me.Controls.Add(Me.btnRegressB)
        Me.Controls.Add(Me.txtbClassPageB)
        Me.Controls.Add(Me.lblAssignments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clbAssB)
        Me.Controls.Add(Me.clbDiscB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(800, 100)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegressB As System.Windows.Forms.Button
    Friend WithEvents clbAssB As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblAssignments As System.Windows.Forms.Label
    Friend WithEvents txtbClassPageB As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clbDiscB As System.Windows.Forms.CheckedListBox
End Class
