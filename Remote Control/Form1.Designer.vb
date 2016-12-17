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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnChUp = New System.Windows.Forms.Button()
        Me.btnVolDwn = New System.Windows.Forms.Button()
        Me.btnVolUp = New System.Windows.Forms.Button()
        Me.btnChDwn = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnMute = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM24"
        '
        'btnPower
        '
        Me.btnPower.AutoSize = True
        Me.btnPower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPower.Location = New System.Drawing.Point(12, 12)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(47, 23)
        Me.btnPower.TabIndex = 0
        Me.btnPower.TabStop = False
        Me.btnPower.Text = "Power"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnChUp
        '
        Me.btnChUp.AutoSize = True
        Me.btnChUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChUp.Location = New System.Drawing.Point(49, 44)
        Me.btnChUp.Name = "btnChUp"
        Me.btnChUp.Size = New System.Drawing.Size(71, 23)
        Me.btnChUp.TabIndex = 1
        Me.btnChUp.TabStop = False
        Me.btnChUp.Text = "Channel ↑"
        Me.btnChUp.UseVisualStyleBackColor = True
        '
        'btnVolDwn
        '
        Me.btnVolDwn.AutoSize = True
        Me.btnVolDwn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVolDwn.Location = New System.Drawing.Point(12, 71)
        Me.btnVolDwn.Name = "btnVolDwn"
        Me.btnVolDwn.Size = New System.Drawing.Size(67, 23)
        Me.btnVolDwn.TabIndex = 2
        Me.btnVolDwn.TabStop = False
        Me.btnVolDwn.Text = "← Volume"
        Me.btnVolDwn.UseVisualStyleBackColor = True
        '
        'btnVolUp
        '
        Me.btnVolUp.AutoSize = True
        Me.btnVolUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVolUp.Location = New System.Drawing.Point(85, 71)
        Me.btnVolUp.Name = "btnVolUp"
        Me.btnVolUp.Size = New System.Drawing.Size(67, 23)
        Me.btnVolUp.TabIndex = 3
        Me.btnVolUp.TabStop = False
        Me.btnVolUp.Text = "Volume →"
        Me.btnVolUp.UseVisualStyleBackColor = True
        '
        'btnChDwn
        '
        Me.btnChDwn.AutoSize = True
        Me.btnChDwn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChDwn.Location = New System.Drawing.Point(49, 100)
        Me.btnChDwn.Name = "btnChDwn"
        Me.btnChDwn.Size = New System.Drawing.Size(71, 23)
        Me.btnChDwn.TabIndex = 4
        Me.btnChDwn.TabStop = False
        Me.btnChDwn.Text = "Channel ↓"
        Me.btnChDwn.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.AutoSize = True
        Me.btnOne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(34, 129)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(28, 30)
        Me.btnOne.TabIndex = 5
        Me.btnOne.TabStop = False
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.AutoSize = True
        Me.btnTwo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(68, 129)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(28, 30)
        Me.btnTwo.TabIndex = 6
        Me.btnTwo.TabStop = False
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.AutoSize = True
        Me.btnThree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(102, 129)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(28, 30)
        Me.btnThree.TabIndex = 7
        Me.btnThree.TabStop = False
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.AutoSize = True
        Me.btnFour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(34, 165)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(28, 30)
        Me.btnFour.TabIndex = 8
        Me.btnFour.TabStop = False
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.AutoSize = True
        Me.btnFive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(68, 165)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(28, 30)
        Me.btnFive.TabIndex = 9
        Me.btnFive.TabStop = False
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.AutoSize = True
        Me.btnSix.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(102, 165)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(28, 30)
        Me.btnSix.TabIndex = 10
        Me.btnSix.TabStop = False
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.AutoSize = True
        Me.btnSeven.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(34, 201)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(28, 30)
        Me.btnSeven.TabIndex = 11
        Me.btnSeven.TabStop = False
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.AutoSize = True
        Me.btnEight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(68, 201)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(28, 30)
        Me.btnEight.TabIndex = 12
        Me.btnEight.TabStop = False
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.AutoSize = True
        Me.btnNine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(102, 201)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(28, 30)
        Me.btnNine.TabIndex = 13
        Me.btnNine.TabStop = False
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.AutoSize = True
        Me.btnZero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(68, 237)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(28, 30)
        Me.btnZero.TabIndex = 14
        Me.btnZero.TabStop = False
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.AutoSize = True
        Me.btnLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(102, 237)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(33, 23)
        Me.btnLast.TabIndex = 15
        Me.btnLast.TabStop = False
        Me.btnLast.Text = "last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnMute
        '
        Me.btnMute.AutoSize = True
        Me.btnMute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMute.Location = New System.Drawing.Point(22, 237)
        Me.btnMute.Name = "btnMute"
        Me.btnMute.Size = New System.Drawing.Size(40, 23)
        Me.btnMute.TabIndex = 16
        Me.btnMute.TabStop = False
        Me.btnMute.Text = "mute"
        Me.btnMute.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(77, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.TabStop = False
        Me.Button1.Text = "Keyboard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(173, 312)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.btnMute)
        Me.Controls.Add(Me.btnChUp)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnVolDwn)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnVolUp)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnChDwn)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnEight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents btnChUp As System.Windows.Forms.Button
    Friend WithEvents btnVolDwn As System.Windows.Forms.Button
    Friend WithEvents btnVolUp As System.Windows.Forms.Button
    Friend WithEvents btnChDwn As System.Windows.Forms.Button
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnSix As System.Windows.Forms.Button
    Friend WithEvents btnSeven As System.Windows.Forms.Button
    Friend WithEvents btnEight As System.Windows.Forms.Button
    Friend WithEvents btnNine As System.Windows.Forms.Button
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnMute As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
