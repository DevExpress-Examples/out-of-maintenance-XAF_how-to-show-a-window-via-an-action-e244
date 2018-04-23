Imports Microsoft.VisualBasic
Imports System
Namespace HowToShowWindowViaAction.Module
	Partial Public Class MyController
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

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.simpleAction1 = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			Me.simpleAction2 = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			Me.popupWindowShowAction1 = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
			Me.popupWindowShowAction2 = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
			' 
			' simpleAction1
			' 
			Me.simpleAction1.Caption = "SimpleAction1"
			Me.simpleAction1.Id = "simpleAction1"
'			Me.simpleAction1.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.simpleAction1_Execute);
			' 
			' simpleAction2
			' 
			Me.simpleAction2.Caption = "SimpleAction2"
			Me.simpleAction2.Id = "simpleAction2"
'			Me.simpleAction2.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.simpleAction2_Execute);
			' 
			' popupWindowShowAction1
			' 
			Me.popupWindowShowAction1.AcceptButtonCaption = Nothing
			Me.popupWindowShowAction1.CancelButtonCaption = Nothing
			Me.popupWindowShowAction1.Caption = "PopupWindowShowAction1"
			Me.popupWindowShowAction1.Id = "PopupWindowShowAction2"
'			Me.popupWindowShowAction1.CustomizePopupWindowParams += New DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(Me.popupWindowShowAction1_CustomizePopupWindowParams);
			' 
			' popupWindowShowAction2
			' 
			Me.popupWindowShowAction2.AcceptButtonCaption = Nothing
			Me.popupWindowShowAction2.CancelButtonCaption = Nothing
			Me.popupWindowShowAction2.Caption = "PopupWindowShowAction1"
			Me.popupWindowShowAction2.Id = "PopupWindowShowAction1"
'			Me.popupWindowShowAction2.CustomizePopupWindowParams += New DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(Me.popupWindowShowAction2_CustomizePopupWindowParams);
			' 
			' MyController
			' 
			Me.TargetObjectType = GetType(HowToShowWindowViaAction.Module.BusinessClass1)

		End Sub

		#End Region

		Private WithEvents simpleAction1 As DevExpress.ExpressApp.Actions.SimpleAction
		Private WithEvents simpleAction2 As DevExpress.ExpressApp.Actions.SimpleAction
		Private WithEvents popupWindowShowAction1 As DevExpress.ExpressApp.Actions.PopupWindowShowAction
		Private WithEvents popupWindowShowAction2 As DevExpress.ExpressApp.Actions.PopupWindowShowAction
	End Class
End Namespace
