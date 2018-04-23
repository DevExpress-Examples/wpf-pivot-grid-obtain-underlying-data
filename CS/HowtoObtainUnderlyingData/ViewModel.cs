using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.PivotGrid;
using HowtoObtainUnderlyingData.NwindDataSetTableAdapters;

namespace HowtoObtainUnderlyingData {
    [POCOViewModel]
    public class ViewModel {
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = new NwindDataSet.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();

        public NwindDataSet.SalesPersonDataTable DataSource { get { return salesPersonDataTable; } }

        protected ViewModel() {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
        }

        public void ShowDrillDownData(CellInfo cellInfo) {
            this.GetService<IDialogService>().ShowDialog(MessageButton.OK, "Drill Down Results", cellInfo);
        }
    }
}
