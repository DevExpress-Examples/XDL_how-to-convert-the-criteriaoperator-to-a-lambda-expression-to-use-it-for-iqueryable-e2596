Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork()
			Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.filterControl1 = New DevExpress.XtraEditors.FilterControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(537, 478)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' btnSave
			' 
			Me.btnSave.Location = New System.Drawing.Point(0, 0)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(100, 34)
			Me.btnSave.TabIndex = 1
			Me.btnSave.Text = "Save"
'			Me.btnSave.Click += New System.EventHandler(Me.OnSaveButtonClick);
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Controls.Add(Me.btnSave)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 478)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(816, 34)
			Me.panelControl1.TabIndex = 2
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(537, 0)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(100, 34)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "ApplyFilter"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnUpdateFilter);
			' 
			' filterControl1
			' 
			Me.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.filterControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.filterControl1.Location = New System.Drawing.Point(537, 0)
			Me.filterControl1.Name = "filterControl1"
			Me.filterControl1.Size = New System.Drawing.Size(279, 478)
			Me.filterControl1.TabIndex = 3
			Me.filterControl1.Text = "filterControl1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(816, 512)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.filterControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Get Lambda Expression From CriteriaOperator"
'			Me.Load += New System.EventHandler(Me.OnLoad);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
		Private WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private filterControl1 As DevExpress.XtraEditors.FilterControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

