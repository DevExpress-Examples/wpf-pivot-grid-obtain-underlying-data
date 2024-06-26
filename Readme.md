<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578831/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2173)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/HowtoObtainUnderlyingData/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HowtoObtainUnderlyingData/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/HowtoObtainUnderlyingData/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowtoObtainUnderlyingData/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/HowtoObtainUnderlyingData/ViewModel.cs) (VB: [ViewModel.vb](./VB/HowtoObtainUnderlyingData/ViewModel.vb))
<!-- default file list end -->
# How to: Obtain Underlying Data


<p>The DXPivotGrid includes the drill-down capability, which enables you to retrieve a list of records that were used to calculate a particular summary. <br />
To obtain drill-down data, use the PivotGridControl's CreateDrillDownDataSource method. Its parameters completely identify a summary cell.<br />
In this example, an end-user can view records from the control's underlying data source, associated with a summary cell, by double-clicking on it. The obtained data is displayed by the DXGrid within a popup window.</p>


<h3>Description</h3>

This example version demonstrates how to display a popup window displaying data from the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellInfo.class">CellInfo</a>.<a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellInfo.DrillDownDataSource.property">DrillDownDataSource</a>&nbsp;by executing ShowDrillDownDataCommand. &nbsp;On mouse event args are converted to the CellInfo object using <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.EventArgsToCellInfoConverter.class">EventArgsToCellInfoConverter</a>.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-obtain-underlying-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-obtain-underlying-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
