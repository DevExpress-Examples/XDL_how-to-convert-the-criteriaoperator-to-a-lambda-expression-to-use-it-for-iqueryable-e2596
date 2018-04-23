Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Data.Linq

Namespace DXSample
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private source As IQueryable(Of Products)
		Private Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim products = New XPQuery(Of Products)(unitOfWork1)

			source = _
				From product In products _
				Where product.Quantity >= 20 _
				Select product

			gridControl1.DataSource = source.ToList()
			CreateFilterColumns()
		End Sub

		Private Sub CreateFilterColumns()
			filterControl1.FilterColumns.Add(New UnboundFilterColumn("ProductID", "ProductID", GetType(Integer), New RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic))
			filterControl1.FilterColumns.Add(New UnboundFilterColumn("Quantity", "Quantity", GetType(Integer), New RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic))
			filterControl1.FilterColumns.Add(New UnboundFilterColumn("Price", "Price", GetType(Decimal), New RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic))
			filterControl1.FilterColumns.Add(New UnboundFilterColumn("ProductName", "ProductName", GetType(String), New RepositoryItemTextEdit(), FilterColumnClauseClass.String))
			filterControl1.FilterColumns.Add(New UnboundFilterColumn("Discontinued", "Discontinued", GetType(Boolean), New RepositoryItemCheckEdit(), FilterColumnClauseClass.Generic))
		End Sub

		Private Sub OnUpdateFilter(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			gridControl1.BeginUpdate()
			Try
				Dim converter As New CriteriaToExpressionConverter()
				Dim filteredData As IQueryable(Of Products) = TryCast(source.AppendWhere(converter, filterControl1.FilterCriteria), IQueryable(Of Products))
				gridControl1.DataSource = Nothing
				gridControl1.DataSource = filteredData.ToList()
			Finally
				gridControl1.EndUpdate()
			End Try
		End Sub

		Private Sub OnSaveButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				unitOfWork1.CommitChanges()
			Catch exc As Exception
				MessageBox.Show(exc.ToString())
				unitOfWork1.ReloadChangedObjects()
			End Try
		End Sub
	End Class
End Namespace
