Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.Xpf
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace CustomFiltering_MVVM

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property HideEvenItems As Boolean
            Get
                Return GetValue(Of Boolean)(NameOf(MainViewModel.HideEvenItems))
            End Get

            Set(ByVal value As Boolean)
                SetValue(value, New Action(AddressOf UpdateFiltrationLogic), NameOf(MainViewModel.HideEvenItems))
            End Set
        End Property

        Public Property HideOddItems As Boolean
            Get
                Return GetValue(Of Boolean)(NameOf(MainViewModel.HideOddItems))
            End Get

            Set(ByVal value As Boolean)
                SetValue(value, New Action(AddressOf UpdateFiltrationLogic), NameOf(MainViewModel.HideOddItems))
            End Set
        End Property

        Public Property CustomRowFilterCommand As ICommand(Of RowFilterArgs)
            Get
                Return GetValue(Of ICommand(Of RowFilterArgs))(NameOf(MainViewModel.CustomRowFilterCommand))
            End Get

            Set(ByVal value As ICommand(Of RowFilterArgs))
                SetValue(value, NameOf(MainViewModel.CustomRowFilterCommand))
            End Set
        End Property

        Public ReadOnly Property Items As ObservableCollection(Of Object)

        Public Sub New()
            Items = New ObservableCollection(Of Object)(GetItems())
            UpdateFiltrationLogic()
        End Sub

        Private Shared Function GetItems() As IEnumerable(Of Object)
            Return New Object() {"A", "B", "C", "D", "E", "F", "G", "H"}
        End Function

        Private Sub UpdateFiltrationLogic()
            CustomRowFilterCommand = New DelegateCommand(Of RowFilterArgs)(AddressOf CustomRowFilter)
        End Sub

        Private Sub CustomRowFilter(ByVal args As RowFilterArgs)
            If HideOddItems AndAlso args.SourceIndex Mod 2 = 1 Then args.Visible = False
            If HideEvenItems AndAlso args.SourceIndex Mod 2 = 0 Then args.Visible = False
        End Sub
    End Class
End Namespace
