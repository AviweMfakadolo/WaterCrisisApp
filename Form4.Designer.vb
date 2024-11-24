<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lblWaterLevel = New System.Windows.Forms.Label()
        Me.btnBuyWater = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnPayServices = New System.Windows.Forms.Button()
        Me.lblLevel1 = New System.Windows.Forms.Label()
        Me.lblLevel2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWaterLevel
        '
        Me.lblWaterLevel.AutoSize = True
        Me.lblWaterLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaterLevel.Location = New System.Drawing.Point(152, 9)
        Me.lblWaterLevel.Name = "lblWaterLevel"
        Me.lblWaterLevel.Size = New System.Drawing.Size(97, 18)
        Me.lblWaterLevel.TabIndex = 0
        Me.lblWaterLevel.Text = "Water Level"
        '
        'btnBuyWater
        '
        Me.btnBuyWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuyWater.Location = New System.Drawing.Point(155, 115)
        Me.btnBuyWater.Name = "btnBuyWater"
        Me.btnBuyWater.Size = New System.Drawing.Size(107, 36)
        Me.btnBuyWater.TabIndex = 3
        Me.btnBuyWater.Text = "Buy Water"
        Me.btnBuyWater.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(330, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(233, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'btnPayServices
        '
        Me.btnPayServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayServices.Location = New System.Drawing.Point(333, 114)
        Me.btnPayServices.Name = "btnPayServices"
        Me.btnPayServices.Size = New System.Drawing.Size(139, 37)
        Me.btnPayServices.TabIndex = 5
        Me.btnPayServices.Text = "Pay Services"
        Me.btnPayServices.UseVisualStyleBackColor = True
        '
        'lblLevel1
        '
        Me.lblLevel1.AutoSize = True
        Me.lblLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel1.Location = New System.Drawing.Point(330, 39)
        Me.lblLevel1.Name = "lblLevel1"
        Me.lblLevel1.Size = New System.Drawing.Size(26, 18)
        Me.lblLevel1.TabIndex = 6
        Me.lblLevel1.Text = "0L"
        '
        'lblLevel2
        '
        Me.lblLevel2.AutoSize = True
        Me.lblLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel2.Location = New System.Drawing.Point(524, 39)
        Me.lblLevel2.Name = "lblLevel2"
        Me.lblLevel2.Size = New System.Drawing.Size(44, 18)
        Me.lblLevel2.TabIndex = 7
        Me.lblLevel2.Text = "500L"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(540, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WaterCrisis.My.Resources.Resources._3928221
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(719, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblLevel2)
        Me.Controls.Add(Me.lblLevel1)
        Me.Controls.Add(Me.btnPayServices)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnBuyWater)
        Me.Controls.Add(Me.lblWaterLevel)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWaterLevel As Label
    Friend WithEvents btnBuyWater As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnPayServices As Button
    Friend WithEvents lblLevel1 As Label
    Friend WithEvents lblLevel2 As Label
    Friend WithEvents Button1 As Button
End Class
