<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.rad500L = New System.Windows.Forms.RadioButton()
        Me.rad1500L = New System.Windows.Forms.RadioButton()
        Me.rad2500L = New System.Windows.Forms.RadioButton()
        Me.rad8000L = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.txtCCV = New System.Windows.Forms.TextBox()
        Me.txtEXP = New System.Windows.Forms.TextBox()
        Me.txtOTP = New System.Windows.Forms.TextBox()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad500L
        '
        Me.rad500L.AutoSize = True
        Me.rad500L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rad500L.Location = New System.Drawing.Point(6, 30)
        Me.rad500L.Name = "rad500L"
        Me.rad500L.Size = New System.Drawing.Size(111, 22)
        Me.rad500L.TabIndex = 0
        Me.rad500L.TabStop = True
        Me.rad500L.Text = "500L=R150"
        Me.rad500L.UseVisualStyleBackColor = True
        '
        'rad1500L
        '
        Me.rad1500L.AutoSize = True
        Me.rad1500L.Location = New System.Drawing.Point(6, 53)
        Me.rad1500L.Name = "rad1500L"
        Me.rad1500L.Size = New System.Drawing.Size(120, 22)
        Me.rad1500L.TabIndex = 1
        Me.rad1500L.TabStop = True
        Me.rad1500L.Text = "1500L=R320"
        Me.rad1500L.UseVisualStyleBackColor = True
        '
        'rad2500L
        '
        Me.rad2500L.AutoSize = True
        Me.rad2500L.Location = New System.Drawing.Point(6, 76)
        Me.rad2500L.Name = "rad2500L"
        Me.rad2500L.Size = New System.Drawing.Size(120, 22)
        Me.rad2500L.TabIndex = 2
        Me.rad2500L.TabStop = True
        Me.rad2500L.Text = "2500L=R580"
        Me.rad2500L.UseVisualStyleBackColor = True
        '
        'rad8000L
        '
        Me.rad8000L.AutoSize = True
        Me.rad8000L.Location = New System.Drawing.Point(6, 99)
        Me.rad8000L.Name = "rad8000L"
        Me.rad8000L.Size = New System.Drawing.Size(120, 22)
        Me.rad8000L.TabIndex = 3
        Me.rad8000L.TabStop = True
        Me.rad8000L.Text = "8000L=R830"
        Me.rad8000L.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.rad500L)
        Me.GroupBox1.Controls.Add(Me.rad1500L)
        Me.GroupBox1.Controls.Add(Me.rad8000L)
        Me.GroupBox1.Controls.Add(Me.rad2500L)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 130)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "liters and prices"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(417, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ENTER CARD NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ENTER CCV "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ENTER EXPIRY DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(417, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ENTER OTP"
        '
        'txtCardNum
        '
        Me.txtCardNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNum.Location = New System.Drawing.Point(615, 22)
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(100, 24)
        Me.txtCardNum.TabIndex = 10
        '
        'txtCCV
        '
        Me.txtCCV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCV.Location = New System.Drawing.Point(615, 69)
        Me.txtCCV.Name = "txtCCV"
        Me.txtCCV.Size = New System.Drawing.Size(100, 24)
        Me.txtCCV.TabIndex = 11
        '
        'txtEXP
        '
        Me.txtEXP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEXP.Location = New System.Drawing.Point(615, 104)
        Me.txtEXP.Name = "txtEXP"
        Me.txtEXP.Size = New System.Drawing.Size(100, 24)
        Me.txtEXP.TabIndex = 12
        '
        'txtOTP
        '
        Me.txtOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTP.Location = New System.Drawing.Point(615, 198)
        Me.txtOTP.Name = "txtOTP"
        Me.txtOTP.Size = New System.Drawing.Size(100, 24)
        Me.txtOTP.TabIndex = 13
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(518, 145)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(107, 35)
        Me.btn_confirm.TabIndex = 14
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(615, 254)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 30)
        Me.btnDone.TabIndex = 15
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btn_Check
        '
        Me.btn_Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Check.Location = New System.Drawing.Point(473, 254)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(75, 30)
        Me.btn_Check.TabIndex = 16
        Me.btn_Check.Text = "CHECK "
        Me.btn_Check.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(333, 254)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 30)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WaterCrisis.My.Resources.Resources._3928221
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(719, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.txtOTP)
        Me.Controls.Add(Me.txtEXP)
        Me.Controls.Add(Me.txtCCV)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rad500L As RadioButton
    Friend WithEvents rad1500L As RadioButton
    Friend WithEvents rad2500L As RadioButton
    Friend WithEvents rad8000L As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents txtCCV As TextBox
    Friend WithEvents txtEXP As TextBox
    Friend WithEvents txtOTP As TextBox
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents btn_Check As Button
    Friend WithEvents btnBack As Button
End Class
