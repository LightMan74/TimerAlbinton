<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caller
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb1cm = New System.Windows.Forms.ComboBox()
        Me.cb1cs = New System.Windows.Forms.ComboBox()
        Me.cb2cm = New System.Windows.Forms.ComboBox()
        Me.cb2cs = New System.Windows.Forms.ComboBox()
        Me.Check1c = New System.Windows.Forms.CheckBox()
        Me.Check2c = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.checklc = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 109)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(327, 155)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Terrain1*Ducon*Contre*Connard"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(1, 110)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(327, 154)
        Me.CheckedListBox1.TabIndex = 2
        Me.CheckedListBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Créer Liste"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Curent : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'cb1cm
        '
        Me.cb1cm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb1cm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb1cm.FormattingEnabled = True
        Me.cb1cm.Location = New System.Drawing.Point(8, 17)
        Me.cb1cm.Name = "cb1cm"
        Me.cb1cm.Size = New System.Drawing.Size(70, 21)
        Me.cb1cm.TabIndex = 6
        '
        'cb1cs
        '
        Me.cb1cs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb1cs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb1cs.FormattingEnabled = True
        Me.cb1cs.Location = New System.Drawing.Point(84, 17)
        Me.cb1cs.Name = "cb1cs"
        Me.cb1cs.Size = New System.Drawing.Size(70, 21)
        Me.cb1cs.TabIndex = 7
        '
        'cb2cm
        '
        Me.cb2cm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb2cm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb2cm.FormattingEnabled = True
        Me.cb2cm.Location = New System.Drawing.Point(8, 60)
        Me.cb2cm.Name = "cb2cm"
        Me.cb2cm.Size = New System.Drawing.Size(70, 21)
        Me.cb2cm.TabIndex = 8
        '
        'cb2cs
        '
        Me.cb2cs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb2cs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb2cs.FormattingEnabled = True
        Me.cb2cs.Location = New System.Drawing.Point(84, 60)
        Me.cb2cs.Name = "cb2cs"
        Me.cb2cs.Size = New System.Drawing.Size(70, 21)
        Me.cb2cs.TabIndex = 9
        '
        'Check1c
        '
        Me.Check1c.AutoSize = True
        Me.Check1c.Location = New System.Drawing.Point(23, 0)
        Me.Check1c.Name = "Check1c"
        Me.Check1c.Size = New System.Drawing.Size(106, 17)
        Me.Check1c.TabIndex = 10
        Me.Check1c.Text = "Valider 1er Appel"
        Me.Check1c.UseVisualStyleBackColor = True
        '
        'Check2c
        '
        Me.Check2c.AutoSize = True
        Me.Check2c.Location = New System.Drawing.Point(20, 43)
        Me.Check2c.Name = "Check2c"
        Me.Check2c.Size = New System.Drawing.Size(117, 17)
        Me.Check2c.TabIndex = 11
        Me.Check2c.Text = "Valider 2eme Appel"
        Me.Check2c.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(165, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Ajouter Liste"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(334, 21)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox2.Size = New System.Drawing.Size(240, 243)
        Me.RichTextBox2.TabIndex = 13
        Me.RichTextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ajouter a la liste"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(165, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Arret Forcé"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'checklc
        '
        Me.checklc.AutoSize = True
        Me.checklc.Location = New System.Drawing.Point(20, 87)
        Me.checklc.Name = "checklc"
        Me.checklc.Size = New System.Drawing.Size(122, 17)
        Me.checklc.TabIndex = 16
        Me.checklc.Text = "Valider Appel à la fin"
        Me.checklc.UseVisualStyleBackColor = True
        '
        'Caller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 268)
        Me.Controls.Add(Me.checklc)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Check2c)
        Me.Controls.Add(Me.Check1c)
        Me.Controls.Add(Me.cb2cs)
        Me.Controls.Add(Me.cb2cm)
        Me.Controls.Add(Me.cb1cs)
        Me.Controls.Add(Me.cb1cm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.MaximumSize = New System.Drawing.Size(593, 307)
        Me.MinimumSize = New System.Drawing.Size(593, 307)
        Me.Name = "Caller"
        Me.Text = "Caller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents cb1cm As ComboBox
    Friend WithEvents cb1cs As ComboBox
    Friend WithEvents cb2cm As ComboBox
    Friend WithEvents cb2cs As ComboBox
    Friend WithEvents Check1c As CheckBox
    Friend WithEvents Check2c As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents checklc As CheckBox
End Class
