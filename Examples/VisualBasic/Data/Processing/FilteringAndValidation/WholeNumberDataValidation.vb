Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Data.Processing.Processing.FilteringAndValidation
    Public Class WholeNumberDataValidation
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Create a workbook object.
            Dim workbook As New Workbook()

            ' Create a worksheet and get the first worksheet.
            Dim ExcelWorkSheet As Worksheet = workbook.Worksheets(0)

            'Accessing the Validations collection of the worksheet
            Dim validations As ValidationCollection = workbook.Worksheets(0).Validations

            'Creating a Validation object
            Dim validation As Validation = validations(validations.Add())

            'Setting the validation type to whole number
            validation.Type = ValidationType.WholeNumber

            'Setting the operator for validation to Between
            validation.Operator = OperatorType.Between

            'Setting the minimum value for the validation
            validation.Formula1 = "10"

            'Setting the maximum value for the validation
            validation.Formula2 = "1000"

            'Applying the validation to a range of cells from A1 to B2 using the
            'CellArea structure
            Dim area As CellArea
            area.StartRow = 0
            area.EndRow = 1
            area.StartColumn = 0
            area.EndColumn = 1

            'Adding the cell area to Validation
            validation.AreaList.Add(area)


            ' Save the workbook.
            workbook.Save(dataDir & "output.out.xls")


        End Sub
    End Class
End Namespace