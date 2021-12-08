Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Xpf.PivotGrid
Imports System.Data
Imports System.Data.SQLite


Namespace HowToObtainUnderlyingData
	<POCOViewModel>
	Public Class ViewModel
		Public ReadOnly Property DataSource() As New DataTable()
		Protected Sub New()
			Dim connection = System.Configuration.ConfigurationManager.ConnectionStrings("nwind").ConnectionString
			Using conn As New SQLiteConnection("Data Source=C:\DataSources\nwind.db;")
				conn.Open()
				Dim command As New SQLiteCommand("Select * from SalesPerson", conn)
				Dim reader As SQLiteDataReader = command.ExecuteReader()
				DataSource.Load(reader)
				reader.Close()
			End Using
		End Sub
		Public Sub ShowDrillDownData(ByVal cellInfo As CellInfo)
			Me.GetService(Of IDialogService)().ShowDialog(MessageButton.OK, "Drill Down Results", cellInfo)
		End Sub
	End Class
End Namespace
