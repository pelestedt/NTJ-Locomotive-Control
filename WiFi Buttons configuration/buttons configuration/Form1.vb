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
    End Sub

    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click
        Programmed.Visible = False
        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        b4.Text = ""
        b5.Text = ""
        b6.Text = ""
        b7.Text = ""
        b8.Text = ""
        b9.Text = ""
        b10.Text = ""
        b11.Text = ""
        b12.Text = ""
        Update()

        Dim clientSocket As New System.Net.Sockets.TcpClient()

        readData = "Ansluter till lok ......"
        msg()

        clientSocket.Connect("10.10.10.10", 44)

        'Label1.Text = "Client Socket Program - Server Connected ..."
        serverStream = clientSocket.GetStream()

        Dim outStream As Byte() =
        System.Text.Encoding.ASCII.GetBytes("sendButtons" + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        REM Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        REM ctThread.Start()

        TextBox1.Text = readData
        TextBox1.Update()

        While clientSocket.Available() < 10
            TextBox1.Text = "Väntar på konfiguration"
            TextBox1.Update()
        End While
omstart:
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

        If (Strings.Left(readData, 2) = "VN") Then
            GoTo omstart
        End If

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

        b1.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete firt value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Locomotive  name
        b2.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b3.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b4.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b5.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b6.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b7.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b8.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b9.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b10.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b11.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, "$")
        REM Extract password
        b12.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        clientSocket.Close()

slut:
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles OpenFile.Click
        Programmed.Visible = False

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

        REM Extract first value to varable "teststring"
        teststring = Current_configuration

        REM Find first "," sign
        B = InStr(teststring, ",")
        REM Extract first value and assign to button
        b1.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete firt value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Locomotive  name
        b2.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b3.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b4.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b5.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b6.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b7.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b8.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b9.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b10.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "," sign
        B = InStr(teststring, ",")
        REM Extract password
        b11.Text = Trim(Strings.Left(teststring, B - 1))
        REM Delete second value from teststring
        teststring = Strings.Right(teststring, (Strings.Len(teststring) - B))

        REM Find next "$" sign
        B = InStr(teststring, "$")
        REM Extract password
        b12.Text = Trim(Strings.Left(teststring, B - 1))
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
            Nydef = b1.Text + ","
            Nydef = Nydef + b2.Text + ","
            Nydef = Nydef + b3.Text + ","
            Nydef = Nydef + b4.Text + ","
            Nydef = Nydef + b5.Text + ","
            Nydef = Nydef + b6.Text + ","
            Nydef = Nydef + b7.Text + ","
            Nydef = Nydef + b8.Text + ","
            Nydef = Nydef + b9.Text + ","
            Nydef = Nydef + b10.Text + ","
            Nydef = Nydef + b11.Text + ","
            Nydef = Nydef + b12.Text + "$"

            file.WriteLine(Nydef)
            file.Close()
        End If
    End Sub

    Private Sub Program_Click(sender As Object, e As EventArgs) Handles Program.Click
        Dim clientSocket As New System.Net.Sockets.TcpClient()


        Program.Enabled = False
        Dim Outmessage As String

        Outmessage = "P" + b1.Text + ","
        Outmessage = Outmessage + b2.Text + ","
        Outmessage = Outmessage + b3.Text + ","
        Outmessage = Outmessage + b4.Text + ","
        Outmessage = Outmessage + b5.Text + ","
        Outmessage = Outmessage + b6.Text + ","
        Outmessage = Outmessage + b7.Text + ","
        Outmessage = Outmessage + b8.Text + ","
        Outmessage = Outmessage + b9.Text + ","
        Outmessage = Outmessage + b10.Text + ","
        Outmessage = Outmessage + b11.Text + ","
        Outmessage = Outmessage + b12.Text + "$"

        readData = "Ansluter till lok för att programmera ......"
        msg()

        clientSocket.Connect("10.10.10.10", 44)

        'Label1.Text = "Client Socket Program - Server Connected ..."
        serverStream = clientSocket.GetStream()

        Dim outStream As Byte() =
        System.Text.Encoding.ASCII.GetBytes("writebuttons" + "$" + Outmessage)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        REM Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        REM ctThread.Start()

        TextBox1.Text = Outmessage
        TextBox1.Update()

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

        Programmed.Visible = True
        Program.Enabled = True
        Programmed.Update()
        clientSocket.Close()
    End Sub

End Class
