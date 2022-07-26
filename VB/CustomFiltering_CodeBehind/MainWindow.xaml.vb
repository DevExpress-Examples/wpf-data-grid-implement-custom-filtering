Imports DevExpress.Xpf.Grid
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls

Namespace CustomFiltering_CodeBehind

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetItems()
        End Sub

        Private Shared Function GetItems() As IEnumerable(Of Object)
            Return New Object() {"A", "B", "C", "D", "E", "F", "G", "H"}
        End Function

        Private Sub OnCustomRowFilter(ByVal sender As Object, ByVal e As RowFilterEventArgs)
            If Me.chkHideOdd.IsChecked.Value AndAlso e.ListSourceRowIndex Mod 2 = 1 Then e.Visible = False
            If Me.chkHideEven.IsChecked.Value AndAlso e.ListSourceRowIndex Mod 2 = 0 Then e.Visible = False
            e.Handled = If(Not e.Visible, True, False)
        End Sub

        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.grid.RefreshData()
        End Sub
    End Class
End Namespace
