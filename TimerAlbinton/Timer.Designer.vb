<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Timer
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Timer))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cb8min = New System.Windows.Forms.CheckBox()
        Me.cb10min = New System.Windows.Forms.CheckBox()
        Me.cb12min = New System.Windows.Forms.CheckBox()
        Me.cbxmin = New System.Windows.Forms.CheckBox()
        Me.cbxminutes = New System.Windows.Forms.ComboBox()
        Me.cbxminysec = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxminutes2 = New System.Windows.Forms.ComboBox()
        Me.cbysecondes2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstart = New System.Windows.Forms.Label()
        Me.l1m = New System.Windows.Forms.Label()
        Me.lstop = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(196, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cb8min
        '
        Me.cb8min.AutoSize = True
        Me.cb8min.Location = New System.Drawing.Point(0, 0)
        Me.cb8min.Name = "cb8min"
        Me.cb8min.Size = New System.Drawing.Size(72, 17)
        Me.cb8min.TabIndex = 3
        Me.cb8min.Text = "8 Minutes"
        Me.cb8min.UseVisualStyleBackColor = True
        '
        'cb10min
        '
        Me.cb10min.AutoSize = True
        Me.cb10min.Location = New System.Drawing.Point(78, 0)
        Me.cb10min.Name = "cb10min"
        Me.cb10min.Size = New System.Drawing.Size(78, 17)
        Me.cb10min.TabIndex = 4
        Me.cb10min.Text = "10 Minutes"
        Me.cb10min.UseVisualStyleBackColor = True
        '
        'cb12min
        '
        Me.cb12min.AutoSize = True
        Me.cb12min.Location = New System.Drawing.Point(162, 0)
        Me.cb12min.Name = "cb12min"
        Me.cb12min.Size = New System.Drawing.Size(78, 17)
        Me.cb12min.TabIndex = 5
        Me.cb12min.Text = "12 Minutes"
        Me.cb12min.UseVisualStyleBackColor = True
        '
        'cbxmin
        '
        Me.cbxmin.AutoSize = True
        Me.cbxmin.Location = New System.Drawing.Point(0, 23)
        Me.cbxmin.Name = "cbxmin"
        Me.cbxmin.Size = New System.Drawing.Size(73, 17)
        Me.cbxmin.TabIndex = 6
        Me.cbxmin.Text = "X Minutes"
        Me.cbxmin.UseVisualStyleBackColor = True
        '
        'cbxminutes
        '
        Me.cbxminutes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxminutes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxminutes.FormattingEnabled = True
        Me.cbxminutes.Location = New System.Drawing.Point(78, 21)
        Me.cbxminutes.Name = "cbxminutes"
        Me.cbxminutes.Size = New System.Drawing.Size(162, 21)
        Me.cbxminutes.TabIndex = 7
        Me.cbxminutes.Text = "Minutes..."
        '
        'cbxminysec
        '
        Me.cbxminysec.AutoSize = True
        Me.cbxminysec.Location = New System.Drawing.Point(0, 46)
        Me.cbxminysec.Name = "cbxminysec"
        Me.cbxminysec.Size = New System.Drawing.Size(146, 17)
        Me.cbxminysec.TabIndex = 10
        Me.cbxminysec.Text = "X Minutes et Y Secondes"
        Me.cbxminysec.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(127, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "0"
        '
        'cbxminutes2
        '
        Me.cbxminutes2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxminutes2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxminutes2.FormattingEnabled = True
        Me.cbxminutes2.Location = New System.Drawing.Point(152, 44)
        Me.cbxminutes2.Name = "cbxminutes2"
        Me.cbxminutes2.Size = New System.Drawing.Size(100, 21)
        Me.cbxminutes2.TabIndex = 17
        Me.cbxminutes2.Text = "Minutes..."
        '
        'cbysecondes2
        '
        Me.cbysecondes2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbysecondes2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbysecondes2.FormattingEnabled = True
        Me.cbysecondes2.Location = New System.Drawing.Point(258, 44)
        Me.cbysecondes2.Name = "cbysecondes2"
        Me.cbysecondes2.Size = New System.Drawing.Size(100, 21)
        Me.cbysecondes2.TabIndex = 18
        Me.cbysecondes2.Text = "Secondes..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(202, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 31)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(230, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 31)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(325, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "0 : 00"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(98, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(100, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 31)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Minutes : Secondes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(294, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Minutes : Secondes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(297, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Temps par default"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(347, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Propriete de l'association Alb'inton"
        '
        'lstart
        '
        Me.lstart.AutoSize = True
        Me.lstart.ForeColor = System.Drawing.Color.Red
        Me.lstart.Location = New System.Drawing.Point(387, 14)
        Me.lstart.Name = "lstart"
        Me.lstart.Size = New System.Drawing.Size(29, 13)
        Me.lstart.TabIndex = 28
        Me.lstart.Text = "Start"
        '
        'l1m
        '
        Me.l1m.AutoSize = True
        Me.l1m.ForeColor = System.Drawing.Color.Red
        Me.l1m.Location = New System.Drawing.Point(377, 27)
        Me.l1m.Name = "l1m"
        Me.l1m.Size = New System.Drawing.Size(60, 13)
        Me.l1m.TabIndex = 29
        Me.l1m.Text = "Middel time"
        '
        'lstop
        '
        Me.lstop.AutoSize = True
        Me.lstop.ForeColor = System.Drawing.Color.Red
        Me.lstop.Location = New System.Drawing.Point(387, 40)
        Me.lstop.Name = "lstop"
        Me.lstop.Size = New System.Drawing.Size(29, 13)
        Me.lstop.TabIndex = 30
        Me.lstop.Text = "Stop"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(368, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Statuts (Sons)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(193, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "date.now"
        '
        'Timer2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(268, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "CALLER"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lstop)
        Me.Controls.Add(Me.l1m)
        Me.Controls.Add(Me.lstart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbysecondes2)
        Me.Controls.Add(Me.cbxminutes2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxminysec)
        Me.Controls.Add(Me.cbxminutes)
        Me.Controls.Add(Me.cbxmin)
        Me.Controls.Add(Me.cb12min)
        Me.Controls.Add(Me.cb10min)
        Me.Controls.Add(Me.cb8min)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(469, 238)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(469, 238)
        Me.Name = "Timer"
        Me.Text = "ALBINTON - Timer - 2.10"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cb8min As System.Windows.Forms.CheckBox
    Friend WithEvents cb10min As System.Windows.Forms.CheckBox
    Friend WithEvents cb12min As System.Windows.Forms.CheckBox
    Friend WithEvents cbxmin As System.Windows.Forms.CheckBox
    Friend WithEvents cbxminutes As System.Windows.Forms.ComboBox
    Friend WithEvents cbxminysec As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxminutes2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbysecondes2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstart As System.Windows.Forms.Label
    Friend WithEvents l1m As System.Windows.Forms.Label
    Friend WithEvents lstop As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button4 As Button
End Class
