Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Articles.CopyShapesBetweenWorksheets
    Public Class CopyControls
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Create a workbook object
            'Open the template file
            Dim workbook As New Workbook(dataDir & "aspose-sample.xlsx")

            'Get the Shapes from the "Control" worksheet.
            Dim shape As Global.Aspose.Cells.Drawing.ShapeCollection = workbook.Worksheets("Sheet3").Shapes

            'Copy the Textbox to the Result Worksheet
            workbook.Worksheets("Sheet1").Shapes.AddCopy(shape(0), 5, 0, 2, 0)

            'Copy the Oval Shape to the Result Worksheet
            workbook.Worksheets("Sheet1").Shapes.AddCopy(shape(1), 10, 0, 2, 0)

            'Save the Worksheet
            workbook.Save(dataDir & "Controls.out.xlsx")

        End Sub
    End Class
End Namespace