<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClassNameB = New System.Windows.Forms.Button()
        Me.btnClassNameC = New System.Windows.Forms.Button()
        Me.txtbClassNameA = New System.Windows.Forms.TextBox()
        Me.btnClassNameA = New System.Windows.Forms.Button()
        Me.txtbClassNameC = New System.Windows.Forms.TextBox()
        Me.txtbClassNameB = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AsdfasdfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEngageA = New System.Windows.Forms.Button()
        Me.btnEngageC = New System.Windows.Forms.Button()
        Me.btnEngageB = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClassNameB
        '
        Me.btnClassNameB.BackColor = System.Drawing.Color.Black
        Me.btnClassNameB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClassNameB.FlatAppearance.BorderSize = 0
        Me.btnClassNameB.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassNameB.ForeColor = System.Drawing.Color.White
        Me.btnClassNameB.Location = New System.Drawing.Point(40, 151)
        Me.btnClassNameB.Name = "btnClassNameB"
        Me.btnClassNameB.Size = New System.Drawing.Size(148, 36)
        Me.btnClassNameB.TabIndex = 1
        Me.btnClassNameB.Text = "Enter Class "
        Me.btnClassNameB.UseVisualStyleBackColor = False
        '
        'btnClassNameC
        '
        Me.btnClassNameC.BackColor = System.Drawing.Color.Black
        Me.btnClassNameC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClassNameC.FlatAppearance.BorderSize = 0
        Me.btnClassNameC.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassNameC.ForeColor = System.Drawing.Color.White
        Me.btnClassNameC.Location = New System.Drawing.Point(42, 230)
        Me.btnClassNameC.Name = "btnClassNameC"
        Me.btnClassNameC.Size = New System.Drawing.Size(146, 39)
        Me.btnClassNameC.TabIndex = 2
        Me.btnClassNameC.Text = "Enter Class "
        Me.btnClassNameC.UseVisualStyleBackColor = False
        '
        'txtbClassNameA
        '
        Me.txtbClassNameA.BackColor = System.Drawing.Color.Black
        Me.txtbClassNameA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbClassNameA.Cursor = System.Windows.Forms.Cursors.Cross
        Me.txtbClassNameA.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbClassNameA.ForeColor = System.Drawing.Color.White
        Me.txtbClassNameA.Location = New System.Drawing.Point(42, 82)
        Me.txtbClassNameA.Name = "txtbClassNameA"
        Me.txtbClassNameA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbClassNameA.Size = New System.Drawing.Size(146, 31)
        Me.txtbClassNameA.TabIndex = 4
        Me.txtbClassNameA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbClassNameA.Visible = False
        '
        'btnClassNameA
        '
        Me.btnClassNameA.BackColor = System.Drawing.Color.Black
        Me.btnClassNameA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClassNameA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Planner3.My.MySettings.Default, "DBClassNameAText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnClassNameA.FlatAppearance.BorderSize = 0
        Me.btnClassNameA.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassNameA.ForeColor = System.Drawing.Color.White
        Me.btnClassNameA.Location = New System.Drawing.Point(42, 74)
        Me.btnClassNameA.Name = "btnClassNameA"
        Me.btnClassNameA.Size = New System.Drawing.Size(146, 39)
        Me.btnClassNameA.TabIndex = 0
        Me.btnClassNameA.Text = Global.Planner3.My.MySettings.Default.DBClassNameAText
        Me.btnClassNameA.UseVisualStyleBackColor = False
        '
        'txtbClassNameC
        '
        Me.txtbClassNameC.BackColor = System.Drawing.Color.Black
        Me.txtbClassNameC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbClassNameC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.txtbClassNameC.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbClassNameC.ForeColor = System.Drawing.Color.White
        Me.txtbClassNameC.Location = New System.Drawing.Point(40, 238)
        Me.txtbClassNameC.Name = "txtbClassNameC"
        Me.txtbClassNameC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbClassNameC.Size = New System.Drawing.Size(146, 31)
        Me.txtbClassNameC.TabIndex = 5
        Me.txtbClassNameC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbClassNameC.Visible = False
        '
        'txtbClassNameB
        '
        Me.txtbClassNameB.BackColor = System.Drawing.Color.Black
        Me.txtbClassNameB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbClassNameB.Cursor = System.Windows.Forms.Cursors.Cross
        Me.txtbClassNameB.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbClassNameB.ForeColor = System.Drawing.Color.White
        Me.txtbClassNameB.Location = New System.Drawing.Point(42, 158)
        Me.txtbClassNameB.Name = "txtbClassNameB"
        Me.txtbClassNameB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbClassNameB.Size = New System.Drawing.Size(146, 31)
        Me.txtbClassNameB.TabIndex = 6
        Me.txtbClassNameB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbClassNameB.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsdfasdfToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(135, 28)
        '
        'AsdfasdfToolStripMenuItem
        '
        Me.AsdfasdfToolStripMenuItem.Name = "AsdfasdfToolStripMenuItem"
        Me.AsdfasdfToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.AsdfasdfToolStripMenuItem.Text = "asdfasdf"
        '
        'btnEngageA
        '
        Me.btnEngageA.BackColor = System.Drawing.Color.Black
        Me.btnEngageA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEngageA.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEngageA.ForeColor = System.Drawing.Color.White
        Me.btnEngageA.Location = New System.Drawing.Point(73, 105)
        Me.btnEngageA.Name = "btnEngageA"
        Me.btnEngageA.Size = New System.Drawing.Size(89, 26)
        Me.btnEngageA.TabIndex = 7
        Me.btnEngageA.Text = "ENGAGE"
        Me.btnEngageA.UseVisualStyleBackColor = False
        Me.btnEngageA.Visible = False
        '
        'btnEngageC
        '
        Me.btnEngageC.BackColor = System.Drawing.Color.Black
        Me.btnEngageC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEngageC.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEngageC.ForeColor = System.Drawing.Color.White
        Me.btnEngageC.Location = New System.Drawing.Point(73, 258)
        Me.btnEngageC.Name = "btnEngageC"
        Me.btnEngageC.Size = New System.Drawing.Size(89, 26)
        Me.btnEngageC.TabIndex = 8
        Me.btnEngageC.Text = "ENGAGE"
        Me.btnEngageC.UseVisualStyleBackColor = False
        Me.btnEngageC.Visible = False
        '
        'btnEngageB
        '
        Me.btnEngageB.BackColor = System.Drawing.Color.Black
        Me.btnEngageB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEngageB.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEngageB.ForeColor = System.Drawing.Color.White
        Me.btnEngageB.Location = New System.Drawing.Point(73, 182)
        Me.btnEngageB.Name = "btnEngageB"
        Me.btnEngageB.Size = New System.Drawing.Size(89, 26)
        Me.btnEngageB.TabIndex = 9
        Me.btnEngageB.Text = "ENGAGE"
        Me.btnEngageB.UseVisualStyleBackColor = False
        Me.btnEngageB.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(450, 119)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 26)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Black
        Me.btnLoad.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(450, 151)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(89, 26)
        Me.btnLoad.TabIndex = 11
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.Black
        Me.btnLog.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.White
        Me.btnLog.Location = New System.Drawing.Point(450, 186)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(89, 26)
        Me.btnLog.TabIndex = 12
        Me.btnLog.Text = "LOG"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(647, 329)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEngageB)
        Me.Controls.Add(Me.btnEngageC)
        Me.Controls.Add(Me.btnEngageA)
        Me.Controls.Add(Me.txtbClassNameB)
        Me.Controls.Add(Me.txtbClassNameC)
        Me.Controls.Add(Me.txtbClassNameA)
        Me.Controls.Add(Me.btnClassNameC)
        Me.Controls.Add(Me.btnClassNameB)
        Me.Controls.Add(Me.btnClassNameA)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(800, 100)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MISSION CONTROL"
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClassNameB As System.Windows.Forms.Button
    Friend WithEvents btnClassNameC As System.Windows.Forms.Button
    Friend WithEvents txtbClassNameA As System.Windows.Forms.TextBox
    Friend WithEvents btnClassNameA As System.Windows.Forms.Button
    Friend WithEvents txtbClassNameC As System.Windows.Forms.TextBox
    Friend WithEvents txtbClassNameB As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AsdfasdfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEngageA As System.Windows.Forms.Button
    Friend WithEvents btnEngageC As System.Windows.Forms.Button
    Friend WithEvents btnEngageB As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnLog As System.Windows.Forms.Button

End Class
