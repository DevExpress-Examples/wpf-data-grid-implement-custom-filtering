Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace CustomFiltering

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New Object() {"A", "B", "C", "D", "E", "F", "G", "H"}
        End Sub

        Private Sub grid_CustomRowFilter(ByVal sender As Object, ByVal e As RowFilterEventArgs)
            If Me.chkHideOdd.IsChecked.Value AndAlso e.ListSourceRowIndex Mod 2 = 1 Then e.Visible = False
            If Me.chkHideEven.IsChecked.Value AndAlso e.ListSourceRowIndex Mod 2 = 0 Then e.Visible = False
            e.Handled = If(Not e.Visible, True, False)
        End Sub

        Private Sub chk_CheckedOrUnchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.grid.RefreshData()
        End Sub
    End Class
End Namespace
