using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.PivotGrid;
using HowtoObtainUnderlyingData.NwindDataSetTableAdapters;

namespace HowtoObtainUnderlyingData {
    public partial class MainWindow : Window {
        FloatingContainer popupContainer;
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = new NwindDataSet.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();

        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
        }

        private void pivotGridControl1_CellDblClick(object sender, 
													DevExpress.Xpf.PivotGrid.PivotCellEventArgs e) {
            GridControl grid = new GridControl();
            ThemeManager.SetThemeName(grid, ApplicationThemeHelper.ApplicationThemeName);
            grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            grid.VerticalAlignment = VerticalAlignment.Stretch;
            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
            grid.ItemsSource = ds;
            grid.PopulateColumns();
            popupContainer = FloatingWindowContainer.ShowDialog(grid, this, new Size(520, 300),
                new FloatingContainerParameters() {
                    AllowSizing = true,
                    CloseOnEscape = true,
                    Title = "Drill Down Form",
                    ClosedDelegate = null
                });
            AddLogicalChild(popupContainer);
        }
    }
}
