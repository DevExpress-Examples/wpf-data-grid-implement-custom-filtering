<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128651196/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1167)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - How to Apply a Custom Filter Condition

This example demonstrates how to apply a custom filter condition in the GridControl.

If you want to maintain a clean MVVM pattern and specify custom filter operations in a ViewModel, create a command and bind it to the [GridControl.CustomRowFilterCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomRowFilterCommand) property.

![](https://docs.devexpress.com/WPF/images/GridControl_CustomRowFilterCommand.png)

<!-- default file list -->

## Files to Look At

### Code Behind Technique

- [MainWindow.xaml](./CS/CustomFiltering_CodeBehind/MainWindow.xaml) ([MainWindow.xaml](./VB/CustomFiltering_CodeBehind/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/CustomFiltering_CodeBehind/MainWindow.xaml.cs#L27-L33) ([MainWindow.xaml.vb](./VB/CustomFiltering_CodeBehind/MainWindow.xaml.vb#L29-L37))

### MVVM Technique

- [MainWindow.xaml](./CS/CustomFiltering_MVVM/MainWindow.xaml) ([MainWindow.xaml](./VB/CustomFiltering_MVVM/MainWindow.xaml))
- [MainViewModel.cs](./CS/CustomFiltering_MVVM/MainViewModel.cs#L36-L41) ([MainViewModel.vb](./VB/CustomFiltering_MVVM/MainViewModel.vb#L50-L57))

<!-- default file list end -->

## Documentation

- [Filter Modes and Custom Filtering](https://docs.devexpress.com/WPF/6410/controls-and-libraries/data-grid/filtering-and-searching/filtering-in-code/filter-modes-and-custom-filtering)
- [Filtering and Searching](https://docs.devexpress.com/WPF/7356/controls-and-libraries/data-grid/filtering-and-searching)
- [GridControl.CustomRowFilter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomRowFilter)
- [TreeListView.CustomNodeFilter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomNodeFilter)
- [GridControl.CustomRowFilterCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomRowFilterCommand)
- [TreeListView.CustomNodeFilterCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomNodeFilterCommand)

## More Examples

- [How to Create a Custom Filter Dropdown](https://github.com/DevExpress-Examples/how-to-create-a-custom-filter-dropdown-e1616)
- [How to customize filter items within a column's Filter Dropdown](https://github.com/DevExpress-Examples/how-to-customize-filter-items-within-a-columns-filter-dropdown-e1533)
