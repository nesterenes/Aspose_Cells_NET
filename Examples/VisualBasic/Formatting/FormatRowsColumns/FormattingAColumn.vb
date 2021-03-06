'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Drawing

Namespace Aspose.Cells.Examples.Formatting.FormatRowsColumns
    Public Class FormattingAColumn
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

            'Obtaining the reference of the first (default) worksheet by passing its sheet index
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            'Adding a new Style to the styles collection of the Excel object
            Dim i As Integer = workbook.Styles.Add()

            'Accessing the newly added Style to the Excel object
            Dim style As Style = workbook.Styles(i)

            'Setting the vertical alignment of the text in the "A1" cell
            style.VerticalAlignment = TextAlignmentType.Center

            'Setting the horizontal alignment of the text in the "A1" cell
            style.HorizontalAlignment = TextAlignmentType.Center

            'Setting the font color of the text in the "A1" cell
            style.Font.Color = Color.Green

            'Shrinking the text to fit in the cell
            style.ShrinkToFit = True

            'Setting the bottom border color of the cell to red
            style.Borders(BorderType.BottomBorder).Color = Color.Red

            'Setting the bottom border type of the cell to medium
            style.Borders(BorderType.BottomBorder).LineStyle = CellBorderType.Medium

            'Creating StyleFlag
            Dim styleFlag As New StyleFlag()
            styleFlag.HorizontalAlignment = True
            styleFlag.VerticalAlignment = True
            styleFlag.ShrinkToFit = True
            styleFlag.Borders = True
            styleFlag.FontColor = True

            'Accessing a column from the Columns collection
            Dim column As Column = worksheet.Cells.Columns(0)

            'Applying the style to the column
            column.ApplyStyle(style, styleFlag)

            'Saving the Excel file
            workbook.Save(dataDir & "book1.xls")
        End Sub
    End Class
End Namespace