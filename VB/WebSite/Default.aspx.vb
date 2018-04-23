Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


Partial Public Class _Default
	Inherits System.Web.UI.Page

	'remove all event handlers for using
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		AddHandler gridView.RowDeleting, AddressOf gridView_RowDeleting
		AddHandler gridView.RowInserting, AddressOf gridView_RowInserting
		AddHandler gridView.RowUpdating, AddressOf gridView_RowUpdating
	End Sub

	Private Sub gridView_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
		e.Cancel = True
		gridView.CancelEdit()
	End Sub

	Private Sub gridView_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs)
		e.Cancel = True
		gridView.CancelEdit()
	End Sub

	Private Sub gridView_RowDeleting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataDeletingEventArgs)
		Throw New Exception("Deleting is not allowed in the online example")
	End Sub

End Class
