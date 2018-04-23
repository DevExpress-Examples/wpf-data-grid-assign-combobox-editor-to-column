Imports Microsoft.VisualBasic
Imports System.Windows

Namespace DXGrid_AssignComboBoxToColumn
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class NwindData
		Public Shared ReadOnly Property Data() As nwindDataSet.ProductsDataTable
			Get
				Return New nwindDataSetTableAdapters.ProductsTableAdapter().GetData()
			End Get
		End Property
	End Class
End Namespace
