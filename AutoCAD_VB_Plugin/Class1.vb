Imports System
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.EditorInput
Imports System.Xml.Linq
Imports System.Runtime
Imports System.Reflection
Imports Autodesk.AutoCAD.Windows

Public Class Class1

    '' Global variable for AddCOMEvent and RemoveCOMEvent commands


    <CommandMethod("createText")>
    Public Sub AdskGreeting()
        '' Get the current document and database, and start a transaction
        Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim acCurDb As Database = acDoc.Database

        Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()
            '' Open the Block table record for read
            Dim acBlkTbl As BlockTable
            acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId,
                                       OpenMode.ForRead)

            '' Open the Block table record Model space for write
            Dim acBlkTblRec As BlockTableRecord
            acBlkTblRec = acTrans.GetObject(acBlkTbl(BlockTableRecord.ModelSpace),
                                          OpenMode.ForWrite)

            '' Creates a new MText object and assigns it a location,
            '' text value and text style
            Dim objText As MText = New MText

            '' Set the default properties for the MText object
            objText.SetDatabaseDefaults()

            '' Specify the insertion point of the MText object
            objText.Location = New Autodesk.AutoCAD.Geometry.Point3d(2, 2, 0)

            '' Set the text string for the MText object
            objText.Contents = "Greetings, Welcome to the AutoCAD .NET Visual Basic plugin - Raghulan Gowthaman A2K Technologies"

            '' Set the text style for the MText object
            objText.TextStyleId = acCurDb.Textstyle

            '' Appends the new MText object to model space
            acBlkTblRec.AppendEntity(objText)

            '' Appends to new MText object to the active transaction
            acTrans.AddNewlyCreatedDBObject(objText, True)

            '' Saves the changes to the database and closes the transaction
            acTrans.Commit()

            'zoom extent
            Dim comApp As Autodesk.AutoCAD.Interop.AcadApplication
            comApp = GetObject(, "AutoCAD.Application")
            comApp.ZoomExtents()

        End Using
    End Sub

    Friend Shared m_ps As Autodesk.AutoCAD.Windows.PaletteSet = Nothing
    <CommandMethod("toolpal1")>
    Public Sub toolpal1()
        'check to see if paletteset is already created
        If m_ps Is Nothing Then
            'no so create it
            m_ps = New Autodesk.AutoCAD.Windows.PaletteSet("My First Palette")
            'create new instance of user control
            Dim myPalette As ToolPal = New ToolPal()
            'add it to the paletteset
            m_ps.Add("My First Palette", myPalette)        End If
        m_ps.Visible = True
    End Sub
End Class