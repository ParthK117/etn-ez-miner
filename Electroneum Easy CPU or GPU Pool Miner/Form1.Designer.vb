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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mining = New System.Windows.Forms.Button()
        Me.lbl_threads = New System.Windows.Forms.Label()
        Me.threads = New System.Windows.Forms.TextBox()
        Me.custom_pool = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.TextBox()
        Me.cpuorgpu = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_gpubrand = New System.Windows.Forms.Label()
        Me.gpubrand = New System.Windows.Forms.ComboBox()
        Me.miner_type = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.RichTextBox()
        Me.check = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'wallet_address
        '
        Me.wallet_address.Location = New System.Drawing.Point(12, 32)
        Me.wallet_address.Name = "wallet_address"
        Me.wallet_address.Size = New System.Drawing.Size(769, 22)
        Me.wallet_address.TabIndex = 0
        Me.wallet_address.Text = "etnkAjckxKuQ2ov3QVmJRWJserxDuFpQJNKud22TN79PhJFtmd7FtDLLGpyErzEWM47W7JVsbXeVfTgmu" &
    "UPsUAaX81rdJrMtJw"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(656, 61)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(125, 31)
        Me.clear.TabIndex = 1
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Electroneum Wallet Address:"
        '
        'pool
        '
        Me.pool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pool.FormattingEnabled = True
        Me.pool.Items.AddRange(New Object() {"uspool.electroneum.com (Official pool)", "eupool.electroneum.com (Official pool)", "asiapool.electroneum.com (Official pool)", "electroneum.hashparty.io (Community pool)", "pool.electroneum.space (Community pool)", "myetn.uk (Community pool)", "etnhash.com (Reddit pool)", "www.etnpools.com (Community pool)", "etnpool.minekitten.io (Community pool)", "custom"})
        Me.pool.Location = New System.Drawing.Point(58, 107)
        Me.pool.Name = "pool"
        Me.pool.Size = New System.Drawing.Size(581, 24)
        Me.pool.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pool:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(766, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Advanced Settings: ______________________________________________________________" &
    "_________________"
        '
        'mining
        '
        Me.mining.Location = New System.Drawing.Point(15, 192)
        Me.mining.Name = "mining"
        Me.mining.Size = New System.Drawing.Size(766, 52)
        Me.mining.TabIndex = 6
        Me.mining.Text = "Start Mining"
        Me.mining.UseVisualStyleBackColor = True
        '
        'lbl_threads
        '
        Me.lbl_threads.AutoSize = True
        Me.lbl_threads.Location = New System.Drawing.Point(12, 302)
        Me.lbl_threads.Name = "lbl_threads"
        Me.lbl_threads.Size = New System.Drawing.Size(99, 17)
        Me.lbl_threads.TabIndex = 7
        Me.lbl_threads.Text = "Thread Count:"
        '
        'threads
        '
        Me.threads.Location = New System.Drawing.Point(118, 299)
        Me.threads.Name = "threads"
        Me.threads.Size = New System.Drawing.Size(24, 22)
        Me.threads.TabIndex = 8
        Me.threads.Text = "4"
        '
        'custom_pool
        '
        Me.custom_pool.Enabled = False
        Me.custom_pool.Location = New System.Drawing.Point(208, 332)
        Me.custom_pool.Name = "custom_pool"
        Me.custom_pool.Size = New System.Drawing.Size(573, 22)
        Me.custom_pool.TabIndex = 9
        Me.custom_pool.Text = "Select custom in pool list to use your own"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Custom Pool:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Port:"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(56, 369)
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
        Me.cpuorgpu.Location = New System.Drawing.Point(12, 61)
        Me.cpuorgpu.Name = "cpuorgpu"
        Me.cpuorgpu.Size = New System.Drawing.Size(138, 24)
        Me.cpuorgpu.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label8.Location = New System.Drawing.Point(7, 456)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Frontend by https://parthk.co.uk"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(108, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "stratum+tcp://"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(9, 438)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(439, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Remember to check for updates and to use your own wallet address!"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "News:"
        '
        'lbl_gpubrand
        '
        Me.lbl_gpubrand.AutoSize = True
        Me.lbl_gpubrand.Location = New System.Drawing.Point(195, 64)
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
        Me.gpubrand.Location = New System.Drawing.Point(285, 61)
        Me.gpubrand.Name = "gpubrand"
        Me.gpubrand.Size = New System.Drawing.Size(138, 24)
        Me.gpubrand.TabIndex = 21
        '
        'miner_type
        '
        Me.miner_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.miner_type.FormattingEnabled = True
        Me.miner_type.Location = New System.Drawing.Point(564, 297)
        Me.miner_type.Name = "miner_type"
        Me.miner_type.Size = New System.Drawing.Size(138, 24)
        Me.miner_type.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(363, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Miner backend (Change only if the default doesn't work):"
        '
        'status
        '
        Me.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.status.Location = New System.Drawing.Point(12, 479)
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Size = New System.Drawing.Size(769, 237)
        Me.status.TabIndex = 0
        Me.status.Text = resources.GetString("status.Text")
        '
        'check
        '
        Me.check.Location = New System.Drawing.Point(602, 155)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(179, 31)
        Me.check.TabIndex = 26
        Me.check.Text = "Check earned ETN"
        Me.check.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.help.Location = New System.Drawing.Point(15, 155)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(179, 31)
        Me.help.TabIndex = 27
        Me.help.Text = "Help/Autotune"
        Me.help.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(791, 728)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.miner_type)
        Me.Controls.Add(Me.gpubrand)
        Me.Controls.Add(Me.lbl_gpubrand)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cpuorgpu)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.custom_pool)
        Me.Controls.Add(Me.threads)
        Me.Controls.Add(Me.lbl_threads)
        Me.Controls.Add(Me.mining)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pool)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.wallet_address)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Electroneum Easy CPU or GPU Pool Miner (v0.1.0)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wallet_address As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pool As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mining As Button
    Friend WithEvents lbl_threads As Label
    Friend WithEvents threads As TextBox
    Friend WithEvents custom_pool As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents port As TextBox
    Friend WithEvents cpuorgpu As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_gpubrand As Label
    Friend WithEvents gpubrand As ComboBox
    Friend WithEvents miner_type As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents status As RichTextBox
    Friend WithEvents check As Button
    Friend WithEvents help As Button
End Class
