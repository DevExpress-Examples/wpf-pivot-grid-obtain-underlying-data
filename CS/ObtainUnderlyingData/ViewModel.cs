using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.PivotGrid;
using System.Data;
using System.Data.SQLite;

namespace HowToObtainUnderlyingData {
    [POCOViewModel]
    public class ViewModel {
        public DataTable DataSource { get; } = new DataTable();
        protected ViewModel() {
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=nwind.db;")) {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand("Select * from SalesPerson", conn);
                SQLiteDataReader reader = command.ExecuteReader();
                DataSource.Load(reader);
                reader.Close();
            }
        }
        public void ShowDrillDownData(CellInfo cellInfo) {
            this.GetService<IDialogService>().ShowDialog(MessageButton.OK, "Drill Down Results", cellInfo);
        }
    }
}
