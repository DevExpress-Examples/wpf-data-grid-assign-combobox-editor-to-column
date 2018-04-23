Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

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
