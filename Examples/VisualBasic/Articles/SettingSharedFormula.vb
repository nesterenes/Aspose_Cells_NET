Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Articles
    Public Class SettingSharedFormula
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim filePath As String = dataDir & "input.xlsx"

            'Instantiate a Workbook from existing file
            Dim workbook As New Workbook(filePath)

            'Get the cells collection in the first worksheet
            Dim cells As Global.Aspose.Cells.Cells = workbook.Worksheets(0).Cells

            'Apply the shared formula in the range i.e.., B2:B14
            cells("B2").SetSharedFormula("=A2*0.09", 13, 1)

            'Save the excel file
            workbook.Save(dataDir & ".out.xlsx", SaveFormat.Xlsx)

        End Sub
    End Class
End Namespace