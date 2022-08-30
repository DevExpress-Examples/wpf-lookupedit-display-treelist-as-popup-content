Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace CustomTreeViewComboBox

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            ThemeManager.ApplicationThemeName = "Office2007Blue"
        End Sub
    End Class
End Namespace
