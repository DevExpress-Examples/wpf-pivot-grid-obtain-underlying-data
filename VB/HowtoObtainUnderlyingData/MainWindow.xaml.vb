Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.PivotGrid
Imports HowtoObtainUnderlyingData.NwindDataSetTableAdapters

Namespace HowtoObtainUnderlyingData

    Public Partial Class MainWindow
        Inherits Window

        Private popupContainer As FloatingContainer

        Private salesPersonDataTable As NwindDataSet.SalesPersonDataTable = New NwindDataSet.SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
        End Sub

        Private Sub pivotGridControl1_CellDblClick(ByVal sender As Object, ByVal e As PivotCellEventArgs)
            Dim grid As GridControl = New GridControl()
            ThemeManager.SetThemeName(grid, ThemeManager.ApplicationThemeName)
            grid.HorizontalAlignment = HorizontalAlignment.Stretch
            grid.VerticalAlignment = VerticalAlignment.Stretch
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            grid.ItemsSource = ds
            grid.PopulateColumns()
            popupContainer = FloatingContainer.ShowDialog(grid, Me, New Size(520, 300), New FloatingContainerParameters() With {.AllowSizing = True, .CloseOnEscape = True, .Title = "Drill Down Form", .ClosedDelegate = Nothing})
            AddLogicalChild(popupContainer)
        End Sub
    End Class
End Namespace
