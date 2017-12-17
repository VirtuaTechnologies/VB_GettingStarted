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
        Me.btn_declaringVars = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_openNewWindow = New System.Windows.Forms.Button()
        Me.ComboBox_Form1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tBox_addToCombo_val = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_addToCombo = New System.Windows.Forms.Button()
        Me.tBox_addToCombo_displayText = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btn_dtabletoComboBox = New System.Windows.Forms.Button()
        Me.ComboBox_datatable = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tBox_XMLFile = New System.Windows.Forms.TextBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.btn_readXMLMethod1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_declaringVars
        '
        Me.btn_declaringVars.AllowDrop = True
        Me.btn_declaringVars.Location = New System.Drawing.Point(29, 16)
        Me.btn_declaringVars.Name = "btn_declaringVars"
        Me.btn_declaringVars.Size = New System.Drawing.Size(159, 23)
        Me.btn_declaringVars.TabIndex = 0
        Me.btn_declaringVars.Text = "Declaring Variables"
        Me.btn_declaringVars.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(844, 353)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btn_dtabletoComboBox)
        Me.TabPage1.Controls.Add(Me.ComboBox_datatable)
        Me.TabPage1.Controls.Add(Me.btn_declaringVars)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(836, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_openNewWindow)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Form1)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 124)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form to Form"
        '
        'btn_openNewWindow
        '
        Me.btn_openNewWindow.Location = New System.Drawing.Point(165, 20)
        Me.btn_openNewWindow.Name = "btn_openNewWindow"
        Me.btn_openNewWindow.Size = New System.Drawing.Size(186, 23)
        Me.btn_openNewWindow.TabIndex = 1
        Me.btn_openNewWindow.Text = "Open Window"
        Me.btn_openNewWindow.UseVisualStyleBackColor = True
        '
        'ComboBox_Form1
        '
        Me.ComboBox_Form1.FormattingEnabled = True
        Me.ComboBox_Form1.Location = New System.Drawing.Point(9, 20)
        Me.ComboBox_Form1.Name = "ComboBox_Form1"
        Me.ComboBox_Form1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox_Form1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tBox_addToCombo_val)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_addToCombo)
        Me.GroupBox1.Controls.Add(Me.tBox_addToCombo_displayText)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TextBox to ComboBox"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Value"
        '
        'tBox_addToCombo_val
        '
        Me.tBox_addToCombo_val.Location = New System.Drawing.Point(247, 26)
        Me.tBox_addToCombo_val.Name = "tBox_addToCombo_val"
        Me.tBox_addToCombo_val.Size = New System.Drawing.Size(124, 20)
        Me.tBox_addToCombo_val.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Display Text"
        '
        'btn_addToCombo
        '
        Me.btn_addToCombo.Location = New System.Drawing.Point(99, 52)
        Me.btn_addToCombo.Name = "btn_addToCombo"
        Me.btn_addToCombo.Size = New System.Drawing.Size(102, 23)
        Me.btn_addToCombo.TabIndex = 4
        Me.btn_addToCombo.Text = "Add to Combo"
        Me.btn_addToCombo.UseVisualStyleBackColor = True
        '
        'tBox_addToCombo_displayText
        '
        Me.tBox_addToCombo_displayText.Location = New System.Drawing.Point(77, 26)
        Me.tBox_addToCombo_displayText.Name = "tBox_addToCombo_displayText"
        Me.tBox_addToCombo_displayText.Size = New System.Drawing.Size(124, 20)
        Me.tBox_addToCombo_displayText.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Text"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(247, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'btn_dtabletoComboBox
        '
        Me.btn_dtabletoComboBox.Location = New System.Drawing.Point(29, 168)
        Me.btn_dtabletoComboBox.Name = "btn_dtabletoComboBox"
        Me.btn_dtabletoComboBox.Size = New System.Drawing.Size(159, 23)
        Me.btn_dtabletoComboBox.TabIndex = 7
        Me.btn_dtabletoComboBox.Text = "Datatable to Combobox"
        Me.btn_dtabletoComboBox.UseVisualStyleBackColor = True
        '
        'ComboBox_datatable
        '
        Me.ComboBox_datatable.FormattingEnabled = True
        Me.ComboBox_datatable.Location = New System.Drawing.Point(194, 170)
        Me.ComboBox_datatable.Name = "ComboBox_datatable"
        Me.ComboBox_datatable.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox_datatable.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Controls.Add(Me.btn_readXMLMethod1)
        Me.TabPage2.Controls.Add(Me.btn_browse)
        Me.TabPage2.Controls.Add(Me.tBox_XMLFile)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(836, 327)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "XML"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "XML File"
        '
        'tBox_XMLFile
        '
        Me.tBox_XMLFile.Location = New System.Drawing.Point(62, 7)
        Me.tBox_XMLFile.Name = "tBox_XMLFile"
        Me.tBox_XMLFile.Size = New System.Drawing.Size(244, 20)
        Me.tBox_XMLFile.TabIndex = 1
        Me.tBox_XMLFile.Text = "Products.xml"
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(313, 7)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_browse.TabIndex = 2
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'btn_readXMLMethod1
        '
        Me.btn_readXMLMethod1.Location = New System.Drawing.Point(395, 6)
        Me.btn_readXMLMethod1.Name = "btn_readXMLMethod1"
        Me.btn_readXMLMethod1.Size = New System.Drawing.Size(118, 23)
        Me.btn_readXMLMethod1.TabIndex = 3
        Me.btn_readXMLMethod1.Text = "Read XML Method 1"
        Me.btn_readXMLMethod1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(10, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(820, 290)
        Me.ListBox1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 400)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_declaringVars As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_addToCombo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tBox_addToCombo_displayText As TextBox
    Friend WithEvents btn_dtabletoComboBox As Button
    Friend WithEvents ComboBox_datatable As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tBox_addToCombo_val As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_Form1 As ComboBox
    Friend WithEvents btn_openNewWindow As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents tBox_XMLFile As TextBox
    Friend WithEvents btn_readXMLMethod1 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
