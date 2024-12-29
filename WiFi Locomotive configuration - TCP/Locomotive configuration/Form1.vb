Imports System.IO
Imports System.Net.Sockets

Public Class Form1
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer
    Dim Current_configuration As String



    Private Sub getMessage()
        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            serverStream = clientSocket.GetStream()
            Dim buffSize As Integer
            Dim inStream(1024) As Byte
            buffSize = 1024
            serverStream.Read(inStream, 0, buffSize)
            Dim returndata As String =
            System.Text.Encoding.ASCII.GetString(inStream)
            readData = returndata
            msg()
        Next
    End Sub
    Private Sub msg()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msg))
        Else
            TextBox1.Text = readData
            TextBox1.Update()
        End If
        TextBox1.Text = readData
        TextBox1.Update()
        '   Threading.Thread.Sleep(10000)
        TextBox1.Text = ""
        TextBox1.Update()

    End Sub

    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click
        Programmed.Visible = False
        SSID.Text = ""
        Loknamn.Text = ""
        Password.Text = ""
        IP1.Text = ""
        IP2.Text = ""
        IP3.Text = ""
        IP4.Text = ""
        NM1.Text = ""
        NM2.Text = ""
        NM3.Text = ""
        NM4.Text = ""
        Port.Text = ""
        Host.Text = ""
        PWM.Text = ""
        Zerospeed.Text = ""
        Acc.Text = ""
        Dcc.Text = ""
        Fullfart.Text = ""
        Slow.Text = ""
        Half.Text = ""
        Shunting.Text = ""
        Start.Text = ""
        Ankomst.Text = ""
        Maxfrq.Text = ""
        Minfrq.Text = ""
        Ljudpuls.Text = ""
        Smoke.Text = ""
        Creep.Text = ""
        mindwell.Text = ""
        maxdwell.Text = ""
        Update()

        Dim clientSocket As New System.Net.Sockets.TcpClient()

        readData = "Ansluter till lok ......"
        msg()
        Try
            Dim valt_lok As String = "Lok" + Lok.Text
            clientSocket.Connect(valt_lok, 23)
            TextBox1.Update()
        Catch
            TextBox1.Text = "Loket hittades inte, välj annan adress och försök igen"
            TextBox1.Update()
            Threading.Thread.Sleep(10000)
            TextBox1.Text = ""
            TextBox1.Update()
            clientSocket.Close()
            GoTo slut
        End Try
        'Label1.Text = "Client Socket Program - Server Connected ..."
        serverStream = clientSocket.GetStream()

        Dim outStream As Byte() =
        System.Text.Encoding.ASCII.GetBytes("Getconfig" + "$")
        clientSocket.NoDelay = True
        serverStream.WriteTimeout = (1)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        REM Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        REM ctThread.Start()

        REM TextBox1.Text = readData
        REM TextBox1.Update()

        While clientSocket.Available() < 10
            TextBox1.Text = "Väntar på konfiguration"
            TextBox1.Update()
        End While

        serverStream = clientSocket.GetStream()
        Dim buffSize As Integer
        Dim inStream(200) As Byte
        buffSize = 200
        serverStream.Read(inStream, 0, buffSize)
        Dim returndata As String =
            System.Text.Encoding.ASCII.GetString(inStream)
        readData = returndata
        TextBox1.Text = readData
        TextBox1.Update()
        msg()


        Dim B As Int16 = 0
        Dim teststring As String
        Current_configuration = readData
        REM Find position for first $
        B = InStr(Current_configuration, "$")
        REM Extract first value to varable "teststring"
        teststring = Current_configuration
        REM Find first "," sign
        B = InStr(teststring, ",")
        REM Extract first value and assign to Semafor addresss

        SSID.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete firt value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Locomotive  name
        Loknamn.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        Password.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract IP address
        IP1.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))
        B = InStr(teststring, ",")
        REM Extract IP address
        IP2.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))
        B = InStr(teststring, ",")
        REM Extract IP address
        IP3.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))
        B = InStr(teststring, ",")
        REM Extract IP address
        IP4.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        NM1.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))
        B = InStr(teststring, ",")
        REM Extract IP address
        NM2.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))
        B = InStr(teststring, ",")
        REM Extract IP address
        NM3.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))
        B = InStr(teststring, ",")
        REM Extract IP address
        NM4.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Port.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Host.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        PWM.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Zerospeed.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Acc.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Dcc.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "$" sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Fullfart.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Slow.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Half.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Shunting.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Start.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Ankomst.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Maxfrq.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Minfrq.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Ljudpuls.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Smoke.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract net mask address
        Creep.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "$" sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        mindwell.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "$" sign
        B = InStr(teststring, "$")
        REM Extract second value and assign to number of wings
        maxdwell.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        REM teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        clientSocket.Close()

