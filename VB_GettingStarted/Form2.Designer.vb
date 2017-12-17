<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ComboBox_Form2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_form2_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox_Form2
        '
        Me.ComboBox_Form2.FormattingEnabled = True
        Me.ComboBox_Form2.Location = New System.Drawing.Point(138, 6)
        Me.ComboBox_Form2.Name = "ComboBox_Form2"
        Me.ComboBox_Form2.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox_Form2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Value selected in Form1"
        '
        'btn_form2_Close
        '
        Me.btn_form2_Close.Location = New System.Drawing.Point(485, 271)
        Me.btn_form2_Close.Name = "btn_form2_Close"
        Me.btn_form2_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_form2_Close.TabIndex = 2
        Me.btn_form2_Close.Text = "Close"
        Me.btn_form2_Close.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 306)
        Me.Controls.Add(Me.btn_form2_Close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox_Form2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_Form2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_form2_Close As Button
End Class
