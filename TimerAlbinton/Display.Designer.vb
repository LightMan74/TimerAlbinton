<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HIDEBARREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHOWBARREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.COLORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOPMOSTONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOPMOStOFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Font = New System.Drawing.Font("Arial", 69.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.MaximumSize = New System.Drawing.Size(850, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(833, 213)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TEMPS RESTANT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 : 00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FONTToolStripMenuItem, Me.COLORToolStripMenuItem, Me.HIDEBARREToolStripMenuItem, Me.SHOWBARREToolStripMenuItem, Me.TOPMOSTONToolStripMenuItem, Me.TOPMOStOFFToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 158)
        '
        'FONTToolStripMenuItem
        '
        Me.FONTToolStripMenuItem.Name = "FONTToolStripMenuItem"
        Me.FONTToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FONTToolStripMenuItem.Text = "FONT"
        '
        'HIDEBARREToolStripMenuItem
        '
        Me.HIDEBARREToolStripMenuItem.Name = "HIDEBARREToolStripMenuItem"
        Me.HIDEBARREToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HIDEBARREToolStripMenuItem.Text = "HIDE BARRE"
        '
        'SHOWBARREToolStripMenuItem
        '
        Me.SHOWBARREToolStripMenuItem.Name = "SHOWBARREToolStripMenuItem"
        Me.SHOWBARREToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SHOWBARREToolStripMenuItem.Text = "SHOW BARRE"
        '
        'COLORToolStripMenuItem
        '
        Me.COLORToolStripMenuItem.Name = "COLORToolStripMenuItem"
        Me.COLORToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.COLORToolStripMenuItem.Text = "COLOR"
        '
        'TOPMOSTONToolStripMenuItem
        '
        Me.TOPMOSTONToolStripMenuItem.Name = "TOPMOSTONToolStripMenuItem"
        Me.TOPMOSTONToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TOPMOSTONToolStripMenuItem.Text = "TOP MOST ON"
        '
        'TOPMOStOFFToolStripMenuItem
        '
        Me.TOPMOStOFFToolStripMenuItem.Name = "TOPMOStOFFToolStripMenuItem"
        Me.TOPMOStOFFToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TOPMOStOFFToolStripMenuItem.Text = "TOP MOSt OFF"
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(834, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 250)
        Me.MinimizeBox = False
        Me.Name = "Display"
        Me.Text = "ALBINTON - DISPLAY"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FONTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HIDEBARREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHOWBARREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents COLORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TOPMOSTONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TOPMOStOFFToolStripMenuItem As ToolStripMenuItem
End Class
