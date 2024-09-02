<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578831/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2173)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Pivot Grid for WPF - How to Display Underlying (Drill-Down) Records

This example demonstrates how to obtain the records from the control's underlying data source for a particular cell. Double-click a cell to invoke a form that contains a grid to show the underlying data.

![Display Underlying (Drill-Down) Records](Images/screenshot.png)

This example is based on the [DevExpress MVVM Framework](https://docs.devexpress.com/WPF/15112).  When a user double-clicks a cell, the [EventToCommand](https://docs.devexpress.com/WPF/17369) class invokes the bound **ShowDrillDownDataCommand** defined in the ViewModel. 

To pass the event data as a parameter to the command, the [EventToCommand.PassEventArgsToCommand](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.EventToCommand.PassEventArgsToCommand) property is set to **true**. The [EventArgsToCellInfoConverter](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.EventArgsToCellInfoConverter) instance is assigned to the [EventToCommand.EventArgsConverter](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.EventToCommand.EventArgsConverter) property to convert the event data to the [CellInfo](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellInfo) parameter type required for the command.

The command calls the **DialogService.ShowDialog** method to invoke a custom window that displays the underlying data. The [DialogService](https://docs.devexpress.com/WPF/17467) is a part of the DevExpress MVVM Framework. It is defined in XAML and specifies the [DXDialogWindow](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.DXDialogWindow) that contains the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) bound to the [CellInfo.DrillDownDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellInfo.DrillDownDataSource) property.

> You can also use the following methods to get the underlying data:

* [CellInfo.CreateDrillDownDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellInfo.CreateDrillDownDataSource) that returns the collection of records in the original data source with the [IEnumerable](https://docs.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerable) interface. 
* The [PivotGridControl.CreateDrillDownDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.CreateDrillDownDataSource.overloads) method and  **CreateDrillDownDataSource** methods available in PivotGridControl event handlers return the [PivotDrillDownDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotDrillDownDataSource) object.

> Asynchronous drill-down operations are performed with the following methods:

* [CellInfo.CreateDrillDownDataSourceAsync](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellInfo.CreateDrillDownDataSourceAsync)
* [PivotGridControl.CreateDrillDownDataSourceAsync ](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.CreateDrillDownDataSourceAsync.overloads)

<!-- default file list -->
## Files to Look At

* [MainWindow.xaml](CS/ObtainUnderlyingData/MainWindow.xaml) (VB: [MainWindow.xaml](VB/ObtainUnderlyingData/MainWindow.xaml))
* [MainWindow.xaml.cs](CS/ObtainUnderlyingData/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](VB/ObtainUnderlyingData/MainWindow.xaml.vb))
* [ViewModel.cs](CS/ObtainUnderlyingData/ViewModel.cs) (VB: [ViewModel.vb](VB/ObtainUnderlyingData/ViewModel.vb))
<!-- default file list end -->


## Documentation

* [Drill-Down to the Underlying Data](https://docs.devexpress.com/WindowsForms/1882)
* [Asynchronous Mode](https://docs.devexpress.com/WPF/9776)


## More Examples

* [How to Use CreateDrillDownDataSource Methods to Display Underlying (Drill-Down) Data](https://github.com/DevExpress-Examples/wpf-pivotgrid-how-to-display-underlying-data)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-obtain-underlying-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-obtain-underlying-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
