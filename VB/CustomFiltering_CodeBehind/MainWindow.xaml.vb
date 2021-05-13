Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace CustomFiltering_CodeBehind
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = GetItems()
		End Sub
		Private Shared Function GetItems() As IEnumerable(Of Object)
			Return New Object() { "A", "B", "C", "D", "E", "F", "G", "H" }
		End Function

		Private Sub OnCustomRowFilter(ByVal sender As Object, ByVal e As RowFilterEventArgs)
			If chkHideOdd.IsChecked.Value AndAlso e.ListSourceRowIndex Mod 2 = 1 Then
				e.Visible = False
			End If
			If chkHideEven.IsChecked.Value AndAlso e.ListSourceRowIndex Mod 2 = 0 Then
				e.Visible = False
			End If
			e.Handled = If(Not e.Visible, True, False)
		End Sub

		Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
			grid.RefreshData()
		End Sub
	End Class
End Namespace
