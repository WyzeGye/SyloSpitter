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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ServerIP = New System.Windows.Forms.TextBox()
        Me.RPCID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RPCPW = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ServerIP
        '
        Me.ServerIP.Location = New System.Drawing.Point(167, 58)
        Me.ServerIP.MaxLength = 16
        Me.ServerIP.Multiline = True
        Me.ServerIP.Name = "ServerIP"
        Me.ServerIP.Size = New System.Drawing.Size(281, 20)
        Me.ServerIP.TabIndex = 1
        '
        'RPCID
        '
        Me.RPCID.Location = New System.Drawing.Point(167, 84)
        Me.RPCID.Name = "RPCID"
        Me.RPCID.Size = New System.Drawing.Size(281, 20)
        Me.RPCID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Where to keep Sylo Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Server IP Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RPC Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "RPC Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Choose a Directory"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(167, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Done"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Please enter the relevant information and press Done"
        '
        'RPCPW
        '
        Me.RPCPW.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.RPCPW.Location = New System.Drawing.Point(167, 111)
        Me.RPCPW.MaxLength = 32
        Me.RPCPW.Name = "RPCPW"
        Me.RPCPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RPCPW.Size = New System.Drawing.Size(281, 20)
        Me.RPCPW.TabIndex = 15
        Me.RPCPW.UseSystemPasswordChar = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "yml"
        Me.SaveFileDialog1.FileName = "docker-compose"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(176, 211)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(77, 13)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Need Docker?"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(176, 198)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "WhatIsMyIP?"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(176, 185)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(38, 13)
        Me.LinkLabel3.TabIndex = 17
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Sylo.io"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 142)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(176, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 26)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "This tool is provided without warranty, and has" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " no affiliation with Sylo, Docke" &
    "r, or WhatIsMyIP"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(176, 224)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel4.TabIndex = 20
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "View this tool on GitHub"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(472, 286)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RPCPW)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RPCID)
        Me.Controls.Add(Me.ServerIP)
        Me.Name = "Form1"
        Me.Text = "Sylo Spitter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ServerIP As TextBox
    Friend WithEvents RPCID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents RPCPW As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
End Class
