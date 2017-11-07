Public Class Form1
    Public Shared pool_url As String = ""
    Private Sub wallet_address_Click(sender As Object, e As EventArgs) Handles wallet_address.Click
        If wallet_address.Text = "etnkAjckxKuQ2ov3QVmJRWJserxDuFpQJNKud22TN79PhJFtmd7FtDLLGpyErzEWM47W7JVsbXeVfTgmuUPsUAaX81rdJrMtJw" Then
            wallet_address.Text = ""
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        wallet_address.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cpuorgpu.SelectedItem = cpuorgpu.Items(0)
        pool.SelectedItem = pool.Items(7)
        gpubrand.Visible = False
        lbl_gpubrand.Visible = False
        gpubrand.SelectedItem = gpubrand.Items(0)
    End Sub

    Private Sub mining_Click(sender As Object, e As EventArgs) Handles mining.Click
        If pool.SelectedItem = pool.Items(9) Then
            pool_url = (custom_pool.Text)
        End If
        If threads.Text <= 1 Then
            threads.Text = "1"
        End If
        If mining.Text = "Stop mining" Then
            Dim arrProcessCPU() As Process = System.Diagnostics.Process.GetProcessesByName("cpuminer")

            For Each p As Process In arrProcessCPU
                p.Kill()
            Next
            Dim arrProcessNV() As Process = System.Diagnostics.Process.GetProcessesByName("ccminer")

            For Each p As Process In arrProcessNV
                p.Kill()
            Next
            Dim arrProcessAMD() As Process = System.Diagnostics.Process.GetProcessesByName("xmr-stak-amd")

            For Each p As Process In arrProcessAMD
                p.Kill()
            Next
            Dim arrProcessNVXMR() As Process = System.Diagnostics.Process.GetProcessesByName("xmr-stak-nvidia")

            For Each p As Process In arrProcessNVXMR
                p.Kill()
            Next
            Dim arrProcessCPUXMR() As Process = System.Diagnostics.Process.GetProcessesByName("xmr-stak-cpu")

            For Each p As Process In arrProcessCPUXMR
                p.Kill()
            Next
            mining.Text = "Start mining"
        Else
            Dim FILE_NAME As String = "mine.bat"
            If System.IO.File.Exists(FILE_NAME) = False Then
                System.IO.File.Create(FILE_NAME).Dispose()
            Else
                System.IO.File.Delete(FILE_NAME)
                System.IO.File.Create(FILE_NAME).Dispose()
            End If

            If cpuorgpu.SelectedItem = cpuorgpu.Items(0) And miner_type.SelectedItem = miner_type.Items(1) Then
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
                objWriter.WriteLine("cpuminer -a cryptonight -o stratum+tcp://" & pool_url & ":" & port.Text & " -u " & wallet_address.Text & " -p x -t " & threads.Text & "pause")
                objWriter.Close()
                System.Diagnostics.Process.Start("mine.bat")
                mining.Text = "Stop mining"
            End If

            If cpuorgpu.SelectedItem = cpuorgpu.Items(1) And gpubrand.SelectedItem = gpubrand.Items(0) And miner_type.SelectedItem = miner_type.Items(1) Then
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
                objWriter.WriteLine("ccminer -o stratum+tcp://" & pool_url & ":" & port.Text & " -u " & wallet_address.Text & " -p x -t " & threads.Text & "pause")
                objWriter.Close()
                System.Diagnostics.Process.Start("mine.bat")
                mining.Text = "Stop mining"
            End If

            If cpuorgpu.SelectedItem = cpuorgpu.Items(1) And gpubrand.SelectedItem = gpubrand.Items(1) Then
                'create new config file
                Dim FILE_NAME_AMD As String = "config.txt"
                If System.IO.File.Exists(FILE_NAME_AMD) = False Then
                    System.IO.File.Create(FILE_NAME_AMD).Dispose()
                Else
                    System.IO.File.Delete(FILE_NAME_AMD)
                    System.IO.File.Create(FILE_NAME_AMD).Dispose()
                End If
                System.IO.File.Copy("config-template.txt", "config.txt", True)
                'This can done way better but i can't be assed
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText("config.txt").Replace("threads_replace", threads.Text)
                fileReader = fileReader.Replace("address_replace", pool_url & ":" & port.Text)
                fileReader = fileReader.Replace("wallet_replace", wallet_address.Text)
                Dim index As Integer = threads.Text
                While index <= 15
                    fileReader = fileReader.Replace("{ ""index"" : " & index & ", ""intensity"" : 1000, ""worksize"" : 8, ""affine_to_cpu"" : false },", "")
                    index += 1
                End While
                My.Computer.FileSystem.WriteAllText("config.txt", fileReader, False)
                System.Diagnostics.Process.Start("xmr-stak-amd.exe")
                mining.Text = "Stop mining"
            End If

            If cpuorgpu.SelectedItem = cpuorgpu.Items(1) And gpubrand.SelectedItem = gpubrand.Items(0) And miner_type.SelectedItem = miner_type.Items(0) Then
                'create new config file
                Dim FILE_NAME_NV As String = "config.txt"
                If System.IO.File.Exists(FILE_NAME_NV) = False Then
                    System.IO.File.Create(FILE_NAME_NV).Dispose()
                Else
                    System.IO.File.Delete(FILE_NAME_NV)
                    System.IO.File.Create(FILE_NAME_NV).Dispose()
                End If
                System.IO.File.Copy("config-template-nv.txt", "config.txt", True)
                'This can done way better but i can't be assed
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText("config.txt").Replace("threads_replace", threads.Text)
                fileReader = fileReader.Replace("address_replace", pool_url & ":" & port.Text)
                fileReader = fileReader.Replace("wallet_replace", wallet_address.Text)
                Dim index As Integer = threads.Text
                While index <= 15
                    fileReader = fileReader.Replace("{ ""index"" : " & index & ",""threads"" : 3, ""blocks"" : 12,""bfactor"" : 6, ""bsleep"" :  25,""affine_to_cpu"" : false,},", "")
                    index += 1
                End While
                My.Computer.FileSystem.WriteAllText("config.txt", fileReader, False)
                System.Diagnostics.Process.Start("xmr-stak-nvidia.exe")
                mining.Text = "Stop mining"
            End If


            If cpuorgpu.SelectedItem = cpuorgpu.Items(0) And miner_type.SelectedItem = miner_type.Items(0) Then
                'create new config file
                Dim FILE_NAME_CPU As String = "config.txt"
                If System.IO.File.Exists(FILE_NAME_CPU) = False Then
                    System.IO.File.Create(FILE_NAME_CPU).Dispose()
                Else
                    System.IO.File.Delete(FILE_NAME_CPU)
                    System.IO.File.Create(FILE_NAME_CPU).Dispose()
                End If
                System.IO.File.Copy("config-template-cpu.txt", "config.txt", True)
                'This can done way better but i can't be assed
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText("config.txt").Replace("threads_replace", threads.Text)
                fileReader = fileReader.Replace("address_replace", pool_url & ":" & port.Text)
                fileReader = fileReader.Replace("wallet_replace", wallet_address.Text)
                Dim index As Integer = ((threads.Text * 2) - 1)
                While index <= 14
                    fileReader = fileReader.Replace("{ ""low_power_mode"" : false, ""no_prefetch"" : true, ""affine_to_cpu"" : " & index & " },", "")
                    index += 1
                End While
                My.Computer.FileSystem.WriteAllText("config.txt", fileReader, False)
                System.Diagnostics.Process.Start("xmr-stak-cpu.exe")
                mining.Text = "Stop mining"
            End If
        End If

    End Sub

    Private Sub cpuorgpu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cpuorgpu.SelectedIndexChanged
        If cpuorgpu.SelectedItem = cpuorgpu.Items(1) Then
            'change threadcount to gpu count
            lbl_threads.Text = "GPU Count:"
            threads.Text = "1"
            port.Text = "5555"
            lbl_gpubrand.Visible = True
            gpubrand.Visible = True
            miner_type.Enabled = True
            miner_type.Items.Clear()
            miner_type.Items.Add("xmr-stak-nvidia")
            miner_type.Items.Add("ccminer")
            miner_type.SelectedItem = miner_type.Items(1)
        End If

        If cpuorgpu.SelectedItem = cpuorgpu.Items(0) Then
            'change threadcount to gpu count
            lbl_threads.Text = "Thread Count:"
            threads.Text = "4"
            lbl_gpubrand.Visible = False
            gpubrand.SelectedItem = gpubrand.Items(0)
            gpubrand.Visible = False
            miner_type.Enabled = True
            miner_type.Items.Clear()
            miner_type.Items.Add("xmr-stak-cpu")
            miner_type.Items.Add("cpuminer-multi")
            miner_type.SelectedItem = miner_type.Items(0)
        End If
    End Sub

    Private Sub pool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pool.SelectedIndexChanged
        If pool.SelectedItem = pool.Items(9) Then
            custom_pool.Enabled = True
            status.Text = status.Text & vbNewLine & ">>Custom pool selected, make sure to add your pool address!"
        Else
            custom_pool.Enabled = False
        End If

        If pool.SelectedItem = pool.Items(0) Then
            pool_url = "uspool.electroneum.com"
            status.Text = status.Text & vbNewLine & ">>uspool.electroneum.com selected, 4% Pool fee, 100 ETN Minimum Cashout"
            status.Text = status.Text & vbNewLine & "   WARNING 1: This pool is having issues paying out, it is not recommended"
            status.Text = status.Text & vbNewLine & "   WARNING 2: This pool has a high minimum cashout, it is not recommended"
            status.Text = status.Text & vbNewLine & "   WARNING 3: This pool is often down, it is not recommended"
        End If
        If pool.SelectedItem = pool.Items(1) Then
            pool_url = "eupool.electroneum.com"
            status.Text = status.Text & vbNewLine & ">>eupool.electroneum.com selected, 4% Pool fee, 100 ETN Minimum Cashout"
            status.Text = status.Text & vbNewLine & "   WARNING 1: This pool is having issues paying out, it is not recommended"
            status.Text = status.Text & vbNewLine & "   WARNING 2: This pool has a high minimum cashout, it is not recommended"
            status.Text = status.Text & vbNewLine & "   WARNING 3: This pool is often down, it is not recommended"
        End If
        If pool.SelectedItem = pool.Items(2) Then
            pool_url = "asiapool.electroneum.com"
            status.Text = status.Text & vbNewLine & ">>asiapool.electroneum.com selected, 4% Pool fee, 100 ETN Minimum Cashout"
            status.Text = status.Text & vbNewLine & "   WARNING 1: This pool is having issues paying out, it is not recommended"
            status.Text = status.Text & vbNewLine & "   WARNING 2: This pool has a high minimum cashout, it is not recommended"
            status.Text = status.Text & vbNewLine & "   WARNING 3: This pool is often down, it is not recommended"
        End If
        If pool.SelectedItem = pool.Items(3) Then
            pool_url = "electroneum.hashparty.io"
            status.Text = status.Text & vbNewLine & ">>electroneum.hashparty.io selected, 2% Pool fee, 2 ETN Minimum Cashout"
            status.Text = status.Text & vbNewLine & "   INFO 1: This pool has a very high hashrate, consider using an alternative pool to spread hashrate out"
        End If
        If pool.SelectedItem = pool.Items(4) Then
            pool_url = "pool.electroneum.space"
            status.Text = status.Text & vbNewLine & ">>pool.electroneum.space selected, UNKWN Pool fee, 1 ETN Minimum Cashout"
        End If
        If pool.SelectedItem = pool.Items(5) Then
            pool_url = "myetn.uk"
            status.Text = status.Text & vbNewLine & ">>myetn.uk selected, 2% Pool fee, 10 ETN Minimum Cashout"
        End If
        If pool.SelectedItem = pool.Items(6) Then
            pool_url = "etnhash.com"
            status.Text = status.Text & vbNewLine & ">>etnhash.com selected, 1.5% Pool fee, 0.5 ETN Minimum Cashout"
        End If
        If pool.SelectedItem = pool.Items(7) Then
            pool_url = "www.etnpools.com"
            status.Text = status.Text & vbNewLine & ">>www.etnpools.com selected, 1% Pool fee, 5 ETN Minimum Cashout"
        End If
        If pool.SelectedItem = pool.Items(8) Then
            pool_url = "etnpool.minekitten.io"
            status.Text = status.Text & vbNewLine & ">>etnpool.minekitten.io selected, 0.4% Pool fee, 5 ETN Minimum Cashout"
        End If
    End Sub

    Private Sub gpubrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gpubrand.SelectedIndexChanged
        If gpubrand.SelectedItem = gpubrand.Items(0) And cpuorgpu.SelectedItem = cpuorgpu.Items(1) Then
            miner_type.Enabled = True
            miner_type.Items.Clear()
            miner_type.Items.Add("xmr-stak-nvidia")
            miner_type.Items.Add("ccminer")
            miner_type.SelectedItem = miner_type.Items(1)
        End If
        If gpubrand.SelectedItem = gpubrand.Items(1) And cpuorgpu.SelectedItem = cpuorgpu.Items(1) Then
            miner_type.Items.Clear()
            miner_type.Items.Add("xmr-stak-amd")
            miner_type.Items.Add("xmr-stak-amd")
            miner_type.SelectedItem = miner_type.Items(0)
            miner_type.Enabled = False
        End If
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        Dim string1 As String = ""
        string1 = miner_type.SelectedItem.ToString()
        If string1 = "xmr-stak-cpu" Then
            status.Text = status.Text & vbNewLine & ">>xmr-stak-cpu miner detected" & vbNewLine & "   ERROR HELP 1: If receiving a 'MEMORY ALLOC FAILED: VirtualAlloc failed' error, disable all auto-starting applications and run the miner after a reboot. You do not have enough free ram."
            status.Text = status.Text & vbNewLine & "   ERROR HELP 2: If receiving msvcp140.dll and vcruntime140.dll not available errors, download and install the following runtime package: https://www.microsoft.com/en-us/download/details.aspx?id=17657"
            status.Text = status.Text & vbNewLine & "   ERROR HELP 3: If it still doesn't work, switch the miner backend to cpuminer-multi"
            status.Text = status.Text & vbNewLine & "   ERROR HELP 4: Perhaps you have too many threads"
            status.Text = status.Text & vbNewLine & ">>Thread count halved"
            threads.Text = threads.Text / 2
        End If
        If cpuorgpu.SelectedItem = cpuorgpu.Items(1) And threads.Text >= 2 Then
            port.Text = "7777"
            status.Text = status.Text & vbNewLine & ">>gpu mining with 2+GPUs detected, setting port to 7777"
        End If
        If string1 = "xmr-stak-nvidia" Then
            status.Text = status.Text & vbNewLine & ">>xmr-stak-nvidia miner detected" & vbNewLine & "   ERROR HELP 1: If receiving a 'MEMORY ALLOC FAILED: VirtualAlloc failed' error, disable all auto-starting applications and run the miner after a reboot. You do not have enough free ram."
            status.Text = status.Text & vbNewLine & "   ERROR HELP 2: If receiving msvcp140.dll and vcruntime140.dll not available errors, download and install the following runtime package: https://www.microsoft.com/en-us/download/details.aspx?id=17657"
            status.Text = status.Text & vbNewLine & "   ERROR HELP 3: If it still doesn't work, switch the miner backend to ccminer, xmr-stak-nvidia does not support more than 16 GPUs"
        End If
        If string1 = "xmr-stak-amd" Then
            status.Text = status.Text & vbNewLine & ">>xmr-stak-amd miner detected" & vbNewLine & "   ERROR HELP 1: If receiving a 'MEMORY ALLOC FAILED: VirtualAlloc failed' error, disable all auto-starting applications and run the miner after a reboot. You do not have enough free ram."
            status.Text = status.Text & vbNewLine & "   ERROR HELP 2: If receiving msvcp140.dll and vcruntime140.dll not available errors, download and install the following runtime package: https://www.microsoft.com/en-us/download/details.aspx?id=17657"
            status.Text = status.Text & vbNewLine & "   ERROR HELP 3:If it still doesn't work, reduce the number of GPUs xmr-stak-amd does not support more than 16 GPUs"
        End If
        If string1 = "ccminer" Then
            status.Text = status.Text & vbNewLine & ">>ccminer detected" & vbNewLine & "   ERROR HELP 1: Your GPU is probably not supported (some GTX x80 Series and 10xx series not supported. Switch to xmr-stak-nvidia"
        End If
        If string1 = "cpuminer-multi" Then
            status.Text = status.Text & vbNewLine & ">>cpuminer-multi detected" & vbNewLine & "   ERROR HELP 1: Your CPU is probably not supported (This build it built for Intel Core-I series, Switch to xmr-stak-cpu"
            status.Text = status.Text & vbNewLine & "   ERROR HELP 2: Perhaps you have too many threads"
            status.Text = status.Text & vbNewLine & ">>Thread count halved"
            threads.Text = threads.Text / 2
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles check.Click
        If pool.SelectedItem = pool.Items(9) Then
            status.Text = status.Text & vbNewLine & "   INFO: Cannot check ETN of custom pool directly from miner, go to their website."
        Else
            Dim webAddress As String = pool_url
            Process.Start(webAddress)
        End If
    End Sub
End Class
