<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radCustomer = New System.Windows.Forms.RadioButton()
        Me.radAdmin = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheWorldSaversIsACompanyThatWasFoundIn2023ItIsACompanyThatServesAsAServiceProviderForAnyOtherCompaniesTheWorldSaversAlsoProgrammApplicationsOrWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTACTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CELNO0456769802ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EAMILWorldgmailcomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUILDING12CarthcartRoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(495, 209)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(128, 24)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(495, 261)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(128, 24)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Visible = False
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(332, 350)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(113, 42)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(534, 350)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(103, 43)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(478, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "OR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WaterCrisis.My.Resources.Resources._5087607
        Me.PictureBox1.Location = New System.Drawing.Point(543, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCustomer)
        Me.GroupBox1.Controls.Add(Me.radAdmin)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(286, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 118)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select user"
        '
        'radCustomer
        '
        Me.radCustomer.AutoSize = True
        Me.radCustomer.Location = New System.Drawing.Point(26, 61)
        Me.radCustomer.Name = "radCustomer"
        Me.radCustomer.Size = New System.Drawing.Size(121, 22)
        Me.radCustomer.TabIndex = 1
        Me.radCustomer.TabStop = True
        Me.radCustomer.Text = "CUSTOMER"
        Me.radCustomer.UseVisualStyleBackColor = True
        '
        'radAdmin
        '
        Me.radAdmin.AutoSize = True
        Me.radAdmin.Location = New System.Drawing.Point(26, 20)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(160, 22)
        Me.radAdmin.TabIndex = 0
        Me.radAdmin.TabStop = True
        Me.radAdmin.Text = "ADMINISTRATOR"
        Me.radAdmin.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTUSToolStripMenuItem, Me.CONTACTSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ABOUTUSToolStripMenuItem
        '
        Me.ABOUTUSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TheWorldSaversIsACompanyThatWasFoundIn2023ItIsACompanyThatServesAsAServiceProviderForAnyOtherCompaniesTheWorldSaversAlsoProgrammApplicationsOrWebsiteToolStripMenuItem})
        Me.ABOUTUSToolStripMenuItem.Name = "ABOUTUSToolStripMenuItem"
        Me.ABOUTUSToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ABOUTUSToolStripMenuItem.Text = "ABOUT US"
        '
        'TheWorldSaversIsACompanyThatWasFoundIn2023ItIsACompanyThatServesAsAServiceProviderForAnyOtherCompaniesTheWorldSaversAlsoProgrammApplicationsOrWebsiteToolStripMenuItem
        '
        Me.TheWorldSaversIsACompanyThatWasFoundIn2023ItIsACompanyThatServesAsAServiceProviderForAnyOtherCompaniesTheWorldSaversAlsoProgrammApplicationsOrWebsiteToolStripMenuItem.Name = "TheWorldSaversIsACompanyThatWasFoundIn2023ItIsACompanyThatServesAsAServiceProvide" &
    "rForAnyOtherCompaniesTheWorldSaversAlsoProgrammApplicationsOrWebsiteToolStripMen" &
    "uItem"
        Me.TheWorldSaversIsACompanyThatWasFoundIn2023ItIsACompanyThatServesAsAServiceProviderForAnyOtherCompaniesTheWorldSaversAlsoProgrammApplicationsOrWebsiteToolStripMenuItem.Size = New System.Drawing.Size(1052, 22)
        Me.TheWorldSaversIsACompanyThatWasFoundIn2023ItIsACompanyThatServesAsAServiceProviderForAnyOtherCompaniesTheWorldSaversAlsoProgrammApplicationsOrWebsiteToolStripMenuItem.Text = "The World Savers is a company that was found in 2023. It is a company that serves" &
    " as a service provider for any other companies. The World Savers also programm a" &
    "pplications or website."
        '
        'CONTACTSToolStripMenuItem
        '
        Me.CONTACTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CELNO0456769802ToolStripMenuItem, Me.EAMILWorldgmailcomToolStripMenuItem, Me.BUILDING12CarthcartRoadToolStripMenuItem})
        Me.CONTACTSToolStripMenuItem.Name = "CONTACTSToolStripMenuItem"
        Me.CONTACTSToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CONTACTSToolStripMenuItem.Text = "CONTACTS"
        '
        'CELNO0456769802ToolStripMenuItem
        '
        Me.CELNO0456769802ToolStripMenuItem.Name = "CELNO0456769802ToolStripMenuItem"
        Me.CELNO0456769802ToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.CELNO0456769802ToolStripMenuItem.Text = "CEL NO : 045 676 9802"
        '
        'EAMILWorldgmailcomToolStripMenuItem
        '
        Me.EAMILWorldgmailcomToolStripMenuItem.Name = "EAMILWorldgmailcomToolStripMenuItem"
        Me.EAMILWorldgmailcomToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.EAMILWorldgmailcomToolStripMenuItem.Text = "EAMIL : world@gmail.com"
        '
        'BUILDING12CarthcartRoadToolStripMenuItem
        '
        Me.BUILDING12CarthcartRoadToolStripMenuItem.Name = "BUILDING12CarthcartRoadToolStripMenuItem"
        Me.BUILDING12CarthcartRoadToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.BUILDING12CarthcartRoadToolStripMenuItem.Text = "BUILDING: 12 Carthcart Road "
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WaterCrisis.My.Resources.Resources._3928221
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(674, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radCustomer As RadioButton
    Friend WithEvents radAdmin As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ABOUTUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheWorldSaversIsACompanyThatWasFoundIn2023ItIsACompanyThatServesAsAServiceProviderForAnyOtherCompaniesTheWorldSaversAlsoProgrammApplicationsOrWebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTACTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CELNO0456769802ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EAMILWorldgmailcomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUILDING12CarthcartRoadToolStripMenuItem As ToolStripMenuItem
End Class
