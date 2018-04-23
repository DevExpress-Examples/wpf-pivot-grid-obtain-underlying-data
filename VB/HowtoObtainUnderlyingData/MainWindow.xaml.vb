Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Themes
Imports DevExpress.XtraPivotGrid
Imports HowtoObtainUnderlyingData.NwindDataSetTableAdapters

Namespace HowtoObtainUnderlyingData
	Partial Public Class MainWindow
		Inherits Window
		Private popupContainer As FloatingContainer
		Private salesPersonDataTable As New NwindDataSet.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()

		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable)
		End Sub

		Private Sub pivotGridControl1_CellDblClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.PivotGrid.PivotCellEventArgs)
			Dim grid As New GridControl()
			ThemeManager.SetThemeName(grid, ThemeManager.ApplicationThemeName)
			grid.HorizontalAlignment = HorizontalAlignment.Stretch
			grid.VerticalAlignment = VerticalAlignment.Stretch
			Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
			grid.DataSource = ds
			grid.PopulateColumns()
			popupContainer = FloatingWindowContainer.ShowDialog(grid, Me, New Size(520, 300), New FloatingContainerParameters() With {.AllowSizing = True, .CloseOnEscape = True, .Title = "Drill Down Form", .ClosedDelegate = Nothing})
			AddLogicalChild(popupContainer)
		End Sub
	End Class
End Namespace