slut:
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles OpenFile.Click
        Programmed.Visible = False
        If SerialPort1.IsOpen = True Then
            Program.Visible = True
        End If

        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Title = "Open File..."
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "Loco definitions *.txt|*.txt"
        OpenFileDialog1.ShowDialog()
        Signalfil.Text = OpenFileDialog1.FileName
        Dim Current_configuration As String
        Current_configuration = My.Computer.FileSystem.ReadAllText(Signalfil.Text)

        Dim B As Int16 = 0
        Dim teststring As String

        REM Get values from file

        REM Find position for first $
        B = InStr(Current_configuration, "$")

        REM Extract values to varable "teststring"
        teststring = Strings.Left(Current_configuration, B)
        REM Find first "," sign
        B = InStr(teststring, ",")
        REM Extract first value and assign to SSID
        SSID.Text = Strings.Left(teststring, B - 1)
        REM Delete firt value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Loknamn.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Password.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        IP1.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        IP2.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        IP3.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        IP4.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        NM1.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        NM2.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        NM3.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        NM4.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Port.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Host.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        PWM.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Zerospeed.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Acc.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Dcc.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Fullfart.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Slow.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Half.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Shunting.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Start.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Ankomst.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Maxfrq.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Minfrq.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Ljudpuls.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Smoke.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        Creep.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract second value and assign to number of wings
        mindwell.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, "$")
        REM Extract second value and assign to number of wings
        maxdwell.Text = Strings.Left(teststring, B - 1)
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

    End Sub

    Private Sub SaveFile_Click(sender As Object, e As EventArgs) Handles SaveFile.Click
        Programmed.Visible = False
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Title = "Save File..."
        SaveFileDialog1.Filter = "Loco definitions *.txt|*.txt"
        SaveFileDialog1.ShowDialog()
        Signalfil.Text = SaveFileDialog1.FileName
        If Strings.Len(Signalfil.Text) > 0 Then
            System.IO.File.Create(Signalfil.Text).Dispose()
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(Signalfil.Text, True)
            Dim Nydef As String
            Nydef = SSID.Text + ","
            Nydef = Nydef + Loknamn.Text + ","
            Nydef = Nydef + Password.Text + ","
            Nydef = Nydef + IP1.Text + ","
            Nydef = Nydef + IP2.Text + ","
            Nydef = Nydef + IP3.Text + ","
            Nydef = Nydef + IP4.Text + ","
            Nydef = Nydef + NM1.Text + ","
            Nydef = Nydef + NM2.Text + ","
            Nydef = Nydef + NM3.Text + ","
            Nydef = Nydef + NM4.Text + ","
            Nydef = Nydef + Port.Text + ","
            Nydef = Nydef + Host.Text + ","
            Nydef = Nydef + PWM.Text + ","
            Nydef = Nydef + Zerospeed.Text + ","
            Nydef = Nydef + Acc.Text + ","
            Nydef = Nydef + Dcc.Text + ","
            Nydef = Nydef + Fullfart.Text + ","
            Nydef = Nydef + Slow.Text + ","
            Nydef = Nydef + Half.Text + ","
            Nydef = Nydef + Shunting.Text + ","
            Nydef = Nydef + Start.Text + ","
            Nydef = Nydef + Ankomst.Text + ","
            Nydef = Nydef + Maxfrq.Text + ","
            Nydef = Nydef + Minfrq.Text + ","
            Nydef = Nydef + Ljudpuls.Text + ","
            Nydef = Nydef + Smoke.Text + ","
            Nydef = Nydef + Creep.Text + ","
            Nydef = Nydef + mindwell.Text + ","
            Nydef = Nydef + maxdwell.Text + "$"

            file.WriteLine(Nydef)
            file.Close()
        End If
    End Sub

    Private Sub Program_Click(sender As Object, e As EventArgs) Handles Program.Click
        Dim clientSocket As New System.Net.Sockets.TcpClient()


        Program.Enabled = False
        Dim Outmessage As String

        Dim txt As String
        txt = SSID.Text
        txt = Strings.Left(txt + "                    ", 10)
        Outmessage = txt + ","


        txt = Loknamn.Text
        txt = Strings.Left(txt + "                    ", 20)
        Outmessage = Outmessage + txt + ","

        txt = Password.Text
        txt = Strings.Left(txt + "                    ", 10)
        Outmessage = Outmessage + txt + ","

        Outmessage = Outmessage + IP1.Text + ","
        Outmessage = Outmessage + IP2.Text + ","
        Outmessage = Outmessage + IP3.Text + ","
        Outmessage = Outmessage + IP4.Text + ","
        Outmessage = Outmessage + NM1.Text + ","
        Outmessage = Outmessage + NM2.Text + ","
        Outmessage = Outmessage + NM3.Text + ","
        Outmessage = Outmessage + NM4.Text + ","
        Outmessage = Outmessage + Port.Text + ","
        Outmessage = Outmessage + Host.Text + ","
        Outmessage = Outmessage + PWM.Text + ","
        Outmessage = Outmessage + Zerospeed.Text + ","
        Outmessage = Outmessage + Acc.Text + ","
        Outmessage = Outmessage + Dcc.Text + ","
        Outmessage = Outmessage + Fullfart.Text + ","
        Outmessage = Outmessage + Slow.Text + ","
        Outmessage = Outmessage + Half.Text + ","
        Outmessage = Outmessage + Shunting.Text + ","
        Outmessage = Outmessage + Start.Text + ","
        Outmessage = Outmessage + Ankomst.Text + ","
        Outmessage = Outmessage + Maxfrq.Text + ","
        Outmessage = Outmessage + Minfrq.Text + ","
        Outmessage = Outmessage + Ljudpuls.Text + ","
        Outmessage = Outmessage + Smoke.Text + ","
        Outmessage = Outmessage + Creep.Text + ","
        Outmessage = Outmessage + mindwell.Text + ","
        Outmessage = Outmessage + maxdwell.Text + "$"

        readData = "Ansluter till lok för att programmera ......"
        msg()
        Try
            Dim valt_lok As String = "Lok" + Lok.Text
            clientSocket.Connect(valt_lok, 23)
        Catch
            TextBox1.Text = "Loket hittades inte, välj annan adress och försök igen"
            TextBox1.Update()
            Threading.Thread.Sleep(5000)
            TextBox1.Text = ""
            TextBox1.Update()
            Programmed.Visible = True
            Program.Enabled = True
            Programmed.Update()
            clientSocket.Close()
            GoTo slut3
        End Try

        'Label1.Text = "Client Socket Program - Server Connected ..."
        serverStream = clientSocket.GetStream()

        Dim outStream As Byte() =
        System.Text.Encoding.ASCII.GetBytes("Writeconfig" + "$" + Outmessage)
        clientSocket.NoDelay = True
        serverStream.WriteTimeout = (1)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        REM Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        REM ctThread.Start()

        TextBox1.Text = "Loket är programmerat. För att kontrollera resultatet anslut till loket och tryck på [Läs up]"
        TextBox1.Update()

        REM serverStream = clientSocket.GetStream()
        REM Dim buffSize As Integer
        REM Dim inStream(200) As Byte
        REM buffSize = 200
        REM serverStream.Read(inStream, 0, buffSize)
        REM Dim returndata As String =
        REM System.Text.Encoding.ASCII.GetString(inStream)
        REM readData = returndata
        REM TextBox1.Text = readData
        REM TextBox1.Update()
        REM msg()

        Programmed.Visible = True
        Program.Enabled = True
        Programmed.Update()
        clientSocket.Close()
