<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128645103/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3106)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF LookUpEdit - Display a TreeList as Popup Content

This example displays hierarchical data in the [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit)'s popup.

1. Use the [PopupBaseEdit.PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate) property to specify a custom [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl).
2. Assign an instance of the [TreeListView](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView) class to the [GridControl.View](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.View) property.
3. Set the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)'s name to **PART_GridControl**.

![image](https://user-images.githubusercontent.com/65009440/186915700-96577a48-c76d-47fb-9fe2-2501ffb772b8.png) 

## Files to Look At

* [MainWindow.xaml](./CS/CustomTreeViewComboBox/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomTreeViewComboBox/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomTreeViewComboBox/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomTreeViewComboBox/MainWindow.xaml.vb))

## Documentation

* [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit)
* [TreeListView](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView)
* [PopupBaseEdit.PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate)

## More Examples

* [WPF LookUpEdit - Customize the Embedded Data Grid](https://github.com/DevExpress-Examples/wpf-lookupedit-customize-the-embedded-data-grid)
* [WPF LookUpEdit - Process New Values](https://github.com/DevExpress-Examples/lookupedit-processing-new-values-e2646)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-display-treelist-as-popup-content&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-display-treelist-as-popup-content&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
