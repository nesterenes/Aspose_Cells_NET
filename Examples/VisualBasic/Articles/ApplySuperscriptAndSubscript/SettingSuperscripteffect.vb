Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Articles.ApplySuperscriptAndSubscript
    Public Class SettingSuperscripteffect
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiating a Workbook object
            Dim workbook As New Workbook()

            'Adding a new worksheet to the Excel object
            workbook.Worksheets.Add()

            'Obtaining the reference of the newly added worksheet by passing its sheet index
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            'Accessing the "A1" cell from the worksheet
            Dim cell As Cell = worksheet.Cells("A1")

            'Adding some value to the "A1" cell
            cell.PutValue("Hello")

            'Setting the font Superscript
            Dim style As Style = cell.GetStyle()
            style.Font.IsSuperscript = True
            cell.SetStyle(style)

            'Saving the Excel file
            workbook.Save(dataDir & "Superscript.out.xls", SaveFormat.Auto)


        End Sub
    End Class
End Namespace