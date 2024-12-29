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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Program = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFile = New System.Windows.Forms.Button()
        Me.SaveFile = New System.Windows.Forms.Button()
        Me.Signalfil = New System.Windows.Forms.Label()
        Me.Programmed = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.b3 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.b2 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.b6 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.b4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.b12 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.b11 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.b10 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.b9 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.b8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.b7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Program)
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Location = New System.Drawing.Point(288, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 45)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kommunikation med kort"
        '
        'Program
        '
        Me.Program.Location = New System.Drawing.Point(103, 14)
        Me.Program.Name = "Program"
        Me.Program.Size = New System.Drawing.Size(84, 23)
        Me.Program.TabIndex = 3
        Me.Program.Text = "Programmera"
        Me.Program.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(13, 14)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Connect.TabIndex = 1
        Me.Button_Connect.Text = "Läs upp"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckFileExists = True
        Me.SaveFileDialog1.CreatePrompt = True
        Me.SaveFileDialog1.Title = "File"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(23, 25)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(75, 23)
        Me.OpenFile.TabIndex = 8
        Me.OpenFile.Text = "Öppna Fil"
        Me.OpenFile.UseVisualStyleBackColor = True
        '
        'SaveFile
        '
        Me.SaveFile.Location = New System.Drawing.Point(104, 25)
        Me.SaveFile.Name = "SaveFile"
        Me.SaveFile.Size = New System.Drawing.Size(75, 23)
        Me.SaveFile.TabIndex = 8
        Me.SaveFile.Text = "Spara Fil"
        Me.SaveFile.UseVisualStyleBackColor = True
        '
        'Signalfil
        '
        Me.Signalfil.AutoSize = True
        Me.Signalfil.Location = New System.Drawing.Point(185, 30)
        Me.Signalfil.Name = "Signalfil"
        Me.Signalfil.Size = New System.Drawing.Size(142, 13)
        Me.Signalfil.TabIndex = 9
        Me.Signalfil.Text = "---------------------------------------------"
        '
        'Programmed
        '
        Me.Programmed.AutoSize = True
        Me.Programmed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Programmed.ForeColor = System.Drawing.Color.ForestGreen
        Me.Programmed.Location = New System.Drawing.Point(48, 257)
        Me.Programmed.Name = "Programmed"
        Me.Programmed.Size = New System.Drawing.Size(221, 20)
        Me.Programmed.TabIndex = 11
        Me.Programmed.Text = "Anslutet lok programmerat"
        Me.Programmed.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 294)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(475, 20)
        Me.TextBox1.TabIndex = 41
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(77, 133)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(154, 20)
        Me.b3.TabIndex = 71
        Me.b3.Text = "Reserv"
        Me.b3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Location = New System.Drawing.Point(24, 136)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 13)
        Me.Label36.TabIndex = 70
        Me.Label36.Text = "Knapp 3"
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(77, 107)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(154, 20)
        Me.b2.TabIndex = 69
        Me.b2.Text = "Reserv"
        Me.b2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Location = New System.Drawing.Point(24, 110)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 13)
        Me.Label37.TabIndex = 68
        Me.Label37.Text = "Knapp 2"
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(77, 81)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(154, 20)
        Me.b1.TabIndex = 67
        Me.b1.Text = "Ljus"
        Me.b1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Location = New System.Drawing.Point(24, 84)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(47, 13)
        Me.Label38.TabIndex = 66
        Me.Label38.Text = "Knapp 1"
        '
        'b6
        '
        Me.b6.Location = New System.Drawing.Point(77, 211)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(154, 20)
        Me.b6.TabIndex = 77
        Me.b6.Text = "Rök"
        Me.b6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(24, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Knapp 6"
        '
        'b5
        '
        Me.b5.Location = New System.Drawing.Point(77, 185)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(154, 20)
        Me.b5.TabIndex = 75
        Me.b5.Text = "Ljud"
        Me.b5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(24, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Knapp 5"
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(77, 159)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(154, 20)
        Me.b4.TabIndex = 73
        Me.b4.Text = "Vissla"
        Me.b4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(24, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Knapp 4"
        '
        'b12
        '
        Me.b12.Location = New System.Drawing.Point(322, 211)
        Me.b12.Name = "b12"
        Me.b12.Size = New System.Drawing.Size(154, 20)
        Me.b12.TabIndex = 89
        Me.b12.Text = "Pendel"
        Me.b12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(269, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Knapp 12"
        '
        'b11
        '
        Me.b11.Location = New System.Drawing.Point(322, 185)
        Me.b11.Name = "b11"
        Me.b11.Size = New System.Drawing.Size(154, 20)
        Me.b11.TabIndex = 87
        Me.b11.Text = "Auto"
        Me.b11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(269, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Knapp 11"
        '
        'b10
        '
        Me.b10.Location = New System.Drawing.Point(322, 159)
        Me.b10.Name = "b10"
        Me.b10.Size = New System.Drawing.Size(154, 20)
        Me.b10.TabIndex = 85
        Me.b10.Text = "Växling"
        Me.b10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(269, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Knapp 10"
        '
        'b9
        '
        Me.b9.Location = New System.Drawing.Point(322, 133)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(154, 20)
        Me.b9.TabIndex = 83
        Me.b9.Text = "Nästa station"
        Me.b9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(269, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Knapp 9"
        '
        'b8
        '
        Me.b8.Location = New System.Drawing.Point(322, 107)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(154, 20)
        Me.b8.TabIndex = 81
        Me.b8.Text = "Nödstopp"
        Me.b8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(269, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Knapp 8"
        '
        'b7
        '
        Me.b7.Location = New System.Drawing.Point(322, 81)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(154, 20)
        Me.b7.TabIndex = 79
        Me.b7.Text = "Kort Vissla"
        Me.b7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(269, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Knapp 7"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(119, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Max 15 tecken"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(357, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Max 15 tecken"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 326)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.b12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.b11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.b10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.b9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.b8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.b7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Programmed)
        Me.Controls.Add(Me.Signalfil)
        Me.Controls.Add(Me.SaveFile)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Konfiguration av knapptexter"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Connect As Button
    Friend WithEvents Program As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFile As Button
    Friend WithEvents SaveFile As Button
    Friend WithEvents Signalfil As Label
    Friend WithEvents Programmed As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents b3 As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents b2 As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents b1 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents b6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents b5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents b4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents b12 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents b11 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents b10 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents b9 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents b8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents b7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
