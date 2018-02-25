Imports Autodesk.AutoCAD.Windows

Public Class ToolPal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
        'adjust opacity
        'AutoCAD_VB_Plugin.Class1.m_ps.Opacity = TrackBar1.Value

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        'toggle docking
        With AutoCAD_VB_Plugin.Class1.m_ps
            Select Case Me.ComboBox1.SelectedIndex
                Case Is = 0 'bottom
                    .Dock = DockSides.Bottom
                Case Is = 1 'left
                    .Dock = DockSides.Left
                Case Is = 2 'right
                    .Dock = DockSides.Right
                Case Is = 3 ''top
                    .Dock = DockSides.Top
                Case Is = 4 'float
                    .Dock = DockSides.None
            End Select
        End With
    End Sub
End Class
