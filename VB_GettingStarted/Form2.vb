
Public Class Form2
    Inherits System.Windows.Forms.Form
    Public msgReceived As String
    Public form2Val As Int16

    Public Sub New(ByVal msgReceived)
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        'this function will run when ever form is fiered.
        ComboBox_Form2.Items.Add(New With {.Text = "USA", .Value = 101})
        ComboBox_Form2.Items.Add(New With {.Text = "UK", .Value = 109})
        ComboBox_Form2.Items.Add(New With {.Text = "France", .Value = 106})
        ComboBox_Form2.Items.Add(New With {.Text = "Germany", .Value = 121})

        ' Add any initialization after the InitializeComponent() call.
        'now set the value for the combobox
        ComboBox_Form2.SelectedIndex = msgReceived

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox_Form2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Form2.SelectedIndexChanged
        'we are storing the value that is selected in the form 2
        'variables.valfromForm2 = ComboBox_Form2.SelectedIndex

    End Sub

    Private Sub btn_form2_Close_Click(sender As Object, e As EventArgs) Handles btn_form2_Close.Click

        Me.Hide()
        Dim form1 As New Form1()
        form1.Show()
        form1.ComboBox_Form1.SelectedIndex = ComboBox_Form2.SelectedIndex


    End Sub
End Class