using DevExpress.ExpressApp.DC;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.SystemModule;

namespace HowToShowWindowViaAction.Module {
	public partial class MyController : ViewController {
		public MyController() {
			InitializeComponent();
			RegisterActions(components);
		}

		private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
			IObjectSpace objectSpace = Application.CreateObjectSpace();
			CollectionSourceBase collectionSource = new CollectionSource(objectSpace, typeof(BusinessClass2));
			e.View = Application.CreateListView(
				 Application.FindListViewId(typeof(BusinessClass2)),
				 collectionSource,
				 true);
		}

		private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
			IObjectSpace objectSpace = Application.CreateObjectSpace();
			string listViewId = Application.FindListViewId(typeof(BusinessClass2));
			e.ShowViewParameters.CreatedView = Application.CreateListView(
				listViewId,
				Application.CreateCollectionSource(objectSpace, typeof(BusinessClass2), listViewId),
				true);
			e.ShowViewParameters.TargetWindow = TargetWindow.NewWindow;
			e.ShowViewParameters.Controllers.Add(Application.CreateController<DialogController>());
		}

		private void simpleAction2_Execute(object sender, SimpleActionExecuteEventArgs e) {
			IObjectSpace objectSpace = Application.CreateObjectSpace();
			BusinessClass2 obj = objectSpace.CreateObject<BusinessClass2>();
			obj.Name = "an existing domain object";
			objectSpace.CommitChanges();

			e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpace, obj);
			e.ShowViewParameters.TargetWindow = TargetWindow.NewModalWindow;
			e.ShowViewParameters.Context = TemplateContext.PopupWindow;
			e.ShowViewParameters.CreateAllControllers = true;
			DialogController defaultDialogController = new DialogController();
			e.ShowViewParameters.Controllers.Add(defaultDialogController);

		}

		private void popupWindowShowAction2_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
			IObjectSpace objectSpace = Application.CreateObjectSpace();
			BusinessClass2 obj = objectSpace.CreateObject<BusinessClass2>();
			obj.Name = "an existing domain object";
			objectSpace.CommitChanges();
			e.View = Application.CreateDetailView(objectSpace, obj);
		}
	}
}
