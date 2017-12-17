Imports System.Xml
Imports System.IO

Public Class Form1



    Private Sub btn_declaringVars_Click(sender As Object, e As EventArgs) Handles btn_declaringVars.Click
        'declaring variables
        Dim stringVar As String = "this is a string var"
        Dim intVar As Int16 = 10

        MessageBox.Show(stringVar + intVar.ToString(), "Message Box Title")
    End Sub

    Private Sub btn_addToCombo_Click(sender As Object, e As EventArgs) Handles btn_addToCombo.Click

        'check if the string is empty
        If Not String.IsNullOrEmpty(tBox_addToCombo_displayText.Text) Then
            'string is not empty
            'add the string to the combobox
            ComboBox1.Items.Add(New With {.Text = tBox_addToCombo_displayText.Text, .Value = tBox_addToCombo_val.Text})
        Else
            'string is empty
            MessageBox.Show("Cannot add empty string", "Message Box Title")
        End If


    End Sub

    Private Sub btn_dtabletoComboBox_Click(sender As Object, e As EventArgs) Handles btn_dtabletoComboBox.Click
        ComboBox_datatable.DisplayMember = "Text"
        ComboBox_datatable.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))
        tb.Rows.Add("USA", 101)
        tb.Rows.Add("UK", 109)
        tb.Rows.Add("France", 106)
        tb.Rows.Add("Germany", 121)
        ComboBox_datatable.DataSource = tb
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this function will run when ever form is fiered.

        ComboBox_Form1.Items.Add(New With {.Text = "USA", .Value = 101})
        ComboBox_Form1.Items.Add(New With {.Text = "UK", .Value = 109})
        ComboBox_Form1.Items.Add(New With {.Text = "France", .Value = 106234234234})
        ComboBox_Form1.Items.Add(New With {.Text = "Germany", .Value = 121})
        ComboBox_Form1.Items.Add("test")
        ComboBox_Form1.Items.Insert(2, "test2")

    End Sub

    Private Sub btn_openNewWindow_Click(sender As Object, e As EventArgs) Handles btn_openNewWindow.Click
        Dim form2 As New Form2(ComboBox_Form1.SelectedIndex)
        form2.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open XML File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "XML files (*.XML)|"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
    End Sub

    Private Sub btn_readXMLMethod1_Click(sender As Object, e As EventArgs) Handles btn_readXMLMethod1.Click

        Dim reader As New XmlTextReader(tBox_XMLFile.Text)
        While reader.Read()
            Select Case reader.NodeType
                Case XmlNodeType.Element
                    ListBox1.Items.Add("<" + reader.Name & ">")
                    Exit Select
                Case XmlNodeType.Text
                    ListBox1.Items.Add(reader.Value)
                    Exit Select
                Case XmlNodeType.EndElement
                    ListBox1.Items.Add("")
                    Exit Select
            End Select
        End While
    End Sub
End Class
