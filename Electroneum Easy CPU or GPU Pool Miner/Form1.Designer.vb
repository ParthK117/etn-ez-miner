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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.wallet_address = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pool = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mining = New System.Windows.Forms.Button()
        Me.lbl_threads = New System.Windows.Forms.Label()
        Me.threads = New System.Windows.Forms.TextBox()
        Me.custom_pool = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.TextBox()
        Me.cpuorgpu = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_gpubrand = New System.Windows.Forms.Label()
        Me.gpubrand = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.RichTextBox()
        Me.check = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.Tab_controller = New System.Windows.Forms.TabControl()
        Me.tab_miner = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.new_miner = New System.Windows.Forms.Button()
        Me.donate = New System.Windows.Forms.Button()
        Me.tab_as = New System.Windows.Forms.TabPage()
        Me.hyperthread = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xmr_notice = New System.Windows.Forms.Label()
        Me.xmr_stak_perf_box = New System.Windows.Forms.ComboBox()
        Me.stak_nvidia_perf = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.miner_type = New System.Windows.Forms.ComboBox()
        Me.open_miners = New System.Windows.Forms.ListBox()
        Me.load_config = New System.Windows.Forms.Button()
        Me.save_config = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.title_lbl = New System.Windows.Forms.Label()
        Me.save_config_dialog = New System.Windows.Forms.SaveFileDialog()
        Me.open_config_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.update_lbl = New System.Windows.Forms.Label()
        Me.Tab_controller.SuspendLayout()
        Me.tab_miner.SuspendLayout()
        Me.tab_as.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wallet_address
        '
        Me.wallet_address.Location = New System.Drawing.Point(6, 26)
        Me.wallet_address.Name = "wallet_address"
        Me.wallet_address.Size = New System.Drawing.Size(769, 22)
        Me.wallet_address.TabIndex = 0
        Me.wallet_address.Text = "etn_your_wallet_address_here_f7b4873fb68b34b8f3bf68awft85n5b46nbeywpbov0m00hfgf64" &
    "3hb1v1me"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(593, 50)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(183, 31)
        Me.clear.TabIndex = 1
        Me.clear.Text = "Clear Wallet Address field"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Electroneum Wallet Address:"
        '
        'pool
        '
        Me.pool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pool.FormattingEnabled = True
        Me.pool.Items.AddRange(New Object() {"uspool.electroneum.com (Official pool)", "eupool.electroneum.com (Official pool)", "asiapool.electroneum.com (Official pool)", "us-etn-pool.hashparty.io (Community pool)", "pool.electroneum.space (Community pool)", "myetn.uk (Community pool)", "etnhash.com (Reddit pool)", "www.etnpools.com (Community pool)", "etnpool.minekitten.io (Community pool)", "custom"})
        Me.pool.Location = New System.Drawing.Point(48, 87)
        Me.pool.Name = "pool"
        Me.pool.Size = New System.Drawing.Size(727, 24)
        Me.pool.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pool:"
        '
        'mining
        '
        Me.mining.ForeColor = System.Drawing.Color.DodgerBlue
        Me.mining.Location = New System.Drawing.Point(6, 207)
        Me.mining.Name = "mining"
        Me.mining.Size = New System.Drawing.Size(770, 48)
        Me.mining.TabIndex = 6
        Me.mining.Text = "Start Mining"
        Me.mining.UseVisualStyleBackColor = True
        '
        'lbl_threads
        '
        Me.lbl_threads.AutoSize = True
        Me.lbl_threads.Location = New System.Drawing.Point(6, 166)
        Me.lbl_threads.Name = "lbl_threads"
        Me.lbl_threads.Size = New System.Drawing.Size(99, 17)
        Me.lbl_threads.TabIndex = 7
        Me.lbl_threads.Text = "Thread Count:"
        '
        'threads
        '
        Me.threads.Location = New System.Drawing.Point(105, 163)
        Me.threads.Name = "threads"
        Me.threads.Size = New System.Drawing.Size(24, 22)
        Me.threads.TabIndex = 8
        Me.threads.Text = "4"
        '
        'custom_pool
        '
        Me.custom_pool.Enabled = False
        Me.custom_pool.Location = New System.Drawing.Point(202, 125)
        Me.custom_pool.Name = "custom_pool"
        Me.custom_pool.Size = New System.Drawing.Size(573, 22)
        Me.custom_pool.TabIndex = 9
        Me.custom_pool.Text = "Select custom in pool list to use your own"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Custom Pool:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(151, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Port:"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(195, 163)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(52, 22)
        Me.port.TabIndex = 12
        Me.port.Text = "3333"
        '
        'cpuorgpu
        '
        Me.cpuorgpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cpuorgpu.FormattingEnabled = True
        Me.cpuorgpu.Items.AddRange(New Object() {"CPU", "GPU"})
        Me.cpuorgpu.Location = New System.Drawing.Point(6, 54)
        Me.cpuorgpu.Name = "cpuorgpu"
        Me.cpuorgpu.Size = New System.Drawing.Size(138, 24)
        Me.cpuorgpu.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(102, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "stratum+tcp://"
        '
        'lbl_gpubrand
        '
        Me.lbl_gpubrand.AutoSize = True
        Me.lbl_gpubrand.Location = New System.Drawing.Point(151, 57)
        Me.lbl_gpubrand.Name = "lbl_gpubrand"
        Me.lbl_gpubrand.Size = New System.Drawing.Size(84, 17)
        Me.lbl_gpubrand.TabIndex = 20
        Me.lbl_gpubrand.Text = "GPU Brand:"
        '
        'gpubrand
        '
        Me.gpubrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gpubrand.FormattingEnabled = True
        Me.gpubrand.Items.AddRange(New Object() {"Nvidia", "AMD"})
        Me.gpubrand.Location = New System.Drawing.Point(241, 54)
        Me.gpubrand.Name = "gpubrand"
        Me.gpubrand.Size = New System.Drawing.Size(138, 24)
        Me.gpubrand.TabIndex = 21
        '
        'status
        '
        Me.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.status.Location = New System.Drawing.Point(6, 261)
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Size = New System.Drawing.Size(769, 256)
        Me.status.TabIndex = 0
        Me.status.Text = resources.GetString("status.Text")
        '
        'check
        '
        Me.check.Location = New System.Drawing.Point(481, 153)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(162, 48)
        Me.check.TabIndex = 26
        Me.check.Text = "Check earned ETN"
        Me.check.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.help.Location = New System.Drawing.Point(314, 153)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(161, 48)
        Me.help.TabIndex = 27
        Me.help.Text = "Help/Autotune"
        Me.help.UseVisualStyleBackColor = True
        '
        'Tab_controller
        '
        Me.Tab_controller.Controls.Add(Me.tab_miner)
        Me.Tab_controller.Controls.Add(Me.tab_as)
        Me.Tab_controller.Location = New System.Drawing.Point(0, 60)
        Me.Tab_controller.Name = "Tab_controller"
        Me.Tab_controller.SelectedIndex = 0
        Me.Tab_controller.Size = New System.Drawing.Size(790, 551)
        Me.Tab_controller.TabIndex = 28
        '
        'tab_miner
        '
        Me.tab_miner.Controls.Add(Me.Label11)
        Me.tab_miner.Controls.Add(Me.new_miner)
        Me.tab_miner.Controls.Add(Me.donate)
        Me.tab_miner.Controls.Add(Me.Label1)
        Me.tab_miner.Controls.Add(Me.help)
        Me.tab_miner.Controls.Add(Me.wallet_address)
        Me.tab_miner.Controls.Add(Me.check)
        Me.tab_miner.Controls.Add(Me.clear)
        Me.tab_miner.Controls.Add(Me.status)
        Me.tab_miner.Controls.Add(Me.pool)
        Me.tab_miner.Controls.Add(Me.Label2)
        Me.tab_miner.Controls.Add(Me.gpubrand)
        Me.tab_miner.Controls.Add(Me.mining)
        Me.tab_miner.Controls.Add(Me.lbl_gpubrand)
        Me.tab_miner.Controls.Add(Me.lbl_threads)
        Me.tab_miner.Controls.Add(Me.threads)
        Me.tab_miner.Controls.Add(Me.custom_pool)
        Me.tab_miner.Controls.Add(Me.Label9)
        Me.tab_miner.Controls.Add(Me.Label5)
        Me.tab_miner.Controls.Add(Me.Label6)
        Me.tab_miner.Controls.Add(Me.cpuorgpu)
        Me.tab_miner.Controls.Add(Me.port)
        Me.tab_miner.Location = New System.Drawing.Point(4, 25)
        Me.tab_miner.Name = "tab_miner"
        Me.tab_miner.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_miner.Size = New System.Drawing.Size(782, 522)
        Me.tab_miner.TabIndex = 0
        Me.tab_miner.Text = "Miner"
        Me.tab_miner.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(195, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(275, 17)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Make sure to use your own wallet address!"
        '
        'new_miner
        '
        Me.new_miner.ForeColor = System.Drawing.Color.Red
        Me.new_miner.Location = New System.Drawing.Point(545, 207)
        Me.new_miner.Name = "new_miner"
        Me.new_miner.Size = New System.Drawing.Size(230, 48)
        Me.new_miner.TabIndex = 32
        Me.new_miner.Text = "Stop Mining"
        Me.new_miner.UseVisualStyleBackColor = True
        Me.new_miner.Visible = False
        '
        'donate
        '
        Me.donate.BackColor = System.Drawing.Color.Transparent
        Me.donate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donate.ForeColor = System.Drawing.Color.LimeGreen
        Me.donate.Location = New System.Drawing.Point(649, 153)
        Me.donate.Name = "donate"
        Me.donate.Size = New System.Drawing.Size(126, 48)
        Me.donate.TabIndex = 31
        Me.donate.Text = "Donate"
        Me.donate.UseVisualStyleBackColor = False
        '
        'tab_as
        '
        Me.tab_as.Controls.Add(Me.update_lbl)
        Me.tab_as.Controls.Add(Me.hyperthread)
        Me.tab_as.Controls.Add(Me.Label3)
        Me.tab_as.Controls.Add(Me.Label8)
        Me.tab_as.Controls.Add(Me.Label10)
        Me.tab_as.Controls.Add(Me.xmr_notice)
        Me.tab_as.Controls.Add(Me.xmr_stak_perf_box)
        Me.tab_as.Controls.Add(Me.stak_nvidia_perf)
        Me.tab_as.Controls.Add(Me.Label4)
        Me.tab_as.Controls.Add(Me.miner_type)
        Me.tab_as.Controls.Add(Me.open_miners)
        Me.tab_as.Controls.Add(Me.load_config)
        Me.tab_as.Controls.Add(Me.save_config)
        Me.tab_as.Location = New System.Drawing.Point(4, 25)
        Me.tab_as.Name = "tab_as"
        Me.tab_as.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_as.Size = New System.Drawing.Size(782, 522)
        Me.tab_as.TabIndex = 1
        Me.tab_as.Text = "Advanced Settings"
        Me.tab_as.UseVisualStyleBackColor = True
        '
        'hyperthread
        '
        Me.hyperthread.AutoSize = True
        Me.hyperthread.Location = New System.Drawing.Point(11, 141)
        Me.hyperthread.Name = "hyperthread"
        Me.hyperthread.Size = New System.Drawing.Size(157, 21)
        Me.hyperthread.TabIndex = 43
        Me.hyperthread.Text = "Hyperthreaded CPU"
        Me.hyperthread.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(685, 18)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Save and Load Configuration: __________________________________________________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(690, 18)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Multiple Miners: ______________________________________________________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(686, 18)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Mining Configuration: _________________________________________________________"
        '
        'xmr_notice
        '
        Me.xmr_notice.AutoSize = True
        Me.xmr_notice.Location = New System.Drawing.Point(8, 213)
        Me.xmr_notice.Name = "xmr_notice"
        Me.xmr_notice.Size = New System.Drawing.Size(562, 17)
        Me.xmr_notice.TabIndex = 39
        Me.xmr_notice.Text = "Note: If you try and use high performance mode and it crashes, switch back to sta" &
    "ndard."
        '
        'xmr_stak_perf_box
        '
        Me.xmr_stak_perf_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xmr_stak_perf_box.FormattingEnabled = True
        Me.xmr_stak_perf_box.Items.AddRange(New Object() {"Standard", "High"})
        Me.xmr_stak_perf_box.Location = New System.Drawing.Point(195, 184)
        Me.xmr_stak_perf_box.Name = "xmr_stak_perf_box"
        Me.xmr_stak_perf_box.Size = New System.Drawing.Size(138, 24)
        Me.xmr_stak_perf_box.TabIndex = 38
        Me.xmr_stak_perf_box.Visible = False
        '
        'stak_nvidia_perf
        '
        Me.stak_nvidia_perf.AutoSize = True
        Me.stak_nvidia_perf.Location = New System.Drawing.Point(8, 186)
        Me.stak_nvidia_perf.Name = "stak_nvidia_perf"
        Me.stak_nvidia_perf.Size = New System.Drawing.Size(179, 17)
        Me.stak_nvidia_perf.TabIndex = 37
        Me.stak_nvidia_perf.Text = "xmr-stak-nvidia perf. mode:"
        Me.stak_nvidia_perf.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(363, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Miner backend (Change only if the default doesn't work):"
        '
        'miner_type
        '
        Me.miner_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.miner_type.FormattingEnabled = True
        Me.miner_type.Location = New System.Drawing.Point(377, 161)
        Me.miner_type.Name = "miner_type"
        Me.miner_type.Size = New System.Drawing.Size(138, 24)
        Me.miner_type.TabIndex = 35
        '
        'open_miners
        '
        Me.open_miners.FormattingEnabled = True
        Me.open_miners.ItemHeight = 16
        Me.open_miners.Items.AddRange(New Object() {"Miner No. |Address:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|Backend:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|Pool:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.open_miners.Location = New System.Drawing.Point(6, 261)
        Me.open_miners.Name = "open_miners"
        Me.open_miners.Size = New System.Drawing.Size(771, 260)
        Me.open_miners.TabIndex = 33
        '
        'load_config
        '
        Me.load_config.Location = New System.Drawing.Point(9, 72)
        Me.load_config.Name = "load_config"
        Me.load_config.Size = New System.Drawing.Size(179, 41)
        Me.load_config.TabIndex = 32
        Me.load_config.Text = "Load Configuration"
        Me.load_config.UseVisualStyleBackColor = True
        '
        'save_config
        '
        Me.save_config.Location = New System.Drawing.Point(9, 25)
        Me.save_config.Name = "save_config"
        Me.save_config.Size = New System.Drawing.Size(179, 41)
        Me.save_config.TabIndex = 31
        Me.save_config.Text = "Save Configuration"
        Me.save_config.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(127, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Label7"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.title_lbl)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 60)
        Me.Panel1.TabIndex = 29
        '
        'title_lbl
        '
        Me.title_lbl.AutoSize = True
        Me.title_lbl.BackColor = System.Drawing.Color.Transparent
        Me.title_lbl.Font = New System.Drawing.Font("Segoe UI Light", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_lbl.ForeColor = System.Drawing.Color.White
        Me.title_lbl.Location = New System.Drawing.Point(104, 6)
        Me.title_lbl.Name = "title_lbl"
        Me.title_lbl.Size = New System.Drawing.Size(608, 51)
        Me.title_lbl.TabIndex = 0
        Me.title_lbl.Text = "Electroneum Ez CPU GPU Pool Miner"
        '
        'open_config_dialog
        '
        Me.open_config_dialog.FileName = "File name"
        '
        'update_lbl
        '
        Me.update_lbl.AutoSize = True
        Me.update_lbl.Location = New System.Drawing.Point(194, 25)
        Me.update_lbl.Name = "update_lbl"
        Me.update_lbl.Size = New System.Drawing.Size(127, 17)
        Me.update_lbl.TabIndex = 44
        Me.update_lbl.Text = "UPDATE_STATUS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 615)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tab_controller)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Electroneum Ez CPU GPU Pool Miner - https://parthk.co.uk"
        Me.Tab_controller.ResumeLayout(False)
        Me.tab_miner.ResumeLayout(False)
        Me.tab_miner.PerformLayout()
        Me.tab_as.ResumeLayout(False)
        Me.tab_as.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wallet_address As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pool As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mining As Button
    Friend WithEvents lbl_threads As Label
    Friend WithEvents threads As TextBox
    Friend WithEvents custom_pool As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents port As TextBox
    Friend WithEvents cpuorgpu As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_gpubrand As Label
    Friend WithEvents gpubrand As ComboBox
    Friend WithEvents status As RichTextBox
    Friend WithEvents check As Button
    Friend WithEvents help As Button
    Friend WithEvents Tab_controller As TabControl
    Friend WithEvents tab_miner As TabPage
    Friend WithEvents tab_as As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents title_lbl As Label
    Friend WithEvents donate As Button
    Friend WithEvents open_miners As ListBox
    Friend WithEvents load_config As Button
    Friend WithEvents save_config As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents miner_type As ComboBox
    Friend WithEvents stak_nvidia_perf As Label
    Friend WithEvents xmr_stak_perf_box As ComboBox
    Friend WithEvents xmr_notice As Label
    Friend WithEvents save_config_dialog As SaveFileDialog
    Friend WithEvents open_config_dialog As OpenFileDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents hyperthread As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents new_miner As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents update_lbl As Label
End Class
