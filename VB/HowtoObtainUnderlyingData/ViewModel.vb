Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Xpf.PivotGrid
Imports NwindDataSetTableAdapters

Namespace HowtoObtainUnderlyingData
    <POCOViewModel>
    Public Class ViewModel
        Private salesPersonDataTable As New NwindDataSet.SalesPersonDataTable()
        Private salesPersonDataAdapter As New SalesPersonTableAdapter()

        Public ReadOnly Property DataSource() As NwindDataSet.SalesPersonDataTable
            Get
                Return salesPersonDataTable
            End Get
        End Property

        Protected Sub New()
            salesPersonDataAdapter.Fill(salesPersonDataTable)
        End Sub

        Public Sub ShowDrillDownData(ByVal cellInfo As CellInfo)
            Me.GetService(Of IDialogService)().ShowDialog(MessageButton.OK, "Drill Down Results", cellInfo)
        End Sub
    End Class
End Namespace
