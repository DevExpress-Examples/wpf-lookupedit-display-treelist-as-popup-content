<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128645103/10.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3106)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [Generic.xaml](./CS/Themes/Generic.xaml) (VB: [Generic.xaml](./VB/Themes/Generic.xaml))
<!-- default file list end -->
# Implement a custom drop-down editor with TreeView as PopupContent


<p>Show how to implement a custom ComboBoxEdit with TreeView as a PopupContent and use it inside DXGrid as a custom column.</p><br />
<p><strong>Update (</strong><strong>version </strong><strong>13.1</strong><strong>):</strong></p><br />
<p>We've modified this code example by using the DevExpress control version 13.1. There is no need to create custom classes to resolve this problem.</p><p>You can accomplish this task by using the Grid control in the TreeView mode as a popup content template of the LookUpEdit control. </p><p>This way is more efficient and clear than the way used in this example for old versions of DevExpress controls. </p><br />
<p>Here is a snippet of the markup file:</p>

```xaml
        <dxg:LookUpEdit Name="lookUpEdit" VerticalAlignment="Top" Width="350" Margin="50,37,67,0"
                        DisplayMember="Name">
            <dxg:LookUpEdit.PopupContentTemplate>
                <ControlTemplate>
                    <dxg:GridControl x:Name="PART_GridControl" AutoGenerateColumns="AddNew">
                        <dxg:GridControl.Columns>
                            <dxg:GridColumn FieldName="Name" Header="Employee Name" />
                            <dxg:GridColumn FieldName="Position" />
                            <dxg:GridColumn FieldName="Department" />
                        </dxg:GridControl.Columns>
                        <dxg:GridControl.View>
                            <dxg:TreeListView Name="treeListView1" AutoWidth="True"
                                  KeyFieldName="ID" ParentFieldName="ParentID"
                                  TreeDerivationMode="Selfreference"/>
                        </dxg:GridControl.View>
                    </dxg:GridControl>
                </ControlTemplate>
            </dxg:LookUpEdit.PopupContentTemplate>
        </dxg:LookUpEdit>


```



<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-display-treelist-as-popup-content&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-display-treelist-as-popup-content&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
