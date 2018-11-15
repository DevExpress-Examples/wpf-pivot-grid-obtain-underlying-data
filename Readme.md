<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/HowtoObtainUnderlyingData/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/HowtoObtainUnderlyingData/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/HowtoObtainUnderlyingData/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowtoObtainUnderlyingData/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Obtain Underlying Data


<p>The DXPivotGrid includes the drill-down capability, which enables you to retrieve a list of records that were used to calculate a particular summary. <br />
To obtain drill-down data, use the PivotGridControl's CreateDrillDownDataSource method. Its parameters completely identify a summary cell.<br />
In this example, an end-user can view records from the control's underlying data source, associated with a summary cell, by double-clicking on it. The obtained data is displayed by the DXGrid within a popup window.</p>

<br/>