slut3:
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calibrate.Click

        Dim clientSocket As New System.Net.Sockets.TcpClient()
        Dim Outmessage As String
        Outmessage = ","
        readData = "Ansluter till lok för att kalibrera startoffset ......"
        msg()
        Try
            Dim valt_lok As String = "Lok" + Lok.Text
            clientSocket.Connect(valt_lok, 23)
        Catch
            TextBox1.Text = "Loket hittades inte, välj ny adress och försök igen"
            TextBox1.Update()
            Threading.Thread.Sleep(5000)
            TextBox1.Text = ""
            TextBox1.Update()
            GoTo slut2
        End Try
        serverStream = clientSocket.GetStream()
        Dim outStream As Byte() =
        System.Text.Encoding.ASCII.GetBytes("Calibrate" + "$" + Outmessage)
        clientSocket.NoDelay = True
        serverStream.WriteTimeout = (1)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
        TextBox1.Text = "Loket Kalibreras. För att kontrollera resultatet anslut till loket och tryck på knappen [Läs up]"
        TextBox1.Update()
        Threading.Thread.Sleep(10000)
        TextBox1.Text = ""
        TextBox1.Update()

        clientSocket.Close()
slut2:
    End Sub

    Private Sub OptimeraPWM_Click(sender As Object, e As EventArgs) Handles OptimeraPWM.Click
        Dim clientSocket As New System.Net.Sockets.TcpClient()
        Dim Outmessage As String
        Outmessage = ","
        readData = "Ansluter till lok för att optimera PWM-frekvens ......"
        msg()
        Try
            Dim valt_lok As String = "Lok" + Lok.Text
            clientSocket.Connect(valt_lok, 23)
        Catch
            TextBox1.Text = "Loket hittades inte, välj ny adress och försök igen"
            TextBox1.Update()
            Threading.Thread.Sleep(5000)
            TextBox1.Text = ""
            TextBox1.Update()
            GoTo slut3
        End Try
        serverStream = clientSocket.GetStream()
        Dim outStream As Byte() =
        System.Text.Encoding.ASCII.GetBytes("PWM" + "$" + Outmessage)
        clientSocket.NoDelay = True
        serverStream.WriteTimeout = (1)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
        TextBox1.Text = "Loket PWM-frekvens optimeras. För att kontrollera resultatet anslut till loket och tryck på knappen [Läs up]"
        TextBox1.Update()
        Threading.Thread.Sleep(10000)
        TextBox1.Text = ""
        TextBox1.Update()

        clientSocket.Close()
slut3:
    End Sub


End Class
