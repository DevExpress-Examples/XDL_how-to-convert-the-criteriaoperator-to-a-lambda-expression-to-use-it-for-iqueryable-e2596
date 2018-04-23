Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Skins

Namespace DXSample
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Dim connectionString As String = AccessConnectionProvider.GetConnectionString("MyDB.mdb")
			XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema)
			XpoDefault.Session = Nothing

			CreateData()

			SkinManager.EnableFormSkins()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub

		Private Shared Sub CreateData()
			Using uow As New UnitOfWork()
				If uow.FindObject(Of Products)(Nothing) Is Nothing Then
					Dim product As New Products(uow)
					product.Discontinued = False
					product.Price = 100
					product.Quantity = 20
					product.ProductName = "Orange"

					product = New Products(uow)
					product.Discontinued = True
					product.Price = 140
					product.Quantity = 50
					product.ProductName = "Apple"

					product = New Products(uow)
					product.Discontinued = False
					product.Price = 30
					product.Quantity = 120
					product.ProductName = "Banana"

					product = New Products(uow)
					product.Discontinued = True
					product.Price = 200
					product.Quantity = 80
					product.ProductName = "Grape"

					product = New Products(uow)
					product.Discontinued = False
					product.Price = 300
					product.Quantity = 10
					product.ProductName = "Garnet"

					product = New Products(uow)
					product.Discontinued = True
					product.Price = 120
					product.Quantity = 320
					product.ProductName = "Mandarin"

					product = New Products(uow)
					product.Discontinued = False
					product.Price = 250
					product.Quantity = 60
					product.ProductName = "Kiwi"

					uow.CommitChanges()
				End If
			End Using
		End Sub
	End Class
End Namespace
