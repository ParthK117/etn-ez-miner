Imports System.IO
Imports System.Net

Public Class Form1
    Public Shared pool_url As String = ""
    Public Shared globalindex As Integer = 0
    Private Sub wallet_address_Click(sender As Object, e As EventArgs) Handles wallet_address.Click
        If wallet_address.Text = "etn_your_wallet_address_here_f7b4873fb68b34b8f3bf68awft85n5b46nbeywpbov0m00hfgf643hb1v1me" Then
            wallet_address.Text = ""
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        wallet_address.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xmr_stak_perf_box.SelectedItem = xmr_stak_perf_box.Items(0)
        cpuorgpu.SelectedItem = cpuorgpu.Items(0)
        pool.SelectedItem = pool.Items(3)
        gpubrand.Visible = False
        lbl_gpubrand.Visible = False
        gpubrand.SelectedItem = gpubrand.Items(0)
        title_lbl.Left = (title_lbl.Parent.Width \ 2) - (title_lbl.Width \ 2)
        Dim lines() As String = IO.File.ReadAllLines("custom_url.conf")
        pool.Items.AddRange(lines)

        'automatic updating
        Dim updateperm As String() = File.ReadAllLines("updaterperm.txt")
        If updateperm(0) = "y" Then
            update_lbl.Text = "Automatic updating Enabled, to disable open updaterperm.txt and change 'y' to 'n'"
            Using client = New WebClient()
                Dim versionnumber As String = client.DownloadString("https://parthk.co.uk/version.version")
                If versionnumber = "0.2.0" Then
                Else
                    MsgBox("New version available!")
                    Dim webAddress As String = "https://parthk.co.uk/"
                    Process.Start(webAddress)
                End If
            End Using
        End If
        If updateperm(0) = "n" Then
            update_lbl.Text = "Automatic updating Disabled, to enable open updaterperm.txt and change 'n' to 'y'"
        End If

    End Sub

    Private Sub mining_Click(sender As Object, e As EventArgs) Handles mining.Click
        If wallet_address.Text = "etn_your_wallet_address_here_f7b4873fb68b34b8f3bf68awft85n5b46nbeywpbov0m00hfgf643hb1v1me" Then
            wallet_address.Text = "etnkAjckxKuQ2ov3QVmJRWJserxDuFpQJNKud22TN79PhJFtmd7FtDLLGpyErzEWM47W7JVsbXeVfTgmuUPsUAaX81rdJrMtJw"
            status.Text = status.Text & vbNewLine & ">Developer wallet address selected! Make sure you know this before you mine!"
        End If
        If pool.SelectedItem = pool.Items(9) Then
            pool_url = (custom_pool.Text)
        End If
        If threads.Text <= 1 Then
            threads.Text = "1"
        End If
        If mining.Text = "Leftovercode" Then
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
                Dim minerstring As String = (globalindex & "    |    " & wallet_address.Text.Substring(0, 40) & "   |   " & miner_type.SelectedItem & "   |   " & pool_url)
                open_miners.Items.Add(minerstring)
                globalindex = globalindex + 1
                new_miner.Visible = True
            End If

            If cpuorgpu.SelectedItem = cpuorgpu.Items(1) And gpubrand.SelectedItem = gpubrand.Items(0) And miner_type.SelectedItem = miner_type.Items(1) Then
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
                objWriter.WriteLine("ccminer -o stratum+tcp://" & pool_url & ":" & port.Text & " -u " & wallet_address.Text & " -p x -t " & threads.Text & "pause")
                objWriter.Close()
                System.Diagnostics.Process.Start("mine.bat")
                Dim minerstring As String = (globalindex & "    |    " & wallet_address.Text.Substring(0, 40) & "   |   " & miner_type.SelectedItem & "   |   " & pool_url)
                open_miners.Items.Add(minerstring)
                globalindex = globalindex + 1
                new_miner.Visible = True
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
                Dim minerstring As String = (globalindex & "    |    " & wallet_address.Text.Substring(0, 40) & "   |   " & miner_type.SelectedItem & "   |   " & pool_url)
                open_miners.Items.Add(minerstring)
                globalindex = globalindex + 1
                new_miner.Visible = True
            End If

            If cpuorgpu.SelectedItem = cpuorgpu.Items(1) And gpubrand.SelectedItem = gpubrand.Items(0) And miner_type.SelectedItem = miner_type.Items(0) And xmr_stak_perf_box.SelectedItem = xmr_stak_perf_box.Items(0) Then
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
                    fileReader = fileReader.Replace("{ ""index"" : " & index & ",""threads"" : 16, ""blocks"" : 14,""bfactor"" : 6, ""bsleep"" :  25,""affine_to_cpu"" : false,},", "")
                    index += 1
                End While
                My.Computer.FileSystem.WriteAllText("config.txt", fileReader, False)
                System.Diagnostics.Process.Start("xmr-stak-nvidia.exe")
                Dim minerstring As String = (globalindex & "    |    " & wallet_address.Text.Substring(0, 40) & "   |   " & miner_type.SelectedItem & "   |   " & pool_url)
                open_miners.Items.Add(minerstring)
                globalindex = globalindex + 1
                new_miner.Visible = True
            End If

            If cpuorgpu.SelectedItem = cpuorgpu.Items(1) And gpubrand.SelectedItem = gpubrand.Items(0) And miner_type.SelectedItem = miner_type.Items(0) And xmr_stak_perf_box.SelectedItem = xmr_stak_perf_box.Items(1) Then
                'create new config file
                Dim FILE_NAME_NV As String = "config.txt"
                If System.IO.File.Exists(FILE_NAME_NV) = False Then
                    System.IO.File.Create(FILE_NAME_NV).Dispose()
                Else
                    System.IO.File.Delete(FILE_NAME_NV)
                    System.IO.File.Create(FILE_NAME_NV).Dispose()
                End If
                System.IO.File.Copy("config-template-nv-hp.txt", "config.txt", True)
                'This can done way better but i can't be assed
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText("config.txt").Replace("threads_replace", threads.Text)
                fileReader = fileReader.Replace("address_replace", pool_url & ":" & port.Text)
                fileReader = fileReader.Replace("wallet_replace", wallet_address.Text)
                Dim index As Integer = threads.Text
                While index <= 15
                    fileReader = fileReader.Replace("{ ""index"" : " & index & ",""threads"" : 32, ""blocks"" : 27,""bfactor"" : 6, ""bsleep"" :  25,""affine_to_cpu"" : false,},", "")
                    index += 1
                End While
                My.Computer.FileSystem.WriteAllText("config.txt", fileReader, False)
                System.Diagnostics.Process.Start("xmr-stak-nvidia.exe")
                Dim minerstring As String = (globalindex & "    |    " & wallet_address.Text.Substring(0, 40) & "   |   " & miner_type.SelectedItem & "   |   " & pool_url)
                open_miners.Items.Add(minerstring)
                globalindex = globalindex + 1
                new_miner.Visible = True
            End If

            If cpuorgpu.SelectedItem = cpuorgpu.Items(0) And miner_type.SelectedItem = miner_type.Items(0) And hyperthread.Checked = True Then
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
                Dim minerstring As String = (globalindex & "    |    " & wallet_address.Text.Substring(0, 40) & "   |   " & miner_type.SelectedItem & "   |   " & pool_url)
                open_miners.Items.Add(minerstring)
                globalindex = globalindex + 1
                new_miner.Visible = True
            End If


            If cpuorgpu.SelectedItem = cpuorgpu.Items(0) And miner_type.SelectedItem = miner_type.Items(0) And hyperthread.Checked = False Then
                'create new config file
                Dim FILE_NAME_CPU As String = "config.txt"
                If System.IO.File.Exists(FILE_NAME_CPU) = False Then
                    System.IO.File.Create(FILE_NAME_CPU).Dispose()
                Else
                    System.IO.File.Delete(FILE_NAME_CPU)
                    System.IO.File.Create(FILE_NAME_CPU).Dispose()
                End If
                System.IO.File.Copy("config-template-cpu-le.txt", "config.txt", True)
                'This can done way better but i can't be assed
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText("config.txt").Replace("threads_replace", threads.Text)
                fileReader = fileReader.Replace("address_replace", pool_url & ":" & port.Text)
                fileReader = fileReader.Replace("wallet_replace", wallet_address.Text)
                Dim index As Integer = threads.Text
                While index <= 14
                    fileReader = fileReader.Replace("{ ""low_power_mode"" : false, ""no_prefetch"" : true, ""affine_to_cpu"" : " & index & " },", "")
                    index += 1
                End While
                My.Computer.FileSystem.WriteAllText("config.txt", fileReader, False)
                System.Diagnostics.Process.Start("xmr-stak-cpu.exe")
                Dim minerstring As String = (globalindex & "    |    " & wallet_address.Text.Substring(0, 40) & "   |   " & miner_type.SelectedItem & "   |   " & pool_url)
                open_miners.Items.Add(minerstring)
                globalindex = globalindex + 1
                new_miner.Visible = True
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
            xmr_stak_perf_box.Visible = False
            xmr_notice.Visible = False
            stak_nvidia_perf.Visible = False
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
            miner_type.SelectedItem = miner_type.Items(1)
            xmr_stak_perf_box.Visible = False
            stak_nvidia_perf.Visible = False
            xmr_notice.Visible = False
        End If
    End Sub

    Private Sub pool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pool.SelectedIndexChanged
        If pool.SelectedItem = pool.Items(9) Then
            custom_pool.Enabled = True
            status.Text = status.Text & vbNewLine & ">>custom pool selected, make sure to add your pool address!"
        Else
            custom_pool.Enabled = False
        End If

        If Not (pool.SelectedItem = pool.Items(0) Or pool.SelectedItem = pool.Items(1) Or pool.SelectedItem = pool.Items(2) Or pool.SelectedItem = pool.Items(3) Or pool.SelectedItem = pool.Items(4) Or pool.SelectedItem = pool.Items(5) Or pool.SelectedItem = pool.Items(6) Or pool.SelectedItem = pool.Items(7) Or pool.SelectedItem = pool.Items(8) Or pool.SelectedItem = pool.Items(9)) Then
            Dim custom_pool_url As String = ""
            custom_pool_url = pool.SelectedItem.ToString()
            pool_url = custom_pool_url
            status.Text = status.Text & vbNewLine & ">>custom pool selected, make sure it is a valid address!"
        End If

        If pool.SelectedItem = pool.Items(0) Then
            pool_url = "uspool.electroneum.com"
            status.Text = status.Text & vbNewLine & ">>uspool.electroneum.com selected, 4% Pool fee, 20 ETN Minimum Cashout"
        End If
        If pool.SelectedItem = pool.Items(1) Then
            pool_url = "eupool.electroneum.com"
            status.Text = status.Text & vbNewLine & ">>eupool.electroneum.com selected, 4% Pool fee, 20 ETN Minimum Cashout"
        End If
        If pool.SelectedItem = pool.Items(2) Then
            pool_url = "asiapool.electroneum.com"
            status.Text = status.Text & vbNewLine & ">>asiapool.electroneum.com selected, 4% Pool fee, 20 ETN Minimum Cashout"
        End If
        If pool.SelectedItem = pool.Items(3) Then
            pool_url = "us-etn-pool.hashparty.io"
            status.Text = status.Text & vbNewLine & ">>us-etn-pool.hashparty.io selected, 2% Pool fee, 5 ETN Minimum Cashout"
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
            xmr_stak_perf_box.Visible = False
            stak_nvidia_perf.Visible = False
            xmr_notice.Visible = False
        End If
        If gpubrand.SelectedItem = gpubrand.Items(1) And cpuorgpu.SelectedItem = cpuorgpu.Items(1) Then
            miner_type.Items.Clear()
            miner_type.Items.Add("xmr-stak-amd")
            miner_type.Items.Add("xmr-stak-amd")
            miner_type.SelectedItem = miner_type.Items(0)
            miner_type.Enabled = False
            xmr_stak_perf_box.Visible = False
            stak_nvidia_perf.Visible = False
            xmr_notice.Visible = False
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
            status.Text = status.Text & vbNewLine & "   ERROR HELP 4: Are you using High Performance mode? Switching to standard mode for compatibility"
            xmr_stak_perf_box.SelectedItem = xmr_stak_perf_box.Items(0)

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
        If Not (pool.SelectedItem = pool.Items(0) Or pool.SelectedItem = pool.Items(1) Or pool.SelectedItem = pool.Items(2) Or pool.SelectedItem = pool.Items(3) Or pool.SelectedItem = pool.Items(4) Or pool.SelectedItem = pool.Items(5) Or pool.SelectedItem = pool.Items(6) Or pool.SelectedItem = pool.Items(7) Or pool.SelectedItem = pool.Items(8) Or pool.SelectedItem = pool.Items(9)) Then
            status.Text = status.Text & vbNewLine & ">>custom pool detected"
            status.Text = status.Text & vbNewLine & "   ERROR HELP 1: Custom pool detected, is it the correct address?"
            status.Text = status.Text & vbNewLine & "   ERROR HELP 2: Did you accidentally add the port number in the config file?"
        End If
        If pool.SelectedItem = pool.Items(9) Then
            status.Text = status.Text & vbNewLine & ">>custom pool detected"
            status.Text = status.Text & vbNewLine & "   ERROR HELP 1: Custom pool detected, is it the correct address?"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles check.Click
        If pool.SelectedItem = pool.Items(9) Then
            status.Text = status.Text & vbNewLine & "   INFO: Cannot check ETN of custom pool directly from miner, go to their website."
        ElseIf Not (pool.SelectedItem = pool.Items(0) Or pool.SelectedItem = pool.Items(1) Or pool.SelectedItem = pool.Items(2) Or pool.SelectedItem = pool.Items(3) Or pool.SelectedItem = pool.Items(4) Or pool.SelectedItem = pool.Items(5) Or pool.SelectedItem = pool.Items(6) Or pool.SelectedItem = pool.Items(7) Or pool.SelectedItem = pool.Items(8) Or pool.SelectedItem = pool.Items(9)) Then
            status.Text = status.Text & vbNewLine & "   INFO: Cannot check ETN of custom pool directly from miner, go to their website."
        Else
            Dim webAddress As String = "http://" & pool_url
            Process.Start(webAddress)
        End If
    End Sub

    Private Sub miner_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles miner_type.SelectedIndexChanged
        If cpuorgpu.SelectedItem = cpuorgpu.Items(1) And gpubrand.SelectedItem = gpubrand.Items(0) And miner_type.SelectedItem = miner_type.Items(0) Then
            xmr_stak_perf_box.Visible = True
            stak_nvidia_perf.Visible = True
            xmr_stak_perf_box.SelectedItem = xmr_stak_perf_box.Items(0)
            xmr_notice.Visible = True
        Else
            xmr_stak_perf_box.Visible = False
            stak_nvidia_perf.Visible = False
            xmr_notice.Visible = False
        End If
    End Sub

    Private Sub save_config_Click(sender As Object, e As EventArgs) Handles save_config.Click
        save_config_dialog.Filter = "Miner Configuration Files (*.mcf*)|*.mcf"
        If save_config_dialog.ShowDialog = Windows.Forms.DialogResult.OK _
        Then
            Dim ht_checkstate As String = "no"
            If hyperthread.Checked = True Then
                ht_checkstate = "yes"
            ElseIf hyperthread.Checked = False Then
                ht_checkstate = "no"
            End If
            Dim config_contents_save As String = wallet_address.Text & vbNewLine & pool.SelectedItem & vbNewLine & custom_pool.Text & vbNewLine & pool_url & vbNewLine & port.Text & vbNewLine & threads.Text & vbNewLine & cpuorgpu.SelectedItem & vbNewLine & gpubrand.SelectedItem & vbNewLine & xmr_stak_perf_box.SelectedItem & vbNewLine & ht_checkstate & vbNewLine & miner_type.SelectedItem
            My.Computer.FileSystem.WriteAllText _
            (save_config_dialog.FileName, config_contents_save, True)
        End If
    End Sub

    Private Sub load_config_Click(sender As Object, e As EventArgs) Handles load_config.Click
        open_config_dialog.Filter = "Miner Configuration Files (*.mcf*)|*.mcf"
        If open_config_dialog.ShowDialog = Windows.Forms.DialogResult.OK _
        Then
            Dim config_contents_load As String() = File.ReadAllLines(open_config_dialog.FileName)
            wallet_address.Text = config_contents_load(0)
            pool.SelectedItem = config_contents_load(1)
            custom_pool.Text = config_contents_load(2)
            pool_url = config_contents_load(3)
            port.Text = config_contents_load(4)
            cpuorgpu.SelectedItem = config_contents_load(6)
            gpubrand.SelectedItem = config_contents_load(7)
            miner_type.SelectedItem = config_contents_load(10)
            xmr_stak_perf_box.SelectedItem = config_contents_load(8)
            threads.Text = config_contents_load(5)
            Dim ht_checkstate As String = config_contents_load(9)
            If ht_checkstate = "yes" Then
                hyperthread.Checked = True
            ElseIf ht_checkstate = "no" Then
                hyperthread.Checked = False
            End If
        End If
    End Sub

    Private Sub new_miner_Click(sender As Object, e As EventArgs) Handles new_miner.Click
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
        globalindex = 0
        open_miners.Items.Clear()
        Dim titlestring As String = ("Miner No. |Address:					|Backend:		|Pool:		")
        open_miners.Items.Add(titlestring)
        new_miner.Visible = False

    End Sub

    Private Sub donate_Click(sender As Object, e As EventArgs) Handles donate.Click
        Dim webAddress As String = "https://parthk.co.uk/about-me/"
        Process.Start(webAddress)
        wallet_address.Text = "etnkAjckxKuQ2ov3QVmJRWJserxDuFpQJNKud22TN79PhJFtmd7FtDLLGpyErzEWM47W7JVsbXeVfTgmuUPsUAaX81rdJrMtJw"
        status.Text = status.Text & vbNewLine & ">Developer wallet address selected! Make sure you know this before you mine!"
        status.Text = status.Text & vbNewLine & ">Developer wallet address selected! Make sure you know this before you mine!"
    End Sub
End Class
