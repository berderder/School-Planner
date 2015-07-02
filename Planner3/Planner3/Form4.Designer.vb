<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.btnRegressC = New System.Windows.Forms.Button()
        Me.txtbClassPageC = New System.Windows.Forms.Button()
        Me.lblAssignments = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clbAssC = New System.Windows.Forms.CheckedListBox()
        Me.clbDiscC = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'btnRegressC
        '
        Me.btnRegressC.BackColor = System.Drawing.Color.Black
        Me.btnRegressC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnRegressC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegressC.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegressC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegressC.Location = New System.Drawing.Point(-2, -4)
        Me.btnRegressC.Name = "btnRegressC"
        Me.btnRegressC.Size = New System.Drawing.Size(82, 31)
        Me.btnRegressC.TabIndex = 14
        Me.btnRegressC.Text = "regress"
        Me.btnRegressC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegressC.UseVisualStyleBackColor = False
        '
        'txtbClassPageC
        '
        Me.txtbClassPageC.BackColor = System.Drawing.Color.Black
        Me.txtbClassPageC.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbClassPageC.ForeColor = System.Drawing.Color.White
        Me.txtbClassPageC.Location = New System.Drawing.Point(12, 86)
        Me.txtbClassPageC.Name = "txtbClassPageC"
        Me.txtbClassPageC.Size = New System.Drawing.Size(146, 39)
        Me.txtbClassPageC.TabIndex = 13
        Me.txtbClassPageC.UseVisualStyleBackColor = False
        '
        'lblAssignments
        '
        Me.lblAssignments.Location = New System.Drawing.Point(69, 48)
        Me.lblAssignments.Name = "lblAssignments"
        Me.lblAssignments.Size = New System.Drawing.Size(88, 17)
        Me.lblAssignments.TabIndex = 12
        Me.lblAssignments.Text = "Assignments"
        Me.lblAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Discussion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clbAssC
        '
        Me.clbAssC.BackColor = System.Drawing.Color.Black
        Me.clbAssC.ColumnWidth = 118
        Me.clbAssC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbAssC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clbAssC.FormattingEnabled = True
        Me.clbAssC.Location = New System.Drawing.Point(158, 48)
        Me.clbAssC.MultiColumn = True
        Me.clbAssC.Name = "clbAssC"
        Me.clbAssC.Size = New System.Drawing.Size(477, 92)
        Me.clbAssC.TabIndex = 10
        '
        'clbDiscC
        '
        Me.clbDiscC.BackColor = System.Drawing.Color.Black
        Me.clbDiscC.ColumnWidth = 150
        Me.clbDiscC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbDiscC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clbDiscC.FormattingEnabled = True
        Me.clbDiscC.Location = New System.Drawing.Point(16, 165)
        Me.clbDiscC.MultiColumn = True
        Me.clbDiscC.Name = "clbDiscC"
        Me.clbDiscC.Size = New System.Drawing.Size(619, 136)
        Me.clbDiscC.TabIndex = 9
        '
        'Form4
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(647, 329)
        Me.Controls.Add(Me.btnRegressC)
        Me.Controls.Add(Me.txtbClassPageC)
        Me.Controls.Add(Me.lblAssignments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clbAssC)
        Me.Controls.Add(Me.clbDiscC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(800, 100)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegressC As System.Windows.Forms.Button
    Friend WithEvents txtbClassPageC As System.Windows.Forms.Button
    Friend WithEvents lblAssignments As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clbAssC As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbDiscC As System.Windows.Forms.CheckedListBox
End Class
