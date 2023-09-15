<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmdButton1 = New System.Windows.Forms.Button()
        Me.cmdButton2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBranchName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(162, 139)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(175, 24)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "mac"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(162, 168)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(175, 24)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "1234567"
        '
        'cmdButton1
        '
        Me.cmdButton1.Location = New System.Drawing.Point(181, 234)
        Me.cmdButton1.Name = "cmdButton1"
        Me.cmdButton1.Size = New System.Drawing.Size(75, 30)
        Me.cmdButton1.TabIndex = 4
        Me.cmdButton1.Text = "&OK"
        Me.cmdButton1.UseVisualStyleBackColor = True
        '
        'cmdButton2
        '
        Me.cmdButton2.Location = New System.Drawing.Point(262, 234)
        Me.cmdButton2.Name = "cmdButton2"
        Me.cmdButton2.Size = New System.Drawing.Size(75, 30)
        Me.cmdButton2.TabIndex = 5
        Me.cmdButton2.Text = "C&ANCEL"
        Me.cmdButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(91, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBranchName
        '
        Me.lblBranchName.AutoSize = True
        Me.lblBranchName.BackColor = System.Drawing.Color.Transparent
        Me.lblBranchName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranchName.ForeColor = System.Drawing.Color.White
        Me.lblBranchName.Location = New System.Drawing.Point(158, 50)
        Me.lblBranchName.Name = "lblBranchName"
        Me.lblBranchName.Size = New System.Drawing.Size(186, 19)
        Me.lblBranchName.TabIndex = 6
        Me.lblBranchName.Text = "Guanzon Central Office"
        Me.lblBranchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(183, 69)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(136, 14)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "Guanzon Bldg. Perez Blvd."
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.BackColor = System.Drawing.Color.Transparent
        Me.lblProvince.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvince.ForeColor = System.Drawing.Color.White
        Me.lblProvince.Location = New System.Drawing.Point(172, 83)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(159, 14)
        Me.lblProvince.TabIndex = 8
        Me.lblProvince.Text = "Dagupan City, Pangasinan 2400"
        Me.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtServer
        '
        Me.txtServer.Enabled = False
        Me.txtServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.Location = New System.Drawing.Point(162, 197)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(175, 24)
        Me.txtServer.TabIndex = 10
        Me.txtServer.Text = "192.168.10.240"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(93, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Server"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ggcAppDriver.My.Resources.Resources.Guanzon_Login2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(501, 399)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.lblProvince)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblBranchName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdButton2)
        Me.Controls.Add(Me.cmdButton1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guanzon Group of Companies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdButton1 As System.Windows.Forms.Button
    Friend WithEvents cmdButton2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBranchName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
