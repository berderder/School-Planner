<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtbClassPageA = New System.Windows.Forms.Button()
        Me.clbDiscA = New System.Windows.Forms.CheckedListBox()
        Me.clbAssA = New System.Windows.Forms.CheckedListBox()
        Me.lblAssignments = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegressA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbClassPageA
        '
        Me.txtbClassPageA.BackColor = System.Drawing.Color.Black
        Me.txtbClassPageA.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbClassPageA.ForeColor = System.Drawing.Color.White
        Me.txtbClassPageA.Location = New System.Drawing.Point(12, 86)
        Me.txtbClassPageA.Name = "txtbClassPageA"
        Me.txtbClassPageA.Size = New System.Drawing.Size(146, 39)
        Me.txtbClassPageA.TabIndex = 0
        Me.txtbClassPageA.UseVisualStyleBackColor = False
        '
        'clbDiscA
        '
        Me.clbDiscA.BackColor = System.Drawing.Color.Black
        Me.clbDiscA.ColumnWidth = 150
        Me.clbDiscA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbDiscA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clbDiscA.FormattingEnabled = True
        Me.clbDiscA.Location = New System.Drawing.Point(16, 165)
        Me.clbDiscA.MultiColumn = True
        Me.clbDiscA.Name = "clbDiscA"
        Me.clbDiscA.Size = New System.Drawing.Size(619, 136)
        Me.clbDiscA.TabIndex = 1
        '
        'clbAssA
        '
        Me.clbAssA.BackColor = System.Drawing.Color.Black
        Me.clbAssA.ColumnWidth = 118
        Me.clbAssA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbAssA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clbAssA.FormattingEnabled = True
        Me.clbAssA.Location = New System.Drawing.Point(158, 48)
        Me.clbAssA.MultiColumn = True
        Me.clbAssA.Name = "clbAssA"
        Me.clbAssA.Size = New System.Drawing.Size(477, 92)
        Me.clbAssA.TabIndex = 2
        '
        'lblAssignments
        '
        Me.lblAssignments.Location = New System.Drawing.Point(69, 48)
        Me.lblAssignments.Name = "lblAssignments"
        Me.lblAssignments.Size = New System.Drawing.Size(88, 17)
        Me.lblAssignments.TabIndex = 3
        Me.lblAssignments.Text = "Assignments"
        Me.lblAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Discussion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegressA
        '
        Me.btnRegressA.BackColor = System.Drawing.Color.Black
        Me.btnRegressA.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnRegressA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegressA.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegressA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegressA.Location = New System.Drawing.Point(-2, -4)
        Me.btnRegressA.Name = "btnRegressA"
        Me.btnRegressA.Size = New System.Drawing.Size(80, 31)
        Me.btnRegressA.TabIndex = 5
        Me.btnRegressA.Text = "regress"
        Me.btnRegressA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegressA.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(647, 329)
        Me.Controls.Add(Me.lblAssignments)
        Me.Controls.Add(Me.btnRegressA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clbAssA)
        Me.Controls.Add(Me.clbDiscA)
        Me.Controls.Add(Me.txtbClassPageA)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(800, 100)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtbClassPageA As System.Windows.Forms.Button
    Friend WithEvents clbDiscA As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbAssA As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblAssignments As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegressA As System.Windows.Forms.Button
End Class
