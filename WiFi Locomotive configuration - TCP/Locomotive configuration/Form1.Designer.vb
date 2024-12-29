<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Program = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SSID = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFile = New System.Windows.Forms.Button()
        Me.SaveFile = New System.Windows.Forms.Button()
        Me.Signalfil = New System.Windows.Forms.Label()
        Me.Programmed = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Loknamn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IP1 = New System.Windows.Forms.TextBox()
        Me.IP2 = New System.Windows.Forms.TextBox()
        Me.IP3 = New System.Windows.Forms.TextBox()
        Me.IP4 = New System.Windows.Forms.TextBox()
        Me.NM4 = New System.Windows.Forms.TextBox()
        Me.NM3 = New System.Windows.Forms.TextBox()
        Me.NM2 = New System.Windows.Forms.TextBox()
        Me.NM1 = New System.Windows.Forms.TextBox()
        Me.Port = New System.Windows.Forms.TextBox()
        Me.Host = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PWM = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Fullfart = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Half = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Shunting = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Zerospeed = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Acc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Dcc = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OptimeraPWM = New System.Windows.Forms.Button()
        Me.Calibrate = New System.Windows.Forms.Button()
        Me.Creep = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Slow = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Ankomst = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Maxfrq = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Minfrq = New System.Windows.Forms.TextBox()
        Me.Minfrqt = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Ljudpuls = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Smoke = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Ångvissla = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.mindwell = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.maxdwell = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Lok = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Program)
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Location = New System.Drawing.Point(1647, 792)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7)
        Me.GroupBox1.Size = New System.Drawing.Size(471, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kommunikation med kort"
        '
        'Program
        '
        Me.Program.Location = New System.Drawing.Point(240, 31)
        Me.Program.Margin = New System.Windows.Forms.Padding(7)
        Me.Program.Name = "Program"
        Me.Program.Size = New System.Drawing.Size(196, 51)
        Me.Program.TabIndex = 3
        Me.Program.Text = "Programmera"
        Me.Program.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(30, 31)
        Me.Button_Connect.Margin = New System.Windows.Forms.Padding(7)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(175, 51)
        Me.Button_Connect.TabIndex = 1
        Me.Button_Connect.Text = "Läs upp"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.ReadTimeout = 26000
        '
        'SSID
        '
        Me.SSID.Location = New System.Drawing.Point(259, 56)
        Me.SSID.Margin = New System.Windows.Forms.Padding(7)
        Me.SSID.Name = "SSID"
        Me.SSID.Size = New System.Drawing.Size(354, 35)
        Me.SSID.TabIndex = 5
        Me.SSID.Text = "SSID med max 10 tecken"
        Me.SSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.OpenFile.Location = New System.Drawing.Point(54, 56)
        Me.OpenFile.Margin = New System.Windows.Forms.Padding(7)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(175, 51)
        Me.OpenFile.TabIndex = 8
        Me.OpenFile.Text = "Öppna Fil"
        Me.OpenFile.UseVisualStyleBackColor = True
        '
        'SaveFile
        '
        Me.SaveFile.Location = New System.Drawing.Point(243, 56)
        Me.SaveFile.Margin = New System.Windows.Forms.Padding(7)
        Me.SaveFile.Name = "SaveFile"
        Me.SaveFile.Size = New System.Drawing.Size(175, 51)
        Me.SaveFile.TabIndex = 8
        Me.SaveFile.Text = "Spara Fil"
        Me.SaveFile.UseVisualStyleBackColor = True
        '
        'Signalfil
        '
        Me.Signalfil.AutoSize = True
        Me.Signalfil.Location = New System.Drawing.Point(432, 67)
        Me.Signalfil.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Signalfil.Name = "Signalfil"
        Me.Signalfil.Size = New System.Drawing.Size(373, 29)
        Me.Signalfil.TabIndex = 9
        Me.Signalfil.Text = "---------------------------------------------"
        '
        'Programmed
        '
        Me.Programmed.AutoSize = True
        Me.Programmed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Programmed.ForeColor = System.Drawing.Color.ForestGreen
        Me.Programmed.Location = New System.Drawing.Point(917, 821)
        Me.Programmed.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Programmed.Name = "Programmed"
        Me.Programmed.Size = New System.Drawing.Size(464, 40)
        Me.Programmed.TabIndex = 11
        Me.Programmed.Text = "Anslutet lok programmerat"
        Me.Programmed.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(16, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SSID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(28, 906)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(2211, 35)
        Me.TextBox1.TabIndex = 41
        '
        'Loknamn
        '
        Me.Loknamn.Location = New System.Drawing.Point(371, 196)
        Me.Loknamn.Margin = New System.Windows.Forms.Padding(7)
        Me.Loknamn.Name = "Loknamn"
        Me.Loknamn.Size = New System.Drawing.Size(242, 35)
        Me.Loknamn.TabIndex = 43
        Me.Loknamn.Text = "DCC-adress 1-9999"
        Me.Loknamn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(16, 203)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 29)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Lok DCC adress 1-9999"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(259, 114)
        Me.Password.Margin = New System.Windows.Forms.Padding(7)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(354, 35)
        Me.Password.TabIndex = 45
        Me.Password.Text = "Password med max 10 tecken"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(16, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Password"
        '
        'IP1
        '
        Me.IP1.Location = New System.Drawing.Point(250, 772)
        Me.IP1.Margin = New System.Windows.Forms.Padding(7)
        Me.IP1.Name = "IP1"
        Me.IP1.ReadOnly = True
        Me.IP1.Size = New System.Drawing.Size(65, 35)
        Me.IP1.TabIndex = 47
        Me.IP1.Text = "10"
        Me.IP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IP1.Visible = False
        '
        'IP2
        '
        Me.IP2.Location = New System.Drawing.Point(345, 772)
        Me.IP2.Margin = New System.Windows.Forms.Padding(7)
        Me.IP2.Name = "IP2"
        Me.IP2.ReadOnly = True
        Me.IP2.Size = New System.Drawing.Size(65, 35)
        Me.IP2.TabIndex = 48
        Me.IP2.Text = "10"
        Me.IP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IP2.Visible = False
        '
        'IP3
        '
        Me.IP3.Location = New System.Drawing.Point(443, 772)
        Me.IP3.Margin = New System.Windows.Forms.Padding(7)
        Me.IP3.Name = "IP3"
        Me.IP3.ReadOnly = True
        Me.IP3.Size = New System.Drawing.Size(65, 35)
        Me.IP3.TabIndex = 49
        Me.IP3.Text = "10"
        Me.IP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IP3.Visible = False
        '
        'IP4
        '
        Me.IP4.Location = New System.Drawing.Point(541, 772)
        Me.IP4.Margin = New System.Windows.Forms.Padding(7)
        Me.IP4.Name = "IP4"
        Me.IP4.ReadOnly = True
        Me.IP4.Size = New System.Drawing.Size(65, 35)
        Me.IP4.TabIndex = 50
        Me.IP4.Text = "10"
        Me.IP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IP4.Visible = False
        '
        'NM4
        '
        Me.NM4.Location = New System.Drawing.Point(541, 830)
        Me.NM4.Margin = New System.Windows.Forms.Padding(7)
        Me.NM4.Name = "NM4"
        Me.NM4.ReadOnly = True
        Me.NM4.Size = New System.Drawing.Size(65, 35)
        Me.NM4.TabIndex = 58
        Me.NM4.Text = "000"
        Me.NM4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NM4.Visible = False
        '
        'NM3
        '
        Me.NM3.Location = New System.Drawing.Point(443, 830)
        Me.NM3.Margin = New System.Windows.Forms.Padding(7)
        Me.NM3.Name = "NM3"
        Me.NM3.ReadOnly = True
        Me.NM3.Size = New System.Drawing.Size(65, 35)
        Me.NM3.TabIndex = 57
        Me.NM3.Text = "255"
        Me.NM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NM3.Visible = False
        '
        'NM2
        '
        Me.NM2.Location = New System.Drawing.Point(345, 830)
        Me.NM2.Margin = New System.Windows.Forms.Padding(7)
        Me.NM2.Name = "NM2"
        Me.NM2.ReadOnly = True
        Me.NM2.Size = New System.Drawing.Size(65, 35)
        Me.NM2.TabIndex = 56
        Me.NM2.Text = "255"
        Me.NM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NM2.Visible = False
        '
        'NM1
        '
        Me.NM1.Location = New System.Drawing.Point(250, 830)
        Me.NM1.Margin = New System.Windows.Forms.Padding(7)
        Me.NM1.Name = "NM1"
        Me.NM1.ReadOnly = True
        Me.NM1.Size = New System.Drawing.Size(65, 35)
        Me.NM1.TabIndex = 55
        Me.NM1.Text = "255"
        Me.NM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NM1.Visible = False
        '
        'Port
        '
        Me.Port.Location = New System.Drawing.Point(40, 828)
        Me.Port.Margin = New System.Windows.Forms.Padding(7)
        Me.Port.Name = "Port"
        Me.Port.ReadOnly = True
        Me.Port.Size = New System.Drawing.Size(65, 35)
        Me.Port.TabIndex = 63
        Me.Port.Text = "44"
        Me.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Port.Visible = False
        '
        'Host
        '
        Me.Host.Location = New System.Drawing.Point(110, 714)
        Me.Host.Margin = New System.Windows.Forms.Padding(7)
        Me.Host.Name = "Host"
        Me.Host.Size = New System.Drawing.Size(354, 35)
        Me.Host.TabIndex = 65
        Me.Host.Text = "QWERTYUIOPASDFGHJKLZ"
        Me.Host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Host.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Password)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Loknamn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.SSID)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 125)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(7)
        Me.GroupBox2.Size = New System.Drawing.Size(674, 288)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nätverksinställningar"
        '
        'PWM
        '
        Me.PWM.Location = New System.Drawing.Point(266, 74)
        Me.PWM.Margin = New System.Windows.Forms.Padding(7)
        Me.PWM.Name = "PWM"
        Me.PWM.Size = New System.Drawing.Size(354, 35)
        Me.PWM.TabIndex = 67
        Me.PWM.Text = "Max 16khz (300-16000)"
        Me.PWM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(23, 80)
        Me.Label14.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(169, 29)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "PWM-frekvens"
        '
        'Fullfart
        '
        Me.Fullfart.Location = New System.Drawing.Point(261, 591)
        Me.Fullfart.Margin = New System.Windows.Forms.Padding(7)
        Me.Fullfart.Name = "Fullfart"
        Me.Fullfart.Size = New System.Drawing.Size(90, 35)
        Me.Fullfart.TabIndex = 69
        Me.Fullfart.Text = "1-126"
        Me.Fullfart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(824, 500)
        Me.Label15.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 29)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Krypfart"
        '
        'Half
        '
        Me.Half.Location = New System.Drawing.Point(261, 538)
        Me.Half.Margin = New System.Windows.Forms.Padding(7)
        Me.Half.Name = "Half"
        Me.Half.Size = New System.Drawing.Size(90, 35)
        Me.Half.TabIndex = 71
        Me.Half.Text = "1-126"
        Me.Half.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(19, 540)
        Me.Label16.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 29)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Halvfart"
        '
        'Shunting
        '
        Me.Shunting.Location = New System.Drawing.Point(261, 647)
        Me.Shunting.Margin = New System.Windows.Forms.Padding(7)
        Me.Shunting.Name = "Shunting"
        Me.Shunting.Size = New System.Drawing.Size(90, 35)
        Me.Shunting.TabIndex = 73
        Me.Shunting.Text = "1-100"
        Me.Shunting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(19, 654)
        Me.Label17.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(194, 29)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "Max Växlings-fart"
        '
        'Zerospeed
        '
        Me.Zerospeed.Location = New System.Drawing.Point(1066, 315)
        Me.Zerospeed.Margin = New System.Windows.Forms.Padding(7)
        Me.Zerospeed.Name = "Zerospeed"
        Me.Zerospeed.Size = New System.Drawing.Size(90, 35)
        Me.Zerospeed.TabIndex = 75
        Me.Zerospeed.Text = "0-255"
        Me.Zerospeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(824, 321)
        Me.Label18.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 29)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "Start offset"
        '
        'Acc
        '
        Me.Acc.Location = New System.Drawing.Point(1066, 373)
        Me.Acc.Margin = New System.Windows.Forms.Padding(7)
        Me.Acc.Name = "Acc"
        Me.Acc.Size = New System.Drawing.Size(90, 35)
        Me.Acc.TabIndex = 77
        Me.Acc.Text = "0-255"
        Me.Acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(824, 379)
        Me.Label19.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 29)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "Accelerationstid"
        '
        'Dcc
        '
        Me.Dcc.Location = New System.Drawing.Point(1066, 431)
        Me.Dcc.Margin = New System.Windows.Forms.Padding(7)
        Me.Dcc.Name = "Dcc"
        Me.Dcc.Size = New System.Drawing.Size(90, 35)
        Me.Dcc.TabIndex = 79
        Me.Dcc.Text = "0-255"
        Me.Dcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(824, 437)
        Me.Label20.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(184, 29)
        Me.Label20.TabIndex = 78
        Me.Label20.Text = "Inbromsningstid"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(1176, 379)
        Me.Label21.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(197, 29)
        Me.Label21.TabIndex = 80
        Me.Label21.Text = "anges i sekunder"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(1176, 437)
        Me.Label22.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(197, 29)
        Me.Label22.TabIndex = 81
        Me.Label22.Text = "anges i sekunder"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.OptimeraPWM)
        Me.GroupBox3.Controls.Add(Me.Calibrate)
        Me.GroupBox3.Controls.Add(Me.Creep)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Slow)
        Me.GroupBox3.Controls.Add(Me.Shunting)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Half)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Fullfart)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.PWM)
        Me.GroupBox3.Location = New System.Drawing.Point(805, 71)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(7)
        Me.GroupBox3.Size = New System.Drawing.Size(660, 714)
        Me.GroupBox3.TabIndex = 82
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Motor och hastihetsinställningar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(371, 651)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 29)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "anges i % av Fullfart"
        '
        'OptimeraPWM
        '
        Me.OptimeraPWM.Location = New System.Drawing.Point(264, 136)
        Me.OptimeraPWM.Margin = New System.Windows.Forms.Padding(7)
        Me.OptimeraPWM.Name = "OptimeraPWM"
        Me.OptimeraPWM.Size = New System.Drawing.Size(359, 60)
        Me.OptimeraPWM.TabIndex = 110
        Me.OptimeraPWM.Text = "Optimera PWM-frekvens"
        Me.OptimeraPWM.UseVisualStyleBackColor = True
        '
        'Calibrate
        '
        Me.Calibrate.Location = New System.Drawing.Point(378, 236)
        Me.Calibrate.Margin = New System.Windows.Forms.Padding(7)
        Me.Calibrate.Name = "Calibrate"
        Me.Calibrate.Size = New System.Drawing.Size(175, 51)
        Me.Calibrate.TabIndex = 78
        Me.Calibrate.Text = "Kalibrera"
        Me.Calibrate.UseMnemonic = False
        Me.Calibrate.UseVisualStyleBackColor = True
        '
        'Creep
        '
        Me.Creep.Location = New System.Drawing.Point(261, 422)
        Me.Creep.Margin = New System.Windows.Forms.Padding(7)
        Me.Creep.Name = "Creep"
        Me.Creep.Size = New System.Drawing.Size(90, 35)
        Me.Creep.TabIndex = 77
        Me.Creep.Text = "1-126"
        Me.Creep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Location = New System.Drawing.Point(21, 596)
        Me.Label35.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(86, 29)
        Me.Label35.TabIndex = 76
        Me.Label35.Text = "Fullfart"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Location = New System.Drawing.Point(19, 489)
        Me.Label34.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(117, 29)
        Me.Label34.TabIndex = 74
        Me.Label34.Text = "Långsamt"
        '
        'Slow
        '
        Me.Slow.Location = New System.Drawing.Point(261, 482)
        Me.Slow.Margin = New System.Windows.Forms.Padding(7)
        Me.Slow.Name = "Slow"
        Me.Slow.Size = New System.Drawing.Size(90, 35)
        Me.Slow.TabIndex = 75
        Me.Slow.Text = "1-126"
        Me.Slow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(1890, 192)
        Me.Label23.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(235, 29)
        Me.Label23.TabIndex = 85
        Me.Label23.Text = "anges i 0,1 sekunder"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(1780, 185)
        Me.Start.Margin = New System.Windows.Forms.Padding(7)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(90, 35)
        Me.Start.TabIndex = 84
        Me.Start.Text = "0-255"
        Me.Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Location = New System.Drawing.Point(1538, 192)
        Me.Label24.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 29)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "Start"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Location = New System.Drawing.Point(1890, 250)
        Me.Label25.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(235, 29)
        Me.Label25.TabIndex = 88
        Me.Label25.Text = "anges i 0,1 sekunder"
        '
        'Ankomst
        '
        Me.Ankomst.Location = New System.Drawing.Point(1780, 243)
        Me.Ankomst.Margin = New System.Windows.Forms.Padding(7)
        Me.Ankomst.Name = "Ankomst"
        Me.Ankomst.Size = New System.Drawing.Size(90, 35)
        Me.Ankomst.TabIndex = 87
        Me.Ankomst.Text = "0-255"
        Me.Ankomst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Location = New System.Drawing.Point(1538, 250)
        Me.Label26.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(105, 29)
        Me.Label26.TabIndex = 86
        Me.Label26.Text = "Ankomst"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Location = New System.Drawing.Point(376, 54)
        Me.Label27.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(300, 29)
        Me.Label27.TabIndex = 91
        Me.Label27.Text = "anges pulser per sekunder"
        '
        'Maxfrq
        '
        Me.Maxfrq.Location = New System.Drawing.Point(266, 47)
        Me.Maxfrq.Margin = New System.Windows.Forms.Padding(7)
        Me.Maxfrq.Name = "Maxfrq"
        Me.Maxfrq.Size = New System.Drawing.Size(90, 35)
        Me.Maxfrq.TabIndex = 90
        Me.Maxfrq.Text = "0-255"
        Me.Maxfrq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Location = New System.Drawing.Point(23, 54)
        Me.Label28.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(147, 29)
        Me.Label28.TabIndex = 89
        Me.Label28.Text = "Maxfrekvens"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Location = New System.Drawing.Point(376, 112)
        Me.Label29.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(300, 29)
        Me.Label29.TabIndex = 94
        Me.Label29.Text = "anges pulser per sekunder"
        '
        'Minfrq
        '
        Me.Minfrq.Location = New System.Drawing.Point(266, 105)
        Me.Minfrq.Margin = New System.Windows.Forms.Padding(7)
        Me.Minfrq.Name = "Minfrq"
        Me.Minfrq.Size = New System.Drawing.Size(90, 35)
        Me.Minfrq.TabIndex = 93
        Me.Minfrq.Text = "0-255"
        Me.Minfrq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Minfrqt
        '
        Me.Minfrqt.AutoSize = True
        Me.Minfrqt.BackColor = System.Drawing.SystemColors.Control
        Me.Minfrqt.Location = New System.Drawing.Point(23, 112)
        Me.Minfrqt.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Minfrqt.Name = "Minfrqt"
        Me.Minfrqt.Size = New System.Drawing.Size(142, 29)
        Me.Minfrqt.TabIndex = 92
        Me.Minfrqt.Text = "Minfrekvens"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Location = New System.Drawing.Point(376, 170)
        Me.Label30.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(129, 29)
        Me.Label30.TabIndex = 97
        Me.Label30.Text = "anges i ms"
        '
        'Ljudpuls
        '
        Me.Ljudpuls.Location = New System.Drawing.Point(266, 163)
        Me.Ljudpuls.Margin = New System.Windows.Forms.Padding(7)
        Me.Ljudpuls.Name = "Ljudpuls"
        Me.Ljudpuls.Size = New System.Drawing.Size(90, 35)
        Me.Ljudpuls.TabIndex = 96
        Me.Ljudpuls.Text = "0-255"
        Me.Ljudpuls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Location = New System.Drawing.Point(23, 170)
        Me.Label31.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(120, 29)
        Me.Label31.TabIndex = 95
        Me.Label31.Text = "Pulslängd"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Location = New System.Drawing.Point(1890, 605)
        Me.Label32.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(177, 29)
        Me.Label32.TabIndex = 100
        Me.Label32.Text = "anges i minuter"
        '
        'Smoke
        '
        Me.Smoke.Location = New System.Drawing.Point(1780, 598)
        Me.Smoke.Margin = New System.Windows.Forms.Padding(7)
        Me.Smoke.Name = "Smoke"
        Me.Smoke.Size = New System.Drawing.Size(90, 35)
        Me.Smoke.TabIndex = 99
        Me.Smoke.Text = "0-255"
        Me.Smoke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Location = New System.Drawing.Point(1538, 605)
        Me.Label33.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(82, 29)
        Me.Label33.TabIndex = 98
        Me.Label33.Text = "Röktid"
        '
        'Ångvissla
        '
        Me.Ångvissla.Location = New System.Drawing.Point(1514, 129)
        Me.Ångvissla.Margin = New System.Windows.Forms.Padding(7)
        Me.Ångvissla.Name = "Ångvissla"
        Me.Ångvissla.Padding = New System.Windows.Forms.Padding(7)
        Me.Ångvissla.Size = New System.Drawing.Size(714, 178)
        Me.Ångvissla.TabIndex = 101
        Me.Ångvissla.TabStop = False
        Me.Ångvissla.Text = "Ångvissla"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Maxfrq)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Ljudpuls)
        Me.GroupBox4.Controls.Add(Me.Minfrqt)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Minfrq)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Location = New System.Drawing.Point(1514, 321)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(7)
        Me.GroupBox4.Size = New System.Drawing.Size(714, 248)
        Me.GroupBox4.TabIndex = 102
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pulsstyrt ångljud"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Location = New System.Drawing.Point(324, 76)
        Me.Label36.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(324, 29)
        Me.Label36.TabIndex = 105
        Me.Label36.Text = "anges i 10 sekundersintervall"
        '
        'mindwell
        '
        Me.mindwell.Location = New System.Drawing.Point(215, 69)
        Me.mindwell.Margin = New System.Windows.Forms.Padding(7)
        Me.mindwell.Name = "mindwell"
        Me.mindwell.Size = New System.Drawing.Size(90, 35)
        Me.mindwell.TabIndex = 104
        Me.mindwell.Text = "0-255"
        Me.mindwell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Location = New System.Drawing.Point(16, 76)
        Me.Label37.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(151, 29)
        Me.Label37.TabIndex = 103
        Me.Label37.Text = "Min uppehåll"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Location = New System.Drawing.Point(324, 136)
        Me.Label38.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(324, 29)
        Me.Label38.TabIndex = 108
        Me.Label38.Text = "anges i 10 sekundersintervall"
        '
        'maxdwell
        '
        Me.maxdwell.Location = New System.Drawing.Point(215, 129)
        Me.maxdwell.Margin = New System.Windows.Forms.Padding(7)
        Me.maxdwell.Name = "maxdwell"
        Me.maxdwell.Size = New System.Drawing.Size(90, 35)
        Me.maxdwell.TabIndex = 107
        Me.maxdwell.Text = "0-255"
        Me.maxdwell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.Location = New System.Drawing.Point(16, 136)
        Me.Label39.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(156, 29)
        Me.Label39.TabIndex = 106
        Me.Label39.Text = "Max uppehåll"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.mindwell)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Controls.Add(Me.Label39)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.maxdwell)
        Me.GroupBox5.Location = New System.Drawing.Point(40, 433)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(7)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(7)
        Me.GroupBox5.Size = New System.Drawing.Size(674, 223)
        Me.GroupBox5.TabIndex = 109
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Stationsuppehåll vid pendeltrafik"
        '
        'Lok
        '
        Me.Lok.Location = New System.Drawing.Point(1780, 737)
        Me.Lok.Name = "Lok"
        Me.Lok.Size = New System.Drawing.Size(161, 35)
        Me.Lok.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1699, 694)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 29)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "DCCadress att programmera"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2297, 1051)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lok)
        Me.Controls.Add(Me.Host)
        Me.Controls.Add(Me.Port)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.NM4)
        Me.Controls.Add(Me.Smoke)
        Me.Controls.Add(Me.NM3)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.NM2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.NM1)
        Me.Controls.Add(Me.Ankomst)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.IP4)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.IP3)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.IP2)
        Me.Controls.Add(Me.Dcc)
        Me.Controls.Add(Me.IP1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Acc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Zerospeed)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Programmed)
        Me.Controls.Add(Me.Signalfil)
        Me.Controls.Add(Me.SaveFile)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Ångvissla)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Form1"
        Me.Text = "Konfiguration av Lok-parametrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Connect As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Program As Button
    Friend WithEvents SSID As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFile As Button
    Friend WithEvents SaveFile As Button
    Friend WithEvents Signalfil As Label
    Friend WithEvents Programmed As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Loknamn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IP1 As TextBox
    Friend WithEvents IP2 As TextBox
    Friend WithEvents IP3 As TextBox
    Friend WithEvents IP4 As TextBox
    Friend WithEvents NM4 As TextBox
    Friend WithEvents NM3 As TextBox
    Friend WithEvents NM2 As TextBox
    Friend WithEvents NM1 As TextBox
    Friend WithEvents Port As TextBox
    Friend WithEvents Host As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PWM As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Fullfart As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Half As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Shunting As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Zerospeed As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Acc As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Dcc As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Start As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Ankomst As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Maxfrq As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Minfrq As TextBox
    Friend WithEvents Minfrqt As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Ljudpuls As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Smoke As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Ångvissla As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Slow As TextBox
    Friend WithEvents Creep As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents mindwell As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents maxdwell As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Calibrate As Button
    Friend WithEvents OptimeraPWM As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Lok As TextBox
    Friend WithEvents Label5 As Label
End Class
