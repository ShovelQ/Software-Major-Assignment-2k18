﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToolBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolBar))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Bar = New System.Windows.Forms.Panel()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnDesigns = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(-99, 0)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(90, 90)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 41
        Me.Logo.TabStop = False
        '
        'Bar
        '
        Me.Bar.BackColor = System.Drawing.Color.Fuchsia
        Me.Bar.Controls.Add(Me.btnNewOrder)
        Me.Bar.Controls.Add(Me.btnHelp)
        Me.Bar.Controls.Add(Me.btnOrders)
        Me.Bar.Controls.Add(Me.btnDesigns)
        Me.Bar.Controls.Add(Me.btnBack)
        Me.Bar.Controls.Add(Me.Username)
        Me.Bar.Controls.Add(Me.btnLogOut)
        Me.Bar.Controls.Add(Me.PictureBox1)
        Me.Bar.Controls.Add(Me.btnQuit)
        Me.Bar.Controls.Add(Me.btnAbout)
        Me.Bar.Controls.Add(Me.btnHome)
        Me.Bar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bar.Location = New System.Drawing.Point(0, 0)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(1231, 108)
        Me.Bar.TabIndex = 42
        '
        'btnNewOrder
        '
        Me.btnNewOrder.BackColor = System.Drawing.Color.White
        Me.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewOrder.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnNewOrder.Location = New System.Drawing.Point(202, 5)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(97, 97)
        Me.btnNewOrder.TabIndex = 40
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.White
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnHelp.Location = New System.Drawing.Point(669, 5)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(80, 95)
        Me.btnHelp.TabIndex = 39
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnOrders
        '
        Me.btnOrders.BackColor = System.Drawing.Color.White
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnOrders.Location = New System.Drawing.Point(408, 5)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(97, 97)
        Me.btnOrders.TabIndex = 38
        Me.btnOrders.Text = "My Orders"
        Me.btnOrders.UseVisualStyleBackColor = False
        '
        'btnDesigns
        '
        Me.btnDesigns.BackColor = System.Drawing.Color.White
        Me.btnDesigns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesigns.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnDesigns.Location = New System.Drawing.Point(305, 5)
        Me.btnDesigns.Name = "btnDesigns"
        Me.btnDesigns.Size = New System.Drawing.Size(97, 97)
        Me.btnDesigns.TabIndex = 37
        Me.btnDesigns.Text = "My Trophy Designs"
        Me.btnDesigns.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnBack.Location = New System.Drawing.Point(755, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 95)
        Me.btnBack.TabIndex = 35
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.White
        Me.Username.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Username.Location = New System.Drawing.Point(1106, 5)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(96, 76)
        Me.Username.TabIndex = 36
        Me.Username.Text = "Hello " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Username!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Welcome to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LAMP"
        Me.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnLogOut.Location = New System.Drawing.Point(841, 5)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 96)
        Me.btnLogOut.TabIndex = 34
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.White
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnQuit.Location = New System.Drawing.Point(1003, 4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(97, 97)
        Me.btnQuit.TabIndex = 31
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.White
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnAbout.Location = New System.Drawing.Point(922, 5)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 96)
        Me.btnAbout.TabIndex = 32
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.White
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.btnHome.Location = New System.Drawing.Point(99, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(97, 97)
        Me.btnHome.TabIndex = 33
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'ToolBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.Logo)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ToolBar"
        Me.Size = New System.Drawing.Size(1231, 108)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar.ResumeLayout(False)
        Me.Bar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Bar As Panel
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnDesigns As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Username As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnHome As Button
End Class
