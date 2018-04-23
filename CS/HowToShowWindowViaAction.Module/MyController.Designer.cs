namespace HowToShowWindowViaAction.Module {
	partial class MyController {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.simpleAction1 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
			this.simpleAction2 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
			this.popupWindowShowAction1 = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
			this.popupWindowShowAction2 = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
			// 
			// simpleAction1
			// 
			this.simpleAction1.Caption = "SimpleAction1";
			this.simpleAction1.Id = "simpleAction1";
			this.simpleAction1.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
			// 
			// simpleAction2
			// 
			this.simpleAction2.Caption = "SimpleAction2";
			this.simpleAction2.Id = "simpleAction2";
			this.simpleAction2.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction2_Execute);
			// 
			// popupWindowShowAction1
			// 
			this.popupWindowShowAction1.AcceptButtonCaption = null;
			this.popupWindowShowAction1.CancelButtonCaption = null;
			this.popupWindowShowAction1.Caption = "PopupWindowShowAction1";
			this.popupWindowShowAction1.Id = "PopupWindowShowAction2";
			this.popupWindowShowAction1.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction1_CustomizePopupWindowParams);
			// 
			// popupWindowShowAction2
			// 
			this.popupWindowShowAction2.AcceptButtonCaption = null;
			this.popupWindowShowAction2.CancelButtonCaption = null;
			this.popupWindowShowAction2.Caption = "PopupWindowShowAction1";
			this.popupWindowShowAction2.Id = "PopupWindowShowAction1";
			this.popupWindowShowAction2.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction2_CustomizePopupWindowParams);
			// 
			// MyController
			// 
			this.TargetObjectType = typeof(HowToShowWindowViaAction.Module.BusinessClass1);

		}

		#endregion

		private DevExpress.ExpressApp.Actions.SimpleAction simpleAction1;
		private DevExpress.ExpressApp.Actions.SimpleAction simpleAction2;
		private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowShowAction1;
		private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowShowAction2;
	}
}
