Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Data.Linq

Namespace DXSample

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private source As IQueryable(Of Products)

        Private Overloads Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs)
            Dim products = New XPQuery(Of Products)(unitOfWork1)
            source = From product In products Where product.Quantity >= 20 Select product
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

        Private Sub OnUpdateFilter(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.BeginUpdate()
            Try
                Dim converter As CriteriaToExpressionConverter = New CriteriaToExpressionConverter()
                Dim filteredData As IQueryable(Of Products) = TryCast(source.AppendWhere(converter, filterControl1.FilterCriteria), IQueryable(Of Products))
                gridControl1.DataSource = Nothing
                gridControl1.DataSource = filteredData.ToList()
            Finally
                gridControl1.EndUpdate()
            End Try
        End Sub

        Private Sub OnSaveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Try
                unitOfWork1.CommitChanges()
            Catch exc As Exception
                Call MessageBox.Show(exc.ToString())
                unitOfWork1.ReloadChangedObjects()
            End Try
        End Sub
    End Class
End Namespace
