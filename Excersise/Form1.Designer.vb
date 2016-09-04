<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Stepper = New System.Windows.Forms.Label()
        Me.txtStepper = New System.Windows.Forms.TextBox()
        Me.Trainer = New System.Windows.Forms.Label()
        Me.txtTrainer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBicycle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPoundsBurned = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Stepper
        '
        Me.Stepper.AutoSize = True
        Me.Stepper.Location = New System.Drawing.Point(12, 9)
        Me.Stepper.Name = "Stepper"
        Me.Stepper.Size = New System.Drawing.Size(44, 13)
        Me.Stepper.TabIndex = 0
        Me.Stepper.Text = "&Stepper"
        '
        'txtStepper
        '
        Me.txtStepper.Location = New System.Drawing.Point(15, 25)
        Me.txtStepper.Name = "txtStepper"
        Me.txtStepper.Size = New System.Drawing.Size(100, 20)
        Me.txtStepper.TabIndex = 1
        '
        'Trainer
        '
        Me.Trainer.AutoSize = True
        Me.Trainer.Location = New System.Drawing.Point(118, 9)
        Me.Trainer.Name = "Trainer"
        Me.Trainer.Size = New System.Drawing.Size(40, 13)
        Me.Trainer.TabIndex = 2
        Me.Trainer.Text = "&Trainer"
        '
        'txtTrainer
        '
        Me.txtTrainer.Location = New System.Drawing.Point(121, 25)
        Me.txtTrainer.Name = "txtTrainer"
        Me.txtTrainer.Size = New System.Drawing.Size(100, 20)
        Me.txtTrainer.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Bicycle"
        '
        'txtBicycle
        '
        Me.txtBicycle.Location = New System.Drawing.Point(227, 24)
        Me.txtBicycle.Name = "txtBicycle"
        Me.txtBicycle.Size = New System.Drawing.Size(100, 20)
        Me.txtBicycle.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pounds burned:"
        '
        'lblPoundsBurned
        '
        Me.lblPoundsBurned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoundsBurned.Location = New System.Drawing.Point(357, 24)
        Me.lblPoundsBurned.Name = "lblPoundsBurned"
        Me.lblPoundsBurned.Size = New System.Drawing.Size(100, 20)
        Me.lblPoundsBurned.TabIndex = 7
        Me.lblPoundsBurned.Text = " "
        Me.lblPoundsBurned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "="
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(15, 51)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(442, 52)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(442, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 147)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPoundsBurned)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBicycle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTrainer)
        Me.Controls.Add(Me.Trainer)
        Me.Controls.Add(Me.txtStepper)
        Me.Controls.Add(Me.Stepper)
        Me.Name = "frmMain"
        Me.Text = "Calories Burned Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Stepper As Label
    Friend WithEvents txtStepper As TextBox
    Friend WithEvents Trainer As Label
    Friend WithEvents txtTrainer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBicycle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPoundsBurned As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents Button2 As Button
End Class
