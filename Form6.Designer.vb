<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.txtEXD = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtAma = New System.Windows.Forms.TextBox()
        Me.txtOneTimePin = New System.Windows.Forms.TextBox()
        Me.btnCONF = New System.Windows.Forms.Button()
        Me.btnPAY = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CARD NUMBER"
        '
        'txtEXD
        '
        Me.txtEXD.AutoSize = True
        Me.txtEXD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEXD.Location = New System.Drawing.Point(168, 103)
        Me.txtEXD.Name = "txtEXD"
        Me.txtEXD.Size = New System.Drawing.Size(115, 18)
        Me.txtEXD.TabIndex = 1
        Me.txtEXD.Text = "EXPIRY DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(168, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CCV NUMBER"
        '
        'txtAmount
        '
        Me.txtAmount.AutoSize = True
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(168, 147)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(145, 18)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Text = "ENTER AMOUNT "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(194, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "OTP"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(365, 35)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 24)
        Me.txtNumber.TabIndex = 5
        '
        'txtCC
        '
        Me.txtCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCC.Location = New System.Drawing.Point(365, 70)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(100, 24)
        Me.txtCC.TabIndex = 6
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(365, 103)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 24)
        Me.txtDate.TabIndex = 7
        '
        'txtAma
        '
        Me.txtAma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAma.Location = New System.Drawing.Point(365, 141)
        Me.txtAma.Name = "txtAma"
        Me.txtAma.Size = New System.Drawing.Size(100, 24)
        Me.txtAma.TabIndex = 8
        '
        'txtOneTimePin
        '
        Me.txtOneTimePin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOneTimePin.Location = New System.Drawing.Point(378, 251)
        Me.txtOneTimePin.Name = "txtOneTimePin"
        Me.txtOneTimePin.Size = New System.Drawing.Size(100, 24)
        Me.txtOneTimePin.TabIndex = 9
        '
        'btnCONF
        '
        Me.btnCONF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCONF.Location = New System.Drawing.Point(272, 200)
        Me.btnCONF.Name = "btnCONF"
        Me.btnCONF.Size = New System.Drawing.Size(94, 30)
        Me.btnCONF.TabIndex = 10
        Me.btnCONF.Text = "CONFIRM"
        Me.btnCONF.UseVisualStyleBackColor = True
        '
        'btnPAY
        '
        Me.btnPAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPAY.Location = New System.Drawing.Point(251, 312)
        Me.btnPAY.Name = "btnPAY"
        Me.btnPAY.Size = New System.Drawing.Size(96, 33)
        Me.btnPAY.TabIndex = 11
        Me.btnPAY.Text = "PAY"
        Me.btnPAY.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(390, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WaterCrisis.My.Resources.Resources._3928221
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(704, 438)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPAY)
        Me.Controls.Add(Me.btnCONF)
        Me.Controls.Add(Me.txtOneTimePin)
        Me.Controls.Add(Me.txtAma)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEXD)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEXD As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtCC As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtAma As TextBox
    Friend WithEvents txtOneTimePin As TextBox
    Friend WithEvents btnCONF As Button
    Friend WithEvents btnPAY As Button
    Friend WithEvents Button1 As Button
End Class
