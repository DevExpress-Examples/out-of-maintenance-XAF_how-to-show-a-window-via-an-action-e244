Imports Microsoft.VisualBasic
Imports DevExpress.ExpressApp.DC
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.SystemModule

Namespace HowToShowWindowViaAction.Module
	Partial Public Class MyController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub

		Private Sub popupWindowShowAction1_CustomizePopupWindowParams(ByVal sender As Object, ByVal e As CustomizePopupWindowParamsEventArgs) Handles popupWindowShowAction1.CustomizePopupWindowParams
			Dim objectSpace As IObjectSpace = Application.CreateObjectSpace()
			Dim collectionSource As CollectionSourceBase = New CollectionSource(objectSpace, GetType(BusinessClass2))
			e.View = Application.CreateListView(Application.FindListViewId(GetType(BusinessClass2)), collectionSource, True)
		End Sub

		Private Sub simpleAction1_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction1.Execute
			Dim objectSpace As IObjectSpace = Application.CreateObjectSpace()
			Dim listViewId As String = Application.FindListViewId(GetType(BusinessClass2))
			e.ShowViewParameters.CreatedView = Application.CreateListView(listViewId, Application.CreateCollectionSource(objectSpace, GetType(BusinessClass2), listViewId), True)
			e.ShowViewParameters.TargetWindow = TargetWindow.NewWindow
			e.ShowViewParameters.Controllers.Add(Application.CreateController(Of DialogController)())
		End Sub

		Private Sub simpleAction2_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction2.Execute
			Dim objectSpace As IObjectSpace = Application.CreateObjectSpace()
			Dim obj As BusinessClass2 = objectSpace.CreateObject(Of BusinessClass2)()
			obj.Name = "an existing domain object"
			objectSpace.CommitChanges()

			e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpace, obj)
			e.ShowViewParameters.TargetWindow = TargetWindow.NewModalWindow
			e.ShowViewParameters.Context = TemplateContext.PopupWindow
			e.ShowViewParameters.CreateAllControllers = True
			Dim defaultDialogController As New DialogController()
			e.ShowViewParameters.Controllers.Add(defaultDialogController)

		End Sub

		Private Sub popupWindowShowAction2_CustomizePopupWindowParams(ByVal sender As Object, ByVal e As CustomizePopupWindowParamsEventArgs) Handles popupWindowShowAction2.CustomizePopupWindowParams
			Dim objectSpace As IObjectSpace = Application.CreateObjectSpace()
			Dim obj As BusinessClass2 = objectSpace.CreateObject(Of BusinessClass2)()
			obj.Name = "an existing domain object"
			objectSpace.CommitChanges()
			e.View = Application.CreateDetailView(objectSpace, obj)
		End Sub
	End Class
End Namespace
