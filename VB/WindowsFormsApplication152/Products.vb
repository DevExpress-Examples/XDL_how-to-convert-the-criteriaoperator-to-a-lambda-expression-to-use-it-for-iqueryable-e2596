Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Namespace DXSample
	Public Class Products
		Inherits XPLiteObject
		Private fProductID As Integer
		<Key(True)> _
		Public Property ProductID() As Integer
			Get
				Return fProductID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("ProductID", fProductID, value)
			End Set
		End Property

		Private fQuantity As Integer
		Public Property Quantity() As Integer
			Get
				Return fQuantity
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("Quantity", fQuantity, value)
			End Set
		End Property

		Private fPrice As Decimal
		Public Property Price() As Decimal
			Get
				Return fPrice
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(Of Decimal)("Price", fPrice, value)
			End Set
		End Property

		Private fProductName As String
		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ProductName", fProductName, value)
			End Set
		End Property

		Private fDiscontinued As Boolean

		Public Property Discontinued() As Boolean
			Get
				Return fDiscontinued
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("Discontinued", fDiscontinued, value)
			End Set
		End Property

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class
End Namespace
